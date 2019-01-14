using Newtonsoft.Json.Linq;
using System;

namespace OandaV20.Models.PricingModel
{
    public class PriceValue
    {
        private readonly double Value;

        // CONSTRUCTORS
        public PriceValue() { }
        public PriceValue(double value)
        {
            this.Value = value;
        }
        public PriceValue(string value)
        {
            Double.TryParse(value, out Value);
        }

        // IMPLICIT OPERATOR SETTERS
        public static implicit operator PriceValue(string value)
        {
            return new PriceValue(value);
        }
        public static implicit operator PriceValue(double value)
        {
            return new PriceValue(value);
        }

        // IMPLICIT OPERATOR GETTERS
        public static implicit operator double(PriceValue x)
        {
            return x.Value;
        }
        public static implicit operator string(PriceValue x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
