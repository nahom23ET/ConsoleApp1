using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // class variables
    public class Employee
    {
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private DateTime birthDay;
        //private int birthDay = 31;
        //private int birthMonth = 12;
        //private int birthYear = 1900;
        private DateTime hireDay;
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        // gettting and setting
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                // the value must be greather than -1
                //if the value is lessthan -1 it will automatically set it to -1
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = -1;
                }

            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }

        public DateTime BirthDay
        {
            get { return this.birthDay; }
            set { this.birthDay = value; }
        }

        public DateTime Hireday
        {
            get { return this.hireDay; }
            set { this.hireDay = value; }
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
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }
            set
            {
                // the value must be greather than -1
                // if the value is lessthan -1 it will automatically set to -1
                if (value > -1)
                {
                    this.reportsTo = value;
                }
                else
                {
                    this.reportsTo = -1;
                }
            }
        }
    }   
    
}
