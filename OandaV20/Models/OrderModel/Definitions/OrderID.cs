namespace OandaV20.Models.OrderModel.Definitions
{
    public class OrderID
    {
        private readonly string Value;

        // CONSTRUCTORS
        public OrderID() { }
        public OrderID(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderID(string value)
        {
            return new OrderID(value);
        }
        public static implicit operator string(OrderID x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
