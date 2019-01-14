using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.TransactionModel
{
    public class OrderFillTransaction
    {
        public TransactionID TransactionID;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // ORDER_FILL
        public OrderID OrderID;
        public ClientID ClientOrderID;
        public InstrumentName Instrument;
        public double Units;
        public double GainQuoteHomeConversionFactor;
        public double LossQuoteHomeConversionFactor;
        // public PriceValue Price; // Deprecated
        public ClientPrice FullPrice;
        public OrderFillReason Reason;
        public AccountUnits PL;
        public AccountUnits Financing;
        public AccountUnits Commission;
        public AccountUnits GuaranteedExecutionFee;
        public AccountUnits AccountBalance;
        public TradeOpen TradeOpened;
        public List<TradeReduce> TradesClosed;
        public TradeReduce TradeReduced;
        public AccountUnits HalfSpreadCost;

        public OrderFillTransaction()
        {
            this.TransactionID = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.ORDER_FILL);
            this.OrderID = new OrderID();
            this.ClientOrderID = new ClientID();
            this.Instrument = new InstrumentName();
            this.FullPrice = new ClientPrice();
            this.Reason = new OrderFillReason();
            this.PL = new AccountUnits();
            this.Financing = new AccountUnits();
            this.Commission = new AccountUnits();
            this.GuaranteedExecutionFee = new AccountUnits();
            this.AccountBalance = new AccountUnits();
            this.TradeOpened = new TradeOpen();
            this.TradesClosed = new List<TradeReduce>();
            this.TradeReduced = new TradeReduce();
            this.HalfSpreadCost = new AccountUnits();
        }

        public OrderFillTransaction(TransactionID transactionID, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, OrderID orderID, ClientID clientOrderID, InstrumentName instrument, double units, double gainQuoteHomeConversionFactor, double lossQuoteHomeConversionFactor, ClientPrice fullPrice, OrderFillReason reason, AccountUnits pL, AccountUnits financing, AccountUnits commission, AccountUnits guaranteedExecutionFee, AccountUnits accountBalance, TradeOpen tradeOpened, List<TradeReduce> tradesClosed, TradeReduce tradeReduced, AccountUnits halfSpreadCost)
        {
            this.TransactionID = transactionID;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.OrderID = orderID;
            this.ClientOrderID = clientOrderID;
            this.Instrument = instrument;
            this.Units = units;
            this.GainQuoteHomeConversionFactor = gainQuoteHomeConversionFactor;
            this.LossQuoteHomeConversionFactor = lossQuoteHomeConversionFactor;
            this.FullPrice = fullPrice;
            this.Reason = reason;
            this.PL = pL;
            this.Financing = financing;
            this.Commission = commission;
            this.GuaranteedExecutionFee = guaranteedExecutionFee;
            this.AccountBalance = accountBalance;
            this.TradeOpened = tradeOpened;
            this.TradesClosed = tradesClosed;
            this.TradeReduced = tradeReduced;
            this.HalfSpreadCost = halfSpreadCost;
        }
    }
}
