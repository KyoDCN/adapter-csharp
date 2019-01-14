using OandaV20.Models.Primitives;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using OandaV20.Models.PositionModel;
using System;
using System.Collections.Generic;
using OandaV20.Models.OrderModel;
using Newtonsoft.Json;

namespace OandaV20.Models.AccountModel
{
    public class Account
    {
        public AccountID Id { get; set; }
        public string Alias { get; set; }
        public Currency Currency { get; set; }
        public AccountUnits Balance { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public GuaranteedStopLossOrderMode GuaranteedStopLossOrderMode { get; set; }
        public AccountUnits PL { get; set; }
        public AccountUnits ResettablePL { get; set; }
        public DateTime ResettablePLTime { get; set; }
        public AccountUnits Financing { get; set; }
        public AccountUnits Commission { get; set; }
        public AccountUnits GuaranteedExecutionFees { get; set; }
        public double MarginRate { get; set; }
        public DateTime MarginCallEnterTime { get; set; }
        public int MarginCallExtensionCount { get; set; }
        public DateTime LastMarginCallExtensionTime { get; set; }
        public int OpenTradeCount { get; set; }
        public int OpenPositionCount { get; set; }
        public int PendingOrderCount { get; set; }
        public bool HedgingEnabled { get; set; }
        public AccountUnits UnrealizedPL { get; set; }
        public AccountUnits NAV { get; set; }
        public AccountUnits MarginUsed { get; set; }
        public AccountUnits MarginAvailable { get; set; }
        public AccountUnits PositionValue { get; set; }
        public AccountUnits MarginCloseoutUnrealizedPL { get; set; }
        public AccountUnits MarginCloseoutNAV { get; set; }
        public AccountUnits MarginCloseoutMarginUsed { get; set; }
        public double MarginCloseoutPercent { get; set; }
        public double MarginCloseoutPositionValue { get; set; }
        public AccountUnits WithdrawalLimit { get; set; }
        public AccountUnits MarginCallMarginUsed { get; set; }
        public double MarginCallPercent { get; set; }
        public TransactionID LastTransactionId { get; set; }
        public List<TradeSummary> Trades { get; set; }
        public List<Position> Positions { get; set; }
        public List<Order> Orders { get; set; }

        public Account()
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
            //this.LastTransactionId = new TransactionID();
            this.Trades = new List<TradeSummary>();
            this.Positions = new List<Position>();
            this.Orders = new List<Order>();
        }
        public Account(AccountID id, string alias, Currency currency, AccountUnits balance, int createdByUserId, DateTime createdTime, GuaranteedStopLossOrderMode guaranteedStopLossOrderMode, AccountUnits pL, AccountUnits resettablePL, DateTime resettablePLTime, AccountUnits financing, AccountUnits commission, AccountUnits guaranteedExecutionFees, double marginRate, DateTime marginCallEnterTime, int marginCallExtensionCount, DateTime lastMarginCallExtensionTime, int openTradeCount, int openPositionCount, int pendingOrderCount, bool hedgingEnabled, AccountUnits unrealizedPL, AccountUnits nAV, AccountUnits marginUsed, AccountUnits marginAvailable, AccountUnits positionValue, AccountUnits marginCloseoutUnrealizedPL, AccountUnits marginCloseoutNAV, AccountUnits marginCloseoutMarginUsed, double marginCloseoutPercent, double marginCloseoutPositionValue, AccountUnits withdrawalLimit, AccountUnits marginCallMarginUsed, double marginCallPercent, TransactionID lastTransactionId, List<TradeSummary> trades, List<Position> positions, List<Order> orders)
        {
            this.Id = id;
            this.Alias = alias;
            this.Currency = currency;
            this.Balance = balance;
            this.CreatedByUserId = createdByUserId;
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
            //this.LastTransactionId = lastTransactionId;
            this.Trades = trades;
            this.Positions = positions;
            this.Orders = orders;
        }
    }

    public class ParseNullDateTimeAsString : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType != typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
