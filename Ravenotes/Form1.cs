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
			FontSize.KeyDown += FontSize_KeyDown;
			FontChoice.SelectedItem = "Arial";
			FontChoice.Click += FontChoice_Click;
			FontChoice.SelectionChangeCommitted += FontChoice_SelectionChangeCommitted;
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
		private void FontSize_KeyDown(object  sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int fontSize = 0;
				bool isNumber = int.TryParse(FontSize.Text, out fontSize);
				if (fontSize >= 1 && fontSize <= 100)
				{
					defaultFontSize = fontSize;
					Input.Font = new Font(Input.Font.FontFamily, fontSize);
					FontSize.Text = fontSize.ToString();
					this.ActiveControl = this.Input;
				}
				else
				{
					FontSize.Text = defaultFontSize.ToString();
				}
			}
		}
		private void FontChoice_SelectionChangeCommitted(object sender, EventArgs e)
		{
			Input.Font = new Font(FontChoice.SelectedItem.ToString(), defaultFontSize);
			this.ActiveControl = this.Input;
		}
		private void FontChoice_Click(object sender, EventArgs e)
		{
			FontChoice.DroppedDown = true;
		}
	}
}
