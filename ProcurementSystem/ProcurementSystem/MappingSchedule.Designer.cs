namespace ProcurementSystem
{
	partial class MappingSchedule
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(240, 211);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(134, 211);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 20F);
			this.label1.Location = new System.Drawing.Point(39, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 27);
			this.label1.TabIndex = 8;
			this.label1.Text = "Auto-Mapping Schedule";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "HH : mm";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(134, 58);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(63, 22);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "HH : mm";
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(134, 103);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.ShowUpDown = true;
			this.dateTimePicker2.Size = new System.Drawing.Size(63, 22);
			this.dateTimePicker2.TabIndex = 13;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.CustomFormat = "HH : mm";
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker3.Location = new System.Drawing.Point(134, 150);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.ShowUpDown = true;
			this.dateTimePicker3.Size = new System.Drawing.Size(63, 22);
			this.dateTimePicker3.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 12);
			this.label2.TabIndex = 15;
			this.label2.Text = "Schedule 1 :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 12);
			this.label3.TabIndex = 16;
			this.label3.Text = "Schedule 2 :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 12);
			this.label4.TabIndex = 17;
			this.label4.Text = "Schedule 3 :";
			// 
			// MappingSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 260);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker3);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Name = "MappingSchedule";
			this.Text = "MappingSchedule";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}