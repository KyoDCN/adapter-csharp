using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// ACCOUNTS
// GET      /accounts
// GET      /accounts/{accountID}
// GET      /accounts/{accountID}/summary
// GET      /accounts/{accountID}/instruments
// PATCH    /accounts/{accountID}/configuration
// GET      /accounts/{accountID}/changes

// PRICING
// GET      /accounts/{accountID}/pricing
// GET      /accounts/{accountID}/pricing/stream

// TRADE
// GET      /accounts/{accountID}/trades
// GET      /accounts/{accountID}/openTrades
// GET      /accounts/{accountID}/trades/{tradeSpecifier}
// PUT      /accounts/{accountID}/trades/{tradeSpecifier}/close
// PUT      /accounts/{accountID}/trades/{tradeSpecifier}/clientExtensions
// PUT      /accounts/{accountID}/trades/{tradeSpecifier}/orders

// ORDER
// POST     /accounts/{accountID}/orders
// GET      /accounts/{accountID}/orders
// GET      /accounts/{accountID}/pendingOrders
// GET      /accounts/{accountID}/orders/{orderSpecifier}
// PUT      /accounts/{accountID}/orders/{orderSpecifier}
// PUT      /accounts/{accountID}/orders/{orderSpecifier}/cancel
// PUT      /accounts/{accountID}/orders/{orderSpecifier}/clientExtensions

// TRANSACTION
// GET      /accounts/{accountID}/transactions
// GET      /accounts/{accountID}/transactions/{transactionID}
// GET      /accounts/{accountID}/transactions/idrange
// GET      /accounts/{accountID}/transactions/sinceid
// GET      /accounts/{accountID}/transactions/stream

// POSITION
// GET      /accounts/{accountID}/positions
// GET      /accounts/{accountID}/openPositions
// GET      /accounts/{accountID}/positions/{instrument}
// PUT      /accounts/{accountID}/positions/{instrument}/close

// INSTRUMENT
// GET      /instruments/{instrument}/candles
// GET      /instruments/{instrument}/orderBook
// GET      /instruments/{instrument}/positionBook

namespace OandaV20.API
{
    public class MainAPI
    {
        /// <summary>
        /// Your Oanda AppToken
        /// </summary>
        private static readonly string AppToken = "";
        /// <summary>
        /// Your Oanda Account ID
        /// </summary>
        internal static readonly string AccountID = "";

        private readonly string FXPracticeHost = "api-fxpractice.oanda.com";
        private readonly string FXStreamPracticeHost = "stream-fxpractice.oanda.com";
        private readonly string FXTradeHost = "api-fxtrade.oanda.com";
        private readonly string FXStreamTradeHost = "stream-fxtrade.oanda.com";
        private readonly string FXVersion = "v3";

        public static JsonSerializer SerializerSetting = new JsonSerializer()
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
        public static JsonSerializerSettings JsonSerializerSetting = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };
        public static JsonSerializerSettings ErrorHandlingSetting = new JsonSerializerSettings
        {
            Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
            {
                Console.WriteLine("Member: " + args.ErrorContext.Member + ", Path: " + args.ErrorContext.Path + " -- " + args.ErrorContext.Error.Message);
                args.ErrorContext.Handled = true;
            },
            Converters = { new Newtonsoft.Json.Converters.IsoDateTimeConverter() }            
        };

        private static HttpClientHandler Handler = new HttpClientHandler()
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        };
        private static HttpClient Client = new HttpClient(Handler)
        {
            DefaultRequestHeaders =
            {
                Authorization = new AuthenticationHeaderValue("Bearer", AppToken),
                AcceptEncoding = { new StringWithQualityHeaderValue("gzip") }
            }
        };

        /// <summary>
        /// Makes an async web request
        /// </summary>
        /// <param name="method">HTTP Method (i.e., GET, POST, DEL, PATCH)</param>
        /// <param name="endpoint">String value endpoint path</param>
        /// <param name="queries">String value of queries</param>
        /// <returns></returns>
        internal async Task<HttpResponseMessage> RequestAsync(
            EHostAPIType hostType, 
            HttpMethod method, 
            string endpoint, 
            string queries = null, 
            string jsonBody = null
        ) {
            UriBuilder uri = new UriBuilder()
            {
                Scheme = Uri.UriSchemeHttps,
                Host = SelectHost(hostType),
                Path = string.Format("/{0}/{1}", FXVersion, endpoint),
                Query = queries ?? null
            };

            HttpRequestMessage req = new HttpRequestMessage()
            {
                Method = method,
                RequestUri = new Uri(uri.Uri.AbsoluteUri),
                Content = jsonBody != null ? new StringContent(jsonBody, Encoding.UTF8, "application/json") : null
            };

            return await Client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead);
        }

        internal string QueryFromNVC(NameValueCollection queries)
        {
            string query = null;

            for (int i = 0; i < queries.Keys.Count; i++)
            {
                query += string.Format(
                    "{0}={1}{2}",
                    queries.GetKey(i),
                    string.Join(",", queries.GetValues(i)),
                    queries.Keys.Count != i + 1 ? "&" : null
                );
            }

            return query;
        }

        public enum EHostAPIType
        {
            REST,
            STREAM
        }
        private string SelectHost(EHostAPIType hostAPI)
        {
            switch(hostAPI)
            {
                case EHostAPIType.REST:
                    return FXPracticeHost;
                case EHostAPIType.STREAM:
                    return FXStreamPracticeHost;
                default:
                    return FXPracticeHost;
            }
        }
    }
}
