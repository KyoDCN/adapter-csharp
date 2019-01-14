using OandaV20.Models.TransactionModel.Definitions;

namespace OandaV20.Models.OrderModel.Definitions
{
    public class OrderIdentifier
    {
        public OrderID OrderID;
        public ClientID ClientOrderID;

        public OrderIdentifier()
        {
            this.OrderID = new OrderID();
            this.ClientOrderID = new ClientID();
        }
        public OrderIdentifier(OrderID orderID, ClientID clientOrderID)
        {
            this.OrderID = orderID;
            this.ClientOrderID = clientOrderID;
        }
    }
}
