using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // class variables
    public class Shipper
    {
        private int shipperID = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        // getting and set
        public int ShipperID
        {
            get { return this.shipperID; }
            set
            {
                if (value > -1)
                {
                    this.shipperID = value;
                }
                else
                {
                    this.shipperID = -1;
                }
            }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public Shipper():this(-1,"n/a","n/a")
        {
            //empty constructor
        }
        public Shipper(int aShipperId):this(aShipperId, "n/a", "n/a")
        {
            // partial constructor 
        }

        // full constructor
        public Shipper(int aShipperID, string aCompanyName, string aPhone)
        {
            this.ShipperID = aShipperID;
            this.CompanyName = aCompanyName;
            this.Phone = aPhone;
        }


        // creating a Tostring
        public override string ToString()
        {
            string message = " ";
            message = message + "shipperID: " + this.shipperID + "\n";
            message = message + "companyName: " + this.companyName + "\n";
            message = message + "phone: " + this.phone + "\n";
            return message;
        }
    }
}
