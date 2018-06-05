﻿namespace ProcurementSystem
{
    partial class CPA
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ContractNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EffectiveDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuyerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BillingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TermsAndCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 46);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Contract Purchase Agreement";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContractNo,
            this.SupplierNo,
            this.CreationDate,
            this.EffectiveDate,
            this.BuyerName,
            this.BillingAddress,
            this.TermsAndCondition,
            this.ItemID});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(19, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(521, 343);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ContractNo
            // 
            this.ContractNo.Text = "ContractNo";
            this.ContractNo.Width = 90;
            // 
            // SupplierNo
            // 
            this.SupplierNo.Text = "SupplierNo";
            this.SupplierNo.Width = 90;
            // 
            // CreationDate
            // 
            this.CreationDate.Text = "CreationDate";
            this.CreationDate.Width = 120;
            // 
            // EffectiveDate
            // 
            this.EffectiveDate.Text = "EffectiveDate";
            this.EffectiveDate.Width = 120;
            // 
            // BuyerName
            // 
            this.BuyerName.Text = "BuyerName";
            this.BuyerName.Width = 90;
            // 
            // BillingAddress
            // 
            this.BillingAddress.Text = "BillingAddress";
            this.BillingAddress.Width = 90;
            // 
            // TermsAndCondition
            // 
            this.TermsAndCondition.Text = "TermsAndCondition";
            this.TermsAndCondition.Width = 90;
            // 
            // ItemID
            // 
            this.ItemID.Text = "ItemID";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(577, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(577, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Contract Purchase Agreement";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(577, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Contract Purchase Agreement";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(577, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create New Contract Purchase Agreement";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "CPA";
            this.Text = "Contract Purchase Agreement";
            this.Load += new System.EventHandler(this.CPA_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ContractNo;
        private System.Windows.Forms.ColumnHeader SupplierNo;
        private System.Windows.Forms.ColumnHeader CreationDate;
        private System.Windows.Forms.ColumnHeader EffectiveDate;
        private System.Windows.Forms.ColumnHeader BuyerName;
        private System.Windows.Forms.ColumnHeader BillingAddress;
        private System.Windows.Forms.ColumnHeader TermsAndCondition;
        private System.Windows.Forms.ColumnHeader ItemID;
    }
}