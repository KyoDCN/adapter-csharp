using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models.AccountModel;
using OandaV20.Models.TransactionModel;
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
    // GET /accounts/{accountID}/transactions
    // GET /accounts/{accountID}/transactions/{transactionID}
    // GET /accounts/{accountID}/transactions/idrange
    // GET /accounts/{accountID}/transactions/sinceid
    // GET /accounts/{accountID}/transactions/stream

    public class TransactionAPI : MainAPI
    {
        /// <summary>
        /// Get a list of Transactions pages that satisfy a time-based Transaction query.
        /// </summary>
        /// <param name="from">The starting time (inclusive) of the time range for the Transactions being queried. [default=Account Creation Time].</param>
        /// <param name="to">The ending time (inclusive) of the time range for the Transactions being queried. [default=Request Time].</param>
        /// <param name="type">A filter for restricting the types of Transactions to retreive.</param>
        /// <param name="pageSize">The number of Transactions to include in each page of the results. [default=100, maximum=1000].</param>
        /// <returns></returns>
        public async Task<List<string>> GetTransactionPages(DateTime? from, DateTime? to, List<TransactionFilter> type, int pageSize = 100)
        {
            #region queryNVC
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "from", from.ToString() },
                { "to", to.ToString() },
                { "pageSize", pageSize.ToString() },
            };
            if (type != null)
            {
                List<string> typeString = type.ConvertAll(new Converter<TransactionFilter, string>(t => t.ToString()));
                queryNVC.Add("type", String.Join(",", typeString));
            }   
            #endregion             

            string path = string.Format("accounts/{0}/transactions", AccountID);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["pages"].ToString();
                    return JsonConvert.DeserializeObject<List<string>>(jsonString, ErrorHandlingSetting);
                }
            }                 
        }
        /// <summary>
        /// Get a list of Transactions pages that satisfy a time-based Transaction query.
        /// </summary>
        /// <param name="from">The starting time (inclusive) of the time range for the Transactions being queried. [default=Account Creation Time].</param>
        /// <param name="to">The ending time (inclusive) of the time range for the Transactions being queried. [default=Request Time].</param>
        /// <returns></returns>
        public async Task<List<string>> GetTransactionPages(DateTime? from, DateTime? to)
        {
            return await GetTransactionPages(from, to, null);
        }
        /// <summary>
        /// Get a list of Transactions pages that satisfy a time-based Transaction query.
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetTransactionPages()
        {
            AccountAPI accountAPI = new AccountAPI();
            Account account = await accountAPI.GetAccountFromID();
            return await GetTransactionPages(account.CreatedTime, DateTime.UtcNow);
        }

        /// <summary>
        /// Get the details of a single Account Transaction.
        /// </summary>
        /// <param name="id">A Transaction ID [required].</param>
        /// <returns></returns>
        public async Task<Transaction> GetSpecificTransaction(TransactionID id)
        {
            string path = string.Format("accounts/{0}/transactions/{1}", AccountID, id);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["transaction"].ToString();
                    return JsonConvert.DeserializeObject<Transaction>(jsonString, ErrorHandlingSetting);
                }
            }           
        }

        /// <summary>
        /// Get a range of Transactions for an Account based on the Transaction IDs.
        /// </summary>
        /// <param name="from">The starting Transacion ID (inclusive) to fetch. [required].</param>
        /// <param name="to">The ending Transacion ID (inclusive) to fetch. [required].</param>
        /// <param name="type">The filter that restricts the types of Transactions to retreive.</param>
        /// <returns></returns>
        public async Task<List<Transaction>> GetTransactionsFromIdRange(TransactionID from, TransactionID to, List<TransactionFilter> type = null)
        {
            #region queryNVC   
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "from", from },
                { "to", to }
            };
            if(type != null)
                queryNVC.Add("type", string.Join(",", type));
            #endregion

            string path = string.Format("accounts/{0}/transactions/idrange", AccountID);
            string query = null;
            string jsonBody = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["transactions"].ToString();
                    return JsonConvert.DeserializeObject<List<Transaction>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get a range of Transactions for an Account starting at (but not including) a provided Transaction ID.
        /// </summary>
        /// <param name="id">The ID of the last Transacion fetched. This query will return all Transactions newer than the TransactionID. [required].</param>
        /// <returns></returns>
        public async Task<List<Transaction>> GetTransactionsSinceID(TransactionID id)
        {
            #region queryNVC   
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "id", id }
            };
            #endregion

            string path = string.Format("accounts/{0}/transactions/sinceid", AccountID);
            string query = null;
            string jsonBody = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["transactions"].ToString();
                    return JsonConvert.DeserializeObject<List<Transaction>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get a stream of Transactions for an Account starting from when the request is made.
        /// <para/> Note: This endpoint is served by the streaming URLs.
        /// </summary>
        /// <returns></returns>
        public async Task<Stream> GetTransactionsStream()
        {
            string path = string.Format("accounts/{0}/transactions/stream", AccountID);
            string query = null;
            string jsonBody = null;

            HttpResponseMessage response = await RequestAsync(EHostAPIType.STREAM, HttpMethod.Get, path, query, jsonBody);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

            return await response.Content.ReadAsStreamAsync();
        }
    }
}
