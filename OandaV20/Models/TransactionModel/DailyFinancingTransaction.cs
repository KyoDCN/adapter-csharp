using OandaV20.Models.AccountModel;
using OandaV20.Models.Primitives;
using OandaV20.Models.TransactionModel.Definitions;
using System;
using System.Collections.Generic;

namespace OandaV20.Models.TransactionModel
{
    public class DailyFinancingTransaction
    {
        public TransactionID Id;
        public DateTime Time;
        public int UserID;
        public AccountID AccountID;
        public TransactionID BatchID;
        public RequestID RequestID;
        public TransactionType Type; // DAILY_FINANCING
        public AccountUnits Financing;
        public AccountUnits AccountBalance;
        public AccountFinancingMode AccountFinancingMode;
        public List<PositionFinancing> PositionFinancings;

        public DailyFinancingTransaction()
        {
            this.Id = new TransactionID();
            this.Time = new DateTime();
            this.AccountID = new AccountID();
            this.BatchID = new TransactionID();
            this.RequestID = new RequestID();
            this.Type = new TransactionType(ETransactionType.DAILY_FINANCING);
            this.Financing = new AccountUnits();
            this.AccountBalance = new AccountUnits();
            this.AccountFinancingMode = new AccountFinancingMode();
            this.PositionFinancings = new List<PositionFinancing>();
        }

        public DailyFinancingTransaction(TransactionID id, DateTime time, int userID, AccountID accountID, TransactionID batchID, RequestID requestID, TransactionType type, AccountUnits financing, AccountUnits accountBalance, AccountFinancingMode accountFinancingMode, List<PositionFinancing> positionFinancings)
        {
            this.Id = id;
            this.Time = time;
            this.UserID = userID;
            this.AccountID = accountID;
            this.BatchID = batchID;
            this.RequestID = requestID;
            this.Type = type;
            this.Financing = financing;
            this.AccountBalance = accountBalance;
            this.AccountFinancingMode = accountFinancingMode;
            this.PositionFinancings = positionFinancings;
        }
    }
}
