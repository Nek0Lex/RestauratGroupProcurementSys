namespace ProcurementSystem
{
    partial class StockManagement
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
            this.textBox_StockID = new System.Windows.Forms.TextBox();
            this.textBox_ItemID = new System.Windows.Forms.TextBox();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label_StockID = new System.Windows.Forms.Label();
            this.label_ItemID = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_Location = new System.Windows.Forms.Label();
            this.label_Owner = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.textBox_Owner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_StockID
            // 
            this.textBox_StockID.Location = new System.Drawing.Point(109, 24);
            this.textBox_StockID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_StockID.Name = "textBox_StockID";
            this.textBox_StockID.Size = new System.Drawing.Size(92, 22);
            this.textBox_StockID.TabIndex = 1;
            // 
            // textBox_ItemID
            // 
            this.textBox_ItemID.Location = new System.Drawing.Point(109, 95);
            this.textBox_ItemID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ItemID.Name = "textBox_ItemID";
            this.textBox_ItemID.Size = new System.Drawing.Size(92, 22);
            this.textBox_ItemID.TabIndex = 2;
            // 
            // textBox_Location
            // 
            this.textBox_Location.Location = new System.Drawing.Point(391, 95);
            this.textBox_Location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.Size = new System.Drawing.Size(91, 22);
            this.textBox_Location.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(195, 307);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 42);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 307);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label_StockID
            // 
            this.label_StockID.AutoSize = true;
            this.label_StockID.Location = new System.Drawing.Point(26, 31);
            this.label_StockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StockID.Name = "label_StockID";
            this.label_StockID.Size = new System.Drawing.Size(43, 12);
            this.label_StockID.TabIndex = 8;
            this.label_StockID.Text = "StockID";
            // 
            // label_ItemID
            // 
            this.label_ItemID.AutoSize = true;
            this.label_ItemID.Location = new System.Drawing.Point(26, 103);
            this.label_ItemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemID.Name = "label_ItemID";
            this.label_ItemID.Size = new System.Drawing.Size(38, 12);
            this.label_ItemID.TabIndex = 9;
            this.label_ItemID.Text = "ItemID";
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(297, 24);
            this.label_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(45, 12);
            this.label_Quantity.TabIndex = 11;
            this.label_Quantity.Text = "Quantity";
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Location = new System.Drawing.Point(302, 103);
            this.label_Location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(46, 12);
            this.label_Location.TabIndex = 12;
            this.label_Location.Text = "Location";
            // 
            // label_Owner
            // 
            this.label_Owner.AutoSize = true;
            this.label_Owner.Location = new System.Drawing.Point(302, 173);
            this.label_Owner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(36, 12);
            this.label_Owner.TabIndex = 13;
            this.label_Owner.Text = "Owner";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(390, 24);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(92, 22);
            this.textBox_Quantity.TabIndex = 14;
            // 
            // textBox_Owner
            // 
            this.textBox_Owner.Location = new System.Drawing.Point(391, 173);
            this.textBox_Owner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Owner.Name = "textBox_Owner";
            this.textBox_Owner.Size = new System.Drawing.Size(91, 22);
            this.textBox_Owner.TabIndex = 15;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.textBox_Owner);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_ItemID);
            this.Controls.Add(this.label_StockID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox_Location);
            this.Controls.Add(this.textBox_ItemID);
            this.Controls.Add(this.textBox_StockID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_StockID;
        private System.Windows.Forms.TextBox textBox_ItemID;
        private System.Windows.Forms.TextBox textBox_Location;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label_StockID;
        private System.Windows.Forms.Label label_ItemID;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.TextBox textBox_Owner;
    }
}