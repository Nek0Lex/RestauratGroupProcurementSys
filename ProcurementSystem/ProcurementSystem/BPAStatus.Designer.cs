﻿namespace ProcurementSystem
{
    partial class BPAStatus
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitofmeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinuminQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.currency = new System.Windows.Forms.ComboBox();
            this.SupplierNo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.TAC = new System.Windows.Forms.RichTextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.BillingAddress = new System.Windows.Forms.RichTextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.BuyerName = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.Effective = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.PurchaseOrderRevision = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.RequestNo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BPANo = new System.Windows.Forms.TextBox();
            this.BPA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 36);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Status Of Blanket Purchase Request";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.currency);
            this.groupBox1.Controls.Add(this.SupplierNo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.TAC);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.BillingAddress);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.BuyerName);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.Effective);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.CreationDate);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.PurchaseOrderRevision);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.RequestNo);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.BPANo);
            this.groupBox1.Controls.Add(this.BPA);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 568);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new agreement";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.unitofmeasurement,
            this.MinuminQTY,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(17, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // unitofmeasurement
            // 
            this.unitofmeasurement.HeaderText = "unit of measurement";
            this.unitofmeasurement.Name = "unitofmeasurement";
            // 
            // MinuminQTY
            // 
            this.MinuminQTY.HeaderText = "MinumumQTY";
            this.MinuminQTY.Name = "MinuminQTY";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(19, 365);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(82, 18);
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "Item:";
            // 
            // currency
            // 
            this.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currency.Enabled = false;
            this.currency.FormattingEnabled = true;
            this.currency.Items.AddRange(new object[] {
            "HKD",
            "RMB",
            "USD",
            "JPY",
            "AUS"});
            this.currency.Location = new System.Drawing.Point(460, 193);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(139, 20);
            this.currency.TabIndex = 23;
            // 
            // SupplierNo
            // 
            this.SupplierNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SupplierNo.Location = new System.Drawing.Point(105, 285);
            this.SupplierNo.Name = "SupplierNo";
            this.SupplierNo.Size = new System.Drawing.Size(134, 16);
            this.SupplierNo.TabIndex = 22;
            this.SupplierNo.Text = "0001";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(17, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(82, 18);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Supplier No:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox16.Location = new System.Drawing.Point(390, 240);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(139, 18);
            this.textBox16.TabIndex = 19;
            this.textBox16.Text = "Terms And Condition:";
            // 
            // TAC
            // 
            this.TAC.Location = new System.Drawing.Point(535, 240);
            this.TAC.Name = "TAC";
            this.TAC.ReadOnly = true;
            this.TAC.Size = new System.Drawing.Size(259, 103);
            this.TAC.TabIndex = 18;
            this.TAC.Text = "";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox15.Location = new System.Drawing.Point(390, 193);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(64, 18);
            this.textBox15.TabIndex = 17;
            this.textBox15.Text = "Currency:";
            // 
            // Amount
            // 
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Amount.Location = new System.Drawing.Point(501, 160);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(134, 16);
            this.Amount.TabIndex = 15;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox13.Location = new System.Drawing.Point(390, 160);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(105, 18);
            this.textBox13.TabIndex = 14;
            this.textBox13.Text = "Amount agreed:";
            // 
            // BillingAddress
            // 
            this.BillingAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BillingAddress.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BillingAddress.Location = new System.Drawing.Point(501, 36);
            this.BillingAddress.Name = "BillingAddress";
            this.BillingAddress.ReadOnly = true;
            this.BillingAddress.Size = new System.Drawing.Size(293, 102);
            this.BillingAddress.TabIndex = 13;
            this.BillingAddress.Text = "";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox12.Location = new System.Drawing.Point(398, 36);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(97, 18);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = "Billing Address:";
            // 
            // BuyerName
            // 
            this.BuyerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuyerName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BuyerName.Location = new System.Drawing.Point(105, 241);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(134, 16);
            this.BuyerName.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox10.Location = new System.Drawing.Point(17, 240);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(82, 18);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "Buyer Name:";
            // 
            // Effective
            // 
            this.Effective.Enabled = false;
            this.Effective.Location = new System.Drawing.Point(119, 198);
            this.Effective.Name = "Effective";
            this.Effective.Size = new System.Drawing.Size(114, 22);
            this.Effective.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox9.Location = new System.Drawing.Point(17, 198);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(96, 18);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Effective Date:";
            // 
            // CreationDate
            // 
            this.CreationDate.Enabled = false;
            this.CreationDate.Location = new System.Drawing.Point(119, 160);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(114, 22);
            this.CreationDate.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(17, 160);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(96, 18);
            this.textBox8.TabIndex = 6;
            this.textBox8.Text = "Creation Date:";
            // 
            // PurchaseOrderRevision
            // 
            this.PurchaseOrderRevision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchaseOrderRevision.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PurchaseOrderRevision.Location = new System.Drawing.Point(181, 120);
            this.PurchaseOrderRevision.Name = "PurchaseOrderRevision";
            this.PurchaseOrderRevision.Size = new System.Drawing.Size(134, 16);
            this.PurchaseOrderRevision.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(17, 120);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(158, 18);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Purchase Order Revision:";
            // 
            // RequestNo
            // 
            this.RequestNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequestNo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RequestNo.Location = new System.Drawing.Point(99, 83);
            this.RequestNo.Name = "RequestNo";
            this.RequestNo.Size = new System.Drawing.Size(134, 16);
            this.RequestNo.TabIndex = 3;
            this.RequestNo.Text = "0000000";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(17, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(84, 18);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "RequestNo:";
            // 
            // BPANo
            // 
            this.BPANo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BPANo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPANo.Location = new System.Drawing.Point(73, 41);
            this.BPANo.Name = "BPANo";
            this.BPANo.ReadOnly = true;
            this.BPANo.Size = new System.Drawing.Size(134, 18);
            this.BPANo.TabIndex = 1;
            this.BPANo.Text = "BPA";
            // 
            // BPA
            // 
            this.BPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BPA.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPA.Location = new System.Drawing.Point(17, 40);
            this.BPA.Name = "BPA";
            this.BPA.ReadOnly = true;
            this.BPA.Size = new System.Drawing.Size(50, 18);
            this.BPA.TabIndex = 0;
            this.BPA.Text = "BPANo:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(653, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BPAStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(860, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "BPAStatus";
            this.Text = "BPAStatus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.TextBox SupplierNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.RichTextBox TAC;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.RichTextBox BillingAddress;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox BuyerName;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DateTimePicker Effective;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox PurchaseOrderRevision;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox RequestNo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox BPANo;
        private System.Windows.Forms.TextBox BPA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitofmeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinuminQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}