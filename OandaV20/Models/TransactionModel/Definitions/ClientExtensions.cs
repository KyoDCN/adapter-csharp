using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class ClientExtensions
    {
        [JsonConverter(typeof(ParseAsStringConverter))]
        public ClientID Id;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public ClientTag Tag;
        [JsonConverter(typeof(ParseAsStringConverter))]
        public ClientComment Comment;

        public ClientExtensions()
        {
            this.Id = new ClientID();
            this.Tag = new ClientTag();
            this.Comment = new ClientComment();
        }

        /// <summary>
        /// A ClientExtensions object allows a client to attach a clientID, tag and comment to Orders and Trades in their Account.  Do not set, modify, or delete this field if your account is associated with MT4.
        /// </summary>
        /// <param name="clientID">A client-provided identifier, used by clients to refer to their Orders or Trades with an identifier that they have provided.</param>
        /// <param name="clientTag">A client-provided tag that can contain any data and may be assigned to their Orders or Trades. Tags are typically used to associate groups of Trades and/or Orders together.</param>
        /// <param name="clientComment">A client-provided comment that can contain any data and may be assigned to their Orders or Trades. Comments are typically used to provide extra context or meaning to an Order or Trade.</param>
        public ClientExtensions(ClientID clientID, ClientTag clientTag, ClientComment clientComment)
        {
            this.Id = clientID;
            this.Tag = clientTag;
            this.Comment = clientComment;
        }
    }
}
