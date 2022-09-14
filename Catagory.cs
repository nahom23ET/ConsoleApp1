//Nahom Tefera
// 08/26/2026

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectnorthwindC

{
    public class Catagory
    {
        //class variables (instance)
        private int catagoryId = -1;
        private string catagoryName = "n/a";
        private string description = "n/a";


        // Getting and Setting
        public int CatagoryId
        {
            get { return this.catagoryId; }
            set
            {
                //must be greather than -1
                if (value > -1)
                { 
                    this.catagoryId = value;
                }
                else
                {
                    this.catagoryId = 0;
                }
            }
            
        }

        public string CatagoryName
        {
            get { return this.catagoryName; }
            set { this.catagoryName = value; }  
        }
        
        public string Description
        {
            get { return this.description; }
            set { this.description = value;  }
        }

        public override string ToString()
        {
            string message = " ";
            message = message + "catagory Id: " + this.catagoryId + "\n";
            message = message + "catagory name: " + this.catagoryName + "\n";
            message = message + "Description: " + this.description + "\n";
            return message;
        }
    }

   

    
}
