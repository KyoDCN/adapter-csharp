using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EOrderCancelReason
    {
        INTERNAL_SERVER_ERROR,
        ACCOUNT_LOCKED,
        ACCOUNT_NEW_POSITIONS_LOCKED,
        ACCOUNT_ORDER_CREATION_LOCKED,
        ACCOUNT_ORDER_FILL_LOCKED,
        CLIENT_REQUEST,
        MIGRATION,
        MARKET_HALTED,
        LINKED_TRADE_CLOSED,
        TIME_IN_FORCE_EXPIRED,
        INSUFFICIENT_MARGIN,
        FIFO_VIOLATION,
        BOUNDS_VIOLATION,
        CLIENT_REQUEST_REPLACED,
        INSUFFICIENT_LIQUIDITY,
        TAKE_PROFIT_ON_FILL_GTD_TIMESTAMP_IN_PAST,
        TAKE_PROFIT_ON_FILL_LOSS,
        LOSING_TAKE_PROFIT,
        STOP_LOSS_ON_FILL_GTD_TIMESTAMP_IN_PAST,
        STOP_LOSS_ON_FILL_LOSS,
        STOP_LOSS_ON_FILL_PRICE_DISTANCE_MAXIMUM_EXCEEDED,
        STOP_LOSS_ON_FILL_REQUIRED,
        STOP_LOSS_ON_FILL_GUARANTEED_REQUIRED,
        STOP_LOSS_ON_FILL_GUARANTEED_NOT_ALLOWED,
        STOP_LOSS_ON_FILL_GUARANTEED_MINIMUM_DISTANCE_NOT_MET,
        STOP_LOSS_ON_FILL_GUARANTEED_LEVEL_RESTRICTION_EXCEEDED,
        STOP_LOSS_ON_FILL_GUARANTEED_HEDGING_NOT_ALLOWED,
        STOP_LOSS_ON_FILL_TIME_IN_FORCE_INVALID,
        STOP_LOSS_ON_FILL_TRIGGER_CONDITION_INVALID,
        TAKE_PROFIT_ON_FILL_PRICE_DISTANCE_MAXIMUM_EXCEEDED,
        TRAILING_STOP_LOSS_ON_FILL_GTD_TIMESTAMP_IN_PAST,
        CLIENT_TRADE_ID_ALREADY_EXISTS,
        POSITION_CLOSEOUT_FAILED,
        OPEN_TRADES_ALLOWED_EXCEEDED,
        PENDING_ORDERS_ALLOWED_EXCEEDED,
        TAKE_PROFIT_ON_FILL_CLIENT_ORDER_ID_ALREADY_EXISTS,
        STOP_LOSS_ON_FILL_CLIENT_ORDER_ID_ALREADY_EXISTS,
        TRAILING_STOP_LOSS_ON_FILL_CLIENT_ORDER_ID_ALREADY_EXISTS,
        POSITION_SIZE_EXCEEDED,
        HEDGING_GSLO_VIOLATION,
        ACCOUNT_POSITION_VALUE_LIMIT_EXCEEDED
    }

    public class OrderCancelReason
    {
        private EOrderCancelReason Value;

        // CONSTRUCTORS
        public OrderCancelReason()
        {
            this.Value = new EOrderCancelReason();
        }
        public OrderCancelReason(string value)
        {
            Set(value);
        }
        public OrderCancelReason(EOrderCancelReason value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Order Cancel Reason", "Order Cancel Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator OrderCancelReason(EOrderCancelReason value)
        {
            return new OrderCancelReason(value);
        }
        public static implicit operator OrderCancelReason(string value)
        {
            return new OrderCancelReason(value);
        }
        public static implicit operator EOrderCancelReason(OrderCancelReason orderCancelReason)
        {
            return orderCancelReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
