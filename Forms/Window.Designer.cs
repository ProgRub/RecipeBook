
namespace Forms
{
	partial class Window
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.homeScreen1 = new Forms.HomeScreen();
			this.SuspendLayout();
			// 
			// homeScreen1
			// 
			this.homeScreen1.AutoSize = true;
			this.homeScreen1.BackColor = System.Drawing.Color.Transparent;
			this.homeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.homeScreen1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.homeScreen1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.homeScreen1.Location = new System.Drawing.Point(0, 0);
			this.homeScreen1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.homeScreen1.Name = "homeScreen1";
			this.homeScreen1.Size = new System.Drawing.Size(199, 99);
			this.homeScreen1.TabIndex = 0;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(199, 99);
			this.Controls.Add(this.homeScreen1);
			this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Window";
			this.Text = "RecipeBook";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HomeScreen homeScreen1;
	}
}

