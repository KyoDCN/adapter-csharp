using OandaV20.Models.OrderModel;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.TradeModel
{
    public class Trade
    {
        public TradeID Id;
        public InstrumentName Instrument;
        public PriceValue Price;
        public DateTime OpenTime;
        public TradeState State;
        public double InitialUnits;
        public AccountUnits InitialMarginRequired;
        public double CurrentUnits;
        public AccountUnits RealizedPL;
        public AccountUnits UnrealizedPL;
        public AccountUnits MarginUsed;
        public PriceValue AverageClosePrice;
        public List<TransactionID> ClosingTransactionIDs;
        public AccountUnits Financing;
        public DateTime CloseTime;
        public ClientExtensions ClientExtensions;
        public TakeProfitOrder takeProfitOrder;
        public StopLossOrder StopLossOrder;
        public TrailingStopLossOrder TrailingStopLossOrder;

        public Trade()
        {
            this.Id = new TradeID();
            this.Instrument = new InstrumentName();
            this.Price = new PriceValue();
            this.OpenTime = new DateTime();
            this.State = new TradeState();
            this.InitialMarginRequired = new AccountUnits();
            this.RealizedPL = new AccountUnits();
            this.UnrealizedPL = new AccountUnits();
            this.MarginUsed = new AccountUnits();
            this.AverageClosePrice = new PriceValue();
            this.ClosingTransactionIDs = new List<TransactionID>();
            this.Financing = new AccountUnits();
            this.CloseTime = new DateTime();
            this.ClientExtensions = new ClientExtensions();
            this.takeProfitOrder = new TakeProfitOrder();
            this.StopLossOrder = new StopLossOrder();
            this.TrailingStopLossOrder = new TrailingStopLossOrder();
        }

        public Trade(TradeID id, InstrumentName instrument, PriceValue price, DateTime openTime, TradeState state, double initialUnits, AccountUnits initialMarginRequired, double currentUnits, AccountUnits realizedPL, AccountUnits unrealizedPL, AccountUnits marginUsed, PriceValue averageClosePrice, List<TransactionID> closingTransactionIDs, AccountUnits financing, DateTime closeTime, ClientExtensions clientExtensions, TakeProfitOrder takeProfitOrder, StopLossOrder stopLossOrder, TrailingStopLossOrder trailingStopLossOrder)
        {
            this.Id = id;
            this.Instrument = instrument;
            this.Price = price;
            this.OpenTime = openTime;
            this.State = state;
            this.InitialUnits = initialUnits;
            this.InitialMarginRequired = initialMarginRequired;
            this.CurrentUnits = currentUnits;
            this.RealizedPL = realizedPL;
            this.UnrealizedPL = unrealizedPL;
            this.MarginUsed = marginUsed;
            this.AverageClosePrice = averageClosePrice;
            this.ClosingTransactionIDs = closingTransactionIDs;
            this.Financing = financing;
            this.CloseTime = closeTime;
            this.ClientExtensions = clientExtensions;
            this.takeProfitOrder = takeProfitOrder;
            this.StopLossOrder = stopLossOrder;
            this.TrailingStopLossOrder = trailingStopLossOrder;
        }
    }
}
