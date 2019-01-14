using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EMarketIfTouchedOrderReason {
        CLIENT_ORDER,
        REPLACEMENT
    }

    public class MarketIfTouchedOrderReason
    {
        private EMarketIfTouchedOrderReason Value;

        // CONSTRUCTORS
        public MarketIfTouchedOrderReason()
        {
            this.Value = new EMarketIfTouchedOrderReason();
        }
        public MarketIfTouchedOrderReason(string value)
        {
            Set(value);
        }
        public MarketIfTouchedOrderReason(EMarketIfTouchedOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        public bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Market If Touched Order Reason", "Market If Touched Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator MarketIfTouchedOrderReason(EMarketIfTouchedOrderReason value)
        {
            return new MarketIfTouchedOrderReason(value);
        }
        public static implicit operator MarketIfTouchedOrderReason(string value)
        {
            return new MarketIfTouchedOrderReason(value);
        }
        public static implicit operator EMarketIfTouchedOrderReason(MarketIfTouchedOrderReason marketIfTouchedOrderReason)
        {
            return marketIfTouchedOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
