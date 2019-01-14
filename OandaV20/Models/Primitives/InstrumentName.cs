using Newtonsoft.Json.Linq;
using System;

namespace OandaV20.Models.Primitives
{
    public enum EInstrumentName
    {
        // MAJOR PAIRS
        EUR_GBP, EUR_JPY, EUR_NZD, EUR_USD, GBP_AUD, GBP_CAD, GBP_CHF, GBP_JPY, GBP_NZD, NZD_CAD, NZD_CHF, NZD_JPY, NZD_USD, USD_CAD, USD_SGD, USD_CHF, USD_JPY,
        // MINOR PAIRS
        EUR_NOK, EUR_SEK, EUR_TRY, GBP_SEK, GBP_TRY, USD_CNH, USD_DKK, USD_HKD, USD_NOK, USD_SEK, USD_TRY,
        // EXOTIC PAIRS
        GBP_ZAR, USD_CZK, USD_HUF, USD_MXN, USD_ZAR, ZAR_JPY,
        // MISC PAIRS
        TRY_JPY, USD_THB, CHF_HKD, AUD_CAD, SGD_JPY, AUD_USD, EUR_CHF, AUD_SGD, GBP_USD, CAD_CHF, CAD_HKD, SGD_CHF, EUR_DKK, CHF_ZAR,
        AUD_NZD, HKD_JPY, CAD_SGD, EUR_ZAR, EUR_PLN, AUD_JPY, SGD_HKD, EUR_HUF, EUR_HKD, AUD_CHF, GBP_HKD, GBP_SGD, EUR_CAD, GBP_PLN,
        USD_PLN, EUR_SGD, CHF_JPY, EUR_AUD, EUR_CZK, AUD_HKD, NZD_HKD, CAD_JPY, USD_SAR, NZD_SGD
    }
    public class InstrumentName
    {
        private EInstrumentName Value;

        public InstrumentName()
        {
        }
        public InstrumentName(string value)
        {
            Set(value);
        }
        public InstrumentName(EInstrumentName value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value )
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Invalid Instrument Pairs value", "Instrument Name Exception");
            }
        }

        // IMPLICIT OPERATOR
        public static implicit operator InstrumentName(EInstrumentName value)
        {
            return new InstrumentName(value);
        }
        public static implicit operator InstrumentName(string value)
        {
            return new InstrumentName(value);
        }
        public static implicit operator EInstrumentName(InstrumentName x)
        {
            return x.Value;
        }
        public static implicit operator string(InstrumentName instrumentName)
        {
            return instrumentName.Value.ToString();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
