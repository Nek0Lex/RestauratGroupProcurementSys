﻿namespace ProcurementSystem
{
    partial class EditPurchaseRequest
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
            this.deleteItem = new System.Windows.Forms.Button();
            this.purchaseList = new System.Windows.Forms.CheckedListBox();
            this.qtn = new System.Windows.Forms.TextBox();
            this.txtQtn = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.CreateDate = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.Label();
            this.StfName = new System.Windows.Forms.Label();
            this.StfId = new System.Windows.Forms.Label();
            this.RestId = new System.Windows.Forms.Label();
            this.RestName = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.Label();
            this.txtStfName = new System.Windows.Forms.Label();
            this.txtRestId = new System.Windows.Forms.Label();
            this.txtRestName = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteItem
            // 
            this.deleteItem.Font = new System.Drawing.Font("新細明體", 11F);
            this.deleteItem.Location = new System.Drawing.Point(574, 254);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(75, 23);
            this.deleteItem.TabIndex = 40;
            this.deleteItem.Text = "Delete";
            this.deleteItem.UseVisualStyleBackColor = true;
            // 
            // purchaseList
            // 
            this.purchaseList.Font = new System.Drawing.Font("新細明體", 14.25F);
            this.purchaseList.FormattingEnabled = true;
            this.purchaseList.HorizontalScrollbar = true;
            this.purchaseList.Items.AddRange(new object[] {
            "Item : Fishball Quantity : 5",
            "Item : Curry Sauce Quantity : 7"});
            this.purchaseList.Location = new System.Drawing.Point(142, 148);
            this.purchaseList.Name = "purchaseList";
            this.purchaseList.Size = new System.Drawing.Size(426, 129);
            this.purchaseList.TabIndex = 39;
            // 
            // qtn
            // 
            this.qtn.Font = new System.Drawing.Font("新細明體", 13F);
            this.qtn.Location = new System.Drawing.Point(441, 334);
            this.qtn.Name = "qtn";
            this.qtn.Size = new System.Drawing.Size(112, 28);
            this.qtn.TabIndex = 38;
            // 
            // txtQtn
            // 
            this.txtQtn.AutoSize = true;
            this.txtQtn.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtQtn.Location = new System.Drawing.Point(358, 337);
            this.txtQtn.Name = "txtQtn";
            this.txtQtn.Size = new System.Drawing.Size(77, 18);
            this.txtQtn.TabIndex = 37;
            this.txtQtn.Text = "Quantity :";
            // 
            // txtItem
            // 
            this.txtItem.AutoSize = true;
            this.txtItem.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtItem.Location = new System.Drawing.Point(137, 337);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(50, 18);
            this.txtItem.TabIndex = 36;
            this.txtItem.Text = "Item :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 11F);
            this.btnAdd.Location = new System.Drawing.Point(578, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // itemList
            // 
            this.itemList.Font = new System.Drawing.Font("新細明體", 11F);
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(193, 336);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(136, 23);
            this.itemList.TabIndex = 34;
            this.itemList.Text = "item";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 11F);
            this.btnCancel.Location = new System.Drawing.Point(707, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("新細明體", 11F);
            this.btnEdit.Location = new System.Drawing.Point(626, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // CreateDate
            // 
            this.CreateDate.AutoSize = true;
            this.CreateDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateDate.Location = new System.Drawing.Point(262, 119);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(81, 19);
            this.CreateDate.TabIndex = 31;
            this.CreateDate.Text = "//sysdate";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.AutoSize = true;
            this.txtCreateDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCreateDate.Location = new System.Drawing.Point(138, 119);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(118, 19);
            this.txtCreateDate.TabIndex = 30;
            this.txtCreateDate.Text = "Create Date :";
            // 
            // StfName
            // 
            this.StfName.AutoSize = true;
            this.StfName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.StfName.Location = new System.Drawing.Point(600, 81);
            this.StfName.Name = "StfName";
            this.StfName.Size = new System.Drawing.Size(101, 19);
            this.StfName.TabIndex = 29;
            this.StfName.Text = "//staffname";
            // 
            // StfId
            // 
            this.StfId.AutoSize = true;
            this.StfId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.StfId.Location = new System.Drawing.Point(574, 100);
            this.StfId.Name = "StfId";
            this.StfId.Size = new System.Drawing.Size(79, 19);
            this.StfId.TabIndex = 28;
            this.StfId.Text = "//staffID";
            // 
            // RestId
            // 
            this.RestId.AutoSize = true;
            this.RestId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestId.Location = new System.Drawing.Point(279, 100);
            this.RestId.Name = "RestId";
            this.RestId.Size = new System.Drawing.Size(72, 19);
            this.RestId.TabIndex = 27;
            this.RestId.Text = "//restID";
            // 
            // RestName
            // 
            this.RestName.AutoSize = true;
            this.RestName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestName.Location = new System.Drawing.Point(305, 81);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(94, 19);
            this.RestName.TabIndex = 26;
            this.RestName.Text = "//restname";
            // 
            // txtStaffId
            // 
            this.txtStaffId.AutoSize = true;
            this.txtStaffId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffId.Location = new System.Drawing.Point(480, 100);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(88, 19);
            this.txtStaffId.TabIndex = 25;
            this.txtStaffId.Text = "Staff ID :";
            // 
            // txtStfName
            // 
            this.txtStfName.AutoSize = true;
            this.txtStfName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStfName.Location = new System.Drawing.Point(480, 81);
            this.txtStfName.Name = "txtStfName";
            this.txtStfName.Size = new System.Drawing.Size(114, 19);
            this.txtStfName.TabIndex = 24;
            this.txtStfName.Text = "Staff Name :";
            // 
            // txtRestId
            // 
            this.txtRestId.AutoSize = true;
            this.txtRestId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRestId.Location = new System.Drawing.Point(138, 100);
            this.txtRestId.Name = "txtRestId";
            this.txtRestId.Size = new System.Drawing.Size(135, 19);
            this.txtRestId.TabIndex = 23;
            this.txtRestId.Text = "Restaurant ID :";
            // 
            // txtRestName
            // 
            this.txtRestName.AutoSize = true;
            this.txtRestName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRestName.Location = new System.Drawing.Point(138, 81);
            this.txtRestName.Name = "txtRestName";
            this.txtRestName.Size = new System.Drawing.Size(161, 19);
            this.txtRestName.TabIndex = 22;
            this.txtRestName.Text = "Restaurant Name :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(194, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(374, 37);
            this.title.TabIndex = 21;
            this.title.Text = "Purchase Request pr001";
            // 
            // EditPurchaseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.purchaseList);
            this.Controls.Add(this.qtn);
            this.Controls.Add(this.txtQtn);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.CreateDate);
            this.Controls.Add(this.txtCreateDate);
            this.Controls.Add(this.StfName);
            this.Controls.Add(this.StfId);
            this.Controls.Add(this.RestId);
            this.Controls.Add(this.RestName);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.txtStfName);
            this.Controls.Add(this.txtRestId);
            this.Controls.Add(this.txtRestName);
            this.Controls.Add(this.title);
            this.Name = "EditPurchaseRequest";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.CheckedListBox purchaseList;
        private System.Windows.Forms.TextBox qtn;
        private System.Windows.Forms.Label txtQtn;
        private System.Windows.Forms.Label txtItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox itemList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label CreateDate;
        private System.Windows.Forms.Label txtCreateDate;
        private System.Windows.Forms.Label StfName;
        private System.Windows.Forms.Label StfId;
        private System.Windows.Forms.Label RestId;
        private System.Windows.Forms.Label RestName;
        private System.Windows.Forms.Label txtStaffId;
        private System.Windows.Forms.Label txtStfName;
        private System.Windows.Forms.Label txtRestId;
        private System.Windows.Forms.Label txtRestName;
        private System.Windows.Forms.Label title;
    }
}