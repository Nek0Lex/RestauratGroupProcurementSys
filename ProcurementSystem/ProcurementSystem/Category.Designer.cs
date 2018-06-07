namespace ProcurementSystem
{
    partial class Category
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddCategory = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DeleteCategory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditCategory = new System.Windows.Forms.Button();
            this.UpdateVIDMapping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(41, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(275, 431);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(638, 431);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(41, 494);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(82, 23);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(905, 497);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(104, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Location = new System.Drawing.Point(241, 527);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.DeleteCategory.TabIndex = 4;
            this.DeleteCategory.Text = "Delete";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 25);
            this.textBox1.TabIndex = 5;
            // 
            // EditCategory
            // 
            this.EditCategory.Location = new System.Drawing.Point(41, 526);
            this.EditCategory.Name = "EditCategory";
            this.EditCategory.Size = new System.Drawing.Size(82, 23);
            this.EditCategory.TabIndex = 6;
            this.EditCategory.Text = "Edit Name";
            this.EditCategory.UseVisualStyleBackColor = true;
            this.EditCategory.Click += new System.EventHandler(this.EditCategory_Click);
            // 
            // UpdateVIDMapping
            // 
            this.UpdateVIDMapping.Location = new System.Drawing.Point(637, 497);
            this.UpdateVIDMapping.Name = "UpdateVIDMapping";
            this.UpdateVIDMapping.Size = new System.Drawing.Size(124, 23);
            this.UpdateVIDMapping.TabIndex = 7;
            this.UpdateVIDMapping.Text = "Update Record";
            this.UpdateVIDMapping.UseVisualStyleBackColor = true;
            this.UpdateVIDMapping.Click += new System.EventHandler(this.UpdateVIDMapping_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.UpdateVIDMapping);
            this.Controls.Add(this.EditCategory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteCategory);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button DeleteCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditCategory;
        private System.Windows.Forms.Button UpdateVIDMapping;
    }
}