using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum EOrderPositionFill
    {
        OPEN_ONLY,
        REDUCE_FIRST,
        REDUCE_ONLY,
        DEFAULT
    }

    public class OrderPositionFill
    {
        private EOrderPositionFill Value;

        // CONSTRUCTORS
        public OrderPositionFill()
        {
            this.Value = new EOrderPositionFill();
        }
        public OrderPositionFill(string value)
        {
            Set(value);
        }
        public OrderPositionFill(EOrderPositionFill value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Order Position Fill", "Order Position Fill Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderPositionFill(EOrderPositionFill value)
        {
            return new OrderPositionFill(value);
        }
        public static implicit operator OrderPositionFill(string value)
        {
            return new OrderPositionFill(value);
        }
        public static implicit operator EOrderPositionFill(OrderPositionFill x)
        {
            return x.Value;
        }
        public static implicit operator string(OrderPositionFill x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
