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
            this.Update = new System.Windows.Forms.Button();
            this.DeleteVIDMapping = new System.Windows.Forms.Button();
            this.CreateVIDMapping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(31, 34);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(207, 346);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(478, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(31, 395);
            this.AddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(181, 42);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(772, 457);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(181, 42);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Location = new System.Drawing.Point(235, 457);
            this.DeleteCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(181, 42);
            this.DeleteCategory.TabIndex = 4;
            this.DeleteCategory.Text = "Delete";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox1.Location = new System.Drawing.Point(235, 402);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 30);
            this.textBox1.TabIndex = 5;
            // 
            // EditCategory
            // 
            this.EditCategory.Location = new System.Drawing.Point(31, 457);
            this.EditCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditCategory.Name = "EditCategory";
            this.EditCategory.Size = new System.Drawing.Size(181, 42);
            this.EditCategory.TabIndex = 6;
            this.EditCategory.Text = "Edit Name";
            this.EditCategory.UseVisualStyleBackColor = true;
            this.EditCategory.Click += new System.EventHandler(this.EditCategory_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(772, 111);
            this.Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(181, 42);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.UpdateVIDMapping_Click);
            // 
            // DeleteVIDMapping
            // 
            this.DeleteVIDMapping.Location = new System.Drawing.Point(772, 187);
            this.DeleteVIDMapping.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteVIDMapping.Name = "DeleteVIDMapping";
            this.DeleteVIDMapping.Size = new System.Drawing.Size(181, 42);
            this.DeleteVIDMapping.TabIndex = 8;
            this.DeleteVIDMapping.Text = "Delete";
            this.DeleteVIDMapping.UseVisualStyleBackColor = true;
            this.DeleteVIDMapping.Click += new System.EventHandler(this.DeleteVIDMapping_Click);
            // 
            // CreateVIDMapping
            // 
            this.CreateVIDMapping.Location = new System.Drawing.Point(772, 34);
            this.CreateVIDMapping.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateVIDMapping.Name = "CreateVIDMapping";
            this.CreateVIDMapping.Size = new System.Drawing.Size(181, 42);
            this.CreateVIDMapping.TabIndex = 9;
            this.CreateVIDMapping.Text = "Create";
            this.CreateVIDMapping.UseVisualStyleBackColor = true;
            this.CreateVIDMapping.Click += new System.EventHandler(this.CreateVIDMapping_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 519);
            this.Controls.Add(this.CreateVIDMapping);
            this.Controls.Add(this.DeleteVIDMapping);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.EditCategory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteCategory);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button DeleteVIDMapping;
        private System.Windows.Forms.Button CreateVIDMapping;
    }
}