using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class TradeOpen
    {
        public TradeID TradeID;
        public double Units;
        public PriceValue Price;
        public AccountUnits GuaranteedExecutionFee;
        public ClientExtensions ClientExtensions;
        public AccountUnits HalfSpreadCost;
        public AccountUnits InitialMarginRequired;

        public TradeOpen()
        {
            this.TradeID = new TradeID();
            this.Price = new PriceValue();
            this.GuaranteedExecutionFee = new AccountUnits();
            this.ClientExtensions = new ClientExtensions();
            this.HalfSpreadCost = new AccountUnits();
            this.InitialMarginRequired = new AccountUnits();
        }
        public TradeOpen(
            TradeID tradeID, 
            double units, 
            PriceValue price, 
            AccountUnits guaranteedExecutionFee, 
            ClientExtensions clientExtensions, 
            AccountUnits halfSpreadCost, 
            AccountUnits initialMarginRequired)
        {
            this.TradeID = tradeID;
            this.Units = units;
            this.Price = price;
            this.GuaranteedExecutionFee = guaranteedExecutionFee;
            this.ClientExtensions = clientExtensions;
            this.HalfSpreadCost = halfSpreadCost;
            this.InitialMarginRequired = initialMarginRequired;
        }
    }
}
