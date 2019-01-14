using System;
using System.Collections.Generic;

namespace OandaV20.Models.TradeModel
{
    public class TradeID
    {
        private readonly int Value;

        // CONSTRUCTORS
        public TradeID() { }
        public TradeID(int TradeID)
        {
            this.Value = TradeID;
        }
        public TradeID(string value)
        {
            Int32.TryParse(value, out this.Value);
        }

        // IMPLICIT OPERATORS
        public static implicit operator TradeID(int value)
        {
            return new TradeID(value);
        }
        public static implicit operator TradeID(string value)
        {
            return new TradeID(value);
        }
        public static implicit operator string(TradeID x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
