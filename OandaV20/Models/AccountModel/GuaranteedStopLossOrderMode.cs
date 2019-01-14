using System;

namespace OandaV20.Models.AccountModel
{
    public enum EGuaranteedStopLossOrderMode
    {
        DISABLED,
        ALLOWED,
        REQUIRED
    }

    public class GuaranteedStopLossOrderMode
    {
        private EGuaranteedStopLossOrderMode Value;

        // CONSTRUCTORS
        public GuaranteedStopLossOrderMode()
        {
        }
        public GuaranteedStopLossOrderMode(string value)
        {
            Set(value);
        }
        public GuaranteedStopLossOrderMode(EGuaranteedStopLossOrderMode value)
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
                throw new ArgumentException("Invalid Guaranteed Stop Loss Order Mode", "Guaranteed Stop Loss Order Mode Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator GuaranteedStopLossOrderMode(EGuaranteedStopLossOrderMode value)
        {
            return new GuaranteedStopLossOrderMode(value);
        }
        public static implicit operator GuaranteedStopLossOrderMode(string value)
        {
            return new GuaranteedStopLossOrderMode(value);
        }
        public static implicit operator EGuaranteedStopLossOrderMode(GuaranteedStopLossOrderMode x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
