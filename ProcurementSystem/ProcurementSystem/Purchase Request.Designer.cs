﻿namespace ProcurementSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseRequestList = new System.Windows.Forms.CheckedListBox();
            this.createPRbtn = new System.Windows.Forms.Button();
            this.edditPRbtn = new System.Windows.Forms.Button();
            this.deletePRbtn = new System.Windows.Forms.Button();
            this.prBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Request";
            // 
            // purchaseRequestList
            // 
            this.purchaseRequestList.Font = new System.Drawing.Font("新細明體", 11F);
            this.purchaseRequestList.FormattingEnabled = true;
            this.purchaseRequestList.HorizontalScrollbar = true;
            this.purchaseRequestList.Items.AddRange(new object[] {
            "Purchase Reuqest pr001",
            "Purchase Request pr002",
            "Purchase Request pr003"});
            this.purchaseRequestList.Location = new System.Drawing.Point(19, 68);
            this.purchaseRequestList.Name = "purchaseRequestList";
            this.purchaseRequestList.Size = new System.Drawing.Size(490, 344);
            this.purchaseRequestList.TabIndex = 1;
            // 
            // createPRbtn
            // 
            this.createPRbtn.Location = new System.Drawing.Point(535, 68);
            this.createPRbtn.Name = "createPRbtn";
            this.createPRbtn.Size = new System.Drawing.Size(197, 26);
            this.createPRbtn.TabIndex = 2;
            this.createPRbtn.Text = "Create Purchase Request";
            this.createPRbtn.UseVisualStyleBackColor = true;
            // 
            // edditPRbtn
            // 
            this.edditPRbtn.Location = new System.Drawing.Point(535, 147);
            this.edditPRbtn.Name = "edditPRbtn";
            this.edditPRbtn.Size = new System.Drawing.Size(197, 26);
            this.edditPRbtn.TabIndex = 3;
            this.edditPRbtn.Text = "Edit Purchase Request";
            this.edditPRbtn.UseVisualStyleBackColor = true;
            // 
            // deletePRbtn
            // 
            this.deletePRbtn.Location = new System.Drawing.Point(535, 228);
            this.deletePRbtn.Name = "deletePRbtn";
            this.deletePRbtn.Size = new System.Drawing.Size(197, 26);
            this.deletePRbtn.TabIndex = 4;
            this.deletePRbtn.Text = "Delete Purchase Request";
            this.deletePRbtn.UseVisualStyleBackColor = true;
            // 
            // prBack
            // 
            this.prBack.Location = new System.Drawing.Point(535, 387);
            this.prBack.Name = "prBack";
            this.prBack.Size = new System.Drawing.Size(197, 25);
            this.prBack.TabIndex = 5;
            this.prBack.Text = "Back";
            this.prBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prBack);
            this.Controls.Add(this.deletePRbtn);
            this.Controls.Add(this.edditPRbtn);
            this.Controls.Add(this.createPRbtn);
            this.Controls.Add(this.purchaseRequestList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Purchase Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox purchaseRequestList;
        private System.Windows.Forms.Button createPRbtn;
        private System.Windows.Forms.Button edditPRbtn;
        private System.Windows.Forms.Button deletePRbtn;
        private System.Windows.Forms.Button prBack;
    }
}