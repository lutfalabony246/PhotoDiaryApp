
namespace PhotoDiaryApp
{
	partial class PhotoDiary
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.photoDiaryDataSet = new PhotoDiaryApp.PhotoDiaryDataSet();
			this.systemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.systemTableAdapter = new PhotoDiaryApp.PhotoDiaryDataSetTableAdapters.SystemTableAdapter();
			this.eventNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.photoDiaryDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(716, 246);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(282, 134);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(152, 73);
			this.panel2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(145, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Event Date";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(281, 213);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(145, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Event Photo Add";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(463, 175);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Upload";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(463, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Brouse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(138, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Event Description";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(274, 66);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(243, 62);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(314, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Create Your Event";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(240, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to PhotoDiary";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventNumberDataGridViewTextBoxColumn,
            this.eventDescriptionDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.dateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.systemBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(16, 254);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(712, 291);
			this.dataGridView1.TabIndex = 1;
			// 
			// photoDiaryDataSet
			// 
			this.photoDiaryDataSet.DataSetName = "PhotoDiaryDataSet";
			this.photoDiaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// systemBindingSource
			// 
			this.systemBindingSource.DataMember = "System";
			this.systemBindingSource.DataSource = this.photoDiaryDataSet;
			// 
			// systemTableAdapter
			// 
			this.systemTableAdapter.ClearBeforeFill = true;
			// 
			// eventNumberDataGridViewTextBoxColumn
			// 
			this.eventNumberDataGridViewTextBoxColumn.DataPropertyName = "EventNumber";
			this.eventNumberDataGridViewTextBoxColumn.HeaderText = "EventNumber";
			this.eventNumberDataGridViewTextBoxColumn.Name = "eventNumberDataGridViewTextBoxColumn";
			this.eventNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eventDescriptionDataGridViewTextBoxColumn
			// 
			this.eventDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EventDescription";
			this.eventDescriptionDataGridViewTextBoxColumn.HeaderText = "EventDescription";
			this.eventDescriptionDataGridViewTextBoxColumn.Name = "eventDescriptionDataGridViewTextBoxColumn";
			this.eventDescriptionDataGridViewTextBoxColumn.Width = 300;
			// 
			// photoDataGridViewImageColumn
			// 
			this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
			this.photoDataGridViewImageColumn.HeaderText = "Photo";
			this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
			this.photoDataGridViewImageColumn.Width = 300;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// PhotoDiary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 555);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Name = "PhotoDiary";
			this.Text = "PhotoDiary";
			this.Load += new System.EventHandler(this.PhotoDiary_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.photoDiaryDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PhotoDiaryDataSet photoDiaryDataSet;
		private System.Windows.Forms.BindingSource systemBindingSource;
		private PhotoDiaryDataSetTableAdapters.SystemTableAdapter systemTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
	}
}