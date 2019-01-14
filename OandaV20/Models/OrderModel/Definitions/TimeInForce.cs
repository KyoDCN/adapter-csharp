using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum ETimeInForce
    {
        GTC,
        GTD,
        GFD,
        FOK,
        IOC
    };

    public class TimeInForce
    {
        private ETimeInForce Value;

        // CONSTRUCTORS
        public TimeInForce()
        {
            this.Value = new ETimeInForce();
        }
        public TimeInForce(string value)
        {
            Set(value);
        }
        public TimeInForce(ETimeInForce value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Cannot set incorrect Time in Force.", "Time in Force Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator TimeInForce(ETimeInForce value)
        {
            return new TimeInForce(value);
        }
        public static implicit operator TimeInForce(string value)
        {
            return new TimeInForce(value);
        }
        public static implicit operator ETimeInForce(TimeInForce x)
        {
            return x.Value;
        }
        public static implicit operator string(TimeInForce x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
