using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiaryApp
{
	public partial class PhotoDiary : Form
	{
		string image = null;
		public PhotoDiary()
		{
			InitializeComponent();
		}

		private void PhotoDiary_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'photoDiaryDataSet.System' table. You can move, or remove it, as needed.
			this.systemTableAdapter.Fill(this.photoDiaryDataSet.System);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using(OpenFileDialog ofd =new OpenFileDialog())
			{
				if(ofd.ShowDialog()==DialogResult.OK)
				{
					image = ofd.FileName;
				
					//.Image=Image.FromFile(ofd,filename)
				}
			}
		}
	}
}
