namespace OandaV20.Models.Primitives
{
    public class Currency
    {
        private readonly string Value;

        // CONSTRUCTORS
        public Currency()
        {
        }
        public Currency(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator Currency(string value)
        {
            return new Currency(value);
        }
        public static implicit operator string(Currency currency)
        {
            return currency.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
