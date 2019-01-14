using OandaV20.Models.AccountModel;
using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class OrderClientExtensionsModifyTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // ORDER_CLIENT_EXTENSIONS_MODIFY
        public OrderID OrderID;
        public ClientID ClientOrderID;
        public ClientExtensions ClientExtensionsModify;
        public ClientExtensions TradeClientExtensionsModify;

        public OrderClientExtensionsModifyTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.ORDER_CLIENT_EXTENSIONS_MODIFY);
            this.OrderID = new OrderID();
            this.ClientOrderID = new ClientID();
            this.ClientExtensionsModify = new ClientExtensions();
            this.TradeClientExtensionsModify = new ClientExtensions();
        }

        public OrderClientExtensionsModifyTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, OrderID orderID, ClientID clientOrderID, ClientExtensions clientExtensionsModify, ClientExtensions tradeClientExtensionsModify)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.OrderID = orderID;
            this.ClientOrderID = clientOrderID;
            this.ClientExtensionsModify = clientExtensionsModify;
            this.TradeClientExtensionsModify = tradeClientExtensionsModify;
        }
    }
}
