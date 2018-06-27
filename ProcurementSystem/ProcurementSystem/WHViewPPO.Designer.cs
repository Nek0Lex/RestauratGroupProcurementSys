namespace ProcurementSystem
{
    partial class WHViewPPO
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Planned Purchase Order";
            // 
            // dGVItem
            // 
            this.dGVItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItem.Location = new System.Drawing.Point(26, 306);
            this.dGVItem.Margin = new System.Windows.Forms.Padding(4);
            this.dGVItem.MultiSelect = false;
            this.dGVItem.Name = "dGVItem";
            this.dGVItem.ReadOnly = true;
            this.dGVItem.RowTemplate.Height = 24;
            this.dGVItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItem.Size = new System.Drawing.Size(557, 439);
            this.dGVItem.TabIndex = 16;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(26, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(868, 216);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PPO Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Creation Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Order Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Despatch Instruction ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Request Number :";
            // 
            // lbDID
            // 
            this.lbDID.AutoSize = true;
            this.lbDID.Location = new System.Drawing.Point(158, 44);
            this.lbDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDID.Name = "lbDID";
            this.lbDID.Size = new System.Drawing.Size(64, 24);
            this.lbDID.TabIndex = 16;
            this.lbDID.Text = "label2";
            // 
            // lbRNo
            // 
            this.lbRNo.AutoSize = true;
            this.lbRNo.Location = new System.Drawing.Point(189, 104);
            this.lbRNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRNo.Name = "lbRNo";
            this.lbRNo.Size = new System.Drawing.Size(64, 24);
            this.lbRNo.TabIndex = 17;
            this.lbRNo.Text = "label2";
            // 
            // lbDesId
            // 
            this.lbDesId.AutoSize = true;
            this.lbDesId.Location = new System.Drawing.Point(259, 166);
            this.lbDesId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDesId.Name = "lbDesId";
            this.lbDesId.Size = new System.Drawing.Size(64, 24);
            this.lbDesId.TabIndex = 18;
            this.lbDesId.Text = "label2";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(531, 104);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(64, 24);
            this.lbStatus.TabIndex = 20;
            this.lbStatus.Text = "label2";
            // 
            // lbCreationDate
            // 
            this.lbCreationDate.AutoSize = true;
            this.lbCreationDate.Location = new System.Drawing.Point(596, 44);
            this.lbCreationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreationDate.Name = "lbCreationDate";
            this.lbCreationDate.Size = new System.Drawing.Size(57, 24);
            this.lbCreationDate.TabIndex = 19;
            this.lbCreationDate.Text = "to-do";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(605, 665);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(296, 29);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(605, 716);
            this.btnGen.Margin = new System.Windows.Forms.Padding(4);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(296, 29);
            this.btnGen.TabIndex = 28;
            this.btnGen.Text = "Confirm";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // WHViewPPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 764);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGVItem);
            this.Controls.Add(this.label1);
            this.Name = "WHViewPPO";
            this.Text = "WHViewPPO";
            ((System.ComponentModel.ISupportInitialize)(this.dGVItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVItem;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGen;
    }
}