
namespace Forms
{
	partial class ManageRecipesScreen
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ListBoxRecipes = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// ListBoxRecipes
			// 
			this.ListBoxRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ListBoxRecipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ListBoxRecipes.FormattingEnabled = true;
			this.ListBoxRecipes.ItemHeight = 16;
			this.ListBoxRecipes.Location = new System.Drawing.Point(62, 3);
			this.ListBoxRecipes.Name = "ListBoxRecipes";
			this.ListBoxRecipes.Size = new System.Drawing.Size(934, 484);
			this.ListBoxRecipes.TabIndex = 6;
			this.ListBoxRecipes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxRecipes_MouseDoubleClick);
			// 
			// ManageRecipesScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ListBoxRecipes);
			this.Name = "ManageRecipesScreen";
			this.Size = new System.Drawing.Size(999, 504);
			this.Enter += new System.EventHandler(this.ManageRecipesScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.ListBoxRecipes, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListBoxRecipes;
	}
}
