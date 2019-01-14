using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models.OrderModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.Primitives;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OandaV20.API
{
    // POST /accounts/{accountID}/orders
    // GET  /accounts/{accountID}/orders
    // GET  /accounts/{accountID}/pendingOrders
    // GET  /accounts/{accountID}/orders/{orderSpecifier}
    // PUT  /accounts/{accountID}/orders/{orderSpecifier}
    // PUT  /accounts/{accountID}/orders/{orderSpecifier}/cancel
    // PUT  /accounts/{accountID}/orders/{orderSpecifier}/clientExtensions

    public class OrderAPI : MainAPI
    {
        #region POST REQUESTS
        /// <summary>
        /// Create an Order for an Account
        /// </summary>
        /// <param name="orderRequest">Specification of the Order to create.</param>
        /// <returns></returns>
        public async Task<dynamic> PostOrder(OrderRequest orderRequest)
        {
            string path = string.Format("accounts/{0}/orders", AccountID);
            string query = null;

            JObject jObject = JObject.FromObject(
                new { order = orderRequest }, 
                SerializerSetting
            );

            string jsonBody = JsonConvert.SerializeObject(jObject, JsonSerializerSetting);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Post, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<dynamic>(jsonString);
                }
            }            
        }
        #endregion

        #region GET REQUESTS
        /// <summary>
        /// Get a list of Orders for an Account
        /// </summary>
        /// <param name="orderIDs">List of Order IDs to retrieve.</param>
        /// <param name="orderStateFilter">The state to filter the requested Orders by [default=PENDING].</param>
        /// <param name="instrument">The instrument to filter the requested orders by.</param>
        /// <param name="count">The maximum number of Orders to return [default=50, maximum=500].</param>
        /// <param name="beforeID">The maximum Order ID to return. If not provided the most recent Orders in the Account are returned.</param>
        /// <returns></returns>
        public async Task<List<Order>> GetOrders
        (
            InstrumentName instrument,
            List<OrderID> orderIDs,
            OrderStateFilter orderStateFilter,            
            int count = 50,
            OrderID beforeID = null
        ) {
            #region queryNVC
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "state", ((EOrderStateFilter)orderStateFilter).ToString() },
                { "count", count.ToString() }
            };
            if (orderIDs != null)
                queryNVC.Add("ids", string.Join(",", orderIDs));
            if (instrument != null)
                queryNVC.Add("instrument", instrument.ToString());
            if (beforeID != null)
                queryNVC.Add("beforeID", beforeID);
            #endregion

            string path = string.Format("accounts/{0}/orders", AccountID);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["orders"].ToString();
                    return JsonConvert.DeserializeObject<List<Order>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }
        /// <summary>
        /// Get a list of Orders for an Account
        /// </summary>
        /// <param name="orderIDs">List of Order IDs to retrieve.</param>
        /// <param name="instrument">The instrument to filter the requested orders by.</param>
        /// <returns></returns>
        public async Task<List<Order>> GetOrders(InstrumentName instrument, List<OrderID> orderIDs)
        {
            return await GetOrders(instrument, orderIDs, EOrderStateFilter.PENDING, 50, null);
        }
        /// <summary>
        /// Get a list of Orders for an Account
        /// </summary>
        /// <param name="instrument">The instrument to filter the requested orders by.</param>
        /// <returns></returns>
        public async Task<List<Order>> GetOrders(InstrumentName instrument)
        {
            return await GetOrders(instrument, null);
        }

        /// <summary>
        /// List all pending Orders in an Account
        /// </summary>
        /// <returns></returns>
        public async Task<List<Order>> GetPendingOrders()
        {
            string path = string.Format("accounts/{0}/pendingOrders", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["orders"].ToString();
                    return JsonConvert.DeserializeObject<List<Order>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get details for a single Order in an Account.
        /// </summary>
        /// <param name="orderSpecifier">The Order Specifier [required].</param>
        /// <returns></returns>
        public async Task<Order> GetSpecificOrder(OrderSpecifier orderSpecifier)
        {
            string path = string.Format("accounts/{0}/orders/{1}", AccountID, orderSpecifier);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["order"].ToString();
                    return JsonConvert.DeserializeObject<Order>(jsonString, ErrorHandlingSetting);
                }
            }            
        }
        #endregion

        #region PUT REQUESTS
        /// <summary>
        /// Replace an Order in an Account by simultaneously cancelling it and creating a replacement Order
        /// </summary>
        /// <param name="orderRequest">Specification of the replacing Order</param>
        /// <param name="orderSpecifier">The specification of an Order as referred to by clients. Either the Order’s OANDA-assigned OrderID or the Order’s client-provided ClientID prefixed by the “@” symbol</param>
        /// <returns></returns>
        public async Task<dynamic> PutReplaceOrder(OrderRequest orderRequest, OrderSpecifier orderSpecifier)
        {
            string path = string.Format("accounts/{0}/orders/{1}", AccountID, orderSpecifier);
            string query = null;

            JObject jObject = JObject.FromObject(
                new { order = orderRequest },
                SerializerSetting
            );

            string jsonBody = JsonConvert.SerializeObject(jObject, JsonSerializerSetting);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<dynamic>(jsonString);
                }
            }            
        }

        /// <summary>
        /// Cancel a pending Order in an Account
        /// </summary>
        /// <param name="orderSpecifier">The specification of an Order as referred to by clients. Either the Order’s OANDA-assigned OrderID or the Order’s client-provided ClientID prefixed by the “@” symbol.</param>
        /// <returns></returns>
        public async Task<dynamic> PutCancelOrder(OrderSpecifier orderSpecifier)
        {
            string path = string.Format("accounts/{0}/orders/{1}/cancel", AccountID, orderSpecifier);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<dynamic>(jsonString);
                }
            }            
        }

        /// <summary>
        /// Update the Client Extensions for an Order in an Account. Do not set, modify, or delete clientExtensions if your account is associated with MT4.
        /// </summary>
        /// <param name="orderSpecifier">The specification of an Order as referred to by clients. Either the Order’s OANDA-assigned OrderID or the Order’s client-provided ClientID prefixed by the “@” symbol.</param>
        /// <param name="clientExtensionsUpdateRequest"><para>"ClientExtensions" The Client Extensions to update for the Order. Do not set, modify, or delete clientExtensions if your account is associated with MT4.</para><para>"TradeClientExtensions" The Client Extensions to update for the Trade created when the Order is filled. Do not set, modify, or delete clientExtensions if your account is associated with MT4.</para></param>
        /// <returns></returns>
        public async Task<dynamic> PutOrderClientExtensions(
            OrderSpecifier orderSpecifier, 
            UpdateOrderClientExtensionsRequest clientExtensionsUpdateRequest
        ) {
            string path = string.Format("accounts/{0}/orders/{1}/clientExtensions", AccountID, orderSpecifier);
            string query = null;
            string jsonBody = JsonConvert.SerializeObject(clientExtensionsUpdateRequest, JsonSerializerSetting);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<dynamic>(jsonString);
                }
            }            
        }
        #endregion
    }
}
