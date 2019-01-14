using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum ETakeProfitOrderReason
    {
        CLIENT_ORDER,
        REPLACEMENT,
        ON_FILL
    }

    public class TakeProfitOrderReason
    {
        private ETakeProfitOrderReason Value;

        // CONSTRUCTORS
        public TakeProfitOrderReason()
        {
            this.Value = new ETakeProfitOrderReason();
        }
        public TakeProfitOrderReason(string value)
        {
            Set(value);
        }
        public TakeProfitOrderReason(ETakeProfitOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Take Profit Order Reason", "Take Profit Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator TakeProfitOrderReason(ETakeProfitOrderReason value)
        {
            return new TakeProfitOrderReason(value);
        }
        public static implicit operator TakeProfitOrderReason(string value)
        {
            return new TakeProfitOrderReason(value);
        }
        public static implicit operator ETakeProfitOrderReason(TakeProfitOrderReason takeProfitOrderReason)
        {
            return takeProfitOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
