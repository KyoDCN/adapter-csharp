using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OandaV20.Models;
using OandaV20.Models.PositionModel;
using OandaV20.Models.PositionModel.Request;
using OandaV20.Models.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OandaV20.API
{
    // GET /accounts/{accountID}/positions
    // GET /accounts/{accountID}/openPositions
    // GET /accounts/{accountID}/positions/{instrument}
    // PUT /accounts/{accountID}/positions/{instrument}/close

    public class PositionAPI : MainAPI
    {
        /// <summary>
        /// List all Positions for an Account. The Positions returned are for every instrument that has had a position during the lifetime of an the Account.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Position>> GetPositions()
        {
            string path = string.Format("accounts/{0}/positions", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["positions"].ToString();
                    return JsonConvert.DeserializeObject<List<Position>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// List all open Positions for an Account. An open Position is a Position in an Account that currently has a Trade opened for it.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Position>> GetOpenPositions()
        {
            string path = string.Format("accounts/{0}/positions", AccountID);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["positions"].ToString();
                    return JsonConvert.DeserializeObject<List<Position>>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Get the details of a single Instrument’s Position in an Account. The Position may by open or not.
        /// </summary>
        /// <param name="instrument">Name of the Instrument [required].</param>
        /// <returns></returns>
        public async Task<Position> GetInstrumentPositions(InstrumentName instrument)
        {
            string path = string.Format("accounts/{0}/positions/{1}", AccountID, instrument);
            string query = null;

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Get, path, query))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = JObject.Parse(await new StreamReader(stream).ReadToEndAsync())["position"].ToString();
                    return JsonConvert.DeserializeObject<Position>(jsonString, ErrorHandlingSetting);
                }
            }            
        }

        /// <summary>
        /// Closeout the open Position for a specific instrument in an Account.
        /// </summary>
        /// <param name="instrument">Name of the Instrument [required].</param>
        /// <param name="positionRequest"></param>
        /// <returns></returns>
        public async Task<PositionCloseoutResponse> PutCloseoutPositionForInstrument(InstrumentName instrument, CloseoutPositionForInstrument positionRequest)
        {
            string path = string.Format("accounts/{0}/positions/{1}/close", AccountID, instrument);
            string query = null;
            string jsonBody = JsonConvert.SerializeObject(positionRequest, JsonSerializerSetting);

            using (HttpResponseMessage response = await RequestAsync(EHostAPIType.REST, HttpMethod.Put, path, query, jsonBody))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new HttpRequestException(JObject.Parse(await response.Content.ReadAsStringAsync())["errorMessage"].ToString());

                using (Stream stream = await response.Content.ReadAsStreamAsync())
                {
                    string jsonString = await new StreamReader(stream).ReadToEndAsync();
                    return JsonConvert.DeserializeObject<PositionCloseoutResponse>(jsonString, ErrorHandlingSetting);
                }
            }                       
        }
    }
}
