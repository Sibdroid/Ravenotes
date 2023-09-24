namespace Ravenotes
{
	partial class Form1
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
			this.Input = new System.Windows.Forms.RichTextBox();
			this.FontSize = new System.Windows.Forms.TextBox();
			this.IncreaseFontSize = new System.Windows.Forms.Button();
			this.DecreaseFontSize = new System.Windows.Forms.Button();
			this.FontChoice = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Input
			// 
			this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Input.Font = new System.Drawing.Font("Roboto", 16F);
			this.Input.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Input.Location = new System.Drawing.Point(2, 2);
			this.Input.Name = "Input";
			this.Input.Size = new System.Drawing.Size(380, 325);
			this.Input.TabIndex = 0;
			this.Input.Text = "";
			// 
			// FontSize
			// 
			this.FontSize.Font = new System.Drawing.Font("Roboto", 20F);
			this.FontSize.Location = new System.Drawing.Point(2, 333);
			this.FontSize.Name = "FontSize";
			this.FontSize.Size = new System.Drawing.Size(80, 40);
			this.FontSize.TabIndex = 1;
			this.FontSize.Text = "16";
			this.FontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// IncreaseFontSize
			// 
			this.IncreaseFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IncreaseFontSize.Font = new System.Drawing.Font("Roboto", 14F);
			this.IncreaseFontSize.Location = new System.Drawing.Point(2, 379);
			this.IncreaseFontSize.Name = "IncreaseFontSize";
			this.IncreaseFontSize.Size = new System.Drawing.Size(37, 37);
			this.IncreaseFontSize.TabIndex = 2;
			this.IncreaseFontSize.Text = "▲";
			this.IncreaseFontSize.UseVisualStyleBackColor = true;
			this.IncreaseFontSize.Click += new System.EventHandler(this.IncreaseFontSize_Click);
			// 
			// DecreaseFontSize
			// 
			this.DecreaseFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DecreaseFontSize.Font = new System.Drawing.Font("Roboto", 14F);
			this.DecreaseFontSize.Location = new System.Drawing.Point(45, 379);
			this.DecreaseFontSize.Name = "DecreaseFontSize";
			this.DecreaseFontSize.Size = new System.Drawing.Size(37, 37);
			this.DecreaseFontSize.TabIndex = 3;
			this.DecreaseFontSize.Text = "▼";
			this.DecreaseFontSize.UseVisualStyleBackColor = true;
			this.DecreaseFontSize.Click += new System.EventHandler(this.DecreaseFontSize_Click);
			// 
			// FontChoice
			// 
			this.FontChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FontChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.FontChoice.Font = new System.Drawing.Font("Roboto", 19.25F);
			this.FontChoice.FormattingEnabled = true;
			this.FontChoice.Items.AddRange(new object[] {
            "Arial",
            "Arial Black",
            "Calibri",
            "Cambria",
            "Courier New",
            "Georgia",
            "Impact",
            "Tahoma",
            "Times New Roman",
            "Verdana"});
			this.FontChoice.Location = new System.Drawing.Point(88, 333);
			this.FontChoice.Name = "FontChoice";
			this.FontChoice.Size = new System.Drawing.Size(240, 40);
			this.FontChoice.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 421);
			this.Controls.Add(this.FontChoice);
			this.Controls.Add(this.DecreaseFontSize);
			this.Controls.Add(this.IncreaseFontSize);
			this.Controls.Add(this.FontSize);
			this.Controls.Add(this.Input);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox Input;
		private System.Windows.Forms.TextBox FontSize;
		private System.Windows.Forms.Button IncreaseFontSize;
		private System.Windows.Forms.Button DecreaseFontSize;
		private System.Windows.Forms.ComboBox FontChoice;
	}
}

