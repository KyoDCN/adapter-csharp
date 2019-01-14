using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class TradeReduce
    {
        public TradeID TradeID;
        public double Units;
        public PriceValue Price;
        public AccountUnits RealizedPL;
        public AccountUnits Financing;
        public AccountUnits GuaranteedExecutionFee;
        public AccountUnits HalfSpreadCost;

        public TradeReduce()
        {
            this.TradeID = new TradeID();
            this.Price = new PriceValue();
            this.RealizedPL = new AccountUnits();
            this.Financing = new AccountUnits();
            this.GuaranteedExecutionFee = new AccountUnits();
            this.HalfSpreadCost = new AccountUnits();
        }
        public TradeReduce(
            TradeID tradeID, 
            double units, 
            PriceValue price, 
            AccountUnits realizedPL, 
            AccountUnits financing, 
            AccountUnits guaranteedExecutionFee, 
            AccountUnits halfSpreadCost
        ) {
            this.TradeID = tradeID;
            this.Units = units;
            this.Price = price;
            this.RealizedPL = realizedPL;
            this.Financing = financing;
            this.GuaranteedExecutionFee = guaranteedExecutionFee;
            this.HalfSpreadCost = halfSpreadCost;
        }
    }
}
