using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class TransactionHeartbeat
    {
        public string Type;
        public TransactionID LastTransactionID;
        public DateTime Time;

        public TransactionHeartbeat()
        {
            this.LastTransactionID = new TransactionID();
            this.Time = new DateTime();
        }
        public TransactionHeartbeat(string type, TransactionID lastTransactionID, DateTime time)
        {
            this.Type = type;
            this.LastTransactionID = lastTransactionID;
            this.Time = time;
        }
    }
}
