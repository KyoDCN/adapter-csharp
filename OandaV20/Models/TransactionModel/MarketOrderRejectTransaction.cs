using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class MarketOrderRejectTransaction
    {
        public TransactionID Id { get; set; }
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public AccountID AccountID { get; set; }
        public TransactionID BatchID { get; set; }
        public RequestID RequestID { get; set; }
        public TransactionType Type { get; set; }
        public InstrumentName Instrument { get; set; }
        public double Units { get; set; }
        public TimeInForce TimeInForce { get; set; }
        public PriceValue PriceBound { get; set; }
        public OrderPositionFill PositionFill { get; set; }
        public MarketOrderTradeClose TradeClose { get; set; }
        public MarketOrderPositionCloseout LongPositionCloseout { get; set; }
        public MarketOrderPositionCloseout ShortPositionCloseout { get; set; }
        public MarketOrderMarginCloseout MarginCloseout { get; set; }
        public MarketOrderDelayedTradeClose DelayedTradeClose { get; set; }
        public MarketOrderReason Reason { get; set; }
        public ClientExtensions ClientExtensions { get; set; }
        public TakeProfitDetails TakeProfitOnFill { get; set; }
        public StopLossDetails StopLossOnFill { get; set; }
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }
        public ClientExtensions TradeClientExtensions { get; set; }
        public TransactionRejectReason RejectReason { get; set; }

        public MarketOrderRejectTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.MARKET_ORDER_REJECT);
            this.Instrument = new InstrumentName();
            this.TimeInForce = new TimeInForce(ETimeInForce.FOK);
            this.PriceBound = new PriceValue();
            this.PositionFill = new OrderPositionFill(EOrderPositionFill.DEFAULT);
            this.TradeClose = new MarketOrderTradeClose();
            this.LongPositionCloseout = new MarketOrderPositionCloseout();
            this.ShortPositionCloseout = new MarketOrderPositionCloseout();
            this.MarginCloseout = new MarketOrderMarginCloseout();
            this.DelayedTradeClose = new MarketOrderDelayedTradeClose();
            this.Reason = new MarketOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.TakeProfitOnFill = new TakeProfitDetails();
            this.StopLossOnFill = new StopLossDetails();
            this.TrailingStopLossOnFill = new TrailingStopLossDetails();
            this.TradeClientExtensions = new ClientExtensions();
            this.RejectReason = new TransactionRejectReason();
        }
        public MarketOrderRejectTransaction(
            TransactionID id, 
            DateTime time, 
            int userId, 
            AccountID accountID, 
            TransactionID batchID, 
            RequestID requestID, 
            TransactionType type, 
            InstrumentName instrument, 
            double units, 
            TimeInForce timeInForce, 
            PriceValue priceBound, 
            OrderPositionFill positionFill, 
            MarketOrderTradeClose tradeClose, 
            MarketOrderPositionCloseout longPositionCloseout, 
            MarketOrderPositionCloseout shortPositionCloseout, 
            MarketOrderMarginCloseout marginCloseout, 
            MarketOrderDelayedTradeClose delayedTradeClose, 
            MarketOrderReason reason, 
            ClientExtensions clientExtensions, 
            TakeProfitDetails takeProfitOnFill, 
            StopLossDetails stopLossOnFill, 
            TrailingStopLossDetails trailingStopLossOnFill, 
            ClientExtensions tradeClientExtensions, 
            TransactionRejectReason rejectReason
        ) {
            this.Id = id;
            this.Time = time;
            this.UserId = userId;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Instrument = instrument;
            this.Units = units;
            this.TimeInForce = timeInForce;
            this.PriceBound = priceBound;
            this.PositionFill = positionFill;
            this.TradeClose = tradeClose;
            this.LongPositionCloseout = longPositionCloseout;
            this.ShortPositionCloseout = shortPositionCloseout;
            this.MarginCloseout = marginCloseout;
            this.DelayedTradeClose = delayedTradeClose;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.TakeProfitOnFill = takeProfitOnFill;
            this.StopLossOnFill = stopLossOnFill;
            this.TrailingStopLossOnFill = trailingStopLossOnFill;
            this.TradeClientExtensions = tradeClientExtensions;
            this.RejectReason = rejectReason;
        }
    }
}
