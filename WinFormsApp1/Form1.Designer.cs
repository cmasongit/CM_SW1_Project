using System.ComponentModel;

namespace WinFormsApp1
{
    partial class guiform 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.addpartbtn = new System.Windows.Forms.Button();
            this.partdeletebtn = new System.Windows.Forms.Button();
            this.modifypartbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DeleteText = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partsname = new System.Windows.Forms.Label();
            this.mainsearchtb = new System.Windows.Forms.TextBox();
            this.mainsearchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchnote = new System.Windows.Forms.Label();
            this.inventorytitle = new System.Windows.Forms.Label();
            this.mppstb = new System.Windows.Forms.TextBox();
            this.partsearchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1859, 1111);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addpartbtn
            // 
            this.addpartbtn.Location = new System.Drawing.Point(726, 1011);
            this.addpartbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addpartbtn.Name = "addpartbtn";
            this.addpartbtn.Size = new System.Drawing.Size(145, 60);
            this.addpartbtn.TabIndex = 1;
            this.addpartbtn.Text = "Add";
            this.addpartbtn.UseVisualStyleBackColor = true;
            this.addpartbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // partdeletebtn
            // 
            this.partdeletebtn.Location = new System.Drawing.Point(919, 1011);
            this.partdeletebtn.Margin = new System.Windows.Forms.Padding(4);
            this.partdeletebtn.Name = "partdeletebtn";
            this.partdeletebtn.Size = new System.Drawing.Size(145, 60);
            this.partdeletebtn.TabIndex = 2;
            this.partdeletebtn.Text = "Delete";
            this.partdeletebtn.UseVisualStyleBackColor = true;
            this.partdeletebtn.Click += new System.EventHandler(this.partdeletebtn_Click);
            // 
            // modifypartbtn
            // 
            this.modifypartbtn.Location = new System.Drawing.Point(1101, 1011);
            this.modifypartbtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifypartbtn.Name = "modifypartbtn";
            this.modifypartbtn.Size = new System.Drawing.Size(145, 60);
            this.modifypartbtn.TabIndex = 3;
            this.modifypartbtn.Text = "Modify";
            this.modifypartbtn.UseVisualStyleBackColor = true;
            this.modifypartbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(726, 535);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DeleteText
            // 
            this.DeleteText.Location = new System.Drawing.Point(910, 535);
            this.DeleteText.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteText.Name = "DeleteText";
            this.DeleteText.Size = new System.Drawing.Size(145, 55);
            this.DeleteText.TabIndex = 5;
            this.DeleteText.Text = "Delete";
            this.DeleteText.UseVisualStyleBackColor = true;
            this.DeleteText.Click += new System.EventHandler(this.DeleteText_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1101, 535);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "Modify";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Products";
            // 
            // partsname
            // 
            this.partsname.AutoSize = true;
            this.partsname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partsname.Location = new System.Drawing.Point(217, 745);
            this.partsname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsname.Name = "partsname";
            this.partsname.Size = new System.Drawing.Size(83, 37);
            this.partsname.TabIndex = 11;
            this.partsname.Text = "Parts";
            // 
            // mainsearchtb
            // 
            this.mainsearchtb.Location = new System.Drawing.Point(1341, 105);
            this.mainsearchtb.Margin = new System.Windows.Forms.Padding(4);
            this.mainsearchtb.Name = "mainsearchtb";
            this.mainsearchtb.Size = new System.Drawing.Size(487, 39);
            this.mainsearchtb.TabIndex = 12;
            this.mainsearchtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mainsearchbtn
            // 
            this.mainsearchbtn.Location = new System.Drawing.Point(1859, 100);
            this.mainsearchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.mainsearchbtn.Name = "mainsearchbtn";
            this.mainsearchbtn.Size = new System.Drawing.Size(145, 49);
            this.mainsearchbtn.TabIndex = 13;
            this.mainsearchbtn.Text = "Search";
            this.mainsearchbtn.UseVisualStyleBackColor = true;
            this.mainsearchbtn.Click += new System.EventHandler(this.mainsearchbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 670);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 320);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(388, 222);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1198, 303);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // searchnote
            // 
            this.searchnote.AutoSize = true;
            this.searchnote.ForeColor = System.Drawing.Color.Red;
            this.searchnote.Location = new System.Drawing.Point(1341, 148);
            this.searchnote.Name = "searchnote";
            this.searchnote.Size = new System.Drawing.Size(556, 32);
            this.searchnote.TabIndex = 16;
            this.searchnote.Text = "To Reset Grid, clear textbox and click search button";
            this.searchnote.Click += new System.EventHandler(this.label2_Click);
            // 
            // inventorytitle
            // 
            this.inventorytitle.AutoSize = true;
            this.inventorytitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventorytitle.Location = new System.Drawing.Point(42, 41);
            this.inventorytitle.Name = "inventorytitle";
            this.inventorytitle.Size = new System.Drawing.Size(222, 59);
            this.inventorytitle.TabIndex = 17;
            this.inventorytitle.Text = "Inventory";
            // 
            // mppstb
            // 
            this.mppstb.Location = new System.Drawing.Point(1341, 595);
            this.mppstb.Margin = new System.Windows.Forms.Padding(4);
            this.mppstb.Name = "mppstb";
            this.mppstb.Size = new System.Drawing.Size(487, 39);
            this.mppstb.TabIndex = 18;
            this.mppstb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // partsearchbtn
            // 
            this.partsearchbtn.Location = new System.Drawing.Point(1859, 590);
            this.partsearchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.partsearchbtn.Name = "partsearchbtn";
            this.partsearchbtn.Size = new System.Drawing.Size(145, 49);
            this.partsearchbtn.TabIndex = 19;
            this.partsearchbtn.Text = "Search";
            this.partsearchbtn.UseVisualStyleBackColor = true;
            this.partsearchbtn.Click += new System.EventHandler(this.partsearchbtn_Click);
            // 
            // guiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1178);
            this.Controls.Add(this.partsearchbtn);
            this.Controls.Add(this.mppstb);
            this.Controls.Add(this.inventorytitle);
            this.Controls.Add(this.searchnote);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainsearchbtn);
            this.Controls.Add(this.mainsearchtb);
            this.Controls.Add(this.partsname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.DeleteText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.modifypartbtn);
            this.Controls.Add(this.partdeletebtn);
            this.Controls.Add(this.addpartbtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "guiform";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       



        #endregion

        private Button button1;
        private Button addpartbtn;
        private Button partdeletebtn;
        private Button modifypartbtn;
        private Button button5;
        private Button DeleteText;
        private Button button7;
        private Label label1;
        private TextBox mainsearchtb;
        private Button mainsearchbtn;
        public DataGridView dataGridView1;
        public DataGridView dataGridView2;
        public Label partsname;
        private Label searchnote;
        private Label inventorytitle;
        private Button partsearchbtn;
        public TextBox mppstb;
    }
}