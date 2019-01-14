using System;

namespace OandaV20.Models.TradeModel
{
    public enum ETradeStateFilter
    {
        OPEN,
        CLOSED,
        CLOSE_WHEN_TRADEABLE,
        ALL
    }

    public class TradeStateFilter
    {
        private ETradeStateFilter Value;

        // CONSTRUCTORS
        public TradeStateFilter()
        {
        }
        public TradeStateFilter(string value)
        {
            Set(value);
        }
        public TradeStateFilter(ETradeStateFilter value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Incorrect Trade State Filter Input", "Trade State Filter Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator TradeStateFilter(ETradeStateFilter value)
        {
            return new TradeStateFilter(value);
        }
        public static implicit operator TradeStateFilter(string value)
        {
            return new TradeStateFilter(value);
        }
        public static implicit operator string(TradeStateFilter x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
