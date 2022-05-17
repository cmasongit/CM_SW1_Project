using System.ComponentModel;

namespace WinFormsApp1
{
    //Form 2 is ADD PART
    public partial class Form2 : Form 
    {
        guiform fg1;
        public Form2(guiform nform1) 
        {
            
            InitializeComponent();
            this.fg1 = nform1;
            this.Shown += new EventHandler(partidset);

        }

        Inventory invent = new Inventory();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Machine ID";
            this.f2machcomtb.Location = new System.Drawing.Point(681, 217);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Company Name";
            this.f2machcomtb.Location = new System.Drawing.Point(728, 217);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
           
            Inventory inventory = new Inventory();
            Product product = new Product();
            CancelEventArgs a = new CancelEventArgs();
            inhouse inhouse = new inhouse();
            outsourced insourced = new outsourced();


            int machid = 0;
            int fetemp = 0;
            







            /*
            f2inventtb.Text = 
                f2max.Text=
                f2min.Text=
                f2pricetb.Text =
             //   f2idtb
            */

            int idnum = 0;
                int invnum = 0;
            decimal pricenum = 0;
            int maxnum = 0;
            int minnum = 0;
            int machnum = 0;

            if (int.TryParse(f2idtb.Text, out idnum))
            {

                if (int.TryParse(f2inventtb.Text, out invnum))
                {

                    if (decimal.TryParse(f2pricetb.Text, out pricenum))
                    {

                        if (int.TryParse(f2max.Text, out maxnum))
                        {

                            if (int.TryParse(f2min.Text, out minnum))
                            {


                               






                                int tempstock = int.Parse(f2inventtb.Text);
                                int tempmax = int.Parse(f2max.Text);
                                int tempmin = int.Parse(f2min.Text);





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









                                    if (radioButton1.Checked == true)
                                    {
                                        
                                       if(int.TryParse(f2machcomtb.Text, out machnum))

                                       {
                                            inhouse.setMachineID(int.Parse(f2machcomtb.Text));
                                            product.setInHouse(inhouse);

                                            product.SetPartID(int.Parse(f2idtb.Text));
                                            product.SetPartName(f2name.Text.ToString());
                                            product.SetPartinStock(int.Parse(f2inventtb.Text));
                                            product.SetPartPrice(decimal.Parse(f2pricetb.Text));
                                            product.SetPartMax(int.Parse(f2max.Text));
                                            product.SetPartMin(int.Parse(f2min.Text));

                                            // inventory.addPart(product);
                                            fg1.partlist.Add(product);

                                            fg1.dt.Rows.Add(null, product.getPartName(), product.getPartinstock(), product.getPartPrice(), product.getPartmax(), product.getPartmin());

                                            fg1.dt.AcceptChanges();
                                            MessageBox.Show("IN-HOUSE PART ADDED");
                                            this.Close();





                                        }else
                                        {
                                            MessageBox.Show("Machine ID entry has a Non-Numeric Value.");
                                        }


                                    }
                                    else if (radioButton2.Checked == true)
                                    {
                                        
                                       
                                        if (int.TryParse(f2machcomtb.Text.Trim(), out fetemp))
                                        {
                                            MessageBox.Show("Outsource entry has a Numeric Value.");
                                        }
                                        else
                                        {
                                            insourced.Setcompanyname(f2machcomtb.Text);
                                            product.SetOSpart(insourced);

                                            product.SetPartID(int.Parse(f2idtb.Text));
                                            product.SetPartName(f2name.Text.ToString());
                                            product.SetPartinStock(int.Parse(f2inventtb.Text));
                                            product.SetPartPrice(decimal.Parse(f2pricetb.Text));
                                            product.SetPartMax(int.Parse(f2max.Text));
                                            product.SetPartMin(int.Parse(f2min.Text));
                                            
                                            // inventory.addPart(product);
                                            fg1.partlist.Add(product);

                                            fg1.dt.Rows.Add(product.getPartID(), product.getPartName(), product.getPartinstock(), product.getPartPrice(), product.getPartmax(), product.getPartmin());

                                            fg1.dt.AcceptChanges();
                                            MessageBox.Show("OUTSOURCED PART ADDED");
                                            this.Close();


                                        }

                                    }
                                    /////
                                    ///
                                    



                                    







                                    
                                }
                                
                            }
                            else {
                                MessageBox.Show("Non-Numeric Value entered for Min");
                                a.Cancel = true;
                            
                            }
                        }
                        else {
                            MessageBox.Show("Non-Numeric Value entered for Max");
                            a.Cancel = true;
                        }
                    }
                    else {
                        MessageBox.Show("Non-Numeric Value entered for Price");
                        a.Cancel = true;
                    }
                }
                else {
                    MessageBox.Show("Non-Numeric Value entered for Inventory");
                    a.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Non-Numeric Value entered for ID");
                a.Cancel = true;
            }






        }


        public void partidset(object sender, EventArgs e)
        {
            int y = fg1.dt.Rows.Count;
            f2idtb.Text = y.ToString();
           // MessageBox.Show(y.ToString());
        }

      

    
    }
}
