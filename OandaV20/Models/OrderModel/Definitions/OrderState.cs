using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum EOrderState
    {
        PENDING,
        FILLED,
        TRIGGERED,
        CANCELLED
    }

    public class OrderState
    {
        private EOrderState Value;

        // CONSTRUCTORS
        public OrderState()
        {
        }
        public OrderState(string value)
        {
            Set(value);
        }
        public OrderState(EOrderState value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Invalid Order State Value", "Order State Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderState(EOrderState value)
        {
            return new OrderState(value);
        }
        public static implicit operator OrderState(string value)
        {
            return new OrderState(value);
        }
        public static implicit operator EOrderState(OrderState x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
