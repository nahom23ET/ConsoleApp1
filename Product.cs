using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC
{
    // class variables
    public class Product
    {
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int catagoryId = -1;
        private string quantityPerUnit = "n/a";
        private double Unitprice = 0.0;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reOrderLevel = -1;
        private bool discontinued = false;

        // getting and set
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if(value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = -1;
                }
            }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if(value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = -1;
                }
            }
        }
        public int CatagoryId
        {
            get { return this.catagoryId; }
            set
            {
                if (value > -1)
                {
                    this.catagoryId = value;
                }
                else
                {
                    this.catagoryId = -1;
                }
            }
        }

        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
        }
         public double UnitPrice
        {
            get { return this.Unitprice; }
            set
            {
                if(value > 0 )
                {
                    this.Unitprice = value;
                }
                else
                {
                    this.Unitprice = 0;
                }
            }
        }

        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set
            {
                if (value > -1)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = -1;
                }
            }
        }

        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set
            {
                if (value > -1)
                {
                    this.unitsOnOrder = value;
                }
                else
                {
                    this.unitsOnOrder = -1;
                }
            }
        }


        public int ReOrderLevel
        {
            get { return this.reOrderLevel; }
            set
            {
                if (value > 0)
                {
                    this.reOrderLevel = value;
                }
                else
                {
                    this.reOrderLevel = 0;
                }
            }
        }
        public bool Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = false; }
        }


        public Product():this(-1,"n/a",-1,-1,"n/a",0.0,-1,-1,-1,false)
        {
            //empty constructoe
        }
        public Product(int aProductId, string aProductName, int aSupplierId):this(aProductId, aProductName, aSupplierId, - 1, "n/a", 0.0, -1, -1, -1, false)
        {
            //partial constructoe
        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCatagoryId, string aQuantityPerUnit, double aUnitprice, int aUnitsInStock, int aUnitsOnOrder, int aReOrderLevel, bool aDiscontinued)
        { 
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CatagoryId = aCatagoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.Unitprice = aUnitprice;
            this.UnitsInStock = aUnitsInStock;
            this.UnitsOnOrder = aUnitsOnOrder;
            this.ReOrderLevel = aReOrderLevel;
            this.Discontinued = aDiscontinued;

        }



        // Creating a Tostring
        public override string ToString()
        {
            string message = " ";
            message = message + "productId: " + this.productId + "\n";
            message = message + "productName: " + this.productName + "\n";
            message = message + "supplierId: " + this.supplierId + "\n";
            message = message + "catagoryId: " + this.catagoryId + "\n";
            message = message + "quantityPerUnit: " + this.quantityPerUnit + "\n";
            message = message + "Unitprice: " + this.Unitprice + "\n";
            message = message + "unitsInStock: " + this.unitsInStock + "\n";
            message = message + "unitsOnOrder: " + this.unitsOnOrder + "\n";
            message = message + "reOrderLevel: " + this.reOrderLevel + "\n";
            message = message + "discontinued: " + this.discontinued + "\n";
            return message;

        }
    }
}
