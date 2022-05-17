using System.ComponentModel;
using System.Data;

namespace WinFormsApp1
{
    public partial class ModProduct : Form
    {
        private int gcr;
        public void Setgcr(int a) { gcr = a; }
        public int Getgcr() { return gcr; }

        Inventory inventory = new Inventory();
        Product product = new Product();
       

        public DataTable apart = new DataTable("Associated Parts");
        public DataTable fillpart = new DataTable("Candidate Parts");
    

        public void Mod_Productshown(object sender, System.EventArgs e)
        {
            

            apart.Columns.Add("Part ID", typeof(int));
            apart.Columns.Add("Name", typeof(string));
            apart.Columns.Add("Inventory", typeof(int));
            apart.Columns.Add("Price", typeof(decimal));
            apart.Columns.Add("Min", typeof(int));
            apart.Columns.Add("Max", typeof(int));
            associatedpartstb.DataSource = apart;
            apart.AcceptChanges();

            fillpart.Columns.Add("Part ID", typeof(int));
            fillpart.Columns.Add("Name", typeof(string));
            fillpart.Columns.Add("Inventory", typeof(int));
            fillpart.Columns.Add("Price", typeof(decimal));
            fillpart.Columns.Add("Max", typeof(int));
            fillpart.Columns.Add("Min", typeof(int));
           // candparts.DataSource = guiform1.dataGridView1.DataSource;
            candparts.DataSource = fillpart;
            fillpart.AcceptChanges();
           
           filltable();
           
           
            

        }



       





      
      
    

        
        


        guiform guiform1 = new guiform();
       
        public ModProduct(guiform nform1)
        {
            inventory.examplelist();
            InitializeComponent();
            this.guiform1 = nform1;
            AddProduct ad = new AddProduct(guiform1);
         
             this.Shown += new System.EventHandler(Mod_Productshown);
          this.Shown+= new System.EventHandler(tableupdater);
            this.Shown += new System.EventHandler(inventory.Productload);
            this.Shown += new System.EventHandler(ad.addproducttableupdater);

        }

        private void cancelbtn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int modid;
        private string modname;
        private int modint;
        private decimal modprice;
        private int modmax;   
        private int modmin;

        public void SetModid(int a) { modid = a; }
        public int GetModid() { return modid; }
        public decimal GetModprice() { return modprice; }
        public void SetModprice(decimal a) { modprice = a; }
        public int GetModmax() { return modmax; }
        public int GetModmin() { return modmin; }
        public void SetModmin(int a) { modmin = a; }
        public void SetModmax(int a) { modmax = a; }
        public string GetModname() { return modname; }
        public void SetModname(string a) { modname = a; }

        public void SetModint(int a) { modint = a; }
        public int GetModint() { return modint; }
        Product temp = new Product();

        public void modifyproduct(int a, string b, int c, decimal d, int e, int f)
        {

            //  inventory.Products.RemoveAt(Getgcr());



            //inventory.examplelist();



            temp = (Product)guiform1.bs2[Getgcr()];
          //  temp = inventory.Products[Getgcr()];
            
            inventory.SetInventoryID(a);
            inventory.SetInventoryName(b); 
            inventory.SetInventoryPrice(d);
            inventory.SetInventoryStock(c);
            inventory.SetInventoryMax(e);
            inventory.SetInventoryMin(f);
          
           // inventory.addProduct(temp);

            modpodid.Text = a.ToString();
            modpodname.Text = b.ToString();
            modpodinv.Text = c.ToString();
            modprodprice.Text = d.ToString();
            modpodmax.Text = e.ToString();
            modpodmin.Text = f.ToString();

            


            
            SetModid(a);
            SetModname(b);
            SetModint(c);
            SetModprice(d);
            SetModmax(e);
            SetModmin(f);
            
            
            Product modtemp = new Product();
            modtemp.setProductID(a);
            modtemp.setProductname(b);
            modtemp.setProductstock(c);
            modtemp.setProductPrice(d);
            modtemp.setProductmax(e);
            modtemp.setProductmin(f);

            temp.setProductID(a);
            temp.setProductname(b);
            temp.setProductstock(c);
            temp.setProductPrice(d);
            temp.setProductmax(e);
            temp.setProductmin(f);

            // inventory.Products.RemoveAt(Getgcr());
            // inventory.Products[Getgcr()] = temp;
            AddProduct z = new AddProduct(guiform1);
            // inventory.Products = z.addProducts;

           
            inventory.updateProduct(Getgcr(), temp);
            // guiform1.bs.List.Add(temp);
             //inventory.Products.Add(modtemp);
            guiform1.bs2.RemoveAt(Getgcr());
           guiform1.bs2.Insert(Getgcr(), temp);
            
          

          

            DataRow dr = guiform1.prodtab.NewRow();
            dr[0] = GetModid();
            dr[1] = GetModname();
            dr[2] = GetModint();
            dr[3] = GetModprice();
            dr[4] = GetModmax();
            dr[5] = GetModmin();

           
           
            guiform1.prodtab.Rows.RemoveAt(guiform1.dataGridView2.CurrentCell.RowIndex);
            
           guiform1.prodtab.Rows.InsertAt(dr, Getgcr());
            guiform1.dtreload();
            this.Click += new EventHandler(guiform1.Form1_Shown);



            candparts.Refresh();

        }

        public int getMDInventorycount()
        {
            return inventory.Products.Count;
        }







        public void savebtn2_Click(object sender, EventArgs e)
        {

            decimal pricnum = 0;
            int stocknum = 0;
            int maxnum = 0;
            int minnum = 0;
            int idnum = 0;
            CancelEventArgs a = new CancelEventArgs();
            if (int.TryParse(modpodid.Text, out idnum))
            {
                if (decimal.TryParse(modprodprice.Text, out pricnum))
                {


                    if (int.TryParse(modpodinv.Text, out stocknum))
                    {

                        if (int.TryParse(modpodmax.Text, out maxnum))
                        {

                            if (int.TryParse(modpodmin.Text, out minnum))
                            {











                                Inventory inventory = new Inventory();
                                guiform guiform = new guiform();
                                // Product temp = new Product();

                                // inventory.updateProduct(Getgcr(), Product a);


                                int tempstock = int.Parse(modpodinv.Text);
                                int tempmax = int.Parse(modpodmax.Text);
                                int tempmin = int.Parse(modpodmin.Text);




                                if (tempstock < tempmin || tempstock > tempmax)
                                {
                                    a.Cancel = true;
                                    MessageBox.Show("The entered stock is out of range");
                                }
                                else if (tempmax < tempmin)
                                {
                                    a.Cancel = true;
                                    MessageBox.Show("Max is less than Min");
                                }

                                else if (tempmax > tempmin || tempstock <= tempmax || tempstock >= tempmin)
                                {


                                    SetModid(int.Parse(modpodid.Text));
                                    SetModname(modpodname.Text);
                                    SetModint(int.Parse(modpodinv.Text));
                                    SetModprice(decimal.Parse(modprodprice.Text));
                                    SetModmax(int.Parse(modpodmax.Text));
                                    SetModmin(int.Parse(modpodmin.Text));




                                    modifyproduct(GetModid(), GetModname(), GetModint(), GetModprice(), GetModmax(), GetModmin());
                                
                                    
                                    
                                    MessageBox.Show("Product Successfully Modified");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Non-numeric Value entered for Min");
                                a.Cancel = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Non-Numeric Value entered for Max");
                            a.Cancel = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a numeric value for Inventory");
                        a.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("Non-Numeric Value entered for Price");
                    a.Cancel = true;
                }
            }else
            {
                MessageBox.Show("Non-Numeric Value entered for ID");
                a.Cancel = true;
            }
        


         

            //  this.Click += new System.EventHandler(tableupdater);
            //   this.Close();




        }

        public void tableupdater(object sender, EventArgs e)
        {


          //  guiform1.getProdlist(AddProduct.NewProd);
            

            modpodid.Text = GetModid().ToString();
            modpodname.Text = GetModname();
            modpodinv.Text = GetModint().ToString();
           modprodprice.Text = GetModprice().ToString();
           modpodmax.Text = GetModmax().ToString();
            modpodmin.Text = GetModmin().ToString();



            /*

            modpodid.Text = inventory.lookupProduct(Getgcr()).getProductID().ToString();
            modpodname.Text = inventory.lookupProduct(Getgcr()).getProductName().ToString();
            modpodinv.Text = inventory.lookupProduct(Getgcr()).getProductstock().ToString();
            modprodprice.Text = inventory.lookupProduct(Getgcr()).getProductPrice().ToString();
            modpodmax.Text = inventory.lookupProduct(Getgcr()).getProductmax().ToString();
            modpodmin.Text = inventory.lookupProduct(Getgcr()).getProductmin().ToString();

            */

        }










        private void candparts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Partlabel3_Click(object sender, EventArgs e)
        {

        }

        private void ModProduct_Load(object sender, EventArgs e)
        {

        }

        BindingSource partall2 = new BindingSource();
       
        public void filltable()
        {
            candparts.Refresh();

             Product a = (Product)guiform1.bs2[Getgcr()];
          //  Product a = inventory.Products[Getgcr()];
            partall2 = guiform1.partall;
           // partall2.ResetBindings(true);
            
            

            for (int i = 0; i < a.AssociatedParts.Count; i++)
                {
                    apart.Rows.Add(a.AssociatedParts[i].getPartID(), a.AssociatedParts[i].getPartName(), a.AssociatedParts[i].getPartinstock(), a.AssociatedParts[i].getPartPrice(), a.AssociatedParts[i].getPartmax(), a.AssociatedParts[i].getPartmin());
                    apart.AcceptChanges();

                }
            
            int idset = 0;
            
            foreach (Part b in guiform1.partlist)
            {
                //b.SetPartID(idset++);
                fillpart.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
               fillpart.AcceptChanges();
            }
            


            




        }

       

        private void Addpart2_Click(object sender, EventArgs e)
        {
           product = (Product)guiform1.bs2[Getgcr()];
            // Product temppart = (Product)guiform1.partlist[candparts.CurrentCell.RowIndex];
            Product temppart = (Product)guiform1.partlist[(int)candparts.CurrentRow.Cells[0].Value];
            // product.AssociatedParts.Add(inventory.AllParts[adcandidparts.CurrentCell.RowIndex]);
            product.AssociatedParts.Add(temppart);

            apart.Rows.Add(temppart.getPartID(), temppart.getPartName(), temppart.getPartinstock(), temppart.getPartPrice(), temppart.getPartmax(), temppart.getPartmin());
           apart.AcceptChanges();
         
            MessageBox.Show("Part added");


        }

        private void removebtn3_Click(object sender, EventArgs e)
        {


            product = (Product)guiform1.bs2[Getgcr()];
            product.AssociatedParts.RemoveAt(associatedpartstb.CurrentCell.RowIndex);
            apart.Rows.RemoveAt(associatedpartstb.CurrentCell.RowIndex);
            MessageBox.Show("Item Removed");
        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
            string temp = modsearchtb.Text;
           




            DataTable aptemp = new DataTable();
            DataTable cptemp = new DataTable();


            aptemp.Columns.Add("Part ID", typeof(int));
            /*
             
            aptemp.Columns["Part ID"].AutoIncrement = true;
            aptemp.Columns["Part ID"].AutoIncrementSeed = 0;
            aptemp.Columns["Part ID"].AutoIncrementStep = 1;
            */
            aptemp.Columns.Add("Name", typeof(string));
            aptemp.Columns.Add("Inventory", typeof(int));
            aptemp.Columns.Add("Price", typeof(decimal));
            aptemp.Columns.Add("Min", typeof(int));
            aptemp.Columns.Add("Max", typeof(int));
            aptemp.AcceptChanges();

            cptemp.Columns.Add("Part ID", typeof(int));
            /*
            cptemp.Columns["Part ID"].AutoIncrement = true;
            cptemp.Columns["Part ID"].AutoIncrementSeed = 0;
            cptemp.Columns["Part ID"].AutoIncrementStep = 1;
            */
            cptemp.Columns.Add("Name", typeof(string));
            cptemp.Columns.Add("Inventory", typeof(int));
            cptemp.Columns.Add("Price", typeof(decimal));
            cptemp.Columns.Add("Min", typeof(int));
            cptemp.Columns.Add("Max", typeof(int));
            cptemp.AcceptChanges();




           
           



            //Change into switch case using strings


            int emp = 0;

            //end of switch case

            foreach (Part b in guiform1.partlist)
            {
                b.SetPartID(emp);
                emp++;

                
                    if (b.getPartName().ToLower().Contains(temp.ToLower()))
                    {

                    
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                        cptemp.AcceptChanges();
                    }
                    else if (b.getPartID().ToString() == temp)
                    {

                   
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                        cptemp.AcceptChanges();

                    }
                    else if (b.getPartmax().ToString() == temp)
                    {
                   
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    }
                    else if (b.getPartinstock().ToString() == temp)
                    {

                   
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    }
                    else if (b.getPartmin().ToString() == temp)
                    {

                   
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    }
                    else if (b.getPartPrice().ToString() == temp)
                    {

                   
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();

                    }
                    else if (temp == "")
                    {
                  
                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();


                    }
                candparts.DataSource = cptemp;

                // Product temppart = (Product)guiform1.partlist[(int)candparts.CurrentRow.Cells[0].Value];

                // product.AssociatedParts.Add(inventory.AllParts[adcandidparts.CurrentCell.RowIndex]);
                // product.AssociatedParts.Add(temppart);

                Product temppart = (Product)guiform1.bs2[Getgcr()];
               
                    aptemp.Rows.Add(temppart.getPartID(), temppart.getPartName(), temppart.getPartinstock(), temppart.getPartPrice(), temppart.getPartmax(), temppart.getPartmin());
                    aptemp.AcceptChanges();
                //   MessageBox.Show("Part added");
                //aptemp = apart;

                // fillpart = cptemp;
                // apart = aptemp;

                // cptemp = fillpart;
                //  aptemp = apart;



                // Product a = (Product)guiform1.bs2[Getgcr()];


                // int i = (int)candparts.CurrentRow.Cells[0].Value;

                /*
                    aptemp.Rows.Add(a.AssociatedParts[i].getPartID(), a.AssociatedParts[i].getPartName(), a.AssociatedParts[i].getPartinstock(), a.AssociatedParts[i].getPartPrice(), a.AssociatedParts[i].getPartmax(), a.AssociatedParts[i].getPartmin());
                    aptemp.AcceptChanges();

                
                */















                //For Associated Parts

                /*
              Product k = (Product)guiform1.bs2[Getgcr()];





                            foreach (Product t in inventory.AssociatedParts)
                            {



                                if (t.getPartName().ToLower() == temp.ToLower())
                                {


                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();
                                }
                                else if (b.getPartID().ToString() == temp)
                                {


                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();

                                }
                                else if (b.getPartmax().ToString() == temp)
                                {

                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();
                                }
                                else if (b.getPartinstock().ToString() == temp)
                                {


                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();
                                }
                                else if (b.getPartmin().ToString() == temp)
                                {


                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();
                                }
                                else if (b.getPartPrice().ToString() == temp)
                                {

                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();

                                }
                                else if (temp == null)
                                {

                                    aptemp.Rows.Add(t.getPartID(), t.getPartName(), t.getPartinstock(), t.getPartPrice(), t.getPartmax(), t.getPartmin());
                                    fillpart.AcceptChanges();


                                }

                            }
                            */

            }


                


             
                







        }
    }
}
