using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TradeModel.Request;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OandaV20.API
{
    // GET /accounts/{accountID}/trades
    // GET /accounts/{accountID}/openTrades
    // GET /accounts/{accountID}/trades/{tradeSpecifier}
    // PUT /accounts/{accountID}/trades/{tradeSpecifier}/close
    // PUT /accounts/{accountID}/trades/{tradeSpecifier}/clientExtensions
    // PUT /accounts/{accountID}/trades/{tradeSpecifier}/orders

    public class TradeAPI : MainAPI
    {
        /// <summary>
        /// Get a list of Trades for an Account.
        /// </summary>
        /// <param name="instrument">The instrument to filter the requested Trades by.</param>
        /// <param name="ids">List of Trade IDs to retrieve. </param>
        /// <param name="state">The state to filter the requested Trades by. [default=OPEN].</param>
        /// <param name="count">The maximum number of Trades to return. [default=50, maximum=500]</param>
        /// <param name="beforeID">The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned.</param>
        /// <returns></returns>
        public async Task<List<Trade>> GetTrades(            
            InstrumentName instrument,
            List<TradeID> ids = null,
            ETradeStateFilter state = ETradeStateFilter.OPEN, 
            int count = 50, 
            TradeID beforeID = null
        ) {
            #region queryNVC
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "state", state.ToString() },
                { "count", count.ToString() }
            };
            if (ids != null)
                queryNVC["ids"] = string.Join(",", ids);
            if (instrument != null)
                queryNVC["instrument"] = instrument;
            if (beforeID != null)
                queryNVC["beforeID"] = beforeID;
            #endregion

            string path = string.Format("accounts/{0}/trades", AccountID);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["trades"].ToString();
                    return JsonConvert.DeserializeObject<List<Trade>>(jsonString);
                }
            }               
        }

        /// <summary>
        /// Get the list of open Trades for an Account
        /// </summary>
        /// <returns></returns>
        public async Task<List<Trade>> GetOpenTrades()
        {
            string path = string.Format("accounts/{0}/openTrades", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["trades"].ToString();
                    return JsonConvert.DeserializeObject<List<Trade>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get the details of a specific Trade in an Account.
        /// </summary>
        /// <param name="specifier">Specifier for the Trade [required].</param>
        /// <returns></returns>
        public async Task<Trade> GetSpecificTrade(TradeSpecifier specifier)
        {
            string path = string.Format("accounts/{0}/trades/{1}", AccountID, specifier);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["trade"].ToString();
                    return JsonConvert.DeserializeObject<Trade>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Close (partially or fully) a specific open Trade in an Account
        /// </summary>
        /// <param name="specifier">Specifier for the Trade [required].</param>
        /// <param name="units">
        /// Indication of how much of the Trade to close. Either the string “ALL”
        /// (indicating that all of the Trade should be closed), or a DecimalNumber
        /// representing the number of units of the open Trade to Close using a
        /// TradeClose MarketOrder. The units specified must always be positive, and
        /// the magnitude of the value cannot exceed the magnitude of the Trade’s
        /// open units.
        /// </param>
        /// <returns></returns>
        public async Task<dynamic> PutCloseTrade(TradeSpecifier specifier, string units = "ALL")
        {
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "units", units }
            };
            string path = string.Format("accounts/{0}/trades/{1}/close", AccountID, specifier);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["trade"].ToString();
                    return JsonConvert.DeserializeObject<Trade>(jsonString, ErrorHandlingSetting);
                }
            }            
        }
        /// <summary>
        /// Close (partially or fully) a specific open Trade in an Account
        /// </summary>
        /// <param name="specifier">Specifier for the Trade [required].</param>
        /// <param name="units">
        /// Indication of how much of the Trade to close. Either the string “ALL”
        /// (indicating that all of the Trade should be closed), or a DecimalNumber
        /// representing the number of units of the open Trade to Close using a
        /// TradeClose MarketOrder. The units specified must always be positive, and
        /// the magnitude of the value cannot exceed the magnitude of the Trade’s
        /// open units.
        /// </param>
        /// <returns></returns>
        public async Task<dynamic> PutCloseTrade(TradeSpecifier specifier, double units)
        {
            return await PutCloseTrade(specifier, units.ToString());
        }

        /// <summary>
        /// Create, replace and cancel a Trade’s dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself.
        /// </summary>
        /// <param name="specifier">Specifier for the Trade [required].</param>
        /// <param name="clientExtensions">
        /// The Client Extensions to update the Trade with. Do not add, update, or 
        /// delete the Client Extensions if your account is associated with MT4.
        /// </param>
        /// <returns></returns>
        public async Task<dynamic> PutTradeClientExtensions(TradeSpecifier specifier, ClientExtensions clientExtensions)
        {
            JObject jObject = JObject.FromObject(
                new { clientExtensions },
                SerializerSetting
            );

            string path = string.Format("accounts/{0}/trades/{1}/clientExtensions", AccountID, specifier);
            string query = null;
            string jsonBody = JsonConvert.SerializeObject(jObject, Formatting.Indented);            

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["trade"].ToString();
                    return JsonConvert.DeserializeObject<dynamic>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Create, replace and cancel a Trade’s dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself.
        /// </summary>
        /// <param name="specifier"></param>
        /// <param name="clientExtensions"></param>
        /// <returns></returns>
        public async Task<dynamic> PutTradeOrder(TradeSpecifier specifier, PutTradeOrderRequest request)
        {
            JObject jObject = JObject.FromObject(
                request,
                SerializerSetting
            );

            string path = string.Format("accounts/{0}/trades/{1}/orders", AccountID, specifier);
            string query = null;
            string jsonBody = JsonConvert.SerializeObject(jObject, Formatting.Indented);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<dynamic>(jsonString, ErrorHandlingSetting);
                }
            }            
        }
    }
}
