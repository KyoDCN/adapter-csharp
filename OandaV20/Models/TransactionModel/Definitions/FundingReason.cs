using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public enum EFundingReason
    {
        CLIENT_FUNDING,
        ACCOUNT_TRANSFER,
        DIVISION_MIGRATION,
        SITE_MIGRATION,
        ADJUSTMENT
    }

    public class FundingReason
    {
        public EFundingReason Value;

        // CONSTRUCTORS
        public FundingReason()
        {
            this.Value = new EFundingReason();
        }
        public FundingReason(string value)
        {
            Set(value);
        }
        public FundingReason(EFundingReason value)
        {
            this.Value = value;
        }

        // SETTERS
        public bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Incorrect Funding Reason", "Funding Reason Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator FundingReason(EFundingReason value)
        {
            return new FundingReason(value);
        }
        public static implicit operator FundingReason(string value)
        {
            return new FundingReason(value);
        }
        public static implicit operator EFundingReason(FundingReason fundingReason)
        {
            return fundingReason.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
