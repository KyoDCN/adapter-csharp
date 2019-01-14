using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum EOrderType
    {
        MARKET,
        LIMIT,
        STOP,
        MARKET_IF_TOUCHED,
        TAKE_PROFIT,
        STOP_LOSS,
        TRAILING_STOP_LOSS,
        FIXED_PRICE
    }
    public class OrderType
    {
        private EOrderType Value;

        // CONSTRUCTORS
        public OrderType()
        {
        }
        public OrderType(string value)
        {
            Set(value);
        }
        public OrderType(EOrderType value)
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
                throw new ArgumentException("Invalid Order Type value", "Order Type Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderType(EOrderType value)
        {
            return new OrderType(value);
        }
        public static implicit operator OrderType(string value)
        {
            return new OrderType(value);
        }
        public static implicit operator string(OrderType x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
