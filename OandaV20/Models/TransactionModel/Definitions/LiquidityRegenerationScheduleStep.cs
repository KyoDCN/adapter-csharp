using OandaV20.Models.Primitives;
using System;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class LiquidityRegenerationScheduleStep
    {
        public DateTime TimeStamp;
        public double BidLiquidityUsed;
        public double AskLiquidityUsed;

        public LiquidityRegenerationScheduleStep()
        {
            this.TimeStamp = new DateTime();
        }
        public LiquidityRegenerationScheduleStep(DateTime timeStamp, double bidLiquidityUsed, double askLiquidityUsed)
        {
            this.TimeStamp = timeStamp;
            this.BidLiquidityUsed = bidLiquidityUsed;
            this.AskLiquidityUsed = askLiquidityUsed;
        }
    }
}
