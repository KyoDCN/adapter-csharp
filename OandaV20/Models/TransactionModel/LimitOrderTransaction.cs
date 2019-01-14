using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class LimitOrderTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // LIMIT_ORDER
        public InstrumentName Instrument; // REQ
        public double Units; // REQ
        public PriceValue Price; // REQ
        public TimeInForce TimeInForce; // GTC, REQ
        public DateTime GTDTime;
        public OrderPositionFill PositionFill; // DEFAULT, REQ
        public OrderTriggerCondition TriggerCondition; // DEFAULT, REQ
        public LimitOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TakeProfitDetails TakeProfitOnFill;
        public StopLossDetails StopLossOnFill;
        public TrailingStopLossDetails TrailingStopLossOnFill;
        public ClientExtensions TradeClientExtensions;
        public OrderID ReplacesOrderID;
        public TransactionID CancellingTransactionID;

        public LimitOrderTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.LIMIT_ORDER);
            this.Instrument = new InstrumentName();
            this.Price = new PriceValue();
            this.TimeInForce = new TimeInForce();
            this.GTDTime = new DateTime();
            this.PositionFill = new OrderPositionFill(EOrderPositionFill.DEFAULT);
            this.TriggerCondition = new OrderTriggerCondition(EOrderTriggerCondition.DEFAULT);
            this.Reason = new LimitOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.TakeProfitOnFill = new TakeProfitDetails();
            this.StopLossOnFill = new StopLossDetails();
            this.TrailingStopLossOnFill = new TrailingStopLossDetails();
            this.TradeClientExtensions = new ClientExtensions();
            this.ReplacesOrderID = new OrderID();
            this.CancellingTransactionID = new TransactionID();
        }
        public LimitOrderTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, InstrumentName instrument, double units, PriceValue price, TimeInForce timeInForce, DateTime gTDTime, OrderPositionFill positionFill, OrderTriggerCondition triggerCondition, LimitOrderReason reason, ClientExtensions clientExtensions, TakeProfitDetails takeProfitOnFill, StopLossDetails stopLossOnFill, TrailingStopLossDetails trailingStopLossOnFill, ClientExtensions tradeClientExtensions, OrderID replacesOrderID, TransactionID cancellingTransactionID)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Instrument = instrument;
            this.Units = units;
            this.Price = price;
            this.TimeInForce = timeInForce;
            this.GTDTime = gTDTime;
            this.PositionFill = positionFill;
            this.TriggerCondition = triggerCondition;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.TakeProfitOnFill = takeProfitOnFill;
            this.StopLossOnFill = stopLossOnFill;
            this.TrailingStopLossOnFill = trailingStopLossOnFill;
            this.TradeClientExtensions = tradeClientExtensions;
            this.ReplacesOrderID = replacesOrderID;
            this.CancellingTransactionID = cancellingTransactionID;
        }
    }
}
