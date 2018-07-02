namespace ProcurementSystem
{
    partial class ItemManagement
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
            this.textBox_ItemID = new System.Windows.Forms.TextBox();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.textBox_ItemDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label_ItemID = new System.Windows.Forms.Label();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_ItemDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ItemID
            // 
            this.textBox_ItemID.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_ItemID.Location = new System.Drawing.Point(186, 45);
            this.textBox_ItemID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ItemID.Name = "textBox_ItemID";
            this.textBox_ItemID.Size = new System.Drawing.Size(195, 27);
            this.textBox_ItemID.TabIndex = 0;
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_ItemName.Location = new System.Drawing.Point(186, 103);
            this.textBox_ItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(269, 27);
            this.textBox_ItemName.TabIndex = 1;
            // 
            // textBox_ItemDescription
            // 
            this.textBox_ItemDescription.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_ItemDescription.Location = new System.Drawing.Point(186, 174);
            this.textBox_ItemDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ItemDescription.Name = "textBox_ItemDescription";
            this.textBox_ItemDescription.Size = new System.Drawing.Size(405, 27);
            this.textBox_ItemDescription.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(186, 249);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 42);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 249);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label_ItemID
            // 
            this.label_ItemID.AutoSize = true;
            this.label_ItemID.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_ItemID.Location = new System.Drawing.Point(53, 48);
            this.label_ItemID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemID.Name = "label_ItemID";
            this.label_ItemID.Size = new System.Drawing.Size(52, 16);
            this.label_ItemID.TabIndex = 5;
            this.label_ItemID.Text = "ItemID";
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_ItemName.Location = new System.Drawing.Point(53, 114);
            this.label_ItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(73, 16);
            this.label_ItemName.TabIndex = 6;
            this.label_ItemName.Text = "ItemName";
            // 
            // label_ItemDescription
            // 
            this.label_ItemDescription.AutoSize = true;
            this.label_ItemDescription.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_ItemDescription.Location = new System.Drawing.Point(53, 177);
            this.label_ItemDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ItemDescription.Name = "label_ItemDescription";
            this.label_ItemDescription.Size = new System.Drawing.Size(108, 16);
            this.label_ItemDescription.TabIndex = 7;
            this.label_ItemDescription.Text = "ItemDescription";
            // 
            // ItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 312);
            this.Controls.Add(this.label_ItemDescription);
            this.Controls.Add(this.label_ItemName);
            this.Controls.Add(this.label_ItemID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox_ItemDescription);
            this.Controls.Add(this.textBox_ItemName);
            this.Controls.Add(this.textBox_ItemID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemManagement";
            this.Text = "ItemManagement";
            this.Load += new System.EventHandler(this.ItemManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ItemID;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.TextBox textBox_ItemDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label_ItemID;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_ItemDescription;
    }
}