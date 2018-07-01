namespace ProcurementSystem
{
    partial class WHUpdateDN
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.dGVItem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkArrived = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDID = new System.Windows.Forms.Label();
            this.lbRNo = new System.Windows.Forms.Label();
            this.lbDesId = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCreationDate = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(555, 655);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 23);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(555, 695);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(222, 23);
            this.btnGen.TabIndex = 29;
            this.btnGen.Text = "Update";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // dGVItem
            // 
            this.dGVItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItem.Location = new System.Drawing.Point(22, 367);
            this.dGVItem.MultiSelect = false;
            this.dGVItem.Name = "dGVItem";
            this.dGVItem.ReadOnly = true;
            this.dGVItem.RowTemplate.Height = 24;
            this.dGVItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItem.Size = new System.Drawing.Size(515, 351);
            this.dGVItem.TabIndex = 28;
            this.dGVItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVItem_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Delivery Note";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkArrived);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.Location = new System.Drawing.Point(555, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 150);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Quantity";
            // 
            // checkArrived
            // 
            this.checkArrived.AutoSize = true;
            this.checkArrived.Location = new System.Drawing.Point(13, 84);
            this.checkArrived.Name = "checkArrived";
            this.checkArrived.Size = new System.Drawing.Size(141, 23);
            this.checkArrived.TabIndex = 17;
            this.checkArrived.Text = "Update Arrived";
            this.checkArrived.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(13, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(13, 48);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 30);
            this.numQty.TabIndex = 15;
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
            this.groupBox2.Size = new System.Drawing.Size(755, 270);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note Information";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(74, 236);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(53, 19);
            this.lbAddress.TabIndex = 29;
            this.lbAddress.Text = "label2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Restaurant Name :";
            // 
            // lbRName
            // 
            this.lbRName.AutoSize = true;
            this.lbRName.Location = new System.Drawing.Point(147, 198);
            this.lbRName.Name = "lbRName";
            this.lbRName.Size = new System.Drawing.Size(53, 19);
            this.lbRName.TabIndex = 26;
            this.lbRName.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Creation Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Delivery Note ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Despatch Instruction ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Request Number :";
            // 
            // lbDID
            // 
            this.lbDID.AutoSize = true;
            this.lbDID.Location = new System.Drawing.Point(148, 35);
            this.lbDID.Name = "lbDID";
            this.lbDID.Size = new System.Drawing.Size(53, 19);
            this.lbDID.TabIndex = 16;
            this.lbDID.Text = "label2";
            // 
            // lbRNo
            // 
            this.lbRNo.AutoSize = true;
            this.lbRNo.Location = new System.Drawing.Point(145, 112);
            this.lbRNo.Name = "lbRNo";
            this.lbRNo.Size = new System.Drawing.Size(53, 19);
            this.lbRNo.TabIndex = 17;
            this.lbRNo.Text = "label2";
            // 
            // lbDesId
            // 
            this.lbDesId.AutoSize = true;
            this.lbDesId.Location = new System.Drawing.Point(527, 113);
            this.lbDesId.Name = "lbDesId";
            this.lbDesId.Size = new System.Drawing.Size(53, 19);
            this.lbDesId.TabIndex = 18;
            this.lbDesId.Text = "label2";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(66, 154);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 19);
            this.lbStatus.TabIndex = 20;
            this.lbStatus.Text = "label2";
            // 
            // lbCreationDate
            // 
            this.lbCreationDate.AutoSize = true;
            this.lbCreationDate.Location = new System.Drawing.Point(123, 74);
            this.lbCreationDate.Name = "lbCreationDate";
            this.lbCreationDate.Size = new System.Drawing.Size(47, 19);
            this.lbCreationDate.TabIndex = 19;
            this.lbCreationDate.Text = "to-do";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(12, 33);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 27);
            this.cbStatus.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbStatus);
            this.groupBox3.Controls.Add(this.btnUpdateStatus);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox3.Location = new System.Drawing.Point(555, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 111);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Status";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(13, 68);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateStatus.TabIndex = 16;
            this.btnUpdateStatus.Text = "Update";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // WHUpdateDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.dGVItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "WHUpdateDN";
            this.Text = "WHUpdateDN";
            this.Load += new System.EventHandler(this.WHUpdateDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DataGridView dGVItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDID;
        private System.Windows.Forms.Label lbRNo;
        private System.Windows.Forms.Label lbDesId;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCreationDate;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.CheckBox checkArrived;
    }
}