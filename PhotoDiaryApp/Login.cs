using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PhotoDiaryApp
{
	public partial class Login : Form
	{
		static string constring = ConfigurationManager.ConnectionStrings["PhotoDiaryApp.Properties.Settings.setting"].ConnectionString;
		SqlConnection con = new SqlConnection(constring);
		//SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
		//SqlConnection connection = new SqlConnection();
		public Login()
		{
			InitializeComponent();
			
			//connection.Open();
			//SqlCommand command = new SqlCommand()


		}

		

		private void nametextBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void loginbutton1_Click(object sender, EventArgs e)
		{
			if (nametextBox1.Text == "")
			{
				MessageBox.Show("Name can't be empty");
			}
			else if (passtextBox2.Text == "")
			{
				MessageBox.Show("Password can't be empty");
			}
			//SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
			//connection.Open();

			//String uname = nametextBox1.Text.ToString();
			//String upass = passtextBox2.Text.ToString();
			//String qry = "select * from Userslogin where username='" + uname + "' and password='" + upass + "'";
			//SqlDataAdapter sda = new SqlDataAdapter(qry, connection);
			//DataTable dt = new DataTable();
			//sda.Fill(dt);
			//if(dt.Rows.Count == 1)
			//{
			//MessageBox.Show("Valid User" + uname);
			//}
			//else
			//{
			//MessageBox.Show("Valid User" + uname);
			//}
			//connection.Open();


			//String qry = "select * from Userslogin where username='" + uname + "'and password='" + upass + "'", connection);
			//SqlDataAdapter sda = new SqlDataAdapter(cmd);
			//DataTable dt = new DataTable();
			//sda.Fill(dt);
			//if (dt.Rows.Count >0)
			//{
			//for(int i= 0;i<dt.Rows.Count;i++)
			//{
			//	if (dt.Rows[i]["password"]) ;
			//}
			//}
			//else
			//{
			//MessageBox.Show("Error");
			//}
			con.Open();
			String uname = nametextBox1.Text.ToString();
			String upass = passtextBox2.Text.ToString();
			String qry = "select * from Userslogin where username='" + uname + "' and password='" + upass + "'";
			SqlDataAdapter sda = new SqlDataAdapter(qry,con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if(dt.Rows.Count == 1)
			{
			MessageBox.Show("Valid User" + uname);
			}
			else
			{
			MessageBox.Show("Valid User" + uname);
			}

			PhotoDiary pd = new PhotoDiary();
			pd.Show();

		}
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
