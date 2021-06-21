using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCrossProduct
{
	public partial class VectorProducts : Form
	{
		public VectorProducts()
		{
			InitializeComponent();
		}

		private void crossProduct_Click(object sender, EventArgs e)
		{
			try
			{
				lblError.Visible = false;

				int ui = int.Parse(txtui.Text);
				int uj = int.Parse(txtuj.Text);
				int uk = int.Parse(txtuk.Text);

				int vi = int.Parse(txtvi.Text);
				int vj = int.Parse(txtvj.Text);
				int vk = int.Parse(txtvk.Text);

				int iVal = (uj * vk - uk * vj);
				int jVal = -(ui * vk - uk * vi);
				int kVal = (ui * vj - uj * vi);

				txtAnswer.Text = $"{iVal},{jVal},{kVal}";
			}
			catch (Exception ex)
			{
				lblError.Text = "Recheck vector values";
				lblError.Visible = true;
			}
		}

		private void dotProduct_Click(object sender, EventArgs e)
		{
			try
			{
				lblError.Visible = false;

				int ui = int.Parse(txtui.Text);
				int uj = int.Parse(txtuj.Text);
				int uk = int.Parse(txtuk.Text);

				int vi = int.Parse(txtvi.Text);
				int vk = int.Parse(txtvk.Text);
				int vj = int.Parse(txtvj.Text);

				int dotProduct = ui * vi + uk * vk + uj * vj;

				txtAnswer.Text = $"{dotProduct}";
			}
			catch (Exception ex)
			{
				lblError.Text = "Recheck vector values";
				lblError.Visible = true;
			}
		}

		private void btnSetU_Click(object sender, EventArgs e)
		{
			try
			{
				lblError.Visible = false;

				string[] vals = txtAnswer.Text.Split(',');
				txtui.Text = vals[0];
				txtuj.Text = vals[1];
				txtuk.Text = vals[2];
			}
			catch (Exception ex)
			{
				lblError.Text = "Invalid input";
				lblError.Visible = true;
			}
		}

		private void btnSetV_Click(object sender, EventArgs e)
		{
			try
			{
				lblError.Visible = false;

				string[] vals = txtAnswer.Text.Split(',');
				txtvi.Text = vals[0];
				txtvj.Text = vals[1];
				txtvk.Text = vals[2];
			}
			catch (Exception ex)
			{
				lblError.Text = "Invalid input";
				lblError.Visible = true;
			}
		}
	}
}
