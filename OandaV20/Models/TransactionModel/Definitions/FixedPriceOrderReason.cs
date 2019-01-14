using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EFixedPriceOrderReason
    {
        PLATFORM_ACCOUNT_MIGRATION
    }

    public class FixedPriceOrderReason
    {
        public EFixedPriceOrderReason Value;

        // CONSTRUCTORS
        public FixedPriceOrderReason()
        {
            this.Value = new EFixedPriceOrderReason();
        }
        public FixedPriceOrderReason(string value)
        {
            Set(value);
        }
        public FixedPriceOrderReason(EFixedPriceOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        public bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Fixed Price Order Reason", "Fixed Price Order Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator FixedPriceOrderReason(EFixedPriceOrderReason value)
        {
            return new FixedPriceOrderReason(value);
        }
        public static implicit operator FixedPriceOrderReason(string value)
        {
            return new FixedPriceOrderReason(value);
        }
        public static implicit operator EFixedPriceOrderReason(FixedPriceOrderReason fixedPriceOrderReason)
        {
            return fixedPriceOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
