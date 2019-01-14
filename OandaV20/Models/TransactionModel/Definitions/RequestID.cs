namespace OandaV20.Models.TransactionModel.Definitions
{
    public class RequestID
    {
        private readonly string Value;

        // CONSTRUCTORS
        public RequestID() { }
        public RequestID(string RequestID)
        {
            this.Value = RequestID;
        }

        // IMPLICIT OPERATORS
        public static implicit operator RequestID(string value)
        {
            return new RequestID(value);
        }
        public static implicit operator string(RequestID requestID)
        {
            return requestID.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
