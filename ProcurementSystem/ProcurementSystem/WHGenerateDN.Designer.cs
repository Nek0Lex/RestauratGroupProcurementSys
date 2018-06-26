namespace ProcurementSystem
{
    partial class WHGenerateDN
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
            this.dGVItem = new System.Windows.Forms.DataGridView();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.tbDID = new System.Windows.Forms.Label();
            this.lbRNo = new System.Windows.Forms.Label();
            this.tbDesId = new System.Windows.Forms.Label();
            this.lbArriveDate = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.lbMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delivery Note";
            // 
            // dGVItem
            // 
            this.dGVItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItem.Location = new System.Drawing.Point(22, 256);
            this.dGVItem.MultiSelect = false;
            this.dGVItem.Name = "dGVItem";
            this.dGVItem.ReadOnly = true;
            this.dGVItem.RowTemplate.Height = 24;
            this.dGVItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItem.Size = new System.Drawing.Size(515, 351);
            this.dGVItem.TabIndex = 14;
            this.dGVItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVItem_CellContentClick);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(13, 48);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 30);
            this.numQty.TabIndex = 15;
            // 
            // tbDID
            // 
            this.tbDID.AutoSize = true;
            this.tbDID.Location = new System.Drawing.Point(6, 34);
            this.tbDID.Name = "tbDID";
            this.tbDID.Size = new System.Drawing.Size(53, 19);
            this.tbDID.TabIndex = 16;
            this.tbDID.Text = "label2";
            // 
            // lbRNo
            // 
            this.lbRNo.AutoSize = true;
            this.lbRNo.Location = new System.Drawing.Point(6, 83);
            this.lbRNo.Name = "lbRNo";
            this.lbRNo.Size = new System.Drawing.Size(53, 19);
            this.lbRNo.TabIndex = 17;
            this.lbRNo.Text = "label2";
            // 
            // tbDesId
            // 
            this.tbDesId.AutoSize = true;
            this.tbDesId.Location = new System.Drawing.Point(6, 132);
            this.tbDesId.Name = "tbDesId";
            this.tbDesId.Size = new System.Drawing.Size(53, 19);
            this.tbDesId.TabIndex = 18;
            this.tbDesId.Text = "label2";
            // 
            // lbArriveDate
            // 
            this.lbArriveDate.AutoSize = true;
            this.lbArriveDate.Location = new System.Drawing.Point(371, 34);
            this.lbArriveDate.Name = "lbArriveDate";
            this.lbArriveDate.Size = new System.Drawing.Size(53, 19);
            this.lbArriveDate.TabIndex = 19;
            this.lbArriveDate.Text = "label2";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(371, 83);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 19);
            this.lbStatus.TabIndex = 20;
            this.lbStatus.Text = "label2";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(555, 584);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(222, 23);
            this.btnGen.TabIndex = 21;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("新細明體", 14F);
            this.lbMax.Location = new System.Drawing.Point(659, 343);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(62, 19);
            this.lbMax.TabIndex = 22;
            this.lbMax.Text = "maxNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.Location = new System.Drawing.Point(564, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Maximum :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.Location = new System.Drawing.Point(555, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 169);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Quantity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDID);
            this.groupBox2.Controls.Add(this.lbRNo);
            this.groupBox2.Controls.Add(this.tbDesId);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.lbArriveDate);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox2.Location = new System.Drawing.Point(22, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 173);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note Information";
            // 
            // WHGenerateDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.dGVItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "WHGenerateDN";
            this.Text = "WHGenerateDN";
            this.Load += new System.EventHandler(this.WHGenerateDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVItem;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label tbDID;
        private System.Windows.Forms.Label lbRNo;
        private System.Windows.Forms.Label tbDesId;
        private System.Windows.Forms.Label lbArriveDate;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}