using System;

namespace OandaV20.Models.Primitives
{
    public enum EInstrumentType
    {
        CURRENCY,
        CFD,
        METAL
    }

    public class InstrumentType
    {
        private EInstrumentType Value;

        // CONSTRUCTORS
        public InstrumentType()
        {
            this.Value = new EInstrumentType();
        }
        public InstrumentType(string value)
        {
            Set(value);
        }
        public InstrumentType(EInstrumentType value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new System.ArgumentException("Cannot set incorrect Instrument Type.\n Must be CURRENCY, CFD, or METAL", "Instrument Type Error");
        }

        // IMPLICIT OPERATORS
        public static implicit operator InstrumentType(EInstrumentType value)
        {
            return new InstrumentType(value);
        }
        public static implicit operator InstrumentType(string value)
        {
            return new InstrumentType(value);
        }
        public static implicit operator EInstrumentType(InstrumentType instrumentType)
        {
            return instrumentType.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
