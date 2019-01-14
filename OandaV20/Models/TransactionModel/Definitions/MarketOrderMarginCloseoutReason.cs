using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EMarketOrderMarginCloseoutReason
    {
        MARGIN_CHECK_VIOLATION,
        REGULATORY_MARGIN_CALL_VIOLATION
    }

    public class MarketOrderMarginCloseoutReason
    {
        private EMarketOrderMarginCloseoutReason Value;

        public MarketOrderMarginCloseoutReason()
        {
            this.Value = new EMarketOrderMarginCloseoutReason();
        }
        public MarketOrderMarginCloseoutReason(string value)
        {
            Set(value);
        }
        public MarketOrderMarginCloseoutReason(EMarketOrderMarginCloseoutReason MarketOrderMarginCloseoutReason)
        {
            this.Value = MarketOrderMarginCloseoutReason;
        }

        // SETTERS
        public bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Invalid Market Order Margin Closeout Reason", "Market Order Margin Closeout Reason Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator MarketOrderMarginCloseoutReason(EMarketOrderMarginCloseoutReason value)
        {
            return new MarketOrderMarginCloseoutReason(value);
        }
        public static implicit operator MarketOrderMarginCloseoutReason(string value)
        {
            return new MarketOrderMarginCloseoutReason(value);
        }
        public static implicit operator EMarketOrderMarginCloseoutReason(MarketOrderMarginCloseoutReason marketOrderMarginCloseoutReason)
        {
            return marketOrderMarginCloseoutReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
