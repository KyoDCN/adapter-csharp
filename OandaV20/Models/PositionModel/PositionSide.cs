using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using System.Collections.Generic;

namespace OandaV20.Models.PositionModel
{
    public class PositionSide
    {
        public double Units;
        public PriceValue AveragePrice;
        public List<TradeID> TradeIDs;
        public AccountUnits PL;
        public AccountUnits UnrealizedPL;
        public AccountUnits ResettablePL;
        public AccountUnits Financing;
        public AccountUnits GuaranteedExecutionFees;

        public PositionSide()
        {
            this.AveragePrice = new PriceValue();
            this.TradeIDs = new List<TradeID>();
            this.PL = new AccountUnits();
            this.UnrealizedPL = new AccountUnits();
            this.ResettablePL = new AccountUnits();
            this.Financing = new AccountUnits();
            this.GuaranteedExecutionFees = new AccountUnits();
        }

        public PositionSide(double units, PriceValue averagePrice, List<TradeID> tradeIDs, AccountUnits pL, AccountUnits unrealizedPL, AccountUnits resettablePL, AccountUnits financing, AccountUnits guaranteedExecutionFees)
        {
            this.AveragePrice = averagePrice;
            this.TradeIDs = tradeIDs;
            this.PL = pL;
            this.UnrealizedPL = unrealizedPL;
            this.ResettablePL = resettablePL;
            this.Financing = financing;
            this.GuaranteedExecutionFees = guaranteedExecutionFees;
        }
    }
}
