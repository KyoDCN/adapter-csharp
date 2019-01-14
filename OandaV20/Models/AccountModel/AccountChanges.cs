using OandaV20.Models.PositionModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel;
using OandaV20.Models.OrderModel;
using System.Collections.Generic;

namespace OandaV20.Models.AccountModel
{
    class AccountChanges
    {
        public List<Order> OrdersCreated;
        public List<Order> OrdersCancelled;
        public List<Order> OrdersFilled;
        public List<Order> OrdersTriggered;
        public List<TradeSummary> TradesOpened;
        public List<TradeSummary> TradesReduced;
        public List<TradeSummary> TradesClosed;
        public List<Position> Positions;
        public List<Transaction> Transactions;

        public AccountChanges()
        {
            this.OrdersCreated = new List<Order>();
            this.OrdersCancelled = new List<Order>();
            this.OrdersFilled = new List<Order>();
            this.OrdersTriggered = new List<Order>();
            this.TradesOpened = new List<TradeSummary>();
            this.TradesReduced = new List<TradeSummary>();
            this.TradesClosed = new List<TradeSummary>();
            this.Positions = new List<Position>();
            this.Transactions = new List<Transaction>();
        }
        public AccountChanges(List<Order> ordersCreated, List<Order> ordersCancelled, List<Order> ordersFilled, List<Order> ordersTriggered, List<TradeSummary> tradesOpened, List<TradeSummary> tradesReduced, List<TradeSummary> tradesClosed, List<Position> positions, List<Transaction> transactions)
        {
            this.OrdersCreated = ordersCreated;
            this.OrdersCancelled = ordersCancelled;
            this.OrdersFilled = ordersFilled;
            this.OrdersTriggered = ordersTriggered;
            this.TradesOpened = tradesOpened;
            this.TradesReduced = tradesReduced;
            this.TradesClosed = tradesClosed;
            this.Positions = positions;
            this.Transactions = transactions;
        }
    }
}
