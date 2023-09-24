using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ravenotes
{
	public partial class Form1 : Form
	{
		int defaultFontSize = 16;
		public Form1()
		{
			InitializeComponent();
			Input.Font = new Font(Input.Font.FontFamily, defaultFontSize);
			FontSize.Font = new Font(Input.Font.FontFamily, defaultFontSize);
		}

		private void IncreaseFontSize_Click(object sender, EventArgs e)
		{
			defaultFontSize++;
			Input.Font = new Font(Input.Font.FontFamily, defaultFontSize);
			FontSize.Text = defaultFontSize.ToString();
			this.ActiveControl = this.Input;
		}

		private void DecreaseFontSize_Click(object sender, EventArgs e)
		{
			defaultFontSize--;
			Input.Font = new Font(Input.Font.FontFamily, defaultFontSize);
			FontSize.Text = defaultFontSize.ToString();
			this.ActiveControl = this.Input;
		}
	}
}
