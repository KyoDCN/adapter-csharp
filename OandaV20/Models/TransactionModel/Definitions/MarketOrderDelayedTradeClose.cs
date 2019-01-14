using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.TradeModel;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class MarketOrderDelayedTradeClose
    {
        public TradeID TradeID;
        public TradeID ClientTradeID;
        public TransactionID SourceTransactionID;

        public MarketOrderDelayedTradeClose()
        {
            this.TradeID = new TradeID();
            this.ClientTradeID = new TradeID();
            this.SourceTransactionID = new TransactionID();
        }
        public MarketOrderDelayedTradeClose(TradeID tradeID, TradeID clientTradeID, TransactionID sourceTransactionID)
        {
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.SourceTransactionID = sourceTransactionID;
        }
    }
}
