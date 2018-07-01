namespace ProcurementSystem
{
    partial class ScheduleReleaseAdd
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
            this.SRNo = new System.Windows.Forms.TextBox();
            this.effectiveDate = new System.Windows.Forms.DateTimePicker();
            this.creationDate = new System.Windows.Forms.DateTimePicker();
            this.shippingAddress = new System.Windows.Forms.RichTextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
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
            this.textBox1.Size = new System.Drawing.Size(733, 43);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Create Scheduled Release";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SRNo);
            this.groupBox1.Controls.Add(this.effectiveDate);
            this.groupBox1.Controls.Add(this.creationDate);
            this.groupBox1.Controls.Add(this.shippingAddress);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Release Setting";
            // 
            // SRNo
            // 
            this.SRNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SRNo.Location = new System.Drawing.Point(85, 27);
            this.SRNo.Name = "SRNo";
            this.SRNo.ReadOnly = true;
            this.SRNo.Size = new System.Drawing.Size(105, 25);
            this.SRNo.TabIndex = 10;
            // 
            // effectiveDate
            // 
            this.effectiveDate.Location = new System.Drawing.Point(137, 116);
            this.effectiveDate.Name = "effectiveDate";
            this.effectiveDate.Size = new System.Drawing.Size(122, 22);
            this.effectiveDate.TabIndex = 9;
            // 
            // creationDate
            // 
            this.creationDate.Location = new System.Drawing.Point(137, 70);
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
            this.textBox5.Location = new System.Drawing.Point(36, 120);
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
            this.textBox4.Location = new System.Drawing.Point(36, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(95, 18);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Creation Date:";
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
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_create.Location = new System.Drawing.Point(413, 300);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(129, 40);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(188, 300);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 40);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ScheduleReleaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 367);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "ScheduleReleaseAdd";
            this.Text = "ScheduleReleaseAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SRNo;
        private System.Windows.Forms.DateTimePicker effectiveDate;
        private System.Windows.Forms.DateTimePicker creationDate;
        private System.Windows.Forms.RichTextBox shippingAddress;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
    }
}