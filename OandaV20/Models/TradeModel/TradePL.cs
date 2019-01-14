using System;

namespace OandaV20.Models.TradeModel
{
    public enum ETradePL
    {
        POSITIVE,
        NEGATIVE,
        ZERO
    }

    public class TradePL
    {
        private ETradePL Value;

        // CONSTRUCTORS
        public TradePL()
        {
        }
        public TradePL(string value)
        {
            Set(value);
        }
        public TradePL(ETradePL value)
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
                throw new ArgumentException("Incorrect Trade PL input", "Trade PL Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator TradePL(ETradePL value)
        {
            return new TradePL(value);
        }
        public static implicit operator TradePL(string value)
        {
            return new TradePL(value);
        }
        public static implicit operator ETradePL(TradePL x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
