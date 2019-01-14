using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum ECancellableOrderType
    {
        LIMIT,
        STOP,
        MARKET_IF_TOUCHED,
        TAKE_PROFIT,
        STOP_LOSS,
        TRAILING_STOP_LOSS
    }

    public class CancellableOrderType
    {
        private ECancellableOrderType Value;

        // CONSTRUCTORS
        public CancellableOrderType()
        {
        }
        public CancellableOrderType(string value)
        {
            Set(value);
        }
        public CancellableOrderType(ECancellableOrderType value)
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
                throw new ArgumentException("Invalid Cancellable Order Type value", "Cancellable Order Type Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator CancellableOrderType(ECancellableOrderType value)
        {
            return new CancellableOrderType(value);
        }
        public static implicit operator CancellableOrderType(string value)
        {
            return new CancellableOrderType(value);
        }
        public static implicit operator ECancellableOrderType(CancellableOrderType x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
