using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.TradeModel
{
    public class TradeSpecifier
    {
        private readonly string Value;

        // CONSTRUCTORS
        public TradeSpecifier()
        {
        }
        public TradeSpecifier(int value)
        {
            this.Value = value.ToString();
        }
        public TradeSpecifier(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator TradeSpecifier(int value)
        {
            return new TradeSpecifier(value);
        }
        public static implicit operator TradeSpecifier(string value)
        {
            return new TradeSpecifier(value);
        }
        public static implicit operator string(TradeSpecifier x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
