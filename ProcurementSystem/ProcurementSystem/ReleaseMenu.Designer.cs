namespace ProcurementSystem
{
    partial class ReleaseMenu
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
            this.BPRForward = new System.Windows.Forms.Button();
            this.SRForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPRForward
            // 
            this.BPRForward.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPRForward.Location = new System.Drawing.Point(42, 22);
            this.BPRForward.Name = "BPRForward";
            this.BPRForward.Size = new System.Drawing.Size(237, 36);
            this.BPRForward.TabIndex = 0;
            this.BPRForward.Text = "Blanket Purchase Release";
            this.BPRForward.UseVisualStyleBackColor = true;
            this.BPRForward.Click += new System.EventHandler(this.BPRForward_Click);
            // 
            // SRForward
            // 
            this.SRForward.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SRForward.Location = new System.Drawing.Point(42, 83);
            this.SRForward.Name = "SRForward";
            this.SRForward.Size = new System.Drawing.Size(237, 36);
            this.SRForward.TabIndex = 1;
            this.SRForward.Text = "Schedule Release";
            this.SRForward.UseVisualStyleBackColor = true;
            this.SRForward.Click += new System.EventHandler(this.SRForward_Click);
            // 
            // ReleaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 150);
            this.Controls.Add(this.SRForward);
            this.Controls.Add(this.BPRForward);
            this.Name = "ReleaseMenu";
            this.Text = "ReleaseMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPRForward;
        private System.Windows.Forms.Button SRForward;
    }
}