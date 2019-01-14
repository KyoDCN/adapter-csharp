using System;

namespace OandaV20.Models.OrderModel.Definitions
{
    public enum EOrderTriggerCondition
    {
        DEFAULT,
        INVERSE,
        BID,
        ASK,
        MID
    }

    public class OrderTriggerCondition
    {
        private EOrderTriggerCondition Value;

        // CONSTRUCTORS
        public OrderTriggerCondition()
        {
            this.Value = new EOrderTriggerCondition();
        }
        public OrderTriggerCondition(string value)
        {
            Set(value);
        }
        public OrderTriggerCondition(EOrderTriggerCondition value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Order Trigger Condition", "Order Trigger Condition Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderTriggerCondition(EOrderTriggerCondition value)
        {
            return new OrderTriggerCondition(value);
        }
        public static implicit operator OrderTriggerCondition(string value)
        {
            return new OrderTriggerCondition(value);
        }
        public static implicit operator EOrderTriggerCondition(OrderTriggerCondition x)
        {
            return x.Value;
        }
        public static implicit operator string(OrderTriggerCondition x)
        {
            return x.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
