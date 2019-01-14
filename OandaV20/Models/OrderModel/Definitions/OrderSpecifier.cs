namespace OandaV20.Models.OrderModel.Definitions
{
    public class OrderSpecifier
    {
        private readonly string Value;

        // CONSTRUCTORS
        public OrderSpecifier()
        {
        }
        public OrderSpecifier(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderSpecifier(string value)
        {
            return new OrderSpecifier(value);
        }
        public static implicit operator OrderSpecifier(int value)
        {
            return new OrderSpecifier(value.ToString());
        }
        public static implicit operator string(OrderSpecifier x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
