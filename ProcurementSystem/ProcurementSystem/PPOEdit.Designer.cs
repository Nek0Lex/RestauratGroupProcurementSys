namespace ProcurementSystem
{
    partial class PPOEdit
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
            this.Currency = new System.Windows.Forms.ComboBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.PurchaseOrderRevision = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.TAC = new System.Windows.Forms.RichTextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.SRNo = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.BuyerAccount = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.BillingAddress = new System.Windows.Forms.RichTextBox();
            this.BuyerName = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.EffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SupplierNo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PPONo = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.textBox1.Size = new System.Drawing.Size(938, 36);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Edit Planned Purchase Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Currency);
            this.groupBox1.Controls.Add(this.textBox21);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.PurchaseOrderRevision);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.TAC);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.SRNo);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.BuyerAccount);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.BillingAddress);
            this.groupBox1.Controls.Add(this.BuyerName);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.EffectiveDate);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.CreationDate);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.SupplierNo);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.PPONo);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(964, 630);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new PPO";
            // 
            // Currency
            // 
            this.Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Currency.FormattingEnabled = true;
            this.Currency.Items.AddRange(new object[] {
            "HKD",
            "RMB",
            "USD",
            "JPY",
            "AUS"});
            this.Currency.Location = new System.Drawing.Point(456, 443);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(139, 20);
            this.Currency.TabIndex = 28;
            this.Currency.SelectedIndexChanged += new System.EventHandler(this.Currency_SelectedIndexChanged);
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox21.Location = new System.Drawing.Point(392, 443);
            this.textBox21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(58, 18);
            this.textBox21.TabIndex = 27;
            this.textBox21.Text = "Currency:";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(456, 386);
            this.Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(99, 22);
            this.Amount.TabIndex = 26;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox19.Location = new System.Drawing.Point(392, 386);
            this.textBox19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(58, 18);
            this.textBox19.TabIndex = 25;
            this.textBox19.Text = "Amount:";
            // 
            // PurchaseOrderRevision
            // 
            this.PurchaseOrderRevision.Location = new System.Drawing.Point(177, 191);
            this.PurchaseOrderRevision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PurchaseOrderRevision.Name = "PurchaseOrderRevision";
            this.PurchaseOrderRevision.Size = new System.Drawing.Size(182, 22);
            this.PurchaseOrderRevision.TabIndex = 24;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox17.Location = new System.Drawing.Point(18, 195);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(153, 18);
            this.textBox17.TabIndex = 23;
            this.textBox17.Text = "Purchase Order Revision:";
            // 
            // TAC
            // 
            this.TAC.Location = new System.Drawing.Point(169, 489);
            this.TAC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TAC.Name = "TAC";
            this.TAC.Size = new System.Drawing.Size(761, 119);
            this.TAC.TabIndex = 22;
            this.TAC.Text = "";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox16.Location = new System.Drawing.Point(18, 489);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(145, 18);
            this.textBox16.TabIndex = 21;
            this.textBox16.Text = "Terms And Condition:";
            // 
            // SRNo
            // 
            this.SRNo.Location = new System.Drawing.Point(443, 324);
            this.SRNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SRNo.Name = "SRNo";
            this.SRNo.Size = new System.Drawing.Size(112, 22);
            this.SRNo.TabIndex = 18;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox13.Location = new System.Drawing.Point(392, 328);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(45, 18);
            this.textBox13.TabIndex = 17;
            this.textBox13.Text = "SRNo:";
            // 
            // BuyerAccount
            // 
            this.BuyerAccount.Location = new System.Drawing.Point(499, 191);
            this.BuyerAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyerAccount.Name = "BuyerAccount";
            this.BuyerAccount.Size = new System.Drawing.Size(165, 22);
            this.BuyerAccount.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox11.Location = new System.Drawing.Point(392, 191);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 18);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "Buyer Account:";
            // 
            // BillingAddress
            // 
            this.BillingAddress.Location = new System.Drawing.Point(511, 54);
            this.BillingAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BillingAddress.Name = "BillingAddress";
            this.BillingAddress.Size = new System.Drawing.Size(332, 90);
            this.BillingAddress.TabIndex = 14;
            this.BillingAddress.Text = "";
            // 
            // BuyerName
            // 
            this.BuyerName.Location = new System.Drawing.Point(482, 262);
            this.BuyerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(157, 22);
            this.BuyerName.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox9.Location = new System.Drawing.Point(392, 54);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(113, 18);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "Billing Address:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox8.Location = new System.Drawing.Point(392, 262);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(84, 18);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Buyer Name:";
            // 
            // EffectiveDate
            // 
            this.EffectiveDate.Location = new System.Drawing.Point(134, 330);
            this.EffectiveDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EffectiveDate.Name = "EffectiveDate";
            this.EffectiveDate.Size = new System.Drawing.Size(132, 22);
            this.EffectiveDate.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(18, 334);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(110, 18);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Effective Date:";
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(134, 264);
            this.CreationDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(132, 22);
            this.CreationDate.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox7.Location = new System.Drawing.Point(18, 268);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(110, 18);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Creation Date:";
            // 
            // SupplierNo
            // 
            this.SupplierNo.Location = new System.Drawing.Point(117, 122);
            this.SupplierNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SupplierNo.Name = "SupplierNo";
            this.SupplierNo.Size = new System.Drawing.Size(116, 22);
            this.SupplierNo.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(18, 126);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(93, 18);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "SupplierNo:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(18, 54);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(58, 18);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "PPONo:";
            // 
            // PPONo
            // 
            this.PPONo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPONo.Location = new System.Drawing.Point(82, 54);
            this.PPONo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PPONo.Name = "PPONo";
            this.PPONo.ReadOnly = true;
            this.PPONo.Size = new System.Drawing.Size(116, 15);
            this.PPONo.TabIndex = 0;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.back.Location = new System.Drawing.Point(795, 711);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(181, 42);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.submit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submit.Location = new System.Drawing.Point(567, 711);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(181, 42);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // PPOEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 772);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "PPOEdit";
            this.Text = "PPOEdit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox PurchaseOrderRevision;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.RichTextBox TAC;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox SRNo;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox BuyerAccount;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.RichTextBox BillingAddress;
        private System.Windows.Forms.TextBox BuyerName;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker EffectiveDate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox SupplierNo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox PPONo;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button submit;
    }
}