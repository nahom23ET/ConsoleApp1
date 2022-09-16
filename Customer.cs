using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // Class variables
    public class Customer
    {
        private string customerId = "n/a";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        // getting and setting
        public string CustomerId
        {
            get { return this.customerId;  }
            set { this.customerId = value; }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }
        public Customer():this("n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            //empty constructor
        }
        public Customer(string acustomerId, string acompanyName) :this(acustomerId, acompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
         // partial constructor
        }

        public Customer(string acustomerId, string acompanyName, string acontactName, string acontactTitle, string aaddress, string acity, string aregion, string apostalCode, string acountry, string aphone, string afax)
        {
            this.CustomerId = acustomerId;
            this.CompanyName = acompanyName;
            this.ContactName = acontactName;
            this.ContactTitle = acontactTitle;
            this.Address = aaddress;
            this.City = acity;
            this.Region = aregion;
            this.PostalCode = apostalCode;
            this.Country = acountry;
            this.Phone = aphone;
            this.Fax = afax;
            
        }

        // To string
        public override string ToString()
        {
            string message = " ";
            message = message + " customer id: " + this.customerId + "\n";
            message = message + "company name: " + this.companyName + "\n";
            message = message + "contact name: " + this.contactName + "\n";
            message = message + "contact title: " + this.contactTitle + "\n";
            message = message + "address: " + this.address + "\n";
            message = message + "city: " + this.city + "\n";
            message = message + "region: " + this.region + "\n";
            message = message + "postal code: " + this.postalCode + "\n";
            message = message + "country: " + this.country + "\n";
            message = message + "phone: " + this.phone + "\n";
            message = message + "fax: "+ this.fax + "\n";
            return message;
        }

    }
}
