namespace ProcurementSystem
{
    partial class ScheduleRelease
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
            this.effectiveDate = new System.Windows.Forms.DateTimePicker();
            this.creationDate = new System.Windows.Forms.DateTimePicker();
            this.shippingAddress = new System.Windows.Forms.RichTextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.requestNo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SRNo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Scheduled Release";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.effectiveDate);
            this.groupBox1.Controls.Add(this.creationDate);
            this.groupBox1.Controls.Add(this.shippingAddress);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.requestNo);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.SRNo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release Setting";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // effectiveDate
            // 
            this.effectiveDate.Location = new System.Drawing.Point(138, 139);
            this.effectiveDate.Name = "effectiveDate";
            this.effectiveDate.Size = new System.Drawing.Size(122, 22);
            this.effectiveDate.TabIndex = 9;
            // 
            // creationDate
            // 
            this.creationDate.Location = new System.Drawing.Point(138, 101);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(122, 22);
            this.creationDate.TabIndex = 8;
            // 
            // shippingAddress
            // 
            this.shippingAddress.Location = new System.Drawing.Point(309, 55);
            this.shippingAddress.Name = "shippingAddress";
            this.shippingAddress.Size = new System.Drawing.Size(388, 137);
            this.shippingAddress.TabIndex = 7;
            this.shippingAddress.Text = "";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(309, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(114, 18);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Shipping Address:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox5.Location = new System.Drawing.Point(36, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(95, 18);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Effective Date:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(36, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(95, 18);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Creation Date:";
            // 
            // requestNo
            // 
            this.requestNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.requestNo.Location = new System.Drawing.Point(119, 66);
            this.requestNo.Name = "requestNo";
            this.requestNo.ReadOnly = true;
            this.requestNo.Size = new System.Drawing.Size(87, 18);
            this.requestNo.TabIndex = 3;
            this.requestNo.TextChanged += new System.EventHandler(this.requestNo_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(36, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(77, 18);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "RequestNo:";
            // 
            // SRNo
            // 
            this.SRNo.FormattingEnabled = true;
            this.SRNo.Location = new System.Drawing.Point(85, 30);
            this.SRNo.Name = "SRNo";
            this.SRNo.Size = new System.Drawing.Size(121, 20);
            this.SRNo.TabIndex = 1;
            this.SRNo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(36, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(43, 18);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "SRNo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(384, 298);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(132, 42);
            this.confirm.TabIndex = 5;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ScheduleRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 352);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "ScheduleRelease";
            this.Text = "ScheduleRelease";
            this.Load += new System.EventHandler(this.ScheduleRelease_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox SRNo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox requestNo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RichTextBox shippingAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.DateTimePicker effectiveDate;
        private System.Windows.Forms.DateTimePicker creationDate;
    }
}