using OandaV20.Models.TransactionModel.Definitions;

namespace OandaV20.Models.TradeModel.Request
{
    public class PutTradeOrderRequest
    {
        public TakeProfitDetails TakeProfit;
        public StopLossDetails StopLoss;
        public TrailingStopLossDetails TrailingStopLoss;

        public PutTradeOrderRequest(TakeProfitDetails value)
        {
            this.TakeProfit = value;
        }
        public PutTradeOrderRequest(StopLossDetails value)
        {
            this.StopLoss = value;
        }
        public PutTradeOrderRequest(TrailingStopLossDetails value)
        {
            this.TrailingStopLoss = value;
        }
    }    
}
