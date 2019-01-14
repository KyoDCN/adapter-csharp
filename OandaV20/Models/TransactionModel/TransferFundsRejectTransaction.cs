using OandaV20.Models.AccountModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class TransferFundsRejectTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // TRANSFER_FUNDS_REJECT
        public AccountUnits Amount;
        public FundingReason FundingReason;
        public string Comment;
        public TransactionRejectReason RejectReason;

        public TransferFundsRejectTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.TRANSFER_FUNDS_REJECT);
            this.Amount = new AccountUnits();
            this.FundingReason = new FundingReason();
            this.RejectReason = new TransactionRejectReason();
        }
        public TransferFundsRejectTransaction(
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
            TransactionRejectReason rejectReason
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
            this.RejectReason = rejectReason;
        }
    }
}
