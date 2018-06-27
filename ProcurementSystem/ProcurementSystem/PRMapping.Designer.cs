namespace ProcurementSystem
{
    partial class PRMapping
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
            this.requestList = new System.Windows.Forms.DataGridView();
            this.RequestNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.GenItemList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.GenItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // requestList
            // 
            this.requestList.AllowUserToAddRows = false;
            this.requestList.AllowUserToDeleteRows = false;
            this.requestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestNo,
            this.CreateDate});
            this.requestList.Location = new System.Drawing.Point(49, 68);
            this.requestList.MultiSelect = false;
            this.requestList.Name = "requestList";
            this.requestList.ReadOnly = true;
            this.requestList.RowTemplate.Height = 24;
            this.requestList.Size = new System.Drawing.Size(248, 321);
            this.requestList.TabIndex = 0;
            this.requestList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestList_CellClick);
            // 
            // RequestNo
            // 
            this.RequestNo.HeaderText = "RequestNo";
            this.RequestNo.Name = "RequestNo";
            this.RequestNo.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(326, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request ID :";
            // 
            // tbRequestID
            // 
            this.tbRequestID.BackColor = System.Drawing.SystemColors.Window;
            this.tbRequestID.Location = new System.Drawing.Point(418, 67);
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(155, 22);
            this.tbRequestID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(329, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item :";
            // 
            // itemList
            // 
            this.itemList.AllowUserToAddRows = false;
            this.itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity});
            this.itemList.Location = new System.Drawing.Point(379, 95);
            this.itemList.Name = "itemList";
            this.itemList.RowTemplate.Height = 24;
            this.itemList.Size = new System.Drawing.Size(346, 121);
            this.itemList.TabIndex = 4;
            this.itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemList_CellContentClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(339, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate To";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Despatch Instruction";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(158, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Branket Purchase Agreement";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 30F);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mapping Request";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GenItemList
            // 
            this.GenItemList.AllowUserToAddRows = false;
            this.GenItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GenItemName,
            this.GenQuantity});
            this.GenItemList.Location = new System.Drawing.Point(379, 223);
            this.GenItemList.Name = "GenItemList";
            this.GenItemList.ReadOnly = true;
            this.GenItemList.RowTemplate.Height = 24;
            this.GenItemList.Size = new System.Drawing.Size(346, 106);
            this.GenItemList.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(303, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gen Item :";
            // 
            // GenItemName
            // 
            this.GenItemName.HeaderText = "ItemName";
            this.GenItemName.Name = "GenItemName";
            this.GenItemName.ReadOnly = true;
            // 
            // GenQuantity
            // 
            this.GenQuantity.HeaderText = "Quantity";
            this.GenQuantity.Name = "GenQuantity";
            this.GenQuantity.ReadOnly = true;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(731, 193);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(66, 23);
            this.addItem.TabIndex = 13;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // PRMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenItemList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRequestID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestList);
            this.Name = "PRMapping";
            this.Text = "PRMapping";
            ((System.ComponentModel.ISupportInitialize)(this.requestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requestList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridView GenItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addItem;
    }
}