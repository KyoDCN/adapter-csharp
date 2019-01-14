using System.Collections.Generic;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class LiquidityRegenerationSchedule
    {
        public List<LiquidityRegenerationScheduleStep> Value;

        // CONSTRUCTORS
        public LiquidityRegenerationSchedule()
        {
            this.Value = new List<LiquidityRegenerationScheduleStep>();
        }
        public LiquidityRegenerationSchedule(List<LiquidityRegenerationScheduleStep> steps)
        {
            this.Value = steps;
        }

        // Implicit Operators
        public static implicit operator LiquidityRegenerationSchedule(List<LiquidityRegenerationScheduleStep> value)
        {
            return new LiquidityRegenerationSchedule(value);
        }
        public static implicit operator List<LiquidityRegenerationScheduleStep>(LiquidityRegenerationSchedule liquidityRegenerationSchedule)
        {
            return liquidityRegenerationSchedule.Value;
        }
    }
}
