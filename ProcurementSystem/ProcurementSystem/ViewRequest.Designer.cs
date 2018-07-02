namespace ProcurementSystem
{
    partial class ViewRequest
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
            this.purchaseList2 = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtStatus = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseList2)).BeginInit();
            this.SuspendLayout();
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
            this.purchaseList2.Location = new System.Drawing.Point(116, 158);
            this.purchaseList2.Name = "purchaseList2";
            this.purchaseList2.ReadOnly = true;
            this.purchaseList2.RowTemplate.Height = 24;
            this.purchaseList2.Size = new System.Drawing.Size(538, 187);
            this.purchaseList2.TabIndex = 53;
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
            // CreateDate
            // 
            this.CreateDate.AutoSize = true;
            this.CreateDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateDate.Location = new System.Drawing.Point(136, 115);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(81, 19);
            this.CreateDate.TabIndex = 52;
            this.CreateDate.Text = "//sysdate";
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.AutoSize = true;
            this.txtCreateDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCreateDate.Location = new System.Drawing.Point(12, 115);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(118, 19);
            this.txtCreateDate.TabIndex = 51;
            this.txtCreateDate.Text = "Create Date :";
            // 
            // StfName
            // 
            this.StfName.AutoSize = true;
            this.StfName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.StfName.Location = new System.Drawing.Point(618, 77);
            this.StfName.Name = "StfName";
            this.StfName.Size = new System.Drawing.Size(101, 19);
            this.StfName.TabIndex = 50;
            this.StfName.Text = "//staffname";
            // 
            // StfId
            // 
            this.StfId.AutoSize = true;
            this.StfId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.StfId.Location = new System.Drawing.Point(592, 96);
            this.StfId.Name = "StfId";
            this.StfId.Size = new System.Drawing.Size(79, 19);
            this.StfId.TabIndex = 49;
            this.StfId.Text = "//staffID";
            // 
            // RestId
            // 
            this.RestId.AutoSize = true;
            this.RestId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestId.Location = new System.Drawing.Point(153, 96);
            this.RestId.Name = "RestId";
            this.RestId.Size = new System.Drawing.Size(72, 19);
            this.RestId.TabIndex = 48;
            this.RestId.Text = "//restID";
            // 
            // RestName
            // 
            this.RestName.AutoSize = true;
            this.RestName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestName.Location = new System.Drawing.Point(179, 77);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(94, 19);
            this.RestName.TabIndex = 47;
            this.RestName.Text = "//restname";
            // 
            // txtStaffId
            // 
            this.txtStaffId.AutoSize = true;
            this.txtStaffId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStaffId.Location = new System.Drawing.Point(498, 96);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(88, 19);
            this.txtStaffId.TabIndex = 46;
            this.txtStaffId.Text = "Staff ID :";
            // 
            // txtStfName
            // 
            this.txtStfName.AutoSize = true;
            this.txtStfName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStfName.Location = new System.Drawing.Point(498, 77);
            this.txtStfName.Name = "txtStfName";
            this.txtStfName.Size = new System.Drawing.Size(114, 19);
            this.txtStfName.TabIndex = 45;
            this.txtStfName.Text = "Staff Name :";
            // 
            // txtRestId
            // 
            this.txtRestId.AutoSize = true;
            this.txtRestId.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRestId.Location = new System.Drawing.Point(12, 96);
            this.txtRestId.Name = "txtRestId";
            this.txtRestId.Size = new System.Drawing.Size(135, 19);
            this.txtRestId.TabIndex = 44;
            this.txtRestId.Text = "Restaurant ID :";
            // 
            // txtRestName
            // 
            this.txtRestName.AutoSize = true;
            this.txtRestName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRestName.Location = new System.Drawing.Point(12, 77);
            this.txtRestName.Name = "txtRestName";
            this.txtRestName.Size = new System.Drawing.Size(161, 19);
            this.txtRestName.TabIndex = 43;
            this.txtRestName.Text = "Restaurant Name :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(176, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(374, 37);
            this.title.TabIndex = 42;
            this.title.Text = "Purchase Request pr001";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStatus.Location = new System.Drawing.Point(498, 115);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(71, 19);
            this.txtStatus.TabIndex = 54;
            this.txtStatus.Text = "Status :";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold);
            this.status.Location = new System.Drawing.Point(575, 115);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(68, 19);
            this.status.TabIndex = 55;
            this.status.Text = "//status";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(607, 396);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(181, 42);
            this.backbtn.TabIndex = 56;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // ViewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.purchaseList2);
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
            this.Name = "ViewRequest";
            this.Text = "ViewRequest";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchaseList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn VItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
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
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button backbtn;
    }
}