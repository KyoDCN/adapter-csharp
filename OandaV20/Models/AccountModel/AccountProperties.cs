using System.Collections.Generic;

namespace OandaV20.Models.AccountModel
{
    public class AccountProperties
    {
        public AccountID Id;
        public int MT4AccountID;
        public List<string> Tags;

        public AccountProperties()
        {
            this.Id = new AccountID();
            this.Tags = new List<string>();
        }
        public AccountProperties(AccountID id, int mT4AccountID, List<string> tags)
        {
            this.Id = id;
            this.MT4AccountID = mT4AccountID;
            this.Tags = tags;
        }
    }
}
