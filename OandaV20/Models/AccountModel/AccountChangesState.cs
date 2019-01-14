using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PositionModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using System.Collections.Generic;

namespace OandaV20.Models.AccountModel
{
    public class AccountChangesState
    {
        public AccountUnits UnrealizedPL;
        public AccountUnits NAV;
        public AccountUnits MarginUsed;
        public AccountUnits MarginAvailable;
        public AccountUnits Positionvalue;
        public AccountUnits MarginCloseoutUnrealizedPL;
        public AccountUnits MarginCloseoutNAV;
        public AccountUnits MarginCloseoutMarginUsed;
        public double MarginCloseoutPercent;
        public double MarginCloseoutPositionValue;
        public AccountUnits WithdrawalLimit;
        public AccountUnits MarginCallMarginUsed;
        public double MarginCallPercent;
        public List<DynamicOrderState> Orders;
        public List<CalculatedTradeState> Trades;
        public List<CalculatedPositionState> Positions;

        public AccountChangesState()
        {
            this.UnrealizedPL = new AccountUnits();
            this.NAV = new AccountUnits();
            this.MarginUsed = new AccountUnits();
            this.MarginAvailable = new AccountUnits();
            this.Positionvalue = new AccountUnits();
            this.MarginCloseoutUnrealizedPL = new AccountUnits();
            this.MarginCloseoutNAV = new AccountUnits();
            this.MarginCloseoutMarginUsed = new AccountUnits();
            this.WithdrawalLimit = new AccountUnits();
            this.MarginCallMarginUsed = new AccountUnits();
            this.Orders = new List<DynamicOrderState>();
            this.Trades = new List<CalculatedTradeState>();
            this.Positions = new List<CalculatedPositionState>();
        }
        public AccountChangesState(AccountUnits unrealizedPL, AccountUnits nAV, AccountUnits marginUsed, AccountUnits marginAvailable, AccountUnits positionvalue, AccountUnits marginCloseoutUnrealizedPL, AccountUnits marginCloseoutNAV, AccountUnits marginCloseoutMarginUsed, double marginCloseoutPercent, double marginCloseoutPositionValue, AccountUnits withdrawalLimit, AccountUnits marginCallMarginUsed, double marginCallPercent, List<DynamicOrderState> orders, List<CalculatedTradeState> trades, List<CalculatedPositionState> positions)
        {
            this.UnrealizedPL = unrealizedPL;
            this.NAV = nAV;
            this.MarginUsed = marginUsed;
            this.MarginAvailable = marginAvailable;
            this.Positionvalue = positionvalue;
            this.MarginCloseoutUnrealizedPL = marginCloseoutUnrealizedPL;
            this.MarginCloseoutNAV = marginCloseoutNAV;
            this.MarginCloseoutMarginUsed = marginCloseoutMarginUsed;
            this.MarginCloseoutPercent = marginCloseoutPercent;
            this.MarginCloseoutPositionValue = marginCloseoutPositionValue;
            this.WithdrawalLimit = withdrawalLimit;
            this.MarginCallMarginUsed = marginCallMarginUsed;
            this.MarginCallPercent = marginCallPercent;
            this.Orders = orders;
            this.Trades = trades;
            this.Positions = positions;
        }
    }
}
