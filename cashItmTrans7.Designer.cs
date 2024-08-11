namespace Inventory_Mobile_1
{
    partial class cashItmTrans7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashItmTrans7));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmobnumbr = new System.Windows.Forms.TextBox();
            this.itmtrnsction = new System.Windows.Forms.DataGridView();
            this.itmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmuntprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itmtotprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaddrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotitm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itmtrnsction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // txtcusname
            // 
            this.txtcusname.Location = new System.Drawing.Point(265, 134);
            this.txtcusname.Margin = new System.Windows.Forms.Padding(4);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(348, 22);
            this.txtcusname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Mobile Number";
            // 
            // txtmobnumbr
            // 
            this.txtmobnumbr.Location = new System.Drawing.Point(265, 164);
            this.txtmobnumbr.Margin = new System.Windows.Forms.Padding(4);
            this.txtmobnumbr.Name = "txtmobnumbr";
            this.txtmobnumbr.Size = new System.Drawing.Size(348, 22);
            this.txtmobnumbr.TabIndex = 3;
            // 
            // itmtrnsction
            // 
            this.itmtrnsction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itmtrnsction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itmname,
            this.itmqty,
            this.itmuntprice,
            this.itmtotprice});
            this.itmtrnsction.Location = new System.Drawing.Point(55, 226);
            this.itmtrnsction.Margin = new System.Windows.Forms.Padding(4);
            this.itmtrnsction.Name = "itmtrnsction";
            this.itmtrnsction.Size = new System.Drawing.Size(590, 185);
            this.itmtrnsction.TabIndex = 4;
            this.itmtrnsction.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.check_item_exists);
            // 
            // itmname
            // 
            this.itmname.HeaderText = "Item Name";
            this.itmname.Name = "itmname";
            // 
            // itmqty
            // 
            this.itmqty.HeaderText = "Item Quantity";
            this.itmqty.Name = "itmqty";
            // 
            // itmuntprice
            // 
            this.itmuntprice.HeaderText = "Item Unit Price";
            this.itmuntprice.Name = "itmuntprice";
            // 
            // itmtotprice
            // 
            this.itmtotprice.HeaderText = "Item Total Price";
            this.itmtotprice.Name = "itmtotprice";
            // 
            // btnaddrow
            // 
            this.btnaddrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddrow.Location = new System.Drawing.Point(653, 370);
            this.btnaddrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddrow.Name = "btnaddrow";
            this.btnaddrow.Size = new System.Drawing.Size(168, 28);
            this.btnaddrow.TabIndex = 5;
            this.btnaddrow.Text = "View Line Total Price";
            this.btnaddrow.UseVisualStyleBackColor = true;
            this.btnaddrow.Click += new System.EventHandler(this.btnaddrow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Amount for all items";
            // 
            // lbltotitm
            // 
            this.lbltotitm.AutoSize = true;
            this.lbltotitm.Location = new System.Drawing.Point(492, 406);
            this.lbltotitm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotitm.Name = "lbltotitm";
            this.lbltotitm.Size = new System.Drawing.Size(0, 16);
            this.lbltotitm.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate Invoice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inventory Management Systen";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(201, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "<<  Back to Cashier Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 100);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(836, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(364, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Iteam Transaction";
            // 
            // cashItmTrans7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(870, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltotitm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnaddrow);
            this.Controls.Add(this.itmtrnsction);
            this.Controls.Add(this.txtmobnumbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcusname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cashItmTrans7";
            this.Text = "Item Transaction Menu";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itmtrnsction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmobnumbr;
        private System.Windows.Forms.DataGridView itmtrnsction;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmuntprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itmtotprice;
        private System.Windows.Forms.Button btnaddrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotitm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}