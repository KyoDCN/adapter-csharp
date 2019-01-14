using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models;
using OandaV20.Models.Primitives;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.API
{
    // GET /accounts/{accountID}/pricing
    // GET /accounts/{accountID}/pricing/stream

    public class PricingAPI : MainAPI
    {
        /// <summary>
        /// Get pricing information for a specified list of Instruments within an Account.
        /// </summary>
        /// <param name="instruments">List of Instruments to get pricing for. [required].</param>
        /// <param name="since">Date/Time filter to apply to the response. Only prices and home conversions (if requested) with a time later than this filter (i.e. the price has changed after the since time) will be provided, and are filtered independently.</param>
        /// <param name="includeUnitsAvailable">Flag that enables the inclusion of the unitsAvailable field in the returned Price objects. [default=True]. Deprecated: Will be removed in a future API update.</param>
        /// <param name="includeHomeConversions">Flag that enables the inclusion of the homeConversions field in the returned response. An entry will be returned for each currency in the set of all base and quote currencies present in the requested instruments list. [default=False].</param>
        /// <returns></returns>
        public async Task<PricingResponse> GetPricingForInstruments(
            List<InstrumentName> instruments, 
            DateTime since,
            bool includeUnitsAvailable = true,
            bool includeHomeConversions = false
        ) {
            #region queryNVC
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "includeUnitsAvailable", includeUnitsAvailable.ToString() },
                { "includeHomeConversions", includeHomeConversions.ToString() }
            };
            if(instruments != null)
                queryNVC.Add("instruments", string.Join(",", instruments));
            if (since != null)
                queryNVC.Add("since", since.ToUniversalTime().ToString());
            #endregion
            
            string path = string.Format("accounts/{0}/pricing", AccountID);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<PricingResponse>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get a stream of Account Prices starting from when the request is made.
        /// <para/> This pricing stream does not include every single price created for the Account, but instead will provide at most 4 prices per second (every 250 milliseconds) for each instrument being requested.
        /// <para/> If more than one price is created for an instrument during the 250 millisecond window, only the price in effect at the end of the window is sent. This means that during periods of rapid price movement, subscribers to this stream will not be sent every price.
        /// <para/> Pricing windows for different connections to the price stream are not all aligned in the same way (i.e. they are not all aligned to the top of the second). This means that during periods of rapid price movement, different subscribers may observe different prices depending on their alignment.
        /// </summary>
        /// <param name="instruments">List of Instruments to stream Prices for. [required].</param>
        /// <returns>Returns the stream content for the specified instruments.</returns>
        public async Task<Stream> GetStreamPricingForInstruments(
            List<InstrumentName> instruments,
            bool snapshot = true
        ) {
            #region queryNVC
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "snapshot", snapshot.ToString() }
            };
            if (instruments != null)
                queryNVC.Add("instruments", string.Join(",", instruments));
            #endregion
            
            string path = string.Format("accounts/{0}/pricing/stream", AccountID);
            string query = QueryFromNVC(queryNVC);

            HttpResponseMessage response = await RequestAsync(EHostAPIType.STREAM, HttpMethod.Get, path, query);

            if (response.StatusCode != HttpStatusCode.OK)
                throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

            return await response.Content.ReadAsStreamAsync();
        }
    }
}
