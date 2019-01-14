using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models;
using OandaV20.Models.InstrumentsModel;
using OandaV20.Models.Primitives;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OandaV20.API
{
    // GET /instruments/{instrument}/candles
    // GET /instruments/{instrument}/orderBook
    // GET /instruments/{instrument}/positionBook

    public class InstrumentAPI : MainAPI
    {
        /// <summary>
        /// Fetch candlestick data for an instrument.
        /// </summary>
        /// <param name="pairs">The instrument pair value</param>
        /// <param name="queryNVC"></param>
        /// <returns></returns>
        public async Task<CandlestickResponse> GetInstrumentCandles(
            InstrumentName instrument,
            DateTime from,
            DateTime to,
            CandlestickGranularity granularity = null,
            int count = 500,
            WeeklyAlignment weeklyAlignment = null,                      
            string price = "M",                     
            bool smooth = false,
            bool includeFirst = true,
            int dailyAlignment = 17,
            string alignmentTimezone = "America/New_York"
        ) {
            #region QueryNVC
            NameValueCollection queryNVC = new NameValueCollection()
            {
                { "count", count.ToString() },
                { "price", price },
                { "smooth", smooth.ToString() },
                { "includeFirst", includeFirst.ToString() },
                { "dailyAlignment", dailyAlignment.ToString() },
                { "alignmentTimeZone", alignmentTimezone }
            };
            if (from != null)
                queryNVC.Add("from", from.ToUniversalTime().ToString());
            if (to != null)
                queryNVC.Add("to", to.ToUniversalTime().ToString());
            if (granularity != null)
                queryNVC.Add("granularity", granularity.ToString());
            if (weeklyAlignment != null)
                queryNVC.Add("weeklyAlignment", weeklyAlignment.ToString());
            #endregion

            string path = string.Format("instruments/{0}/candles", instrument);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<CandlestickResponse>(jsonString, ErrorHandlingSetting);
                }
            }            
        }
        public async Task<CandlestickResponse> GetInstrumentCandles(
            InstrumentName instrument,
            DateTime from,
            DateTime to,
            CandlestickGranularity granularity = null,
            int count = 500,
            WeeklyAlignment weeklyAlignment = null       
        ) {
            return await GetInstrumentCandles(instrument, from, to, granularity, count, weeklyAlignment);
        }
        public async Task<CandlestickResponse> GetInstrumentCandles(
            InstrumentName instrument,
            DateTime from,
            DateTime to
        ) {
            return await GetInstrumentCandles(instrument, from, to, ECandlestickGranularity.S5, 500, EWeeklyAlignment.Friday);
        }
        public async Task<CandlestickResponse> GetInstrumentCandles(
            InstrumentName instrument
        ) {
            return await GetInstrumentCandles(instrument);
        }

        /// <summary>
        /// Fetch an order book for an instrument.
        /// </summary>
        /// <param name="pairs"></param>
        /// <param name="queryNVC"></param>
        /// <returns></returns>
        public async Task<OrderBook> GetInstrumentOrderBook(InstrumentName pair, DateTime? time = null)
        {
            NameValueCollection queryNVC = new NameValueCollection();
            if (time != null)
                queryNVC.Add("time", time.Value.ToUniversalTime().ToString());

            string path = string.Format("instruments/{0}/orderBook", pair.ToString());
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["orderBook"].ToString();
                    return JsonConvert.DeserializeObject<OrderBook>(jsonString, ErrorHandlingSetting);
                }
            }                        
        }

        /// <summary>
        /// Fetch a position book for an instrument.
        /// </summary>
        /// <param name="pairs"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public async Task<PositionBook> GetInstrumentPositionBook(InstrumentName pairs, DateTime? time = null)
        {
            NameValueCollection queryNVC = new NameValueCollection();
            if (time != null)
                queryNVC.Add("time", time.Value.ToUniversalTime().ToString());

            string path = string.Format("instruments/{0}/positionBook", pairs);
            string query = QueryFromNVC(queryNVC);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    JObject jObject = JObject.Parse(await new StreamReader(stream).ReadToEndAsync());
                    var jsonString = jObject.ContainsKey("positionBook") ? jObject["positionBook"].ToString() : null;
                    return JsonConvert.DeserializeObject<PositionBook>(jsonString, ErrorHandlingSetting);
                }
            }            
        }
    }
}
