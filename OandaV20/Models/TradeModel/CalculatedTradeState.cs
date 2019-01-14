using OandaV20.Models.Primitives;

namespace OandaV20.Models.TradeModel
{
    public class CalculatedTradeState
    {
        public TradeID Id;
        public AccountUnits UnrealizedPL;
        public AccountUnits MarginUsed;

        public CalculatedTradeState()
        {
            this.Id = new TradeID();
            this.UnrealizedPL = new AccountUnits();
            this.MarginUsed = new AccountUnits();
        }

        public CalculatedTradeState(TradeID id, AccountUnits unrealizedPL, AccountUnits marginUsed)
        {
            this.Id = id;
            this.UnrealizedPL = unrealizedPL;
            this.MarginUsed = marginUsed;
        }
    }
}
