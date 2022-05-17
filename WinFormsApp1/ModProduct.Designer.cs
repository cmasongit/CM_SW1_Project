namespace WinFormsApp1
{
    partial class ModProduct
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
            this.candparts = new System.Windows.Forms.DataGridView();
            this.associatedpartstb = new System.Windows.Forms.DataGridView();
            this.ModifyPod2 = new System.Windows.Forms.Label();
            this.Partlabel3 = new System.Windows.Forms.Label();
            this.AssociaPart2 = new System.Windows.Forms.Label();
            this.modpodid = new System.Windows.Forms.TextBox();
            this.modpodname = new System.Windows.Forms.TextBox();
            this.modpodinv = new System.Windows.Forms.TextBox();
            this.modprodprice = new System.Windows.Forms.TextBox();
            this.modpodmax = new System.Windows.Forms.TextBox();
            this.modpodmin = new System.Windows.Forms.TextBox();
            this.ProdID2 = new System.Windows.Forms.Label();
            this.ProdNm2 = new System.Windows.Forms.Label();
            this.ProdInvent2 = new System.Windows.Forms.Label();
            this.ProdPrice2 = new System.Windows.Forms.Label();
            this.Prodmax2 = new System.Windows.Forms.Label();
            this.Prodmin2 = new System.Windows.Forms.Label();
            this.modsearchtb = new System.Windows.Forms.TextBox();
            this.searchbtn2 = new System.Windows.Forms.Button();
            this.Addpart2 = new System.Windows.Forms.Button();
            this.removebtn3 = new System.Windows.Forms.Button();
            this.savebtn2 = new System.Windows.Forms.Button();
            this.cancelbtn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candparts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedpartstb)).BeginInit();
            this.SuspendLayout();
            // 
            // candparts
            // 
            this.candparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candparts.Location = new System.Drawing.Point(615, 160);
            this.candparts.Margin = new System.Windows.Forms.Padding(6);
            this.candparts.Name = "candparts";
            this.candparts.ReadOnly = true;
            this.candparts.RowHeadersWidth = 82;
            this.candparts.RowTemplate.Height = 25;
            this.candparts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candparts.Size = new System.Drawing.Size(817, 320);
            this.candparts.TabIndex = 0;
            this.candparts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candparts_CellContentClick);
            // 
            // associatedpartstb
            // 
            this.associatedpartstb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedpartstb.Location = new System.Drawing.Point(615, 614);
            this.associatedpartstb.Margin = new System.Windows.Forms.Padding(6);
            this.associatedpartstb.Name = "associatedpartstb";
            this.associatedpartstb.ReadOnly = true;
            this.associatedpartstb.RowHeadersWidth = 82;
            this.associatedpartstb.RowTemplate.Height = 25;
            this.associatedpartstb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedpartstb.Size = new System.Drawing.Size(817, 320);
            this.associatedpartstb.TabIndex = 1;
            this.associatedpartstb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ModifyPod2
            // 
            this.ModifyPod2.AutoSize = true;
            this.ModifyPod2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModifyPod2.Location = new System.Drawing.Point(56, 34);
            this.ModifyPod2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ModifyPod2.Name = "ModifyPod2";
            this.ModifyPod2.Size = new System.Drawing.Size(194, 32);
            this.ModifyPod2.TabIndex = 2;
            this.ModifyPod2.Text = "Modify Product";
            // 
            // Partlabel3
            // 
            this.Partlabel3.AutoSize = true;
            this.Partlabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Partlabel3.Location = new System.Drawing.Point(615, 122);
            this.Partlabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Partlabel3.Name = "Partlabel3";
            this.Partlabel3.Size = new System.Drawing.Size(194, 32);
            this.Partlabel3.TabIndex = 3;
            this.Partlabel3.Text = "Candidate Parts";
            this.Partlabel3.Click += new System.EventHandler(this.Partlabel3_Click);
            // 
            // AssociaPart2
            // 
            this.AssociaPart2.AutoSize = true;
            this.AssociaPart2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AssociaPart2.Location = new System.Drawing.Point(615, 576);
            this.AssociaPart2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AssociaPart2.Name = "AssociaPart2";
            this.AssociaPart2.Size = new System.Drawing.Size(202, 32);
            this.AssociaPart2.TabIndex = 4;
            this.AssociaPart2.Text = "Associated Parts";
            // 
            // modpodid
            // 
            this.modpodid.Location = new System.Drawing.Point(262, 207);
            this.modpodid.Margin = new System.Windows.Forms.Padding(6);
            this.modpodid.Name = "modpodid";
            this.modpodid.ReadOnly = true;
            this.modpodid.Size = new System.Drawing.Size(182, 39);
            this.modpodid.TabIndex = 5;
            // 
            // modpodname
            // 
            this.modpodname.Location = new System.Drawing.Point(262, 297);
            this.modpodname.Margin = new System.Windows.Forms.Padding(6);
            this.modpodname.Name = "modpodname";
            this.modpodname.Size = new System.Drawing.Size(182, 39);
            this.modpodname.TabIndex = 6;
            // 
            // modpodinv
            // 
            this.modpodinv.Location = new System.Drawing.Point(262, 399);
            this.modpodinv.Margin = new System.Windows.Forms.Padding(6);
            this.modpodinv.Name = "modpodinv";
            this.modpodinv.Size = new System.Drawing.Size(182, 39);
            this.modpodinv.TabIndex = 7;
            // 
            // modprodprice
            // 
            this.modprodprice.Location = new System.Drawing.Point(262, 501);
            this.modprodprice.Margin = new System.Windows.Forms.Padding(6);
            this.modprodprice.Name = "modprodprice";
            this.modprodprice.Size = new System.Drawing.Size(182, 39);
            this.modprodprice.TabIndex = 8;
            // 
            // modpodmax
            // 
            this.modpodmax.Location = new System.Drawing.Point(247, 614);
            this.modpodmax.Margin = new System.Windows.Forms.Padding(6);
            this.modpodmax.Name = "modpodmax";
            this.modpodmax.Size = new System.Drawing.Size(71, 39);
            this.modpodmax.TabIndex = 9;
            // 
            // modpodmin
            // 
            this.modpodmin.Location = new System.Drawing.Point(414, 614);
            this.modpodmin.Margin = new System.Windows.Forms.Padding(6);
            this.modpodmin.Name = "modpodmin";
            this.modpodmin.Size = new System.Drawing.Size(67, 39);
            this.modpodmin.TabIndex = 10;
            // 
            // ProdID2
            // 
            this.ProdID2.AutoSize = true;
            this.ProdID2.Location = new System.Drawing.Point(217, 213);
            this.ProdID2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProdID2.Name = "ProdID2";
            this.ProdID2.Size = new System.Drawing.Size(37, 32);
            this.ProdID2.TabIndex = 11;
            this.ProdID2.Text = "ID";
            // 
            // ProdNm2
            // 
            this.ProdNm2.AutoSize = true;
            this.ProdNm2.Location = new System.Drawing.Point(184, 307);
            this.ProdNm2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProdNm2.Name = "ProdNm2";
            this.ProdNm2.Size = new System.Drawing.Size(78, 32);
            this.ProdNm2.TabIndex = 12;
            this.ProdNm2.Text = "Name";
            // 
            // ProdInvent2
            // 
            this.ProdInvent2.AutoSize = true;
            this.ProdInvent2.Location = new System.Drawing.Point(150, 405);
            this.ProdInvent2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProdInvent2.Name = "ProdInvent2";
            this.ProdInvent2.Size = new System.Drawing.Size(115, 32);
            this.ProdInvent2.TabIndex = 13;
            this.ProdInvent2.Text = "Inventory";
            // 
            // ProdPrice2
            // 
            this.ProdPrice2.AutoSize = true;
            this.ProdPrice2.Location = new System.Drawing.Point(180, 508);
            this.ProdPrice2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ProdPrice2.Name = "ProdPrice2";
            this.ProdPrice2.Size = new System.Drawing.Size(65, 32);
            this.ProdPrice2.TabIndex = 14;
            this.ProdPrice2.Text = "Price";
            // 
            // Prodmax2
            // 
            this.Prodmax2.AutoSize = true;
            this.Prodmax2.Location = new System.Drawing.Point(180, 621);
            this.Prodmax2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Prodmax2.Name = "Prodmax2";
            this.Prodmax2.Size = new System.Drawing.Size(59, 32);
            this.Prodmax2.TabIndex = 15;
            this.Prodmax2.Text = "Max";
            // 
            // Prodmin2
            // 
            this.Prodmin2.AutoSize = true;
            this.Prodmin2.Location = new System.Drawing.Point(351, 621);
            this.Prodmin2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Prodmin2.Name = "Prodmin2";
            this.Prodmin2.Size = new System.Drawing.Size(56, 32);
            this.Prodmin2.TabIndex = 16;
            this.Prodmin2.Text = "Min";
            // 
            // modsearchtb
            // 
            this.modsearchtb.Location = new System.Drawing.Point(752, 34);
            this.modsearchtb.Margin = new System.Windows.Forms.Padding(6);
            this.modsearchtb.Name = "modsearchtb";
            this.modsearchtb.Size = new System.Drawing.Size(517, 39);
            this.modsearchtb.TabIndex = 17;
            // 
            // searchbtn2
            // 
            this.searchbtn2.Location = new System.Drawing.Point(1293, 32);
            this.searchbtn2.Margin = new System.Windows.Forms.Padding(6);
            this.searchbtn2.Name = "searchbtn2";
            this.searchbtn2.Size = new System.Drawing.Size(139, 49);
            this.searchbtn2.TabIndex = 18;
            this.searchbtn2.Text = "Search";
            this.searchbtn2.UseVisualStyleBackColor = true;
            this.searchbtn2.Click += new System.EventHandler(this.searchbtn2_Click);
            // 
            // Addpart2
            // 
            this.Addpart2.Location = new System.Drawing.Point(1293, 508);
            this.Addpart2.Margin = new System.Windows.Forms.Padding(6);
            this.Addpart2.Name = "Addpart2";
            this.Addpart2.Size = new System.Drawing.Size(139, 49);
            this.Addpart2.TabIndex = 19;
            this.Addpart2.Text = "Add";
            this.Addpart2.UseVisualStyleBackColor = true;
            this.Addpart2.Click += new System.EventHandler(this.Addpart2_Click);
            // 
            // removebtn3
            // 
            this.removebtn3.Location = new System.Drawing.Point(1293, 966);
            this.removebtn3.Margin = new System.Windows.Forms.Padding(6);
            this.removebtn3.Name = "removebtn3";
            this.removebtn3.Size = new System.Drawing.Size(139, 49);
            this.removebtn3.TabIndex = 20;
            this.removebtn3.Text = "Delete";
            this.removebtn3.UseVisualStyleBackColor = true;
            this.removebtn3.Click += new System.EventHandler(this.removebtn3_Click);
            // 
            // savebtn2
            // 
            this.savebtn2.Location = new System.Drawing.Point(557, 1026);
            this.savebtn2.Margin = new System.Windows.Forms.Padding(6);
            this.savebtn2.Name = "savebtn2";
            this.savebtn2.Size = new System.Drawing.Size(139, 49);
            this.savebtn2.TabIndex = 21;
            this.savebtn2.Text = "Save";
            this.savebtn2.UseVisualStyleBackColor = true;
            this.savebtn2.Click += new System.EventHandler(this.savebtn2_Click);
            // 
            // cancelbtn3
            // 
            this.cancelbtn3.Location = new System.Drawing.Point(793, 1026);
            this.cancelbtn3.Margin = new System.Windows.Forms.Padding(6);
            this.cancelbtn3.Name = "cancelbtn3";
            this.cancelbtn3.Size = new System.Drawing.Size(139, 49);
            this.cancelbtn3.TabIndex = 22;
            this.cancelbtn3.Text = "Cancel";
            this.cancelbtn3.UseVisualStyleBackColor = true;
            this.cancelbtn3.Click += new System.EventHandler(this.cancelbtn3_Click);
            // 
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 1105);
            this.Controls.Add(this.cancelbtn3);
            this.Controls.Add(this.savebtn2);
            this.Controls.Add(this.removebtn3);
            this.Controls.Add(this.Addpart2);
            this.Controls.Add(this.searchbtn2);
            this.Controls.Add(this.modsearchtb);
            this.Controls.Add(this.Prodmin2);
            this.Controls.Add(this.Prodmax2);
            this.Controls.Add(this.ProdPrice2);
            this.Controls.Add(this.ProdInvent2);
            this.Controls.Add(this.ProdNm2);
            this.Controls.Add(this.ProdID2);
            this.Controls.Add(this.modpodmin);
            this.Controls.Add(this.modpodmax);
            this.Controls.Add(this.modprodprice);
            this.Controls.Add(this.modpodinv);
            this.Controls.Add(this.modpodname);
            this.Controls.Add(this.modpodid);
            this.Controls.Add(this.AssociaPart2);
            this.Controls.Add(this.Partlabel3);
            this.Controls.Add(this.ModifyPod2);
            this.Controls.Add(this.associatedpartstb);
            this.Controls.Add(this.candparts);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModProduct";
            this.Text = "ModProduct";
            this.Load += new System.EventHandler(this.ModProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candparts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedpartstb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label ModifyPod2;
        private Label Partlabel3;
        private Label AssociaPart2;
        private Label ProdID2;
        private Label ProdNm2;
        private Label ProdInvent2;
        private Label ProdPrice2;
        private Label Prodmax2;
        private Label Prodmin2;
        private Button searchbtn2;
        private Button Addpart2;
        private Button removebtn3;
        private Button savebtn2;
        private Button cancelbtn3;
        public TextBox modpodid;
        public TextBox modpodname;
        public TextBox modpodinv;
        public TextBox modprodprice;
        public TextBox modpodmax;
        public TextBox modpodmin;
        public DataGridView candparts;
        public DataGridView associatedpartstb;
        public TextBox modsearchtb;
    }
}