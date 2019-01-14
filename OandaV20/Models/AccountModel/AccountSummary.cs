using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.AccountModel
{
    public class AccountSummary
    {
        public AccountID Id;
        public string Alias;
        public Currency Currency;
        public AccountUnits Balance;
        public int CreatedByUserID;
        public DateTime CreatedTime;
        public GuaranteedStopLossOrderMode GuaranteedStopLossOrderMode;
        public AccountUnits PL;
        public AccountUnits ResettablePL;
        public DateTime ResettablePLTime;
        public AccountUnits Financing;
        public AccountUnits Commission;
        public AccountUnits GuaranteedExecutionFees;
        public double MarginRate;
        public DateTime MarginCallEnterTime;
        public int MarginCallExtensionCount;
        public DateTime LastMarginCallExtensionTime;
        public int OpenTradeCount;
        public int OpenPositionCount;
        public int PendingOrderCount;
        public bool HedgingEnabled;
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
        public TransactionID LastTransactionID;

        public AccountSummary()
        {
            this.Id = new AccountID();
            this.Currency = new Currency();
            this.Balance = new AccountUnits();
            this.CreatedTime = new DateTime();
            this.GuaranteedStopLossOrderMode = new GuaranteedStopLossOrderMode();
            this.PL = new AccountUnits();
            this.ResettablePL = new AccountUnits();
            this.ResettablePLTime = new DateTime();
            this.Financing = new AccountUnits();
            this.Commission = new AccountUnits();
            this.GuaranteedExecutionFees = new AccountUnits();
            this.MarginCallEnterTime = new DateTime();
            this.LastMarginCallExtensionTime = new DateTime();
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
            this.LastTransactionID = new TransactionID();
        }
        public AccountSummary(AccountID id, string alias, Currency currency, AccountUnits balance, int createdByUserID, DateTime createdTime, GuaranteedStopLossOrderMode guaranteedStopLossOrderMode, AccountUnits pL, AccountUnits resettablePL, DateTime resettablePLTime, AccountUnits financing, AccountUnits commission, AccountUnits guaranteedExecutionFees, double marginRate, DateTime marginCallEnterTime, int marginCallExtensionCount, DateTime lastMarginCallExtensionTime, int openTradeCount, int openPositionCount, int pendingOrderCount, bool hedgingEnabled, AccountUnits unrealizedPL, AccountUnits nAV, AccountUnits marginUsed, AccountUnits marginAvailable, AccountUnits positionValue, AccountUnits marginCloseoutUnrealizedPL, AccountUnits marginCloseoutNAV, AccountUnits marginCloseoutMarginUsed, double marginCloseoutPercent, double marginCloseoutPositionValue, AccountUnits withdrawalLimit, AccountUnits marginCallMarginUsed, double marginCallPercent, TransactionID lastTransactionID)
        {
            this.Id = id;
            this.Alias = alias;
            this.Currency = currency;
            this.Balance = balance;
            this.CreatedByUserID = createdByUserID;
            this.CreatedTime = createdTime;
            this.GuaranteedStopLossOrderMode = guaranteedStopLossOrderMode;
            this.PL = pL;
            this.ResettablePL = resettablePL;
            this.ResettablePLTime = resettablePLTime;
            this.Financing = financing;
            this.Commission = commission;
            this.GuaranteedExecutionFees = guaranteedExecutionFees;
            this.MarginRate = marginRate;
            this.MarginCallEnterTime = marginCallEnterTime;
            this.MarginCallExtensionCount = marginCallExtensionCount;
            this.LastMarginCallExtensionTime = lastMarginCallExtensionTime;
            this.OpenTradeCount = openTradeCount;
            this.OpenPositionCount = openPositionCount;
            this.PendingOrderCount = pendingOrderCount;
            this.HedgingEnabled = hedgingEnabled;
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
            this.LastTransactionID = lastTransactionID;
        }
    }
}