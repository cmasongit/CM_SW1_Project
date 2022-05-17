namespace WinFormsApp1
{
    partial class Form3
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
            this.modinh = new System.Windows.Forms.RadioButton();
            this.modoutsourced = new System.Windows.Forms.RadioButton();
            this.modID = new System.Windows.Forms.Label();
            this.modName = new System.Windows.Forms.Label();
            this.modinv = new System.Windows.Forms.Label();
            this.modPrice = new System.Windows.Forms.Label();
            this.modMx = new System.Windows.Forms.Label();
            this.modmin = new System.Windows.Forms.Label();
            this.modmidcn = new System.Windows.Forms.Label();
            this.f3submitbtn = new System.Windows.Forms.Button();
            this.f3cancelbtn = new System.Windows.Forms.Button();
            this.modtitle = new System.Windows.Forms.Label();
            this.f3idtb = new System.Windows.Forms.TextBox();
            this.f3name = new System.Windows.Forms.TextBox();
            this.f3invent = new System.Windows.Forms.TextBox();
            this.f3price = new System.Windows.Forms.TextBox();
            this.f3machcn = new System.Windows.Forms.TextBox();
            this.f3max = new System.Windows.Forms.TextBox();
            this.f3min = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modinh
            // 
            this.modinh.AutoSize = true;
            this.modinh.Checked = true;
            this.modinh.Location = new System.Drawing.Point(182, 75);
            this.modinh.Margin = new System.Windows.Forms.Padding(4);
            this.modinh.Name = "modinh";
            this.modinh.Size = new System.Drawing.Size(143, 36);
            this.modinh.TabIndex = 4;
            this.modinh.TabStop = true;
            this.modinh.Text = "In-House";
            this.modinh.UseVisualStyleBackColor = true;
            this.modinh.CheckedChanged += new System.EventHandler(this.modinh_CheckedChanged);
            // 
            // modoutsourced
            // 
            this.modoutsourced.AutoSize = true;
            this.modoutsourced.Location = new System.Drawing.Point(396, 75);
            this.modoutsourced.Margin = new System.Windows.Forms.Padding(4);
            this.modoutsourced.Name = "modoutsourced";
            this.modoutsourced.Size = new System.Drawing.Size(169, 36);
            this.modoutsourced.TabIndex = 5;
            this.modoutsourced.Text = "Outsourced";
            this.modoutsourced.UseVisualStyleBackColor = true;
            this.modoutsourced.CheckedChanged += new System.EventHandler(this.modoutsourced_CheckedChanged);
            // 
            // modID
            // 
            this.modID.AutoSize = true;
            this.modID.Location = new System.Drawing.Point(204, 192);
            this.modID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modID.Name = "modID";
            this.modID.Size = new System.Drawing.Size(37, 32);
            this.modID.TabIndex = 12;
            this.modID.Text = "ID";
            // 
            // modName
            // 
            this.modName.AutoSize = true;
            this.modName.Location = new System.Drawing.Point(165, 267);
            this.modName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(78, 32);
            this.modName.TabIndex = 13;
            this.modName.Text = "Name";
            // 
            // modinv
            // 
            this.modinv.AutoSize = true;
            this.modinv.Location = new System.Drawing.Point(132, 337);
            this.modinv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modinv.Name = "modinv";
            this.modinv.Size = new System.Drawing.Size(115, 32);
            this.modinv.TabIndex = 14;
            this.modinv.Text = "Inventory";
            // 
            // modPrice
            // 
            this.modPrice.AutoSize = true;
            this.modPrice.Location = new System.Drawing.Point(176, 405);
            this.modPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPrice.Name = "modPrice";
            this.modPrice.Size = new System.Drawing.Size(65, 32);
            this.modPrice.TabIndex = 15;
            this.modPrice.Text = "Price";
            // 
            // modMx
            // 
            this.modMx.AutoSize = true;
            this.modMx.Location = new System.Drawing.Point(182, 474);
            this.modMx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modMx.Name = "modMx";
            this.modMx.Size = new System.Drawing.Size(59, 32);
            this.modMx.TabIndex = 16;
            this.modMx.Text = "Max";
            // 
            // modmin
            // 
            this.modmin.AutoSize = true;
            this.modmin.Location = new System.Drawing.Point(396, 474);
            this.modmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modmin.Name = "modmin";
            this.modmin.Size = new System.Drawing.Size(56, 32);
            this.modmin.TabIndex = 20;
            this.modmin.Text = "Min";
            // 
            // modmidcn
            // 
            this.modmidcn.AutoSize = true;
            this.modmidcn.Location = new System.Drawing.Point(113, 550);
            this.modmidcn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modmidcn.Name = "modmidcn";
            this.modmidcn.Size = new System.Drawing.Size(136, 32);
            this.modmidcn.TabIndex = 21;
            this.modmidcn.Text = "Machine ID";
            // 
            // f3submitbtn
            // 
            this.f3submitbtn.Location = new System.Drawing.Point(182, 646);
            this.f3submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.f3submitbtn.Name = "f3submitbtn";
            this.f3submitbtn.Size = new System.Drawing.Size(145, 43);
            this.f3submitbtn.TabIndex = 22;
            this.f3submitbtn.Text = "Submit";
            this.f3submitbtn.UseVisualStyleBackColor = true;
            this.f3submitbtn.Click += new System.EventHandler(this.f3submitbtn_Click);
            // 
            // f3cancelbtn
            // 
            this.f3cancelbtn.Location = new System.Drawing.Point(396, 646);
            this.f3cancelbtn.Margin = new System.Windows.Forms.Padding(4);
            this.f3cancelbtn.Name = "f3cancelbtn";
            this.f3cancelbtn.Size = new System.Drawing.Size(145, 43);
            this.f3cancelbtn.TabIndex = 23;
            this.f3cancelbtn.Text = "Cancel";
            this.f3cancelbtn.UseVisualStyleBackColor = true;
            this.f3cancelbtn.Click += new System.EventHandler(this.f3cancelbtn_Click);
            // 
            // modtitle
            // 
            this.modtitle.AutoSize = true;
            this.modtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modtitle.Location = new System.Drawing.Point(22, 19);
            this.modtitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modtitle.Name = "modtitle";
            this.modtitle.Size = new System.Drawing.Size(150, 32);
            this.modtitle.TabIndex = 24;
            this.modtitle.Text = "Modify Part";
            this.modtitle.Click += new System.EventHandler(this.modtitle_Click);
            // 
            // f3idtb
            // 
            this.f3idtb.Location = new System.Drawing.Point(251, 186);
            this.f3idtb.Margin = new System.Windows.Forms.Padding(4);
            this.f3idtb.Name = "f3idtb";
            this.f3idtb.ReadOnly = true;
            this.f3idtb.Size = new System.Drawing.Size(193, 39);
            this.f3idtb.TabIndex = 25;
            this.f3idtb.TextChanged += new System.EventHandler(this.f3idtb_TextChanged);
            // 
            // f3name
            // 
            this.f3name.Location = new System.Drawing.Point(251, 260);
            this.f3name.Margin = new System.Windows.Forms.Padding(4);
            this.f3name.Name = "f3name";
            this.f3name.Size = new System.Drawing.Size(193, 39);
            this.f3name.TabIndex = 26;
            // 
            // f3invent
            // 
            this.f3invent.Location = new System.Drawing.Point(251, 331);
            this.f3invent.Margin = new System.Windows.Forms.Padding(4);
            this.f3invent.Name = "f3invent";
            this.f3invent.Size = new System.Drawing.Size(193, 39);
            this.f3invent.TabIndex = 27;
            // 
            // f3price
            // 
            this.f3price.Location = new System.Drawing.Point(251, 395);
            this.f3price.Margin = new System.Windows.Forms.Padding(4);
            this.f3price.Name = "f3price";
            this.f3price.Size = new System.Drawing.Size(193, 39);
            this.f3price.TabIndex = 28;
            // 
            // f3machcn
            // 
            this.f3machcn.Location = new System.Drawing.Point(251, 550);
            this.f3machcn.Margin = new System.Windows.Forms.Padding(4);
            this.f3machcn.Name = "f3machcn";
            this.f3machcn.Size = new System.Drawing.Size(222, 39);
            this.f3machcn.TabIndex = 29;
            this.f3machcn.TextChanged += new System.EventHandler(this.f3machcn_TextChanged);
            // 
            // f3max
            // 
            this.f3max.Location = new System.Drawing.Point(254, 467);
            this.f3max.Margin = new System.Windows.Forms.Padding(4);
            this.f3max.Name = "f3max";
            this.f3max.Size = new System.Drawing.Size(69, 39);
            this.f3max.TabIndex = 30;
            this.f3max.TextChanged += new System.EventHandler(this.f3max_TextChanged);
            // 
            // f3min
            // 
            this.f3min.Location = new System.Drawing.Point(455, 467);
            this.f3min.Margin = new System.Windows.Forms.Padding(4);
            this.f3min.Name = "f3min";
            this.f3min.Size = new System.Drawing.Size(69, 39);
            this.f3min.TabIndex = 31;
            this.f3min.TextChanged += new System.EventHandler(this.f3min_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 766);
            this.Controls.Add(this.f3min);
            this.Controls.Add(this.f3max);
            this.Controls.Add(this.f3machcn);
            this.Controls.Add(this.f3price);
            this.Controls.Add(this.f3invent);
            this.Controls.Add(this.f3name);
            this.Controls.Add(this.f3idtb);
            this.Controls.Add(this.modtitle);
            this.Controls.Add(this.f3cancelbtn);
            this.Controls.Add(this.f3submitbtn);
            this.Controls.Add(this.modmidcn);
            this.Controls.Add(this.modmin);
            this.Controls.Add(this.modMx);
            this.Controls.Add(this.modPrice);
            this.Controls.Add(this.modinv);
            this.Controls.Add(this.modName);
            this.Controls.Add(this.modID);
            this.Controls.Add(this.modoutsourced);
            this.Controls.Add(this.modinh);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton modinh;
        private RadioButton modoutsourced;
        private Label modID;
        private Label modName;
        private Label modinv;
        private Label modPrice;
        private Label modMx;
        private Label modmin;
        private Label modmidcn;
        private Button f3submitbtn;
        private Button f3cancelbtn;
        private Label modtitle;
        public TextBox f3idtb;
        public TextBox f3name;
        public TextBox f3invent;
        public TextBox f3price;
        public TextBox f3machcn;
        public TextBox f3max;
        public TextBox f3min;
    }
}