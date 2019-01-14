using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum ETransactionType
    {
        CREATE,
        CLOSE,
        REOPEN,
        CLIENT_CONFIGURE,
        CLIENT_CONFIGURE_REJECT,
        TRANSFER_FUNDS,
        TRANSFER_FUNDS_REJECT,
        MARKET_ORDER,
        MARKET_ORDER_REJECT,
        FIXED_PRICE_ORDER,
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

    public class TransactionType
    {
        private ETransactionType Value;

        // CONSTRUCTORS
        public TransactionType()
        {
            this.Value = new ETransactionType();
        }
        public TransactionType(string value)
        {
            Set(value);
        }
        public TransactionType(ETransactionType value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Invalid Transaction Type", "Transaction Type Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator TransactionType(ETransactionType value)
        {
            return new TransactionType(value);
        }
        public static implicit operator TransactionType(string value)
        {
            return new TransactionType(value);
        }
        public static implicit operator ETransactionType(TransactionType x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}