namespace Client
{
    partial class RoomAssignment
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
            this.CalcTotalRent = new System.Windows.Forms.Button();
            this.PayAmount = new System.Windows.Forms.Button();
            this.Assig = new System.Windows.Forms.ComboBox();
            this.AdvPay = new System.Windows.Forms.TextBox();
            this.Advance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guestname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomAssignTable = new System.Windows.Forms.DataGridView();
            this.CinDate = new System.Windows.Forms.DateTimePicker();
            this.CoutDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomAvailText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RoomOcc = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomAssignTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcTotalRent
            // 
            this.CalcTotalRent.BackColor = System.Drawing.Color.DarkOrange;
            this.CalcTotalRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcTotalRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcTotalRent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalcTotalRent.Location = new System.Drawing.Point(488, 618);
            this.CalcTotalRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalcTotalRent.Name = "CalcTotalRent";
            this.CalcTotalRent.Size = new System.Drawing.Size(356, 43);
            this.CalcTotalRent.TabIndex = 40;
            this.CalcTotalRent.Text = "CALCULATE TOTAL RENT";
            this.CalcTotalRent.UseVisualStyleBackColor = false;
            this.CalcTotalRent.Click += new System.EventHandler(this.CalcTotalRent_Click);
            // 
            // PayAmount
            // 
            this.PayAmount.BackColor = System.Drawing.Color.DarkOrange;
            this.PayAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PayAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PayAmount.Location = new System.Drawing.Point(98, 613);
            this.PayAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PayAmount.Name = "PayAmount";
            this.PayAmount.Size = new System.Drawing.Size(183, 43);
            this.PayAmount.TabIndex = 38;
            this.PayAmount.Text = "PAY AMOUNT";
            this.PayAmount.UseVisualStyleBackColor = false;
            this.PayAmount.Click += new System.EventHandler(this.PayAmount_Click);
            // 
            // Assig
            // 
            this.Assig.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assig.FormattingEnabled = true;
            this.Assig.Location = new System.Drawing.Point(98, 568);
            this.Assig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Assig.Name = "Assig";
            this.Assig.Size = new System.Drawing.Size(225, 34);
            this.Assig.TabIndex = 37;
            // 
            // AdvPay
            // 
            this.AdvPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdvPay.Location = new System.Drawing.Point(616, 565);
            this.AdvPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdvPay.Multiline = true;
            this.AdvPay.Name = "AdvPay";
            this.AdvPay.Size = new System.Drawing.Size(228, 36);
            this.AdvPay.TabIndex = 36;
            // 
            // Advance
            // 
            this.Advance.AutoSize = true;
            this.Advance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advance.Location = new System.Drawing.Point(614, 539);
            this.Advance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Advance.Name = "Advance";
            this.Advance.Size = new System.Drawing.Size(168, 19);
            this.Advance.TabIndex = 35;
            this.Advance.Text = "ADVANCE PAYMENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "CHECK OUT DATE";
            // 
            // Total
            // 
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.Location = new System.Drawing.Point(350, 565);
            this.Total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Total.Multiline = true;
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(228, 36);
            this.Total.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 539);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "TOTAL RENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "CHECK IN DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 539);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "ROOM ASSIGNMENT";
            // 
            // Guestname
            // 
            this.Guestname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Guestname.Location = new System.Drawing.Point(98, 488);
            this.Guestname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Guestname.Multiline = true;
            this.Guestname.Name = "Guestname";
            this.Guestname.Size = new System.Drawing.Size(228, 36);
            this.Guestname.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 466);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "GUEST NAME";
            // 
            // RoomAssignTable
            // 
            this.RoomAssignTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomAssignTable.Location = new System.Drawing.Point(91, 141);
            this.RoomAssignTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomAssignTable.Name = "RoomAssignTable";
            this.RoomAssignTable.RowHeadersWidth = 51;
            this.RoomAssignTable.RowTemplate.Height = 24;
            this.RoomAssignTable.Size = new System.Drawing.Size(783, 299);
            this.RoomAssignTable.TabIndex = 25;
            this.RoomAssignTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomAssignTable_CellContentClick);
            // 
            // CinDate
            // 
            this.CinDate.CalendarFont = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinDate.Location = new System.Drawing.Point(350, 496);
            this.CinDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CinDate.Name = "CinDate";
            this.CinDate.Size = new System.Drawing.Size(205, 20);
            this.CinDate.TabIndex = 41;
            // 
            // CoutDate
            // 
            this.CoutDate.CalendarFont = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoutDate.Location = new System.Drawing.Point(616, 496);
            this.CoutDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CoutDate.Name = "CoutDate";
            this.CoutDate.Size = new System.Drawing.Size(205, 20);
            this.CoutDate.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.RoomAvailText);
            this.panel1.Location = new System.Drawing.Point(142, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 47);
            this.panel1.TabIndex = 43;
            // 
            // RoomAvailText
            // 
            this.RoomAvailText.AutoSize = true;
            this.RoomAvailText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomAvailText.Location = new System.Drawing.Point(17, 47);
            this.RoomAvailText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomAvailText.Name = "RoomAvailText";
            this.RoomAvailText.Size = new System.Drawing.Size(0, 19);
            this.RoomAvailText.TabIndex = 27;
            this.RoomAvailText.Click += new System.EventHandler(this.RoomAvailText_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.RoomOcc);
            this.panel2.Location = new System.Drawing.Point(410, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 47);
            this.panel2.TabIndex = 44;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RoomOcc
            // 
            this.RoomOcc.AutoSize = true;
            this.RoomOcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomOcc.Location = new System.Drawing.Point(12, 47);
            this.RoomOcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomOcc.Name = "RoomOcc";
            this.RoomOcc.Size = new System.Drawing.Size(0, 19);
            this.RoomOcc.TabIndex = 27;
            this.RoomOcc.Click += new System.EventHandler(this.RoomOcc_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Red;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(922, 38);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(42, 40);
            this.Exitbutton.TabIndex = 45;
            this.Exitbutton.Text = "X";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(874, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 46;
            this.button1.Text = "◄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 45);
            this.label5.TabIndex = 47;
            this.label5.Text = "ROOM ASSIGNMENT";
            // 
            // RoomAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 691);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoutDate);
            this.Controls.Add(this.CinDate);
            this.Controls.Add(this.CalcTotalRent);
            this.Controls.Add(this.PayAmount);
            this.Controls.Add(this.Assig);
            this.Controls.Add(this.AdvPay);
            this.Controls.Add(this.Advance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guestname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomAssignTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomAssignment_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomAssignment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RoomAssignTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcTotalRent;
        private System.Windows.Forms.Button PayAmount;
        private System.Windows.Forms.ComboBox Assig;
        private System.Windows.Forms.TextBox AdvPay;
        private System.Windows.Forms.Label Advance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Guestname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RoomAssignTable;
        private System.Windows.Forms.DateTimePicker CinDate;
        private System.Windows.Forms.DateTimePicker CoutDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoomAvailText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RoomOcc;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}