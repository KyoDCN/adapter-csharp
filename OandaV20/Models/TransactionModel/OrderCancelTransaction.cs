using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class OrderCancelTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // ORDER_CANCEL
        public OrderID OrderID;
        public OrderID ClientOrderID;
        public OrderCancelReason Reason;
        public OrderID ReplacedByOrderID;

        public OrderCancelTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.ORDER_CANCEL);
            this.OrderID = new OrderID();
            this.ClientOrderID = new OrderID();
            this.Reason = new OrderCancelReason();
            this.ReplacedByOrderID = new OrderID();
        }

        public OrderCancelTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, OrderID orderID, OrderID clientOrderID, OrderCancelReason reason, OrderID replacedByOrderID)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.OrderID = orderID;
            this.ClientOrderID = clientOrderID;
            this.Reason = reason;
            this.ReplacedByOrderID = replacedByOrderID;
        }
    }
}
