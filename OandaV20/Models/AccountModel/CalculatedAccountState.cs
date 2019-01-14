using OandaV20.Models.Primitives;

namespace OandaV20.Models.AccountModel
{
    public class CalculatedAccountState
    {
        public AccountUnits UnrealizedPL;
        public AccountUnits NAV;
        public AccountUnits MarginUsed;
        public AccountUnits MarginAvailable;
        public AccountUnits PositionValue;
        public AccountUnits MarginCloseoutUnrealizedPL;
        public AccountUnits MarginCloseoutNAV;
        public AccountUnits MarginCloseoutMarginUsed;
        public double MarginCloseoutPercent;
        public double MarginCloseoutPositionValue;
        public AccountUnits WithdrawalLimit;
        public AccountUnits MarginCallMarginUsed;
        public double MarginCallPercent;

        public CalculatedAccountState()
        {
            this.UnrealizedPL = new AccountUnits();
            this.NAV = new AccountUnits();
            this.MarginUsed = new AccountUnits();
            this.MarginAvailable = new AccountUnits();
            this.PositionValue = new AccountUnits();
            this.MarginCloseoutUnrealizedPL = new AccountUnits();
            this.MarginCloseoutNAV = new AccountUnits();
            this.MarginCloseoutMarginUsed = new AccountUnits();
            this.WithdrawalLimit = new AccountUnits();
            this.MarginCallMarginUsed = new AccountUnits();
        }
        public CalculatedAccountState(AccountUnits unrealizedPL, AccountUnits nAV, AccountUnits marginUsed, AccountUnits marginAvailable, AccountUnits positionValue, AccountUnits marginCloseoutUnrealizedPL, AccountUnits marginCloseoutNAV, AccountUnits marginCloseoutMarginUsed, double marginCloseoutPercent, double marginCloseoutPositionValue, AccountUnits withdrawalLimit, AccountUnits marginCallMarginUsed, double marginCallPercent)
        {
            this.UnrealizedPL = unrealizedPL;
            this.NAV = nAV;
            this.MarginUsed = marginUsed;
            this.MarginAvailable = marginAvailable;
            this.PositionValue = positionValue;
            this.MarginCloseoutUnrealizedPL = marginCloseoutUnrealizedPL;
            this.MarginCloseoutNAV = marginCloseoutNAV;
            this.MarginCloseoutMarginUsed = marginCloseoutMarginUsed;
            this.MarginCloseoutPercent = marginCloseoutPercent;
            this.MarginCloseoutPositionValue = marginCloseoutPositionValue;
            this.WithdrawalLimit = withdrawalLimit;
            this.MarginCallMarginUsed = marginCallMarginUsed;
            this.MarginCallPercent = marginCallPercent;
        }
    }
}
