using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models.AccountModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OandaV20.API
{
    // GET     /accounts
    // GET     /accounts/{accountID}
    // GET     /accounts/{accountID}/summary
    // GET     /accounts/{accountID}/instruments
    // PATCH   /accounts/{accountID}/configuration
    // GET     /accounts/{accountID}/changes

    public class AccountAPI : MainAPI
    {
        /// <summary>
        /// Get the full details for a single Account that a client has access to. Full pending Order, open Trade and open Position representations are provided.
        /// </summary>
        /// <returns></returns>
        public async Task<Account> GetAccountFromID()
        {            
            string path = string.Format("accounts/{0}", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(
                         JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString()
                    );

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["account"].ToString();
                    return JsonConvert.DeserializeObject<Account>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get a summary for a single Account that a client has access to.
        /// </summary>
        /// <returns></returns>
        public async Task<Account> GetAccountSummary()
        {
            string path = string.Format("accounts/{0}/summary", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["account"].ToString();
                    return JsonConvert.DeserializeObject<Account>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get the list of tradeable instruments for the given Account. The list of tradeable instruments is dependent on the regulatory division that the Account is located in, thus should be the same for all Accounts owned by a single user.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Instrument>> GetAccountInstruments(NameValueCollection queriesNVC)
        {
            string path = string.Format("accounts/{0}/instruments", AccountID);
            string query = QueryFromNVC(queriesNVC) ?? null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["instruments"].ToString();
                    return JsonConvert.DeserializeObject<List<Instrument>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Set the client-configurable portions of an Account.
        /// </summary>
        /// <returns></returns>
        public async Task<dynamic> PatchAccountConfiguration()
        {
            string path = string.Format("accounts/{0}/configuration", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, new HttpMethod("PATCH"), path, query))
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

        /// <summary>
        /// Endpoint used to poll an Account for its current state and changes since a specified TransactionID.
        /// </summary>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public async Task<dynamic> GetAccountChanges(TransactionID transactionID)
        {
            NameValueCollection queryNVC = new NameValueCollection();
            queryNVC.Add("sinceTransactionID", transactionID);

            string path = string.Format("accounts/{0}/changes", AccountID);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
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