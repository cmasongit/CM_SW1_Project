using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddProduct : Form
    {
        guiform fg1 = new guiform();

        Inventory inventory = new Inventory();
        Product product = new Product();




        public AddProduct(guiform f)
        {


            this.fg1 = f;
            InitializeComponent();
            inventory.examplelist();
            this.Shown += new EventHandler(Ad_Productshown);
            this.Shown += new EventHandler(productidset);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Product p = new Product();
        public BindingList<Product> addProducts = new BindingList<Product>();



        private void ADSAVE_Click(object sender, EventArgs e)
        {


            CancelEventArgs a = new CancelEventArgs();


            int idnum = 0;
            if (int.TryParse(ADIDTEXT.Text, out idnum))
            {





                decimal prnum = 0;
                if (decimal.TryParse(adpricetb.Text.Trim(), out prnum))
                {
                    Decimal tempprict = decimal.Parse(adpricetb.Text);

                    int invnum = 0;
                    int maxnum = 0;
                    int minnum = 0;
                    if (int.TryParse(adinventtb.Text.Trim(), out invnum) && int.TryParse(admaxtb.Text.Trim(), out maxnum) && int.TryParse(admintb.Text.Trim(), out minnum))
                    {

                        int tempstock = int.Parse(adinventtb.Text);
                        int tempmax = int.Parse(admaxtb.Text);
                        int tempmin = int.Parse(admintb.Text);

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



                            product.setProductID(int.Parse(ADIDTEXT.Text));
                            product.setProductname(adnametb.Text);
                            product.setProductstock(int.Parse(adinventtb.Text));
                            product.setProductPrice(decimal.Parse(adpricetb.Text));
                            product.setProductmax(int.Parse(admaxtb.Text));
                            product.setProductmin(int.Parse(admintb.Text));

                            fg1.bs2.Add(product);
                           inventory.Products.Add(product);

                            DataRow dr = fg1.prodtab.NewRow();
                            dr[0] = product.getProductID();
                            dr[1] = product.getProductName();
                            dr[2] = product.getProductstock();
                            dr[3] = product.getProductPrice();
                            dr[4] = product.getProductmax();
                            dr[5] = product.getProductmin();

                            fg1.prodtab.Rows.Add(dr);
                            fg1.prodtab.AcceptChanges();


                            this.Click += new EventHandler(fg1.Form1_Shown);
                            this.Click += new EventHandler(addproducttableupdater);


                            this.Close();
                        }

                    }
                    else
                    {
                        //Inventory
                        MessageBox.Show("Non-Numeric value was entered! Please check Inventory, Min Or Max for Non-Numeric Values.");
                        a.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("Value entered for Price is Non-Numeric. Please Try Again");
                    a.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Value entered for ID is Non-Numeric. Please Try Again");
                a.Cancel = true;

            }



        }

        public void addproducttableupdater(object sender, EventArgs e)
        {

            fg1.SetProdlist(inventory.Products);



        }

        public void productidset(object sender, EventArgs e)
        {
            int y = fg1.prodtab.Rows.Count;
           ADIDTEXT.Text = y.ToString();
            // MessageBox.Show(y.ToString());
        }







        public DataTable associpart = new DataTable("Associated Parts");
        public DataTable candpart = new DataTable("Candidate Parts");


        

        public void filltables()
        {

            ModProduct md = new ModProduct(fg1);

            Product a = (Product)fg1.bs2[md.Getgcr()];

            //


            for (int i = 0; i < product.AssociatedParts.Count; i++)
            {
                associpart.Rows.Add(product.AssociatedParts[i].getPartID(), product.AssociatedParts[i].getPartName(), product.AssociatedParts[i].getPartinstock(), product.AssociatedParts[i].getPartPrice(), product.AssociatedParts[i].getPartmax(), product.AssociatedParts[i].getPartmin());
                associpart.AcceptChanges();

            }

            int idset = 0;
            foreach (Part b in fg1.partlist)
            {
              b.SetPartID(idset++);
                candpart.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                candpart.AcceptChanges();
            }



        }
        public void Ad_Productshown(object sender, System.EventArgs e)
        {


            associpart.Columns.Add("Part ID", typeof(int));
            associpart.Columns.Add("Name", typeof(string));
            associpart.Columns.Add("Inventory", typeof(int));
            associpart.Columns.Add("Price", typeof(decimal));
            associpart.Columns.Add("Min", typeof(int));
            associpart.Columns.Add("Max", typeof(int));
            adassociatedp.DataSource = associpart;
            associpart.AcceptChanges();

            candpart.Columns.Add("Part ID", typeof(int));
            candpart.Columns.Add("Name", typeof(string));
            candpart.Columns.Add("Inventory", typeof(int));
            candpart.Columns.Add("Price", typeof(decimal));
            candpart.Columns.Add("Max", typeof(int));
            candpart.Columns.Add("Min", typeof(int));
            //
            //adcandidparts.DataSource = fg1.dataGridView1.DataSource;
            adcandidparts.DataSource = candpart;
            candpart.AcceptChanges();

            filltables();



        }

        private void Addpartbtn2_Click(object sender, EventArgs e)
        {


            // fg1.bs2[adcandidparts.CurrentCell.RowIndex];
            // Product product = new Product();
            //  Product temp = (Product)fg1.partlist[adcandidparts.CurrentCell.RowIndex];
            Product temp = (Product)fg1.partlist[(int)adcandidparts.CurrentRow.Cells[0].Value];
            // Product temp = (Product)inventory.AllParts[adcandidparts.CurrentCell.RowIndex];

            // product.AssociatedParts.Add(inventory.AllParts[adcandidparts.CurrentCell.RowIndex]);
            product.AssociatedParts.Add(temp);

            associpart.Rows.Add(temp.getPartID(), temp.getPartName(), temp.getPartinstock(), temp.getPartPrice(), temp.getPartmax(), temp.getPartmin());
            associpart.AcceptChanges();





        }

        private void deletepartbtn2_Click(object sender, EventArgs e)
        {
            //  product.AssociatedParts.RemoveAt(adassociatedp.CurrentCell.RowIndex);


            product.AssociatedParts.RemoveAt(adassociatedp.CurrentCell.RowIndex);
            associpart.Rows.RemoveAt(adassociatedp.CurrentCell.RowIndex);






        }

        private void adSearchbtn_Click(object sender, EventArgs e)
        {

            string temp = adsearch.Text;

            DataTable aptemp = new DataTable();
            DataTable cptemp = new DataTable();


            aptemp.Columns.Add("Part ID", typeof(int));
            aptemp.Columns.Add("Name", typeof(string));
            aptemp.Columns.Add("Inventory", typeof(int));
            aptemp.Columns.Add("Price", typeof(decimal));
            aptemp.Columns.Add("Min", typeof(int));
            aptemp.Columns.Add("Max", typeof(int));
            aptemp.AcceptChanges();

            cptemp.Columns.Add("Part ID", typeof(int));
            cptemp.Columns.Add("Name", typeof(string));
            cptemp.Columns.Add("Inventory", typeof(int));
            cptemp.Columns.Add("Price", typeof(decimal));
            cptemp.Columns.Add("Min", typeof(int));
            cptemp.Columns.Add("Max", typeof(int));
            cptemp.AcceptChanges();




           // adassociatedp.DataSource = aptemp;
          





            foreach (Part b in fg1.partlist)
            {


                if (b.getPartName().ToLower().Contains(temp.ToLower()))
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                  
                }
                else if (b.getPartID().ToString() == temp)
                {


                    cptemp.Rows.Add(b.getPartID(), b.getPartName(), b.getPartinstock(), b.getPartPrice(), b.getPartmax(), b.getPartmin());
                   

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
                adcandidparts.DataSource = cptemp;

                Product temppart = (Product)fg1.bs2[(int)fg1.dataGridView2.CurrentRow.Cells[0].Value];

                aptemp.Rows.Add(temppart.getPartID(), temppart.getPartName(), temppart.getPartinstock(), temppart.getPartPrice(), temppart.getPartmax(), temppart.getPartmin());
                aptemp.AcceptChanges();


                // candpart = cptemp; //canidates parts
                //  associpart = aptemp;

            }
        }
    }
}
