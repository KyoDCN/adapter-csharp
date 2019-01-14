using OandaV20.Models.AccountModel;
using OandaV20.Models.TradeModel;
using OandaV20.Models.TransactionModel.Definitions;
using System;

namespace OandaV20.Models.TransactionModel
{
    public class TradeClientExtensionsModifyTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // TRADE_CLIENT_EXTENSIONS_MODIFY
        public TradeID TradeID;
        public ClientID ClientTradeID;
        public ClientExtensions TradeClientExtensionsModify;

        public TradeClientExtensionsModifyTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.TRADE_CLIENT_EXTENSIONS_MODIFY);
            this.TradeID = new TradeID();
            this.ClientTradeID = new ClientID();
            this.TradeClientExtensionsModify = new ClientExtensions();
        }

        public TradeClientExtensionsModifyTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, TradeID tradeID, ClientID clientTradeID, ClientExtensions tradeClientExtensionsModify)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.TradeID = tradeID;
            this.ClientTradeID = clientTradeID;
            this.TradeClientExtensionsModify = tradeClientExtensionsModify;
        }
    }
}
