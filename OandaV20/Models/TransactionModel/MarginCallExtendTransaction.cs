using OandaV20.Models.AccountModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class MarginCallExtendTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // MARGIN_CALL_EXTEND
        public int ExtensionNumber;

        public MarginCallExtendTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.MARGIN_CALL_EXTEND);
        }

        public MarginCallExtendTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, int extensionNumber)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.ExtensionNumber = extensionNumber;
        }
    }
}
