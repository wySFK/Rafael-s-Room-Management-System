namespace Client
{
    partial class Billing
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
            this.BillingTable = new System.Windows.Forms.DataGridView();
            this.BillingID = new System.Windows.Forms.TextBox();
            this.aasd = new System.Windows.Forms.Label();
            this.AddCharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PayStat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.Button();
            this.CalcAmt = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BillingTable
            // 
            this.BillingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillingTable.Location = new System.Drawing.Point(104, 57);
            this.BillingTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BillingTable.Name = "BillingTable";
            this.BillingTable.RowHeadersWidth = 51;
            this.BillingTable.RowTemplate.Height = 24;
            this.BillingTable.Size = new System.Drawing.Size(755, 372);
            this.BillingTable.TabIndex = 0;
            // 
            // BillingID
            // 
            this.BillingID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BillingID.Location = new System.Drawing.Point(95, 466);
            this.BillingID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BillingID.Multiline = true;
            this.BillingID.Name = "BillingID";
            this.BillingID.Size = new System.Drawing.Size(228, 36);
            this.BillingID.TabIndex = 7;
            // 
            // aasd
            // 
            this.aasd.AutoSize = true;
            this.aasd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aasd.Location = new System.Drawing.Point(92, 444);
            this.aasd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aasd.Name = "aasd";
            this.aasd.Size = new System.Drawing.Size(93, 19);
            this.aasd.TabIndex = 6;
            this.aasd.Text = "BILLING ID";
            // 
            // AddCharge
            // 
            this.AddCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddCharge.Location = new System.Drawing.Point(95, 555);
            this.AddCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCharge.Multiline = true;
            this.AddCharge.Name = "AddCharge";
            this.AddCharge.Size = new System.Drawing.Size(228, 36);
            this.AddCharge.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 533);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADDITIONAL CHARGE";
            // 
            // TotalAmount
            // 
            this.TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalAmount.Location = new System.Drawing.Point(352, 466);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalAmount.Multiline = true;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(228, 36);
            this.TotalAmount.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "TOTAL AMOUNT";
            // 
            // PayStat
            // 
            this.PayStat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayStat.FormattingEnabled = true;
            this.PayStat.Location = new System.Drawing.Point(610, 466);
            this.PayStat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PayStat.Name = "PayStat";
            this.PayStat.Size = new System.Drawing.Size(135, 27);
            this.PayStat.TabIndex = 14;
            this.PayStat.SelectedIndexChanged += new System.EventHandler(this.PayStat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "PAYMENT STATUS";
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.DarkOrange;
            this.CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckOut.Location = new System.Drawing.Point(352, 543);
            this.CheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(136, 48);
            this.CheckOut.TabIndex = 17;
            this.CheckOut.Text = "CHECK OUT";
            this.CheckOut.UseVisualStyleBackColor = false;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // CalcAmt
            // 
            this.CalcAmt.BackColor = System.Drawing.Color.DarkOrange;
            this.CalcAmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcAmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcAmt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalcAmt.Location = new System.Drawing.Point(507, 543);
            this.CalcAmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalcAmt.Name = "CalcAmt";
            this.CalcAmt.Size = new System.Drawing.Size(176, 48);
            this.CalcAmt.TabIndex = 19;
            this.CalcAmt.Text = "CALCULATE BILL";
            this.CalcAmt.UseVisualStyleBackColor = false;
            this.CalcAmt.Click += new System.EventHandler(this.CalcAmt_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Red;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(871, 12);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(42, 40);
            this.Exitbutton.TabIndex = 20;
            this.Exitbutton.Text = "X";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(823, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "◄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "BILLING";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(925, 609);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.CalcAmt);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayStat);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillingID);
            this.Controls.Add(this.aasd);
            this.Controls.Add(this.BillingTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Billing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Billing_FormClosed);
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BillingTable;
        private System.Windows.Forms.TextBox BillingID;
        private System.Windows.Forms.Label aasd;
        private System.Windows.Forms.TextBox AddCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PayStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Button CalcAmt;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}