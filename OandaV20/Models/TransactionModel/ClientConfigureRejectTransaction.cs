using OandaV20.Models.AccountModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class ClientConfigureRejectTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // CLIENT_CONFIGURE_REJECT
        public string Alias;
        public double MarginRate;
        public TransactionRejectReason TransactionRejectReason;

        public ClientConfigureRejectTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.CLIENT_CONFIGURE_REJECT);
            this.TransactionRejectReason = new TransactionRejectReason();
            
        }
        public ClientConfigureRejectTransaction(
            TransactionID id, 
            DateTime time, 
            int userID, 
            AccountID accountID, 
            TransactionID batchID, 
            RequestID requestID, 
            TransactionType type, 
            string alias, 
            double marginRate, 
            TransactionRejectReason transactionRejectReason
        ) {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Alias = alias;
            this.MarginRate = marginRate;
            this.TransactionRejectReason = transactionRejectReason;
        }
    }
}
