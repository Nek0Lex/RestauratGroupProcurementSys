﻿namespace ProcurementSystem
{
    partial class CreatePurchaseRequest
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
            this.title = new System.Windows.Forms.Label();
            this.txtRestName = new System.Windows.Forms.Label();
            this.txtRestId = new System.Windows.Forms.Label();
            this.txtStfName = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.Label();
            this.RestName = new System.Windows.Forms.Label();
            this.RestId = new System.Windows.Forms.Label();
            this.StfId = new System.Windows.Forms.Label();
            this.StfName = new System.Windows.Forms.Label();
            this.txtCreateDate = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.Label();
            this.txtQtn = new System.Windows.Forms.Label();
            this.qtn = new System.Windows.Forms.TextBox();
            this.deleteItem = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.purchaseList2 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseList2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(185, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(385, 37);
            this.title.TabIndex = 0;
            this.title.Text = "Create Purchase Request";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // txtRestName
            // 
            this.txtRestName.AutoSize = true;
            this.txtRestName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRestName.Location = new System.Drawing.Point(12, 81);
            this.txtRestName.Name = "txtRestName";
            this.txtRestName.Size = new System.Drawing.Size(161, 19);
            this.txtRestName.TabIndex = 1;
            this.txtRestName.Text = "Restaurant Name :";
            // 
            // txtRestId
            // 
            this.txtRestId.AutoSize = true;
            this.txtRestId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRestId.Location = new System.Drawing.Point(12, 100);
            this.txtRestId.Name = "txtRestId";
            this.txtRestId.Size = new System.Drawing.Size(135, 19);
            this.txtRestId.TabIndex = 2;
            this.txtRestId.Text = "Restaurant ID :";
            this.txtRestId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStfName
            // 
            this.txtStfName.AutoSize = true;
            this.txtStfName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStfName.Location = new System.Drawing.Point(479, 81);
            this.txtStfName.Name = "txtStfName";
            this.txtStfName.Size = new System.Drawing.Size(114, 19);
            this.txtStfName.TabIndex = 3;
            this.txtStfName.Text = "Staff Name :";
            // 
            // txtStaffId
            // 
            this.txtStaffId.AutoSize = true;
            this.txtStaffId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffId.Location = new System.Drawing.Point(479, 100);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(88, 19);
            this.txtStaffId.TabIndex = 4;
            this.txtStaffId.Text = "Staff ID :";
            // 
            // RestName
            // 
            this.RestName.AutoSize = true;
            this.RestName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestName.Location = new System.Drawing.Point(179, 81);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(94, 19);
            this.RestName.TabIndex = 5;
            this.RestName.Text = "//restname";
            // 
            // RestId
            // 
            this.RestId.AutoSize = true;
            this.RestId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestId.Location = new System.Drawing.Point(153, 100);
            this.RestId.Name = "RestId";
            this.RestId.Size = new System.Drawing.Size(72, 19);
            this.RestId.TabIndex = 6;
            this.RestId.Text = "//restID";
            // 
            // StfId
            // 
            this.StfId.AutoSize = true;
            this.StfId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.StfId.Location = new System.Drawing.Point(573, 100);
            this.StfId.Name = "StfId";
            this.StfId.Size = new System.Drawing.Size(79, 19);
            this.StfId.TabIndex = 7;
            this.StfId.Text = "//staffID";
            // 
            // StfName
            // 
            this.StfName.AutoSize = true;
            this.StfName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.StfName.Location = new System.Drawing.Point(599, 81);
            this.StfName.Name = "StfName";
            this.StfName.Size = new System.Drawing.Size(101, 19);
            this.StfName.TabIndex = 8;
            this.StfName.Text = "//staffname";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.AutoSize = true;
            this.txtCreateDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCreateDate.Location = new System.Drawing.Point(12, 119);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(118, 19);
            this.txtCreateDate.TabIndex = 9;
            this.txtCreateDate.Text = "Create Date :";
            // 
            // CreateDate
            // 
            this.CreateDate.AutoSize = true;
            this.CreateDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateDate.Location = new System.Drawing.Point(136, 119);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(81, 19);
            this.CreateDate.TabIndex = 10;
            this.CreateDate.Text = "//sysdate";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("新細明體", 11F);
            this.btnCreate.Location = new System.Drawing.Point(376, 427);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(181, 42);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 11F);
            this.btnCancel.Location = new System.Drawing.Point(603, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 42);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // itemList
            // 
            this.itemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemList.Font = new System.Drawing.Font("新細明體", 11F);
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(192, 336);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(136, 23);
            this.itemList.TabIndex = 14;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 11F);
            this.btnAdd.Location = new System.Drawing.Point(577, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 42);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItem
            // 
            this.txtItem.AutoSize = true;
            this.txtItem.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtItem.Location = new System.Drawing.Point(136, 337);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(50, 18);
            this.txtItem.TabIndex = 16;
            this.txtItem.Text = "Item :";
            // 
            // txtQtn
            // 
            this.txtQtn.AutoSize = true;
            this.txtQtn.Font = new System.Drawing.Font("新細明體", 13F);
            this.txtQtn.Location = new System.Drawing.Point(357, 337);
            this.txtQtn.Name = "txtQtn";
            this.txtQtn.Size = new System.Drawing.Size(77, 18);
            this.txtQtn.TabIndex = 17;
            this.txtQtn.Text = "Quantity :";
            // 
            // qtn
            // 
            this.qtn.Font = new System.Drawing.Font("新細明體", 13F);
            this.qtn.Location = new System.Drawing.Point(440, 334);
            this.qtn.Name = "qtn";
            this.qtn.Size = new System.Drawing.Size(112, 28);
            this.qtn.TabIndex = 18;
            // 
            // deleteItem
            // 
            this.deleteItem.Font = new System.Drawing.Font("新細明體", 11F);
            this.deleteItem.Location = new System.Drawing.Point(577, 153);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(181, 42);
            this.deleteItem.TabIndex = 20;
            this.deleteItem.Text = "Delete";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("新細明體", 13F);
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(438, 367);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 18);
            this.errorMsg.TabIndex = 21;
            // 
            // purchaseList2
            // 
            this.purchaseList2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.purchaseList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemQuantity,
            this.VItemId,
            this.category_id});
            this.purchaseList2.Location = new System.Drawing.Point(139, 153);
            this.purchaseList2.Name = "purchaseList2";
            this.purchaseList2.ReadOnly = true;
            this.purchaseList2.RowTemplate.Height = 24;
            this.purchaseList2.Size = new System.Drawing.Size(418, 136);
            this.purchaseList2.TabIndex = 22;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "ItemQuantity";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            // 
            // VItemId
            // 
            this.VItemId.HeaderText = "VItemId";
            this.VItemId.Name = "VItemId";
            this.VItemId.ReadOnly = true;
            this.VItemId.Visible = false;
            // 
            // category_id
            // 
            this.category_id.HeaderText = "category_id";
            this.category_id.Name = "category_id";
            this.category_id.ReadOnly = true;
            this.category_id.Visible = false;
            // 
            // CreatePurchaseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.purchaseList2);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.qtn);
            this.Controls.Add(this.txtQtn);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
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
            this.Name = "CreatePurchaseRequest";
            this.Text = "Create_Purchase_Request";
            this.Load += new System.EventHandler(this.Create_Purchase_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label txtRestName;
        private System.Windows.Forms.Label txtRestId;
        private System.Windows.Forms.Label txtStfName;
        private System.Windows.Forms.Label txtStaffId;
        private System.Windows.Forms.Label RestName;
        private System.Windows.Forms.Label RestId;
        private System.Windows.Forms.Label StfId;
        private System.Windows.Forms.Label StfName;
        private System.Windows.Forms.Label txtCreateDate;
        private System.Windows.Forms.Label CreateDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox itemList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label txtItem;
        private System.Windows.Forms.Label txtQtn;
        private System.Windows.Forms.TextBox qtn;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.DataGridView purchaseList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn VItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
    }
}