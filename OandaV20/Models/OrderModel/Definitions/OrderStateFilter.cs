using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum EOrderStateFilter
    {
        PENDING,
        FILLED,
        TRIGGERED,
        CANCELLED,
        ALL
    }

    public class OrderStateFilter
    {
        private EOrderStateFilter Value;

        // CONSTRUCTORS
        public OrderStateFilter()
        {
        }
        public OrderStateFilter(string value)
        {
            Set(value);
        }
        public OrderStateFilter(EOrderStateFilter value)
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
                throw new ArgumentException("Invalid Order State Filter value", "Order State Filter Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderStateFilter(EOrderStateFilter value)
        {
            return new OrderStateFilter(value);
        }
        public static implicit operator OrderStateFilter(string value)
        {
            return new OrderStateFilter(value);
        }
        public static implicit operator EOrderStateFilter(OrderStateFilter x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
