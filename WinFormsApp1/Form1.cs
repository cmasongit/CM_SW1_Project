using System.ComponentModel;
using System.Data;

namespace WinFormsApp1
{
    public partial class guiform : Form
    {
        Inventory inventory = new Inventory();
        public DataTable dt = new DataTable("Parts");
        public DataTable prodtab = new DataTable("Products");

        public BindingSource bs = new BindingSource();
        public BindingSource bs2 = new BindingSource(); //For inventory Products
        public BindingSource partall = new BindingSource(); //For all parts
        public BindingSource partlist = new BindingSource();
        public BindingSource associatedpartslist = new BindingSource();

        private int currentrow;

        private BindingList<Product> Prodlist;

        public void SetProdlist(BindingList<Product> a)
        {
            Prodlist = a;
        }

        public BindingList<Product> getProdlist()
        {
            return Prodlist;
        }


        //ModProduct md = new ModProduct();

        private int id = 0;
        private string name;
        private int inventorystock;
        private decimal price;
        private int ppmax;
        private int ppmin;

        public void inHouseadder(int i, string a, int ins, decimal pri, int ppm, int ppmi, inhouse p)
        {


        }

        public void outsourceadder(int i, string a, int ins, decimal pri, int ppm, int ppmi, outsourced p)
        {


        }

        public int getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }

        public void setid(int a)
        {
            this.id = a;
        }

        public void setname(string a)
        {
            name = a;
        }






        public int GetCurrentRow()
        {
            return currentrow;
        }

        public void SetCurrentRow(int a)
        {
            currentrow = a;
        }











        public void Form1_Shown(object sender, System.EventArgs e)
        {
            Form2 form2 = new Form2(this);

            dt.Columns.Add("Part ID", typeof(int));



            dt.Columns["Part ID"].AutoIncrement = true;
            dt.Columns["Part ID"].AutoIncrementSeed = 0;
            dt.Columns["Part ID"].AutoIncrementStep = 1;


            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Inventory", typeof(int));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Max", typeof(int));
            dt.Columns.Add("Min", typeof(int));


            dt.AcceptChanges();
            //  bs.DataSource = dt;
            dataGridView1.DataSource = dt;

            prodtab.Columns.Add("Product ID", typeof(int));

            prodtab.Columns["Product ID"].AutoIncrement = true;
            prodtab.Columns["Product ID"].AutoIncrementSeed = 0;
            prodtab.Columns["Product ID"].AutoIncrementStep = 1;

            prodtab.Columns.Add("Name", typeof(string));
            prodtab.Columns.Add("Inventory", typeof(int));
            prodtab.Columns.Add("Price", typeof(decimal));
            prodtab.Columns.Add("Max", typeof(int));
            prodtab.Columns.Add("Min", typeof(int));


            prodtab.AcceptChanges();
            bs.DataSource = prodtab;
            bs2.DataSource = inventory.Products;
            dataGridView2.DataSource = bs;
            associatedpartslist.DataSource = inventory.AssociatedParts;
            partall.DataSource = dt;
            partlist.DataSource = inventory.AllParts;

            //  MessageBox.Show("This is partlist total  " +partlist.Count.ToString());


            SetProdlist(inventory.Products);

            exampledata();






        }
        public void exampledata()
        {
            //  DataTable dt = (DataTable)dataGridView1.DataSource;
            // DataTable prodtab = (DataTable)dataGridView2.DataSource;







            int idset = 0;
            int sendset = 0;
            foreach (Part a in partlist)
            {



                a.SetPartID(idset++);

                dt.Rows.Add(null, a.getPartName(), a.getPartinstock(), a.getPartPrice(), a.getPartmax(), a.getPartmin());
                dt.AcceptChanges();
            }



            foreach (Product b in bs2)
            {
                b.setProductID(sendset++);
                prodtab.Rows.Add(null, b.getProductName(), b.getProductstock(), b.getProductPrice(), b.getProductmax(), b.getProductmin());
                prodtab.AcceptChanges();
                //MessageBox.Show(b.getProductID().ToString());

                

            }




        }

      
        public void dtreload()
        {
            dt.Rows.Clear();
          //  int sendset = 0;
            foreach (Part a in partlist)
            {

               // a.SetPartID(idset++);

                dt.Rows.Add(a.getPartID(), a.getPartName(), a.getPartinstock(), a.getPartPrice(), a.getPartmax(), a.getPartmin());
                dt.AcceptChanges();
            }


        }

        public void productreload()
        {
            prodtab.Rows.Clear();


            foreach (Product b in bs2)
            {
               // b.setProductID(sendset++);
                prodtab.Rows.Add(b.getProductID(), b.getProductName(), b.getProductstock(), b.getProductPrice(), b.getProductmax(), b.getProductmin());
                prodtab.AcceptChanges();
                //MessageBox.Show(b.getProductID().ToString());



            }



        }




        public guiform()
        {
            inventory.examplelist();

            InitializeComponent();



            this.Load += new System.EventHandler(Form1_Shown);
            this.Load += new EventHandler(inventory.Productload);
           

        }

        public void tablerefresher(object sender, EventArgs e)
        {
            int a = inventory.Products.Count;
            setCrn(a);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.Show();

        }

        private void DeleteText_Click(object sender, EventArgs e)
        {

            CancelEventArgs a = new CancelEventArgs();
            DialogResult proddel = MessageBox.Show("Remove Product at Index: " + dataGridView2.CurrentCell.RowIndex + "?", "Confirm to Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (proddel == DialogResult.Yes)
            {
                if (inventory.Products[dataGridView2.CurrentCell.RowIndex].AssociatedParts.Count != 0)
                {
                    a.Cancel = true;
                    MessageBox.Show("Product cannot be removed");
                }
                else
                {
                    prodtab.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                    bs2.RemoveAt(dataGridView2.CurrentCell.RowIndex);
                }
            }
            else if (proddel == DialogResult.No)
            {
                a.Cancel = true;
            }









            // inventory.Products.RemoveAt(dataGridView2.CurrentCell.RowIndex);


        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }


        private int partcrn;
        public int GetPartCrn() { return partcrn; }
        public void SetPartCrn(int a) { partcrn = a; }

        //FORM 3 MOD PART
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            Product s = new Product();




            // int c2;
            // c2 = dataGridView1.CurrentCell.RowIndex;
            // setCrn(c2);

            // form3.Setf3ptid(dataGridView1.CurrentCell.RowIndex);

            // s = (Product)inventory.AllParts[dataGridView1.CurrentCell.RowIndex];

            
            int p = (int)dataGridView1.CurrentRow.Cells[0].Value;
            s = (Product)partlist[p];
           // MessageBox.Show(p.ToString());
           // SetPartCrn(dataGridView1.CurrentCell.RowIndex);
            form3.Setparid(s.getPartID());
            form3.Setparna(s.getPartName());
            form3.Setparst(s.getPartinstock());
            form3.Setpapri(s.getPartPrice());
            form3.Setparmax(s.getPartmax());
            form3.Setparmin(s.getPartmin());

            
            



            /*
            md.SetModid(int.Parse(dataGridView2.Rows[cmp].Cells[0].Value.ToString()));
            md.SetModname(dataGridView2.Rows[cmp].Cells[1].Value.ToString());
            md.SetModint(int.Parse(dataGridView2.Rows[cmp].Cells[2].Value.ToString()));
            md.SetModprice(decimal.Parse(dataGridView2.Rows[cmp].Cells[3].Value.ToString()));
            md.SetModmax(int.Parse(dataGridView2.Rows[cmp].Cells[4].Value.ToString()));
            md.SetModmin(int.Parse(dataGridView2.Rows[cmp].Cells[5].Value.ToString()));
            */











          form3.SetModpargcr(p); //Set current row index


            /*
            form3.f3idtb.Text = form3.Getparid().ToString();
            form3.f3name.Text = form3.Getparna();
            form3.f3invent.Text = form3.Getparst().ToString();
            form3.f3price.Text = form3.Getpapri().ToString();
            form3.f3max.Text = form3.Getparmax().ToString();
            form3.f3min.Text = form3.Getparmin().ToString();
            */




        }

        private void partdeletebtn_Click(object sender, EventArgs e)
        {
            ModProduct x = new ModProduct(this);
            DialogResult partdelete = MessageBox.Show("Are you sure about removing Part at index   " + dataGridView1.CurrentCell.RowIndex, "Ok ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            CancelEventArgs a = new CancelEventArgs();
            if (partdelete == DialogResult.OK)
            {
                dt.Rows.RemoveAt((dataGridView1.CurrentCell.RowIndex));

                dt.AcceptChanges();
                inventory.deletePart(inventory.AllParts[dataGridView1.CurrentCell.RowIndex]);
               // inventory.AllParts.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                partlist.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                MessageBox.Show("Part Deleted");

            }
            else if (partdelete == DialogResult.Cancel)
            {
                a.Cancel = true;
            }














            //  inventory.removePart();
            // inventory.AllParts.r
            // x.fillpart.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            //  partall.RemoveAt(dataGridView1.CurrentCell.RowIndex);

            //MessageBox.Show(inventory.AllParts.Count.ToString());
            //  partall.Remove(partall[dataGridView1.CurrentCell.RowIndex]);

            // string a = dataGridView1.CurrentCell.Value.ToString();
            //  counter.Text = a;





        }









        private int crn;


        public void setCrn(int a)
        {

        }
        public int getCrn() { return crn; }



        private int productrowindex;

        public int getProductrowindex() { return productrowindex; }
        public void setProductrowindex(int a) { productrowindex = a; }




        private void button7_Click(object sender, EventArgs e)
        {
            ModProduct md = new ModProduct(this);
            md.Show();

            string b = dataGridView2.CurrentCell.Value.ToString();

            string fixedce = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            int k = md.getMDInventorycount();

            string c = prodtab.Rows.Count.ToString();


            // setCrn(dataGridView2.CurrentCell.RowIndex);
            // setProductrowindex(dataGridView2.CurrentCell.RowIndex);

             setProductrowindex((int)dataGridView2.CurrentRow.Cells[0].Value);


            // prodtab.Rows[getProductrowindex()].;
            AddProduct a = new AddProduct(this);
            SetProdlist(a.addProducts);


            int cmp = getProductrowindex();
            SetCurrentRow(cmp);
            md.Setgcr(cmp);



            
            md.SetModid((int)dataGridView2.CurrentRow.Cells[0].Value);
            md.SetModname(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            md.SetModint(int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString()));
            md.SetModprice(decimal.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString()));
            md.SetModmax(int.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString()));
            md.SetModmin(int.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString()));
            

            




            // md.SetModid(inventory.lookupProduct(md.Getgcr()).getProductID());

            this.Click += new System.EventHandler(md.tableupdater);



            //  prodtab.Rows.RemoveAt(cmp);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void mainsearchbtn_Click(object sender, EventArgs e)
        {
            
            string temp2 = mainsearchtb.Text;

            //PART SEARCH CODE


            DataTable aptemp = new DataTable();

            /*
            aptemp.Columns.Add("Product ID", typeof(int));
            aptemp.Columns.Add("Name", typeof(string));
            aptemp.Columns.Add("Inventory", typeof(int));
            aptemp.Columns.Add("Price", typeof(decimal));
            aptemp.Columns.Add("Max", typeof(int));
            aptemp.Columns.Add("Min", typeof(int));
            aptemp.AcceptChanges();
            */
            aptemp = prodtab;
        aptemp.Rows.Clear();
            dataGridView2.DataSource = aptemp;


           
            int productidset = 0;
           

            foreach(Product q in bs2)
            {

               

                //MessageBox.Show(q.getProductID().ToString());

                if (q.getProductName().ToLower().Contains(temp2.ToLower()))
                {
                  // aptemp.Rows.Clear();
                   aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                   aptemp.AcceptChanges();

                 SetCurrentRow(q.getProductID());
                }
                else if (q.getProductID().ToString() == temp2)
                {

                  // aptemp.Rows.Clear();
                   aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                   aptemp.AcceptChanges();

                    SetCurrentRow(q.getProductID());

                }
                else if (q.getProductmax().ToString() == temp2)
                {

                  // aptemp.Rows.Clear();
                    aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                   aptemp.AcceptChanges();
                    SetCurrentRow(q.getProductID());

                }
                else if (q.getProductstock().ToString() == temp2)
                {

                 //  aptemp.Rows.Clear();
                    aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                  aptemp.AcceptChanges();
                    SetCurrentRow(q.getProductID());

                }
                else if (q.getProductmin().ToString() == temp2)
                {

                 //  aptemp.Rows.Clear(); //wg
                    aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                 aptemp.AcceptChanges();
                    SetCurrentRow(q.getProductID());

                }
                else if (q.getProductPrice().ToString() == temp2)
                {

                   // aptemp.Rows.Clear(); //wg
                    aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                    aptemp.AcceptChanges();
                    SetCurrentRow(q.getProductID());


                }
                
                else if (temp2 == "")
                {

                 //  aptemp.Rows.Clear();
                     aptemp.Rows.Add(q.getProductID(), q.getProductName(), q.getProductstock(), q.getProductPrice(), q.getProductmax(), q.getProductmin());
                   // aptemp = prodtab;


                }
                
               



            }



















        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void partsearchbtn_Click(object sender, EventArgs e)
        {
            string temp = mppstb.Text;
            Form3 f3 = new Form3(this);
            DataTable cptemp = new DataTable();


            cptemp.Columns.Add("Part ID", typeof(int));
            cptemp.Columns.Add("Name", typeof(string));
            cptemp.Columns.Add("Inventory", typeof(int));
            cptemp.Columns.Add("Price", typeof(decimal));
            cptemp.Columns.Add("Max", typeof(int));
            cptemp.Columns.Add("Min", typeof(int));
            cptemp.AcceptChanges();

            cptemp = dt;
            cptemp.Rows.Clear();
            dataGridView1.DataSource = cptemp;

           // MessageBox.Show(partlist.Count.ToString());


            foreach (Part b in partlist)
            {



                if (b.getPartName().ToLower().Contains(temp.ToLower()))
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
             
                    SetPartCrn(b.getPartID());
                 




                    //  SetCurrentRow()
                }
                else if (b.getPartID().ToString() == temp)
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    SetPartCrn(b.getPartID());
                }
                else if (b.getPartmax().ToString() == temp)
                {

                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    SetPartCrn(b.getPartID());
                }
                else if (b.getPartinstock().ToString() == temp)
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    SetPartCrn(b.getPartID());
                }
                else if (b.getPartmin().ToString() == temp)
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    SetPartCrn(b.getPartID());
                }
                else if (b.getPartPrice().ToString() == temp)
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                    cptemp.AcceptChanges();
                    SetPartCrn(b.getPartID());

                }
                else if (temp == "")
                {

                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                   // cptemp.AcceptChanges();


                }


                //dt = cptemp;



            }





        }
    }
}