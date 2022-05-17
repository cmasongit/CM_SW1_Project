namespace WinFormsApp1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.f2idtb = new System.Windows.Forms.TextBox();
            this.f2name = new System.Windows.Forms.TextBox();
            this.f2inventtb = new System.Windows.Forms.TextBox();
            this.f2pricetb = new System.Windows.Forms.TextBox();
            this.f2max = new System.Windows.Forms.TextBox();
            this.f2machcomtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.f2min = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(336, 510);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(145, 43);
            this.submitbtn.TabIndex = 1;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(295, 47);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(143, 36);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In-House";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(563, 47);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(169, 36);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Outsourced";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // f2idtb
            // 
            this.f2idtb.Location = new System.Drawing.Point(284, 137);
            this.f2idtb.Margin = new System.Windows.Forms.Padding(4);
            this.f2idtb.Name = "f2idtb";
            this.f2idtb.ReadOnly = true;
            this.f2idtb.Size = new System.Drawing.Size(193, 39);
            this.f2idtb.TabIndex = 5;
            // 
            // f2name
            // 
            this.f2name.Location = new System.Drawing.Point(284, 213);
            this.f2name.Margin = new System.Windows.Forms.Padding(4);
            this.f2name.Name = "f2name";
            this.f2name.Size = new System.Drawing.Size(193, 39);
            this.f2name.TabIndex = 6;
            // 
            // f2inventtb
            // 
            this.f2inventtb.Location = new System.Drawing.Point(284, 294);
            this.f2inventtb.Margin = new System.Windows.Forms.Padding(4);
            this.f2inventtb.Name = "f2inventtb";
            this.f2inventtb.Size = new System.Drawing.Size(193, 39);
            this.f2inventtb.TabIndex = 7;
            // 
            // f2pricetb
            // 
            this.f2pricetb.Location = new System.Drawing.Point(284, 369);
            this.f2pricetb.Margin = new System.Windows.Forms.Padding(4);
            this.f2pricetb.Name = "f2pricetb";
            this.f2pricetb.Size = new System.Drawing.Size(193, 39);
            this.f2pricetb.TabIndex = 8;
            // 
            // f2max
            // 
            this.f2max.Location = new System.Drawing.Point(669, 137);
            this.f2max.Margin = new System.Windows.Forms.Padding(4);
            this.f2max.Name = "f2max";
            this.f2max.Size = new System.Drawing.Size(69, 39);
            this.f2max.TabIndex = 9;
            // 
            // f2machcomtb
            // 
            this.f2machcomtb.Location = new System.Drawing.Point(681, 217);
            this.f2machcomtb.Margin = new System.Windows.Forms.Padding(4);
            this.f2machcomtb.Name = "f2machcomtb";
            this.f2machcomtb.Size = new System.Drawing.Size(193, 39);
            this.f2machcomtb.TabIndex = 10;
            this.f2machcomtb.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Machine ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Add Part";
            // 
            // f2min
            // 
            this.f2min.Location = new System.Drawing.Point(852, 134);
            this.f2min.Margin = new System.Windows.Forms.Padding(4);
            this.f2min.Name = "f2min";
            this.f2min.Size = new System.Drawing.Size(69, 39);
            this.f2min.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(793, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Min";
            // 
            // Form2
            // 
            this.AcceptButton = this.submitbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1059, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.f2min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f2machcomtb);
            this.Controls.Add(this.f2max);
            this.Controls.Add(this.f2pricetb);
            this.Controls.Add(this.f2inventtb);
            this.Controls.Add(this.f2name);
            this.Controls.Add(this.f2idtb);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox f2idtb;
        public Button submitbtn;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public TextBox f2name;
        public TextBox f2inventtb;
        public TextBox f2pricetb;
        public TextBox f2max;
        public TextBox f2machcomtb;
        public TextBox f2min;
    }
}