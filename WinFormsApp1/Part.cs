using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        private inhouse h;
        private outsourced s;
      
      public void setInHouse(inhouse h)
        {
            this.h = h;
        }
        public void SetOSpart(outsourced s) { this.s = s; }

        public inhouse GetInhouse()
        {
            return h;
        }
        public outsourced GetOutsourced() { return s; }


        public void SetPartID(int a) { partID = a; }
        public void SetPartName(string a) { name = a; }
        public void SetPartPrice(decimal a) { price = a; }
        public void SetPartinStock(int a) { inStock = a; }
        public void SetPartMin(int a) { min = a; }
        public void SetPartMax(int a) { max = a; }




        public int getPartID() { return partID; }
        public string getPartName() { return name; }
        public decimal getPartPrice() { return price; }
        public int getPartinstock() { return inStock; }
        public int getPartmin() { return min; }
        public int getPartmax() { return max; }



    }

    public class outsourced:Part
    {
        private string outsource;

        public string getcompanyname() {
            
        return outsource;
        }

        public void Setcompanyname(string outsource) { 
        this.outsource = outsource;
           
        }

    }
}
