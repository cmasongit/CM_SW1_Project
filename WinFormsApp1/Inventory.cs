using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Inventory : Product
    {
       public BindingList<Product> Products = new BindingList<Product>();
       public BindingList<Part> AllParts = new BindingList<Part>();
        public BindingSource assoicatedpart  = new BindingSource();
        public BindingSource cpart = new BindingSource();
        private int inventoryid;
        private string inventoryname;
        private int inventorystock;
        private decimal inventoryprice;
        private int inventorymin;
        private int inventorymax;

        public event PropertyChangedEventHandler PropertyChanged;

        DataGridView productviewer = new DataGridView();
        public void Productload(object sender, EventArgs e)
        {
            initializeProducts();
           
            Products.AddingNew += new AddingNewEventHandler(Product_AddingNew);
            Products.ListChanged += new ListChangedEventHandler(Product_listchanged);
        }


        

        void initializeProducts()
        {
            Products.AllowNew = true;
            Products.AllowRemove = true;

            Products.RaiseListChangedEvents = true;

            Products.AllowEdit = true;

        }

        void Product_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Product();
        }



        void Product_listchanged(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());
        }












        public void SetInventoryID(int a) { inventoryid = a; }
        public int GetInventoryID() { return inventoryid; }
        public string GetInventoryName() { return inventoryname; }
        public int GetInventoryStock() { return inventorystock; }
        public decimal GetInventoryPrice() { return inventoryprice; }
        public int GetInventoryMin() { return inventorymin; }
        public int GetInventoryMax() { return inventorymax; }
        
        public void SetInventoryMin(int a) {inventorymin = a; }
        public void SetInventoryName(string a) { inventoryname = a; } 
        public void SetInventoryStock(int a) { inventorystock = a; }

        public void SetInventoryPrice(decimal a) { inventoryprice = a; } 
        public void SetInventoryMax(int a) { inventorymax = a; }




     
        public void addProduct(Product a)
        {

            


           Products.Add(a);
            OnPropertyChanged();
          
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }




       public bool removeProduct(int a)
        {
            /*
            for (int i = 0; i < Products.Count; i++)
            {
                if (i == a)
                {
                    Products[i] = null;
                }
            }
            */

            Products.RemoveAt(a);




            return false;
        }

        Form2 f2;
        guiform g;

       public Product lookupProduct(int a) { 
            
            
            

            return Products[a];


        }

       


       public void updateProduct(int a, Product b) {

          
          //  MessageBox.Show(fg1.bs2.Count.ToString());
            
            //  b  = lookupProduct(a);
          // b = Products[a];//newly 12 22 21 8 38pm
          b.setProductID(GetInventoryID());
            b.setProductname(GetInventoryName());
        b.setProductstock(GetInventoryStock());
            b.setProductPrice(GetInventoryPrice());
            b.setProductmax(GetInventoryMax());
            b.setProductmin(GetInventoryMin());
            
            
          //  Products.Insert(a, b);
        
        
        
        }

       public void addPart(Part a)
        {

            
                

            AllParts.Add(a);
            

        }
        //NEWLY UPDATED DELETE PART 
       public bool deletePart(Part a)
        {
            bool ft;
            
         foreach(Part b in AllParts)
            {
                if(b == a)
                {
                    AllParts.Remove(b);
                    return true;
                }
                
            }
            
           
          
            return false;


        }

       public Part lookupPart(int a) { return AllParts[a]; }
       public void UpdatePart(int a, Part b) {

           guiform g = new guiform();
          
           
          //  g.partlist.Insert(a, b);
           // AllParts[a] = b;
        
        
        
        }

        
        public void examplelist()
        {   inhouse ih = new inhouse();
            outsourced osco = new outsourced();
            Product prodpart = new Product();
            Product tempProduct = new Product();
            Product product = new Product();
           // cpart.DataSource = AllParts;

           // prodpart.SetPartID(2);
            prodpart.SetPartName("Wheel");
            prodpart.SetPartinStock(15);
            prodpart.SetPartPrice((decimal)12.11);
            prodpart.SetPartMax(25);
            prodpart.SetPartMin(5);

         //   ih.setMachineID(12345);

            osco.Setcompanyname("Wheeler & Co");
         // prodpart.setInHouse(ih);
            prodpart.SetOSpart(osco);
            AllParts.Add(prodpart);
          //  cpart.Add(prodpart);
            




            tempProduct.setProductID(0);
            tempProduct.setProductname("Red Bicycle");
            tempProduct.setProductstock(15);
            tempProduct.setProductmax(25);
            tempProduct.setProductmin(1);
            tempProduct.setProductPrice((decimal)11.44);
            Products.Add(tempProduct);

            product.setProductID(1);
           product.setProductname("Blue Bicycle");
            product.setProductstock(25);
           product.setProductmax(20);
            product.setProductmin(5);
          product.setProductPrice((decimal)15.44);
            Products.Add(product);

            
           Product product2 = new Product();
            inhouse ih2 = new inhouse();
            ih2.setMachineID(88948);
            product2.SetPartinStock(12);
            product2.SetPartPrice((decimal)16.99);
            product2.SetPartName("Pedal");
            product2.SetPartMax(10);
            product2.SetPartMin(2);
            product2.setInHouse(ih2);
            product.AssociatedParts.Add(product2);
            AllParts.Add(product2);

            
            Product product1 = new Product();
           // product1.SetPartID(4);
           outsourced k = new outsourced();
           k.Setcompanyname("Seat Company");
            product1.SetPartinStock(17);
            product1.SetPartPrice((decimal)19.99);
            product1.SetPartName("Seat");
            product1.SetPartMax(10);
            product1.SetPartMin(7);
            product1.SetOSpart(k);
            product.AssociatedParts.Add(product1);
            AllParts.Add(product1);
            

        
        }








    
       

    }
}
