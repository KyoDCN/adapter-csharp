using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class FixedPriceOrderTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserId;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // FIXED_PRICE_ORDER
        public InstrumentName Instrument; //REQ
        public double Units; // REQ
        public PriceValue Price; // REQ
        public OrderPositionFill PositionFill; // DEFAULT, REQ
        public string TradeState; // REQ
        public FixedPriceOrderReason Reason;
        public ClientExtensions ClientExtensions;
        public TakeProfitDetails TakeProfitOnFill;
        public StopLossDetails StopLossOnFill;
        public TrailingStopLossDetails TrailingStopLossOnFill;
        public ClientExtensions TradeClientExtensions;

        public FixedPriceOrderTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.FIXED_PRICE_ORDER);
            this.Instrument = new InstrumentName();
            this.Price = new PriceValue();
            this.PositionFill = new OrderPositionFill(EOrderPositionFill.DEFAULT);
            this.Reason = new FixedPriceOrderReason();
            this.ClientExtensions = new ClientExtensions();
            this.TakeProfitOnFill = new TakeProfitDetails();
            this.StopLossOnFill = new StopLossDetails();
            this.TrailingStopLossOnFill = new TrailingStopLossDetails();
            this.TradeClientExtensions = new ClientExtensions();
        }
        public FixedPriceOrderTransaction(
            TransactionID id, 
            DateTime time, 
            int userId, 
            AccountID accountID, 
            TransactionID batchID, 
            RequestID requestID, 
            TransactionType type, 
            InstrumentName instrument, 
            double units, 
            PriceValue price, 
            OrderPositionFill positionFill, 
            string tradeState, 
            FixedPriceOrderReason reason, 
            ClientExtensions clientExtensions, 
            TakeProfitDetails takeProfitOnFill, 
            StopLossDetails stopLossOnFill, 
            TrailingStopLossDetails trailingStopLossOnFill, 
            ClientExtensions tradeClientExtensions
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
            this.Price = price;
            this.PositionFill = positionFill;
            this.TradeState = tradeState;
            this.Reason = reason;
            this.ClientExtensions = clientExtensions;
            this.TakeProfitOnFill = takeProfitOnFill;
            this.StopLossOnFill = stopLossOnFill;
            this.TrailingStopLossOnFill = trailingStopLossOnFill;
            this.TradeClientExtensions = tradeClientExtensions;
        }
    }
}
