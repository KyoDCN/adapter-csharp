using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EStopOrderReason
    {
        CLIENT_ORDER,
        REPLACEMENT
    }

    public class StopOrderReason
    {
        private EStopOrderReason Value;

        // CONSTRUCTORS
        public StopOrderReason()
        {
            this.Value = new EStopOrderReason();
        }
        public StopOrderReason(string value)
        {
            Set(value);
        }
        public StopOrderReason(EStopOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Stop Order Reason", "Stop Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator StopOrderReason(EStopOrderReason value)
        {
            return new StopOrderReason(value);
        }
        public static implicit operator StopOrderReason(string value)
        {
            return new StopOrderReason(value);
        }
        public static implicit operator EStopOrderReason(StopOrderReason stopOrderReason)
        {
            return stopOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
