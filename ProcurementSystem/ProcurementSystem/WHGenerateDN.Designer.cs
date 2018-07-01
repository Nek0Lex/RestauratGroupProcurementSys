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
            this.lbDID = new System.Windows.Forms.Label();
            this.lbRNo = new System.Windows.Forms.Label();
            this.lbDesId = new System.Windows.Forms.Label();
            this.lbCreationDate = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.lbMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.RichTextBox();
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
            this.dGVItem.Location = new System.Drawing.Point(22, 409);
            this.dGVItem.MultiSelect = false;
            this.dGVItem.Name = "dGVItem";
            this.dGVItem.ReadOnly = true;
            this.dGVItem.RowTemplate.Height = 24;
            this.dGVItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItem.Size = new System.Drawing.Size(644, 351);
            this.dGVItem.TabIndex = 14;
            this.dGVItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVItem_CellContentClick);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(13, 48);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 30);
            this.numQty.TabIndex = 15;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // lbDID
            // 
            this.lbDID.AutoSize = true;
            this.lbDID.Location = new System.Drawing.Point(154, 35);
            this.lbDID.Name = "lbDID";
            this.lbDID.Size = new System.Drawing.Size(53, 19);
            this.lbDID.TabIndex = 16;
            this.lbDID.Text = "label2";
            // 
            // lbRNo
            // 
            this.lbRNo.AutoSize = true;
            this.lbRNo.Location = new System.Drawing.Point(151, 112);
            this.lbRNo.Name = "lbRNo";
            this.lbRNo.Size = new System.Drawing.Size(53, 19);
            this.lbRNo.TabIndex = 17;
            this.lbRNo.Text = "label2";
            // 
            // lbDesId
            // 
            this.lbDesId.AutoSize = true;
            this.lbDesId.Location = new System.Drawing.Point(533, 113);
            this.lbDesId.Name = "lbDesId";
            this.lbDesId.Size = new System.Drawing.Size(53, 19);
            this.lbDesId.TabIndex = 18;
            this.lbDesId.Text = "label2";
            // 
            // lbCreationDate
            // 
            this.lbCreationDate.AutoSize = true;
            this.lbCreationDate.Location = new System.Drawing.Point(129, 74);
            this.lbCreationDate.Name = "lbCreationDate";
            this.lbCreationDate.Size = new System.Drawing.Size(47, 19);
            this.lbCreationDate.TabIndex = 19;
            this.lbCreationDate.Text = "to-do";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(72, 154);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 19);
            this.lbStatus.TabIndex = 20;
            this.lbStatus.Text = "label2";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(686, 732);
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
            this.lbMax.Location = new System.Drawing.Point(786, 492);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(18, 19);
            this.lbMax.TabIndex = 22;
            this.lbMax.Text = "0";
            this.lbMax.Click += new System.EventHandler(this.lbMax_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.Location = new System.Drawing.Point(695, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Maximum :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.Location = new System.Drawing.Point(686, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 169);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Quantity";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbRName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbDID);
            this.groupBox2.Controls.Add(this.lbRNo);
            this.groupBox2.Controls.Add(this.lbDesId);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.lbCreationDate);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox2.Location = new System.Drawing.Point(22, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 327);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Restaurant Name :";
            // 
            // lbRName
            // 
            this.lbRName.AutoSize = true;
            this.lbRName.Location = new System.Drawing.Point(153, 198);
            this.lbRName.Name = "lbRName";
            this.lbRName.Size = new System.Drawing.Size(53, 19);
            this.lbRName.TabIndex = 26;
            this.lbRName.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Creation Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Delivery Note ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Despatch Instruction ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Request Number :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(686, 692);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAddress.Location = new System.Drawing.Point(97, 234);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(754, 72);
            this.lbAddress.TabIndex = 30;
            this.lbAddress.Text = "";
            // 
            // WHGenerateDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 772);
            this.Controls.Add(this.btnBack);
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
        private System.Windows.Forms.Label lbDID;
        private System.Windows.Forms.Label lbRNo;
        private System.Windows.Forms.Label lbDesId;
        private System.Windows.Forms.Label lbCreationDate;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox lbAddress;
    }
}