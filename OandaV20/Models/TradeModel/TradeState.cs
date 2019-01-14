using System;

namespace OandaV20.Models.TradeModel
{
    public enum ETradeState
    {
        OPEN,
        CLOSED,
        CLOSE_WHEN_TRADEABLE
    }

    public class TradeState
    {
        private ETradeState Value;

        // CONSTRUCTORS
        public TradeState()
        {
        }
        public TradeState(string value)
        {
            Set(value);
        }
        public TradeState(ETradeState value)
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
                throw new ArgumentException("Incorrect Trade State Input", "Trade State Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator TradeState(ETradeState value)
        {
            return new TradeState(value);
        }
        public static implicit operator TradeState(string value)
        {
            return new TradeState(value);
        }
        public static implicit operator ETradeState(TradeState x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
