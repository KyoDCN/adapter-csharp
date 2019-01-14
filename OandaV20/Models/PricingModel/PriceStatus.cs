using System;

namespace OandaV20.Models.PricingModel
{
    public enum EPriceStatus
    {
        TRADEABLE,
        NON_TRADEABLE,
        INVALID
    }

    public class PriceStatus
    {
        private EPriceStatus Value;

        // CONSTRUCTORS
        public PriceStatus()
        {
            this.Value = new EPriceStatus();
        }
        public PriceStatus(EPriceStatus value)
        {
            this.Value = value;
        }
        public PriceStatus(string value)
        {
            Set(value);
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Invalid Price Status. Must be TRADEABLE or NON-TRADEABLE", "Price Status error");
        }

        // IMPLICIT OPERATORS
        public static implicit operator PriceStatus(EPriceStatus value)
        {
            return new PriceStatus(value);
        }
        public static implicit operator PriceStatus(string value)
        {
            return new PriceStatus(value);
        }
        public static implicit operator EPriceStatus(PriceStatus x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}