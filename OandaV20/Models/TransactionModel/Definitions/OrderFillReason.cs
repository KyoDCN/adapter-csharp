using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EOrderFillReason
    {
        LIMIT_ORDER,
        STOP_ORDER,
        MARKET_IF_TOUCHED_ORDER,
        TAKE_PROFIT_ORDER,
        STOP_LOSS_ORDER,
        TRAILING_STOP_LOSS_ORDER,
        MARKET_ORDER,
        MARKET_ORDER_TRADE_CLOSE,
        MARKET_ORDER_POSITION_CLOSEOUT,
        MARKET_ORDER_MARGIN_CLOSEOUT,
        MARKET_ORDER_DELAYED_TRADE_CLOSE
    }

    public class OrderFillReason
    {
        private EOrderFillReason Value;

        // CONSTRUCTORS
        public OrderFillReason()
        {
            this.Value = new EOrderFillReason();
        }
        public OrderFillReason(string value)
        {
            Set(value);
        }
        public OrderFillReason(EOrderFillReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Order Fill Reason", "Order Fill Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderFillReason(EOrderFillReason value)
        {
            return new OrderFillReason(value);
        }
        public static implicit operator OrderFillReason(string value)
        {
            return new OrderFillReason(value);
        }
        public static implicit operator EOrderFillReason(OrderFillReason orderFillReason)
        {
            return orderFillReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
