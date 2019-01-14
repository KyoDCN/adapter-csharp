using System;

namespace OandaV20.Models.AccountModel
{
    public enum EPositionAggregationMode
    {
        ABSOLUTE_SUM,
        MAXIMAL_SIDE,
        NET_SUM
    }
    public class PositionAggregationMode
    {
        private EPositionAggregationMode Value;

        // CONSTRUCTORS
        public PositionAggregationMode()
        {
        }
        public PositionAggregationMode(string value)
        {
            Set(value);
        }
        public PositionAggregationMode(EPositionAggregationMode value)
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
                throw new ArgumentException("Invalid Position Aggregation Mode Value", "Position Aggregation Mode Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator PositionAggregationMode(EPositionAggregationMode value)
        {
            return new PositionAggregationMode(value);
        }
        public static implicit operator PositionAggregationMode(string value)
        {
            return new PositionAggregationMode(value);
        }
        public static implicit operator EPositionAggregationMode(PositionAggregationMode x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
