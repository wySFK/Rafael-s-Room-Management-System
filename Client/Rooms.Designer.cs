namespace Client
{
    partial class Rooms
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
            this.RoomTable = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.Avail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomTable
            // 
            this.RoomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomTable.Location = new System.Drawing.Point(91, 57);
            this.RoomTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomTable.Name = "RoomTable";
            this.RoomTable.RowHeadersWidth = 51;
            this.RoomTable.RowTemplate.Height = 24;
            this.RoomTable.Size = new System.Drawing.Size(837, 376);
            this.RoomTable.TabIndex = 0;
            this.RoomTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomTable_CellContentClick);
            // 
            // RoomID
            // 
            this.RoomID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomID.Location = new System.Drawing.Point(91, 466);
            this.RoomID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomID.Multiline = true;
            this.RoomID.Name = "RoomID";
            this.RoomID.Size = new System.Drawing.Size(228, 36);
            this.RoomID.TabIndex = 5;
            this.RoomID.TextChanged += new System.EventHandler(this.RoomID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ROOM ID";
            // 
            // RoomNum
            // 
            this.RoomNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomNum.Location = new System.Drawing.Point(91, 539);
            this.RoomNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomNum.Multiline = true;
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Size = new System.Drawing.Size(228, 36);
            this.RoomNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 517);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ROOM NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "ROOM  NAME";
            // 
            // Capacity
            // 
            this.Capacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Capacity.Location = new System.Drawing.Point(392, 539);
            this.Capacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Capacity.Multiline = true;
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(228, 36);
            this.Capacity.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 517);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "ROOM CAPACITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(682, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "DESCRIPTION";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBtn.Location = new System.Drawing.Point(91, 608);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(104, 43);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateBtn.Location = new System.Drawing.Point(231, 608);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 43);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Location = new System.Drawing.Point(375, 608);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 43);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewBtn.Location = new System.Drawing.Point(516, 608);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 43);
            this.ViewBtn.TabIndex = 17;
            this.ViewBtn.Text = "VIEW";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // Avail
            // 
            this.Avail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avail.Location = new System.Drawing.Point(685, 539);
            this.Avail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Avail.Multiline = true;
            this.Avail.Name = "Avail";
            this.Avail.Size = new System.Drawing.Size(190, 36);
            this.Avail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 517);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "AVAILABILITY";
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price.Location = new System.Drawing.Point(685, 608);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(190, 36);
            this.Price.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 586);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "PRICE";
            // 
            // Desc
            // 
            this.Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Desc.Location = new System.Drawing.Point(685, 466);
            this.Desc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Desc.Multiline = true;
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(190, 36);
            this.Desc.TabIndex = 13;
            // 
            // RoomName
            // 
            this.RoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomName.Location = new System.Drawing.Point(392, 466);
            this.RoomName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomName.Multiline = true;
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(228, 36);
            this.RoomName.TabIndex = 9;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Red;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(917, 12);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(42, 40);
            this.Exitbutton.TabIndex = 22;
            this.Exitbutton.Text = "X";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(869, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "◄";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 45);
            this.label8.TabIndex = 24;
            this.label8.Text = "ROOMS";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 609);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Avail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rooms_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rooms_FormClosed);
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomTable;
        private System.Windows.Forms.TextBox RoomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.TextBox Avail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}