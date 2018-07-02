namespace ProcurementSystem
{
    partial class BlanketPurchaseReleaseAdd
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
            this.bpaNoSelection = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.actualAmount = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.restNo = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.creationDate = new System.Windows.Forms.DateTimePicker();
            this.requestNo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.releaseNo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bpaNolb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(619, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Create Blanket Purchase Release(Urgent)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bpaNoSelection);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.actualAmount);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.account);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.deliveryDate);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.restNo);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.creationDate);
            this.groupBox1.Controls.Add(this.requestNo);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.releaseNo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.bpaNolb);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 460);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release";
            // 
            // bpaNoSelection
            // 
            this.bpaNoSelection.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bpaNoSelection.FormattingEnabled = true;
            this.bpaNoSelection.Location = new System.Drawing.Point(79, 30);
            this.bpaNoSelection.Name = "bpaNoSelection";
            this.bpaNoSelection.Size = new System.Drawing.Size(135, 25);
            this.bpaNoSelection.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName});
            this.dataGridView1.Location = new System.Drawing.Point(22, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 104);
            this.dataGridView1.TabIndex = 23;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quantity.Location = new System.Drawing.Point(625, 415);
            this.quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(135, 25);
            this.quantity.TabIndex = 22;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox11.Location = new System.Drawing.Point(562, 418);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(60, 18);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = "Quantity:";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox10.Location = new System.Drawing.Point(625, 385);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(12, 18);
            this.textBox10.TabIndex = 20;
            this.textBox10.Text = "$";
            // 
            // actualAmount
            // 
            this.actualAmount.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.actualAmount.Location = new System.Drawing.Point(643, 382);
            this.actualAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actualAmount.Name = "actualAmount";
            this.actualAmount.Size = new System.Drawing.Size(117, 25);
            this.actualAmount.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox9.Location = new System.Drawing.Point(562, 385);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(57, 18);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "Amount:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(20, 221);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(93, 18);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Item:";
            // 
            // account
            // 
            this.account.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.account.Location = new System.Drawing.Point(538, 65);
            this.account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(81, 25);
            this.account.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.Location = new System.Drawing.Point(480, 68);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(61, 18);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Account:";
            // 
            // deliveryDate
            // 
            this.deliveryDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDate.Location = new System.Drawing.Point(119, 183);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(121, 25);
            this.deliveryDate.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(20, 189);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(93, 18);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Delivery Date:";
            // 
            // restNo
            // 
            this.restNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.restNo.Location = new System.Drawing.Point(538, 30);
            this.restNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restNo.Name = "restNo";
            this.restNo.Size = new System.Drawing.Size(81, 25);
            this.restNo.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(480, 33);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(52, 18);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "RestNo:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(20, 147);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(93, 18);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Creation Date:";
            // 
            // creationDate
            // 
            this.creationDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.creationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creationDate.Location = new System.Drawing.Point(119, 141);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(121, 25);
            this.creationDate.TabIndex = 8;
            // 
            // requestNo
            // 
            this.requestNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.requestNo.Location = new System.Drawing.Point(98, 106);
            this.requestNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.requestNo.Name = "requestNo";
            this.requestNo.Size = new System.Drawing.Size(94, 25);
            this.requestNo.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(20, 106);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(72, 18);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "RequestNo:";
            // 
            // releaseNo
            // 
            this.releaseNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.releaseNo.Location = new System.Drawing.Point(98, 68);
            this.releaseNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.releaseNo.Name = "releaseNo";
            this.releaseNo.Size = new System.Drawing.Size(94, 25);
            this.releaseNo.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(20, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(72, 18);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "ReleaseNo:";
            // 
            // bpaNolb
            // 
            this.bpaNolb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bpaNolb.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bpaNolb.Location = new System.Drawing.Point(20, 33);
            this.bpaNolb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bpaNolb.Name = "bpaNolb";
            this.bpaNolb.ReadOnly = true;
            this.bpaNolb.Size = new System.Drawing.Size(52, 18);
            this.bpaNolb.TabIndex = 2;
            this.bpaNolb.Text = "BPANo:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(614, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(390, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlanketPurchaseReleaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "BlanketPurchaseReleaseAdd";
            this.Text = "BlanketPurchaseReleaseAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox actualAmount;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker deliveryDate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox restNo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker creationDate;
        private System.Windows.Forms.TextBox requestNo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox releaseNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bpaNolb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bpaNoSelection;
    }
}