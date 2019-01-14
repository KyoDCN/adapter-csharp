using OandaV20.Models.AccountModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    class TransferFundsTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // TRANSFER_FUNDS
        public AccountUnits Amount;
        public FundingReason FundingReason;
        public string Comment;
        public AccountUnits AccountBalance;

        public TransferFundsTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.TRANSFER_FUNDS);
            this.Amount = new AccountUnits();
            this.FundingReason = new FundingReason();
            this.AccountBalance = new AccountUnits();
        }
        public TransferFundsTransaction(
            TransactionID id, 
            DateTime time, 
            int userID, 
            AccountID accountID, 
            TransactionID batchID, 
            RequestID requestID, 
            TransactionType type, 
            AccountUnits amount, 
            FundingReason fundingReason, 
            string comment, 
            AccountUnits accountBalance
        ) {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Amount = amount;
            this.FundingReason = fundingReason;
            this.Comment = comment;
            this.AccountBalance = accountBalance;
        }
    }
}
