using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.Primitives
{
    public enum EDatetimeFormat
    {
        RFC3339,
        UNIX
    }

    public class AcceptDatetimeFormat
    {        
        private EDatetimeFormat Value;

        // CONSTRUCTORS
        public AcceptDatetimeFormat()
        {
        }
        public AcceptDatetimeFormat(string value)
        {
            Set(value);
        }
        public AcceptDatetimeFormat(EDatetimeFormat value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if (Enum.TryParse(value, out this.Value))
                return true;
            else
                throw new ArgumentException("Unable to set incorrect DateTime format.\n Must either be: UNIX or RFC3339", "DateTime Format Error Exception");
        }

        // IMPLICIT OPERATORS
        public static implicit operator AcceptDatetimeFormat(EDatetimeFormat value)
        {
            return new AcceptDatetimeFormat(value);
        }
        public static implicit operator AcceptDatetimeFormat(string value)
        {
            return new AcceptDatetimeFormat(value);
        }
        public static implicit operator EDatetimeFormat(AcceptDatetimeFormat acceptDatetimeFormat)
        {
            return acceptDatetimeFormat.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
