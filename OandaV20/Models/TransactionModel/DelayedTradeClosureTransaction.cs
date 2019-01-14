using OandaV20.Models.AccountModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class DelayedTradeClosureTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // DELAYED_TRADE_CLOSURE
        public MarketOrderReason Reason;
        public TradeID TradeIDs;

        public DelayedTradeClosureTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.DELAYED_TRADE_CLOSURE);
            this.Reason = new MarketOrderReason();
            this.TradeIDs = new TradeID();
        }

        public DelayedTradeClosureTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, MarketOrderReason reason, TradeID tradeIDs)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Reason = reason;
            this.TradeIDs = tradeIDs;
        }
    }
}
