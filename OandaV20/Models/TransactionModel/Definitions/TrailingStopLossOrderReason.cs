using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum ETrailingStopLossOrderReason
    {
        CLIENT_ORDER,
        REPLACEMENT,
        ON_FILL
    }

    public class TrailingStopLossOrderReason
    {
        private ETrailingStopLossOrderReason Value;

        // CONSTRUCTORS
        public TrailingStopLossOrderReason()
        {
            this.Value = new ETrailingStopLossOrderReason();
        }
        public TrailingStopLossOrderReason(string value)
        {
            Set(value);
        }
        public TrailingStopLossOrderReason(ETrailingStopLossOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Trailing Stop Loss Order Reason", "Trailing Stop Loss Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator TrailingStopLossOrderReason(ETrailingStopLossOrderReason value)
        {
            return new TrailingStopLossOrderReason(value);
        }
        public static implicit operator TrailingStopLossOrderReason(string value)
        {
            return new TrailingStopLossOrderReason(value);
        }
        public static implicit operator ETrailingStopLossOrderReason(TrailingStopLossOrderReason trailingStopLossOrderReason)
        {
            return trailingStopLossOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
