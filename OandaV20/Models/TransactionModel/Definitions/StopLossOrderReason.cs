using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EStopLossOrderReason
    {
        CLIENT_ORDER,
        REPLACEMENT,
        ON_FILL
    }

    public class StopLossOrderReason
    {
        private EStopLossOrderReason Value;

        // CONSTRUCTORS
        public StopLossOrderReason()
        {
            this.Value = new EStopLossOrderReason();
        }
        public StopLossOrderReason(string value)
        {
            Set(value);
        }
        public StopLossOrderReason(EStopLossOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Stop Loss Order Reason", "Stop Loss Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator StopLossOrderReason(EStopLossOrderReason value)
        {
            return new StopLossOrderReason(value);
        }
        public static implicit operator StopLossOrderReason(string value)
        {
            return new StopLossOrderReason(value);
        }
        public static implicit operator EStopLossOrderReason(StopLossOrderReason stopLossOrderReason)
        {
            return stopLossOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
