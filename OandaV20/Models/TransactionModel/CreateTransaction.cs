using OandaV20.Models.AccountModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    class CreateTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // DEFAULT=CREATE
        public int DivisionID;
        public int SiteID;
        public int AccountUserID;
        public int AccountNumber;
        public Currency HomeCurrency;

        public CreateTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.CREATE);
            this.HomeCurrency = new Currency();
        }
        public CreateTransaction(
            TransactionID id, 
            DateTime time, 
            int userID, AccountID accountID, 
            TransactionID batchID, 
            RequestID requestID, 
            TransactionType type, 
            int divisionID, 
            int siteID, 
            int accountUserID, 
            int accountNumber, 
            Currency homeCurrency
        ) {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.DivisionID = divisionID;
            this.SiteID = siteID;
            this.AccountUserID = accountUserID;
            this.AccountNumber = accountNumber;
            this.HomeCurrency = homeCurrency;
        }
    }
}
