namespace OandaV20.Models.AccountModel
{
    public class AccountID
    {
        private readonly string Value;

        // CONSTRUCTORS
        public AccountID()
        {
        }
        public AccountID(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator AccountID(string value)
        {
            return new AccountID(value);
        }
        public static implicit operator string(AccountID x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
