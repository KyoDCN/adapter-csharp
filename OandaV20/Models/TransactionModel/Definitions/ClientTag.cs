using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class ClientTag
    {
        private string Value;

        // CONSTRUCTORS
        public ClientTag() { }
        public ClientTag(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator ClientTag(string value)
        {
            return new ClientTag(value);
        }
        public static implicit operator string(ClientTag clientTag)
        {
            return clientTag.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
