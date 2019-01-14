using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class OrderCancelRejectTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // ORDER_CANCEL_REJECT
        public OrderID OrderID;
        public OrderID ClientOrderID;
        public TransactionRejectReason RejectReason;

        public OrderCancelRejectTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.ORDER_CANCEL_REJECT);
            this.OrderID = new OrderID();
            this.ClientOrderID = new OrderID();
            this.RejectReason = new TransactionRejectReason();
        }

        public OrderCancelRejectTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, OrderID orderID, OrderID clientOrderID, TransactionRejectReason rejectReason)
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
            this.RejectReason = rejectReason;
        }
    }
}
