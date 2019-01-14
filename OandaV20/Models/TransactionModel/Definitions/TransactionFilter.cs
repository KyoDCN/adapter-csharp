using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum ETransactionFilter
    {
        ORDER,
        FUNDING,
        ADMIN,
        CREATE,
        CLOSE,
        REOPEN,
        CLIENT_CONFIGURE,
        CLIENT_CONFIGURE_REJECT,
        TRANSFER_FUNDS,
        TRANSFER_FUNDS_REJECT,
        MARKET_ORDER,
        MARKET_ORDER_REJECT,
        LIMIT_ORDER,
        LIMIT_ORDER_REJECT,
        STOP_ORDER,
        STOP_ORDER_REJECT,
        MARKET_IF_TOUCHED_ORDER,
        MARKET_IF_TOUCHED_ORDER_REJECT,
        TAKE_PROFIT_ORDER,
        TAKE_PROFIT_ORDER_REJECT,
        STOP_LOSS_ORDER,
        STOP_LOSS_ORDER_REJECT,
        TRAILING_STOP_LOSS_ORDER,
        TRAILING_STOP_LOSS_ORDER_REJECT,
        ONE_CANCELS_ALL_ORDER,
        ONE_CANCELS_ALL_ORDER_REJECT,
        ONE_CANCELS_ALL_ORDER_TRIGGERED,
        ORDER_FILL,
        ORDER_CANCEL,
        ORDER_CANCEL_REJECT,
        ORDER_CLIENT_EXTENSIONS_MODIFY,
        ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT,
        TRADE_CLIENT_EXTENSIONS_MODIFY,
        TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT,
        MARGIN_CALL_ENTER,
        MARGIN_CALL_EXTEND,
        MARGIN_CALL_EXIT,
        DELAYED_TRADE_CLOSURE,
        DAILY_FINANCING,
        RESET_RESETTABLE_PL
    }

    public class TransactionFilter
    {
        private ETransactionFilter Value;

        public TransactionFilter()
        {
            this.Value = new ETransactionFilter();
        }
        public TransactionFilter(string value)
        {
            Set(value);
        }
        public TransactionFilter(ETransactionFilter value)
        {
            this.Value = value;
        }

        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Invalid Transaction Filter value", "Transaction Filter Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator TransactionFilter(ETransactionFilter value)
        {
            return new TransactionFilter(value);
        }
        public static implicit operator TransactionFilter(string value)
        {
            return new TransactionFilter(value);
        }
        public static implicit operator ETransactionFilter(TransactionFilter x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
