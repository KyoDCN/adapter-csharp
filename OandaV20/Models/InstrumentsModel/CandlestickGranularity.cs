using System;

namespace OandaV20.Models.InstrumentsModel
{
    public enum ECandlestickGranularity
    {
        S5,
        S10,
        S15,
        S30,
        M1,
        M2,
        M4,
        M5,
        M10,
        M15,
        M30,
        H1,
        H2,
        H3,
        H4,
        H6,
        H8,
        H12,
        D,
        W,
        M
    }  

    public class CandlestickGranularity
    {
        private ECandlestickGranularity Value;

        // CONSTRUCTORS
        public CandlestickGranularity()
        {
        }
        public CandlestickGranularity(string value)
        {
            Set(value);
        }
        public CandlestickGranularity(ECandlestickGranularity value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Incorrect Candlestick Granularity Input", "Candlestick Granularity Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator CandlestickGranularity(ECandlestickGranularity value)
        {
            return new CandlestickGranularity(value);
        }
        public static implicit operator CandlestickGranularity(string value)
        {
            return new CandlestickGranularity(value);
        }
        public static implicit operator ECandlestickGranularity(CandlestickGranularity x)
        {
            return x.Value;
        }
    }
}
