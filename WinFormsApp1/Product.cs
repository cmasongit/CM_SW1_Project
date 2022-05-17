using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Product : Part
    {
       public BindingList<Part> AssociatedParts = new BindingList<Part>();

        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public Product(int a, string b, int c, decimal d, int e, int f)
        {
            this.productID = a;
            this.name = b;
            this.inStock = c;
            this.price = d;
            this.max = e;
            this.min = f;
        }
        public Product(int a) { 
            this.productID = a;
        }

        public Product() { }


        public void setProductID(int a) { productID = a; }
        public int getProductID() { return productID; }

        public void setProductname(string a) { name = a; }
        public string getProductName() { return name; }

        public void setProductPrice(decimal a) { price = a; }
        public decimal getProductPrice() { return price; }

        public void setProductstock(int a) { inStock = a; }
        public int getProductstock() { return inStock; }

        public void setProductmin(int a) { min = a; }
        public int getProductmin() { return min; }

        public void setProductmax(int a) { max = a; }
        public int getProductmax() { return max; }



        void addAssociatedPart(Part a)
        {
          


            AssociatedParts.Add(a);
        }


        bool removeAssociatedPart(int a)
        {

            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (i == a)
                {
                    AssociatedParts[i] = null;

                }
                else break;
            }

            return false;
        }


        Part lookupAssociatedPart(int a) { return null; }

    }
    }
