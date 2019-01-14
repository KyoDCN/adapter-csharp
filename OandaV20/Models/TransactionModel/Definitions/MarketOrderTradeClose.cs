using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.TradeModel;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class MarketOrderTradeClose
    {
        public TradeID TradeID;
        public string ClientTradeID;
        public string Units;

        public MarketOrderTradeClose()
        {
            this.TradeID = new TradeID();
        }
        public MarketOrderTradeClose(TradeID tradeID, string clientTradeID, string units)
        {
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.Units = units;
        }
    }
}
