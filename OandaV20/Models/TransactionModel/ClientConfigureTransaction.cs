using OandaV20.Models.AccountModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class ClientConfigureTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type;
        public string Alias;
        public double MarginRate;

        public ClientConfigureTransaction()
        {
            this.Type = new TransactionType(ETransactionType.CLIENT_CONFIGURE);
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.CLIENT_CONFIGURE);
        }
        public ClientConfigureTransaction(
            TransactionID id, 
            DateTime time, 
            int userID, 
            AccountID accountID, 
            TransactionID batchID, 
            RequestID requestID, 
            TransactionType type, 
            string alias, 
            double marginRate
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
        }
    }
}
