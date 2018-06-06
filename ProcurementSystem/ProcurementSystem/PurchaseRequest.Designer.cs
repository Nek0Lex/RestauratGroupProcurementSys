namespace ProcurementSystem
{
    partial class PurchaseRequest
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.errorEditMsg = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Request List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // purchaseRequestList
            // 
            this.purchaseRequestList.Cursor = System.Windows.Forms.Cursors.Default;
            this.purchaseRequestList.Font = new System.Drawing.Font("新細明體", 11F);
            this.purchaseRequestList.FormattingEnabled = true;
            this.purchaseRequestList.HorizontalScrollbar = true;
            this.purchaseRequestList.Location = new System.Drawing.Point(19, 68);
            this.purchaseRequestList.Name = "purchaseRequestList";
            this.purchaseRequestList.Size = new System.Drawing.Size(490, 344);
            this.purchaseRequestList.TabIndex = 1;
            this.purchaseRequestList.SelectedIndexChanged += new System.EventHandler(this.purchaseRequestList_SelectedIndexChanged);
            // 
            // createPRbtn
            // 
            this.createPRbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.createPRbtn.Location = new System.Drawing.Point(535, 68);
            this.createPRbtn.Name = "createPRbtn";
            this.createPRbtn.Size = new System.Drawing.Size(197, 26);
            this.createPRbtn.TabIndex = 2;
            this.createPRbtn.Text = "Create Purchase Request";
            this.createPRbtn.UseVisualStyleBackColor = true;
            this.createPRbtn.Click += new System.EventHandler(this.createPRbtn_Click_1);
            // 
            // edditPRbtn
            // 
            this.edditPRbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.edditPRbtn.Location = new System.Drawing.Point(535, 147);
            this.edditPRbtn.Name = "edditPRbtn";
            this.edditPRbtn.Size = new System.Drawing.Size(197, 26);
            this.edditPRbtn.TabIndex = 3;
            this.edditPRbtn.Text = "Edit Purchase Request";
            this.edditPRbtn.UseVisualStyleBackColor = true;
            this.edditPRbtn.Click += new System.EventHandler(this.edditPRbtn_Click);
            // 
            // deletePRbtn
            // 
            this.deletePRbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.deletePRbtn.Location = new System.Drawing.Point(535, 228);
            this.deletePRbtn.Name = "deletePRbtn";
            this.deletePRbtn.Size = new System.Drawing.Size(197, 26);
            this.deletePRbtn.TabIndex = 4;
            this.deletePRbtn.Text = "Delete Purchase Request";
            this.deletePRbtn.UseVisualStyleBackColor = true;
            this.deletePRbtn.Click += new System.EventHandler(this.deletePRbtn_Click);
            // 
            // prBack
            // 
            this.prBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.prBack.Location = new System.Drawing.Point(535, 336);
            this.prBack.Name = "prBack";
            this.prBack.Size = new System.Drawing.Size(197, 25);
            this.prBack.TabIndex = 5;
            this.prBack.Text = "Back";
            this.prBack.UseVisualStyleBackColor = true;
            this.prBack.Click += new System.EventHandler(this.prBack_Click);
            // 
            // textSearch
            // 
            this.textSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.textSearch.Location = new System.Drawing.Point(535, 287);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(123, 22);
            this.textSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Location = new System.Drawing.Point(664, 287);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(533, 257);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 12);
            this.errorMsg.TabIndex = 8;
            // 
            // errorEditMsg
            // 
            this.errorEditMsg.AutoSize = true;
            this.errorEditMsg.ForeColor = System.Drawing.Color.Red;
            this.errorEditMsg.Location = new System.Drawing.Point(533, 176);
            this.errorEditMsg.Name = "errorEditMsg";
            this.errorEditMsg.Size = new System.Drawing.Size(0, 12);
            this.errorEditMsg.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(535, 389);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PurchaseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.errorEditMsg);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.prBack);
            this.Controls.Add(this.deletePRbtn);
            this.Controls.Add(this.edditPRbtn);
            this.Controls.Add(this.createPRbtn);
            this.Controls.Add(this.purchaseRequestList);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseRequest";
            this.Text = "Purchase Request";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label errorEditMsg;
        private System.Windows.Forms.Button btnRefresh;
    }
}