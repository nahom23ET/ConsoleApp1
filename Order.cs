using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // class variables
    public class Order
    {
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private DateTime orederDate;
        private DateTime requireDate;
        private DateTime shippedDate;
        private int shipVia = -1;
        private double freight = 0;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";


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

        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }

        public int EmployeeId
        {
            // the value must be greather than -1
            // if the value is lessthan -1 it will automatically set to -1
            get { return this.employeeId; }
            set
            {
                if(value > -1)
                {
                    this.employeeId = value;
                }
                else 
                { 
                    this.employeeId = -1;
                }
            }

        }

        public DateTime OrederDate
        {
            get { return this.orederDate; }
            set { this.orederDate = value; }
        }

        public DateTime RequiredDate
        {
            get { return this.requireDate; }
            set { this.requireDate = value; }
        }

        public DateTime ShippedDate
        {
            get {  return this.shippedDate; }
            set { this.shippedDate = value; }
        }

        public int ShipVia
        {
            get { return this.shipVia; }
            set
            {
                // the value must be greather than -1
                // if the value is lessthan -1 it will automatically set to -1
                if (value > -1)
                {
                    this.shipVia = value;
                }
                else
                {
                    this.ShipVia = -1;
                }
            }
        }

        public double Freight
        {
            get { return this.freight; }
            set
            {
                // the value must be greather than 0
                // if the value is lessthan 0 it will automatically set to 0

                if (value > 0 )
                {
                    this.freight = value;
                }
                else
                {
                    this.freight = 0.0;
                }
            }
        }
         public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }

        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }
        public string ShipCity
        {
            get { return this.shipCity; }
            set { this.shipCity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }
        // Creating a To string
        public override string ToString()
        {
            string message = " ";
            message = message + "orderId: " + this.orderId + "\n";
            message = message + "customerId: " + this.customerId + "\n";
            message = message + "employeeId: " + this.employeeId + "\n";
            message = message + "orederDate: " + this.orederDate + "\n";
            message = message + "requireDate: " + this.requireDate + "\n";
            message = message + "shippedDate: " + this.shippedDate + "\n";
            message = message + "shipVia: " + this.shipVia + "\n";
            message = message + "freight: " + this.freight + "\n";
            message = message + "shipName: " + this.shipName + "\n";
            message = message + "shipAddress: " + this.shipAddress + "\n";
            message = message + "shipCity: " + this.shipCity + "\n";
            message = message + "shipRegion: " + this.shipRegion + "\n";
            message = message + "shipPostalCode: " + this.shipPostalCode + "\n";
            message = message + "shipCountry: " + this.shipCountry + "\n";
            return message;

        }
    }
}
