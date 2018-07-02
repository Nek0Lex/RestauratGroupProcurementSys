namespace ProcurementSystem
{
    partial class WHPurchaseOrder
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
            System.Windows.Forms.ColumnHeader BPANo;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BPANoTW = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PromisedQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BPANoSelection = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            BPANo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BPANo
            // 
            BPANo.Text = "BPANo";
            BPANo.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(873, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Purchase Order(Warehouse)";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BPANoTW
            // 
            this.BPANoTW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BPANoTW.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPANoTW.Location = new System.Drawing.Point(6, 35);
            this.BPANoTW.Name = "BPANoTW";
            this.BPANoTW.ReadOnly = true;
            this.BPANoTW.Size = new System.Drawing.Size(62, 20);
            this.BPANoTW.TabIndex = 1;
            this.BPANoTW.Text = "BPA No:";
            this.BPANoTW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.refresh_btn);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.BPANoSelection);
            this.groupBox1.Controls.Add(this.BPANoTW);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 446);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(331, 34);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(219, 23);
            this.search.TabIndex = 6;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(270, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Search:";
            // 
            // refresh_btn
            // 
            this.refresh_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.refresh_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.refresh_btn.Location = new System.Drawing.Point(699, 29);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(143, 26);
            this.refresh_btn.TabIndex = 4;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseMnemonic = false;
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            BPANo,
            this.ItemID,
            this.PromisedQuantity,
            this.UOM,
            this.MoQ,
            this.Price,
            this.Amount,
            this.Category,
            this.Reference});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(861, 356);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ItemID
            // 
            this.ItemID.Text = "ItemID";
            this.ItemID.Width = 70;
            // 
            // PromisedQuantity
            // 
            this.PromisedQuantity.Text = "PromisedQuantity";
            this.PromisedQuantity.Width = 100;
            // 
            // UOM
            // 
            this.UOM.Text = "Unit of measure";
            this.UOM.Width = 100;
            // 
            // MoQ
            // 
            this.MoQ.Text = "MoQ";
            this.MoQ.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 100;
            // 
            // Reference
            // 
            this.Reference.Text = "Reference";
            this.Reference.Width = 100;
            // 
            // BPANoSelection
            // 
            this.BPANoSelection.FormattingEnabled = true;
            this.BPANoSelection.Location = new System.Drawing.Point(74, 34);
            this.BPANoSelection.Name = "BPANoSelection";
            this.BPANoSelection.Size = new System.Drawing.Size(161, 21);
            this.BPANoSelection.TabIndex = 2;
            this.BPANoSelection.SelectedIndexChanged += new System.EventHandler(this.BPANoSelection_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.back_btn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back_btn.Location = new System.Drawing.Point(698, 538);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(181, 42);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // WHPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 592);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "WHPurchaseOrder";
            this.Text = "WHPurchaseOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BPANoTW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox BPANoSelection;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader PromisedQuantity;
        private System.Windows.Forms.ColumnHeader UOM;
        private System.Windows.Forms.ColumnHeader MoQ;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Reference;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox search;
    }
}