using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EMarketOrderReason
    {
        CLIENT_ORDER,
        TRADE_CLOSE,
        POSITION_CLOSEOUT,
        MARGIN_CLOSEOUT,
        DELAYED_TRADE_CLOSE
    }

    public class MarketOrderReason
    {
        private EMarketOrderReason Value;

        // CONSTRUCTORS
        public MarketOrderReason()
        {
            this.Value = new EMarketOrderReason();
        }
        public MarketOrderReason(string value)
        {
            Set(value);
        }
        public MarketOrderReason(EMarketOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Market Order Reason Type", "Market Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator MarketOrderReason(EMarketOrderReason value)
        {
            return new MarketOrderReason(value);
        }
        public static implicit operator MarketOrderReason(string value)
        {
            return new MarketOrderReason(value);
        }
        public static implicit operator EMarketOrderReason(MarketOrderReason marketOrderReason)
        {
            return marketOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
