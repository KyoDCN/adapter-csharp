using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.Primitives
{
    public enum EDirection
    {
        LONG,
        SHORT
    };

    public class Direction
    {
        private EDirection Value;

        // CONSTRUCTORS
        public Direction()
        {
            this.Value = new EDirection();
        }
        public Direction(string value)
        {
            Set(value);
        }
        public Direction(EDirection value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Cannot set incorrect Direction.\n Must be LONG or SHORT", "Direction Error");
        }

        public static implicit operator Direction(EDirection value)
        {
            return new Direction(value);
        }
        public static implicit operator Direction(string value)
        {
            return new Direction(value);
        }
        public static implicit operator EDirection(Direction x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
