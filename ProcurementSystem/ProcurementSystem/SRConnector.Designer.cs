namespace ProcurementSystem
{
    partial class SRConnector
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
            this.pposelection = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_openSR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pposelection
            // 
            this.pposelection.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pposelection.FormattingEnabled = true;
            this.pposelection.Location = new System.Drawing.Point(99, 45);
            this.pposelection.Name = "pposelection";
            this.pposelection.Size = new System.Drawing.Size(128, 25);
            this.pposelection.TabIndex = 0;
            this.pposelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(39, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 18);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "PPONo:";
            // 
            // btn_openSR
            // 
            this.btn_openSR.Location = new System.Drawing.Point(88, 87);
            this.btn_openSR.Name = "btn_openSR";
            this.btn_openSR.Size = new System.Drawing.Size(101, 33);
            this.btn_openSR.TabIndex = 2;
            this.btn_openSR.Text = "Open SR";
            this.btn_openSR.UseVisualStyleBackColor = true;
            this.btn_openSR.Click += new System.EventHandler(this.btn_openSR_Click);
            // 
            // SRConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 132);
            this.Controls.Add(this.btn_openSR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pposelection);
            this.Name = "SRConnector";
            this.Text = "SRConnector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pposelection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_openSR;
    }
}