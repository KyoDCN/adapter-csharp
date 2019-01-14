using System;

namespace OandaV20.Models.AccountModel
{
    public enum EAccountFinancingMode
    {
        NO_FINANCING,
        SECOND_BY_SECOND,
        DAILY
    }

    public class AccountFinancingMode
    {
        private EAccountFinancingMode Value;

        public AccountFinancingMode()
        {
        }
        public AccountFinancingMode(string value)
        {
            Set(value);
        }
        public AccountFinancingMode(EAccountFinancingMode value)
        {
            this.Value = value;
        }

        private bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Cannot set incorrect Account Financing Mode.", "Account Financing Mode Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator AccountFinancingMode(EAccountFinancingMode value)
        {
            return new AccountFinancingMode(value);
        }
        public static implicit operator AccountFinancingMode(string value)
        {
            return new AccountFinancingMode(value);
        }
        public static implicit operator EAccountFinancingMode(AccountFinancingMode x)
        {
            return x.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
