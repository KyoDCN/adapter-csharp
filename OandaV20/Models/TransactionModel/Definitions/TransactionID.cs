namespace OandaV20.Models.TransactionModel.Definitions
{
    public class TransactionID
    {
        private readonly string Value;

        // CONSTRUCTORS
        public TransactionID()
        {
        }
        public TransactionID(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator TransactionID(string value)
        {
            return new TransactionID(value);
        }
        public static implicit operator string(TransactionID transactionId)
        {
            return transactionId.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
