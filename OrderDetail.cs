using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // class variables
    public class OrderDetail
    {
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = 0.0;
        private int quantity = 0;
        private double discount = 0.0;

        // getting and setting
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                // the value must be greather than -1
                // if the value is lessthan -1 it will automatically set to -1
                if (value > -1)
                {
                    this.orderId = value;
                }
                else
                {
                    this.orderId = -1;
                }
            }
        }

        public int ProductId
        {
            get { return this.productId; }
            set
            {
                // the value must be greather than -1
                // if the value is lessthan -1 it will automatically set to -1
                if (value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = -1;
                }
            }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                // the value must be greather than -1
                // if the value is lessthan -1 it will automatically set to -1
                if (value > 0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0.0;
                }
            }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                // the value must be greather than 0
                // if the value is lessthan 0 it will automatically set to 0

                if (value > 0)
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }             
            }
        }

        public double Discount
        {
            get { return this.discount; }
            set
            {
                // the value must be greather than 0
                // if the value is lessthan it will automatically set to 0
                if (value > 0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = 0.0;

                }
            }
        }
        // overriding to string
        public override string ToString()
        {
            string message = " ";
            message = message + " orderId: " + this.orderId + "\n";
            message = message + " productId: " + this.productId + "\n";
            message = message + " unitPrice: " + this.unitPrice + "\n";
            message = message + " quantity: " + this.quantity + "\n";
            message = message + " discount: " + this.discount + "\n";
            return message;
        }
    }
}
