using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class OpenTradeFinancing
    {
        public TradeID TradeID;
        public AccountUnits Financing;

        public OpenTradeFinancing()
        {
            this.TradeID = new TradeID();
            this.Financing = new AccountUnits();
        }
        public OpenTradeFinancing(TradeID tradeID, AccountUnits financing)
        {
            this.TradeID = tradeID;
            this.Financing = financing;
        }
    }
}
