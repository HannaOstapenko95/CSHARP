using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order :EntityBase, ILoggable
    {
        public Order() : this(0) // chain constructor
        {

        }
        public Order(int orderId)
        {
            orderId = orderId;
            OrderItems = new List<OrderItem>(); //initialize
        }
        //for relation (composition using ID) with Customer and Address
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        //Composition between Order and OrderItems
        public List<OrderItem> OrderItems { get; set; }

        /*public string Log()
        {
            throw new NotImplementedException();
        }*/
        public string Log() => $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

        public override string ToString() => 
            $"{OrderDate.Value.Date} ({OrderId})";
        /*//Retrieve one order
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        //Saves current order
        public bool Save()
        {
            return true;
        }*/
        //Validates the order data
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

    }
 
}
