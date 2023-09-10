using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWDev_Project_Hint
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void bAnalyst_Compare_Click(object sender, EventArgs e)
		{
			int iResult;
			if ( (iResult=string.Compare(tbSource.Text, tbKeyword.Text, false /*bIgnorecase*/)) == 0)
			{	/* equal */
				tbResult.Text = "เท่ากันครับ";
			}
			else
			{	/* not equal */
				tbResult.Text = "ไม่เท่ากัน";
			}
		}

		private void btContain_Click(object sender, EventArgs e)
		{
			int iResult;
			string strSource = tbSource.Text;
			iResult = strSource.IndexOf(tbKeyword.Text);
			if ( iResult >= 0 )
			{
				tbResult.Text	= "หาเจอที่ตำแหน่ง" + iResult.ToString();
			}
			else
			{
				tbResult.Text	= "หาไม่เจอ";
			}
		}
	}
}
