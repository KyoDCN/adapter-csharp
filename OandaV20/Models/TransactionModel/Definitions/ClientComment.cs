using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class ClientComment
    {
        private string Value;

        // CONSTRUCTORS
        public ClientComment()
        {
        }
        public ClientComment(string value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator ClientComment(string value)
        {
            return new ClientComment(value);
        }
        public static implicit operator string(ClientComment clientComment)
        {
            return clientComment.Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
