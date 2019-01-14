using OandaV20.Models.TransactionModel.Definitions;

namespace OandaV20.Models.PositionModel.Request
{
    public enum ECloseoutUnits
    {
        ALL,
        NONE
    }
    public class CloseoutPositionForInstrument
    {
        public string LongUnits; // default=ALL
        public ClientExtensions LongClientExtensions;
        public string ShortUnits; // default=ALL
        public ClientExtensions ShortClientExtensions;

        public CloseoutPositionForInstrument(int longUnits, int shortUnits)
        {
            this.LongUnits = longUnits.ToString();
            this.ShortUnits = shortUnits.ToString();
        }
        public CloseoutPositionForInstrument(ECloseoutUnits longUnits, ECloseoutUnits shortUnits)
        {
            this.LongUnits = longUnits.ToString();
            this.ShortUnits = shortUnits.ToString();
        }
        public CloseoutPositionForInstrument(int longUnits, ECloseoutUnits shortUnits)
        {
            this.LongUnits = longUnits.ToString();
            this.ShortUnits = shortUnits.ToString();
        }
        public CloseoutPositionForInstrument(ECloseoutUnits longUnits, int shortUnits)
        {
            this.LongUnits = longUnits.ToString();
            this.ShortUnits = shortUnits.ToString();
        }
    }
}
