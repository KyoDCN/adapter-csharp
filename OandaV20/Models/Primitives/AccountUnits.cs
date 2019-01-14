namespace OandaV20.Models.Primitives
{
    public class AccountUnits
    {
        public readonly string Value;

        // CONSTRUCTORS
        public AccountUnits()
        {
        }
        public AccountUnits(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator AccountUnits(string value)
        {
            return new AccountUnits(value);
        }
        public static implicit operator string(AccountUnits accountUnits)
        {
            return accountUnits.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
