
namespace PhotoDiaryApp
{
	partial class Login
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.loginbutton1 = new System.Windows.Forms.Button();
			this.passlabel2 = new System.Windows.Forms.Label();
			this.passtextBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.nametextBox1 = new System.Windows.Forms.TextBox();
			this.namelabel1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(723, 153);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(252, 92);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(193, 100);
			this.panel3.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.namelabel1);
			this.panel1.Controls.Add(this.nametextBox1);
			this.panel1.Controls.Add(this.loginbutton1);
			this.panel1.Controls.Add(this.passlabel2);
			this.panel1.Controls.Add(this.passtextBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(39, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(653, 408);
			this.panel1.TabIndex = 0;
			// 
			// loginbutton1
			// 
			this.loginbutton1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.loginbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginbutton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.loginbutton1.Location = new System.Drawing.Point(291, 283);
			this.loginbutton1.Name = "loginbutton1";
			this.loginbutton1.Size = new System.Drawing.Size(85, 34);
			this.loginbutton1.TabIndex = 5;
			this.loginbutton1.Text = "Login";
			this.loginbutton1.UseVisualStyleBackColor = false;
			this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
			// 
			// passlabel2
			// 
			this.passlabel2.AutoSize = true;
			this.passlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passlabel2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.passlabel2.Location = new System.Drawing.Point(121, 243);
			this.passlabel2.Name = "passlabel2";
			this.passlabel2.Size = new System.Drawing.Size(86, 20);
			this.passlabel2.TabIndex = 4;
			this.passlabel2.Text = "Password";
			// 
			// passtextBox2
			// 
			this.passtextBox2.Location = new System.Drawing.Point(222, 243);
			this.passtextBox2.Name = "passtextBox2";
			this.passtextBox2.Size = new System.Drawing.Size(222, 20);
			this.passtextBox2.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PhotoDiaryApp.Properties.Resources.check1;
			this.pictureBox1.Location = new System.Drawing.Point(256, 56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 110);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// nametextBox1
			// 
			this.nametextBox1.Location = new System.Drawing.Point(222, 206);
			this.nametextBox1.Name = "nametextBox1";
			this.nametextBox1.Size = new System.Drawing.Size(222, 20);
			this.nametextBox1.TabIndex = 6;
			this.nametextBox1.TextChanged += new System.EventHandler(this.nametextBox1_TextChanged);
			// 
			// namelabel1
			// 
			this.namelabel1.AutoSize = true;
			this.namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.namelabel1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.namelabel1.Location = new System.Drawing.Point(150, 206);
			this.namelabel1.Name = "namelabel1";
			this.namelabel1.Size = new System.Drawing.Size(55, 20);
			this.namelabel1.TabIndex = 7;
			this.namelabel1.Text = "Name";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(723, 508);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label passlabel2;
		private System.Windows.Forms.TextBox passtextBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button loginbutton1;
		private System.Windows.Forms.TextBox nametextBox1;
		private System.Windows.Forms.Label namelabel1;
	}
}

