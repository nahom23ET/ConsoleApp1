using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // class variables
    public class Supplier
    {
        private int supplierId = -1;
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
        private string homePage = "n/a";

        // getting and set
        public int SupplierId
        {
            get{ return this.supplierId; }
            set
            {
                if( value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = -1;
                }
            }
        }

        public string CompanyName
        {
            get{ return this.companyName; }
            set { this.companyName = value; }
        }

        public string ContactName
        {
            get{ return this.contactName; }
            set{ this.contactName = value; }
        }

        public string ContactTitle
        {
            get{ return this.contactTitle; }
            set { this.contactTitle = value; }
        }

        public string Address
        {
            get{ return this.address; }
            set { this.address = value; }
        }
        
        public string City
        {
            get{ return this.city; }
            set { this.city = value; }
        }
        
        public string Region
        {
            get{ return this.region; }
            set { this.region = value; }
        }

        public string PostalCode
        {
            get{ return this.postalCode; }
            set { this.postalCode = value; }
        }

        public string Country
        {
            get{ return this.country; }
            set { this.country = value; }
        }

        public string Phone
        {
            get{ return this.phone; }
            set { this.phone = value; }
        }

        public string Fax
        {
            get{ return this.fax; }
            set { this.fax = value; }
        }

        public string HomePage
        {
            get{ return this.homePage; }
            set { this.homePage = value; }

        }
        public Supplier():this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            // empty constructor
        }

        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle):this(aSupplierId, aCompanyName, aContactName, aContactTitle, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {
            // partial constructor
        }

        //full constructor
        public Supplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {
            this.SupplierId = aSupplierId;
            this.CompanyName = aCompanyName;
            this.ContactName = aContactName;
            this.ContactTitle = aContactTitle;
            this.Address = anAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
            this.HomePage = aHomePage;

        }


        // creating a override Tostring
        public override string ToString()
        {
            string message = " ";
            message = message + "supplierId: " + this.supplierId + "\n";
            message = message + "companyName: " + this.companyName + "\n";
            message = message + "contactName: " + this.contactName + "\n";
            message = message + "contactTitle: " + this.contactTitle + "\n";
            message = message + "address: " + this.address + "\n";
            message = message + "city: " + this.city + "\n";
            message = message + "region: " + this.region + "\n";
            message = message + "postalCode: " + this.postalCode + "\n";
            message = message + "country: " + this.country + "\n";
            message = message + "phone: " + this.phone + "\n";
            message = message + "fax: " + this.fax + "\n";
            message = message + "homePage: " + this.homePage + "\n";
            return message;

        }
    }

}
