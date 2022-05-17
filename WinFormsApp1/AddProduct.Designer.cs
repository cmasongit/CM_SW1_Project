namespace WinFormsApp1
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Producttitle = new System.Windows.Forms.Label();
            this.ADSAVE = new System.Windows.Forms.Button();
            this.ADCANCEL = new System.Windows.Forms.Button();
            this.adcandidparts = new System.Windows.Forms.DataGridView();
            this.adassociatedp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.adSearchbtn = new System.Windows.Forms.Button();
            this.adsearch = new System.Windows.Forms.TextBox();
            this.ADname = new System.Windows.Forms.Label();
            this.ADprice = new System.Windows.Forms.Label();
            this.ADinvent = new System.Windows.Forms.Label();
            this.ADmax = new System.Windows.Forms.Label();
            this.ADmin = new System.Windows.Forms.Label();
            this.Addpartbtn2 = new System.Windows.Forms.Button();
            this.deletepartbtn2 = new System.Windows.Forms.Button();
            this.ADIDTEXT = new System.Windows.Forms.TextBox();
            this.adnametb = new System.Windows.Forms.TextBox();
            this.adpricetb = new System.Windows.Forms.TextBox();
            this.adinventtb = new System.Windows.Forms.TextBox();
            this.admaxtb = new System.Windows.Forms.TextBox();
            this.admintb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adcandidparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adassociatedp)).BeginInit();
            this.SuspendLayout();
            // 
            // Producttitle
            // 
            this.Producttitle.AutoSize = true;
            this.Producttitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Producttitle.Location = new System.Drawing.Point(22, 41);
            this.Producttitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Producttitle.Name = "Producttitle";
            this.Producttitle.Size = new System.Drawing.Size(159, 32);
            this.Producttitle.TabIndex = 0;
            this.Producttitle.Text = "Add Product";
            // 
            // ADSAVE
            // 
            this.ADSAVE.Location = new System.Drawing.Point(533, 866);
            this.ADSAVE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ADSAVE.Name = "ADSAVE";
            this.ADSAVE.Size = new System.Drawing.Size(139, 49);
            this.ADSAVE.TabIndex = 1;
            this.ADSAVE.Text = "Save";
            this.ADSAVE.UseVisualStyleBackColor = true;
            this.ADSAVE.Click += new System.EventHandler(this.ADSAVE_Click);
            // 
            // ADCANCEL
            // 
            this.ADCANCEL.Location = new System.Drawing.Point(741, 866);
            this.ADCANCEL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ADCANCEL.Name = "ADCANCEL";
            this.ADCANCEL.Size = new System.Drawing.Size(139, 49);
            this.ADCANCEL.TabIndex = 2;
            this.ADCANCEL.Text = "Cancel";
            this.ADCANCEL.UseVisualStyleBackColor = true;
            this.ADCANCEL.Click += new System.EventHandler(this.ADCANCEL_Click);
            // 
            // adcandidparts
            // 
            this.adcandidparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adcandidparts.Location = new System.Drawing.Point(715, 183);
            this.adcandidparts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adcandidparts.Name = "adcandidparts";
            this.adcandidparts.ReadOnly = true;
            this.adcandidparts.RowHeadersWidth = 82;
            this.adcandidparts.RowTemplate.Height = 25;
            this.adcandidparts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adcandidparts.Size = new System.Drawing.Size(687, 241);
            this.adcandidparts.TabIndex = 3;
            // 
            // adassociatedp
            // 
            this.adassociatedp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adassociatedp.Location = new System.Drawing.Point(715, 529);
            this.adassociatedp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adassociatedp.Name = "adassociatedp";
            this.adassociatedp.RowHeadersWidth = 82;
            this.adassociatedp.RowTemplate.Height = 25;
            this.adassociatedp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adassociatedp.Size = new System.Drawing.Size(687, 241);
            this.adassociatedp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // adSearchbtn
            // 
            this.adSearchbtn.Location = new System.Drawing.Point(1263, 41);
            this.adSearchbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adSearchbtn.Name = "adSearchbtn";
            this.adSearchbtn.Size = new System.Drawing.Size(139, 49);
            this.adSearchbtn.TabIndex = 6;
            this.adSearchbtn.Text = "Search";
            this.adSearchbtn.UseVisualStyleBackColor = true;
            this.adSearchbtn.Click += new System.EventHandler(this.adSearchbtn_Click);
            // 
            // adsearch
            // 
            this.adsearch.Location = new System.Drawing.Point(774, 41);
            this.adsearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adsearch.Name = "adsearch";
            this.adsearch.Size = new System.Drawing.Size(455, 39);
            this.adsearch.TabIndex = 7;
            // 
            // ADname
            // 
            this.ADname.AutoSize = true;
            this.ADname.Location = new System.Drawing.Point(191, 331);
            this.ADname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ADname.Name = "ADname";
            this.ADname.Size = new System.Drawing.Size(78, 32);
            this.ADname.TabIndex = 8;
            this.ADname.Text = "Name";
            // 
            // ADprice
            // 
            this.ADprice.AutoSize = true;
            this.ADprice.Location = new System.Drawing.Point(191, 399);
            this.ADprice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ADprice.Name = "ADprice";
            this.ADprice.Size = new System.Drawing.Size(65, 32);
            this.ADprice.TabIndex = 9;
            this.ADprice.Text = "Price";
            // 
            // ADinvent
            // 
            this.ADinvent.AutoSize = true;
            this.ADinvent.Location = new System.Drawing.Point(158, 482);
            this.ADinvent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ADinvent.Name = "ADinvent";
            this.ADinvent.Size = new System.Drawing.Size(115, 32);
            this.ADinvent.TabIndex = 10;
            this.ADinvent.Text = "Inventory";
            // 
            // ADmax
            // 
            this.ADmax.AutoSize = true;
            this.ADmax.Location = new System.Drawing.Point(197, 576);
            this.ADmax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ADmax.Name = "ADmax";
            this.ADmax.Size = new System.Drawing.Size(59, 32);
            this.ADmax.TabIndex = 11;
            this.ADmax.Text = "Max";
            // 
            // ADmin
            // 
            this.ADmin.AutoSize = true;
            this.ADmin.Location = new System.Drawing.Point(409, 576);
            this.ADmin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ADmin.Name = "ADmin";
            this.ADmin.Size = new System.Drawing.Size(56, 32);
            this.ADmin.TabIndex = 12;
            this.ADmin.Text = "Min";
            // 
            // Addpartbtn2
            // 
            this.Addpartbtn2.Location = new System.Drawing.Point(1263, 437);
            this.Addpartbtn2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Addpartbtn2.Name = "Addpartbtn2";
            this.Addpartbtn2.Size = new System.Drawing.Size(139, 49);
            this.Addpartbtn2.TabIndex = 14;
            this.Addpartbtn2.Text = "Add";
            this.Addpartbtn2.UseVisualStyleBackColor = true;
            this.Addpartbtn2.Click += new System.EventHandler(this.Addpartbtn2_Click);
            // 
            // deletepartbtn2
            // 
            this.deletepartbtn2.Location = new System.Drawing.Point(1263, 783);
            this.deletepartbtn2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deletepartbtn2.Name = "deletepartbtn2";
            this.deletepartbtn2.Size = new System.Drawing.Size(139, 49);
            this.deletepartbtn2.TabIndex = 15;
            this.deletepartbtn2.Text = "Delete";
            this.deletepartbtn2.UseVisualStyleBackColor = true;
            this.deletepartbtn2.Click += new System.EventHandler(this.deletepartbtn2_Click);
            // 
            // ADIDTEXT
            // 
            this.ADIDTEXT.Location = new System.Drawing.Point(312, 247);
            this.ADIDTEXT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ADIDTEXT.Name = "ADIDTEXT";
            this.ADIDTEXT.ReadOnly = true;
            this.ADIDTEXT.Size = new System.Drawing.Size(223, 39);
            this.ADIDTEXT.TabIndex = 16;
            this.ADIDTEXT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // adnametb
            // 
            this.adnametb.Location = new System.Drawing.Point(312, 324);
            this.adnametb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adnametb.Name = "adnametb";
            this.adnametb.Size = new System.Drawing.Size(223, 39);
            this.adnametb.TabIndex = 17;
            // 
            // adpricetb
            // 
            this.adpricetb.Location = new System.Drawing.Point(312, 399);
            this.adpricetb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adpricetb.Name = "adpricetb";
            this.adpricetb.Size = new System.Drawing.Size(223, 39);
            this.adpricetb.TabIndex = 18;
            // 
            // adinventtb
            // 
            this.adinventtb.Location = new System.Drawing.Point(312, 476);
            this.adinventtb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adinventtb.Name = "adinventtb";
            this.adinventtb.Size = new System.Drawing.Size(223, 39);
            this.adinventtb.TabIndex = 19;
            // 
            // admaxtb
            // 
            this.admaxtb.Location = new System.Drawing.Point(312, 570);
            this.admaxtb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.admaxtb.Name = "admaxtb";
            this.admaxtb.Size = new System.Drawing.Size(63, 39);
            this.admaxtb.TabIndex = 20;
            // 
            // admintb
            // 
            this.admintb.Location = new System.Drawing.Point(472, 570);
            this.admintb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.admintb.Name = "admintb";
            this.admintb.Size = new System.Drawing.Size(63, 39);
            this.admintb.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 482);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Associated Parts";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.admintb);
            this.Controls.Add(this.admaxtb);
            this.Controls.Add(this.adinventtb);
            this.Controls.Add(this.adpricetb);
            this.Controls.Add(this.adnametb);
            this.Controls.Add(this.ADIDTEXT);
            this.Controls.Add(this.deletepartbtn2);
            this.Controls.Add(this.Addpartbtn2);
            this.Controls.Add(this.ADmin);
            this.Controls.Add(this.ADmax);
            this.Controls.Add(this.ADinvent);
            this.Controls.Add(this.ADprice);
            this.Controls.Add(this.ADname);
            this.Controls.Add(this.adsearch);
            this.Controls.Add(this.adSearchbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adassociatedp);
            this.Controls.Add(this.adcandidparts);
            this.Controls.Add(this.ADCANCEL);
            this.Controls.Add(this.ADSAVE);
            this.Controls.Add(this.Producttitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.adcandidparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adassociatedp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Producttitle;
        private Button ADSAVE;
        private Button ADCANCEL;
        private Label label2;
        private Label ADname;
        private Label ADprice;
        private Label ADinvent;
        private Label ADmax;
        private Label ADmin;
        private Button Addpartbtn2;
        private Button deletepartbtn2;
        private Label label8;
        private Label label9;
        public TextBox ADIDTEXT;
        public TextBox adnametb;
        public TextBox adpricetb;
        public TextBox adinventtb;
        public TextBox admaxtb;
        public TextBox admintb;
        public DataGridView adcandidparts;
        public DataGridView adassociatedp;
        public Button adSearchbtn;
        public TextBox adsearch;
    }
}