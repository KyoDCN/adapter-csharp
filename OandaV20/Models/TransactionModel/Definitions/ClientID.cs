using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class ClientID
    {
        private string Value;

        // CONSTRUCTORS
        public ClientID() { }
        public ClientID(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator ClientID(string value)
        {
            return new ClientID(value);
        }
        public static implicit operator string(ClientID clientID)
        {
            return clientID.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
