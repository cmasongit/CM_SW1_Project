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
    public partial class Form3 : Form

      
    {
        guiform fg1 = new guiform();


        public Form3(guiform a)
        {
            fg1 = a;
            InitializeComponent();
           this.Shown += new EventHandler(textdisplayed);
         
        }

        private void modtitle_Click(object sender, EventArgs e)
        {

        }

        private void f3idtb_TextChanged(object sender, EventArgs e)
        {

        }


        private int modpartgcr;
        public int GetModpargcr() { return modpartgcr; }
        public void SetModpargcr(int a) { modpartgcr = a; }

        public void modpart(int a, string b, int c, decimal d, int e, int f)
        {
            Product temp = new Product();
            Inventory inventory = new Inventory();
           // Form3 f3 = new Form3(fg1);
          //  temp = (Product)inventory.AllParts[GetModpargcr()];
           
           

            temp.SetPartID(a);
            temp.SetPartName(b);
            temp.SetPartinStock(c);
            temp.SetPartPrice(d);
            temp.SetPartMax(e);
            temp.SetPartMin(f);
            temp.setInHouse(inhouse);
            temp.SetOSpart(insourced);


            f3idtb.Text = a.ToString();
            f3name.Text = b;
            f3invent.Text = c.ToString();
            f3price.Text = d.ToString();
            f3max.Text = e.ToString();
            f3min.Text = f.ToString();


            fg1.partlist.RemoveAt(GetModpargcr());
           fg1.partlist.Insert(GetModpargcr(),temp);

           // inventory.AllParts.RemoveAt(GetModpargcr());
         //   inventory.AllParts.Insert(GetModpargcr(),temp);

            
           // MessageBox.Show(temp.getPartName());
            inventory.UpdatePart(GetModpargcr(),temp);





           // MessageBox.Show(b);
            //CREATE A NEW ROW
            DataRow dr = fg1.dt.NewRow();
            dr[0] = a.ToString();
            dr[1] = b;
            dr[2] = c.ToString();
            dr[3] = d.ToString();
            dr[4] = e.ToString();
            dr[5] = f.ToString();

            // fg1.dt.Rows.RemoveAt(GetModpargcr());
            fg1.dt.Rows.RemoveAt(fg1.dataGridView1.CurrentCell.RowIndex);

            fg1.dt.Rows.InsertAt(dr, GetModpargcr());
           //fg1.dtreload();
            
          //  fg1.exampledata();

          //  fg1.dtreload();
           
          
        
        }

        public void maxminchecker(object sender, CancelEventArgs e)
        {
           
        }



        private void f3submitbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(fg1);
            guiform fg = new guiform();

            CancelEventArgs a = new CancelEventArgs();

            //try parse here

            int fetemp = 0;
            int machid = 0;

           

            int idnum = 0;
            int invenum = 0;
            decimal pricenum = 0;
            int maxnum = 0;
            int minnum = 0;
            int machnum2 = 0;



            if(int.TryParse(f3idtb.Text,out idnum)){
               if( int.TryParse(f3invent.Text, out invenum)){
                    if(decimal.TryParse(f3price.Text, out pricenum)){
                       if( int.TryParse(f3max.Text, out maxnum)){
                           if (int.TryParse(f3min.Text, out minnum)){



                                int tempstock = int.Parse(f3invent.Text);
                                int tempmax = int.Parse(f3max.Text);
                                int tempmin = int.Parse(f3min.Text);

                                if (tempstock < tempmin||  tempstock > tempmax)
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
                                    //MIDDLE HERE

                                    if (modoutsourced.Checked == true)
                                    {
                                        if (int.TryParse(f3machcn.Text.Trim(), out fetemp))
                                        {
                                            MessageBox.Show("Outsource entry is a Numeric Value. Please Enter Non-Numeric Values ");
                                        }
                                        else
                                        {
                                            insourced.Setcompanyname(f3machcn.Text);
                                            Setparid(int.Parse(f3idtb.Text));
                                            Setparna(f3name.Text);
                                            Setparst(int.Parse(f3invent.Text));
                                            Setpapri(decimal.Parse(f3price.Text));
                                            Setparmax(int.Parse(f3max.Text));
                                            Setparmin(int.Parse(f3min.Text));
                                            modoutsourced.Checked = true;


                                            modpart(Getparid(), Getparna(), Getparst(), Getpapri(), Getparmax(), Getparmin());
                                           
                                            MessageBox.Show("OUTSOURCED PART SUCCESSFULLY MODIFIED");
                                           
                                            this.Close();
                                        }
                                    }

                                    else if (modinh.Checked == true)
                                    {

                                       if(int.TryParse(f3machcn.Text, out machnum2)){
                                            inhouse.setMachineID(int.Parse(f3machcn.Text));
                                            Setparid(int.Parse(f3idtb.Text));
                                            Setparna(f3name.Text);
                                            Setparst(int.Parse(f3invent.Text));
                                            Setpapri(decimal.Parse(f3price.Text));
                                            Setparmax(int.Parse(f3max.Text));
                                            Setparmin(int.Parse(f3min.Text));


                                            modpart(Getparid(), Getparna(), Getparst(), Getpapri(), Getparmax(), Getparmin());
                                            MessageBox.Show("INHOUSE PART SUCCESSFULLY MODIFIED");
                                           
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("An Non-Numeric Value was entered for MACHINE-ID");
                                            a.Cancel = true;
                                        }

                                    }












                                }
                            }
                            else
                            {
                                MessageBox.Show("Non-Numeric Value entered for MIN");
                                a.Cancel = true;
                            }
                        }
                        else {
                            MessageBox.Show("Non-Numeric Value entered for MAX");
                            a.Cancel = true;
                        }
                    }
                    else {
                        MessageBox.Show("Non-Numeric Value entered for PRICE");
                        a.Cancel = true;
                    }
                }
                else {
                    MessageBox.Show("Non-Numeric Value entered for INVENTORY");
                    a.Cancel = true;
                }
            }
            else {
                MessageBox.Show("Non-Numeric Value entered for ID");
                a.Cancel = true;
            }


        }

        private void f3cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f3machcn_TextChanged(object sender, EventArgs e)
        {

        }

        private int parid;
        private string parna;
        private int parst;
        private decimal papri;
        private int parmax;
        private int parmin;

        public int Getparid() { return parid; }
        public string Getparna() { return parna; }
        public int Getparst() { return parst; }
        public decimal Getpapri() { return papri; } 
        public int Getparmax() { return parmax; }
        public int Getparmin() { return parmin; }
        public void Setparid(int parid) { this.parid = parid; }

        public void Setparna(string a) { this.parna = a; }
        public void Setparst(int a ) { this.parst = a; }
        public void Setpapri(decimal a) { this.papri = a; }
        public void Setparmax(int a ) { this.parmax = a; }
        public void Setparmin(int a ) { this.parmin = a; }

        private int f3ptid;
        public int Getf3ptid() { return f3ptid; }
        public void Setf3ptid(int a) { f3ptid = a; }




        public void textdisplayed(object sender, EventArgs e)
        {

            Inventory inventory = new Inventory();
            CancelEventArgs a = new CancelEventArgs();
            Product x = new Product();


            //fg1.setCrn(fg1.dataGridView1.CurrentCell.RowIndex);
          //  x = (Product)fg1.partlist[fg1.GetPartCrn()];
          //  x = (Product)inventory.AllParts[Getf3ptid()];
         // x = (Product)fg1.partlist[Getf3ptid()];

          //  MessageBox.Show((string)fg1.dataGridView1.CurrentRow.Cells[0].Value);
        x = (Product)fg1.partlist[GetModpargcr()];
            f3idtb.Text = Getparid().ToString();
            f3name.Text = Getparna();
            f3invent.Text = Getparst().ToString();
            f3price.Text = Getpapri().ToString();
            f3max.Text = Getparmax().ToString();
            f3min.Text = Getparmin().ToString();

            

            if ((x.GetInhouse() != null) == true && (x.GetInhouse().getMachineID() != 0) == true)
            {
                modinh.Checked = true;
               f3machcn.Text = x.GetInhouse().getMachineID().ToString();
                outsourced outsourced = new outsourced();
                x.SetOSpart(outsourced);
                
            }
            else if(x.GetOutsourced() != null )
            {
                modoutsourced.Checked = true;

               f3machcn.Text = x.GetOutsourced().getcompanyname();
               inhouse inhouse = x.GetInhouse();
                x.setInHouse(inhouse);
               


            }
            







        }

        private void f3max_TextChanged(object sender, EventArgs e)
        {

        }

        private void f3min_TextChanged(object sender, EventArgs e)
        {

        }

        inhouse inhouse = new inhouse();
        outsourced insourced = new outsourced();


        private void modoutsourced_CheckedChanged(object sender, EventArgs e)
        {
            Inventory c = new Inventory();
            Product x = new Product();
            x = (Product)fg1.partlist[(int)fg1.dataGridView1.CurrentRow.Cells[0].Value];

            modmidcn.Text = "Company Name";
            this.f3machcn.Location = new System.Drawing.Point(302, 550);

            if (x.GetOutsourced() != null)
            {
                f3machcn.Text = x.GetOutsourced().getcompanyname();

            }
            else
            {
                f3machcn.Text = String.Empty;
            }



        }

        private void modinh_CheckedChanged(object sender, EventArgs e)
        {
            CancelEventArgs a = new CancelEventArgs();
            Inventory c = new Inventory();
            Product x = new Product();
            x = (Product)fg1.partlist[fg1.dataGridView1.CurrentCell.RowIndex];

            modmidcn.Text = "Machine ID";
            this.f3machcn.Location = new System.Drawing.Point(251, 550);

            if (x.GetInhouse() != null)
            {
                f3machcn.Text = x.GetInhouse().getMachineID().ToString();
            }
            else
            {
                f3machcn.Text = String.Empty;
            }
            



        }
    }
}
