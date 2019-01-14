using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum ELimitOrderReason
    {
        CLIENT_ORDER,
        REPLACEMENT
    }

    public class LimitOrderReason
    {
        public ELimitOrderReason Value;

        // CONSTRUCTORS
        public LimitOrderReason()
        {
            this.Value = new ELimitOrderReason();
        }
        public LimitOrderReason(string value)
        {
            Set(value);
        }
        public LimitOrderReason(ELimitOrderReason value)
        {
            this.Value = value;
        }

        // SETTERS
        public bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Limit Order Reason", "Limit Order Reason Exception");
        }

        // IMPLICIT OPERATOR
        public static implicit operator LimitOrderReason(ELimitOrderReason value)
        {
            return new LimitOrderReason(value);
        }
        public static implicit operator LimitOrderReason(string value)
        {
            return new LimitOrderReason(value);
        }
        public static implicit operator ELimitOrderReason(LimitOrderReason limitOrderReason)
        {
            return limitOrderReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
