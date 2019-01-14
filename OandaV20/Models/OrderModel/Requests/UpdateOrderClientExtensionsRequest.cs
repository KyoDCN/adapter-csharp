using OandaV20.Models.TransactionModel.Definitions;

namespace OandaV20.Models.OrderModel.Requests
{
    public class UpdateOrderClientExtensionsRequest
    {
        public ClientExtensions ClientExtensions;
        public ClientExtensions TradeClientExtensions;

        public UpdateOrderClientExtensionsRequest()
        {
            ClientExtensions = new ClientExtensions();
            TradeClientExtensions = new ClientExtensions();
        }
        public UpdateOrderClientExtensionsRequest(ClientExtensions clientExtensions, ClientExtensions tradeClientExtensions)
        {
            this.ClientExtensions = clientExtensions;
            this.TradeClientExtensions = tradeClientExtensions;
        }
    }
}
