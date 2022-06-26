
namespace Forms
{
	partial class HomeScreen
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
			this.ButtonAddRecipeFromUrl = new System.Windows.Forms.Button();
			this.ButtonAddRecipeManually = new System.Windows.Forms.Button();
			this.ButtonManageCheckRecipes = new System.Windows.Forms.Button();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.Enabled = false;
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.Visible = false;
			// 
			// ButtonAddRecipeFromUrl
			// 
			this.ButtonAddRecipeFromUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonAddRecipeFromUrl.FlatAppearance.BorderSize = 0;
			this.ButtonAddRecipeFromUrl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddRecipeFromUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddRecipeFromUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddRecipeFromUrl.Location = new System.Drawing.Point(12, 5);
			this.ButtonAddRecipeFromUrl.Name = "ButtonAddRecipeFromUrl";
			this.ButtonAddRecipeFromUrl.Size = new System.Drawing.Size(186, 27);
			this.ButtonAddRecipeFromUrl.TabIndex = 6;
			this.ButtonAddRecipeFromUrl.Text = "Add Recipe From URL";
			this.ButtonAddRecipeFromUrl.UseVisualStyleBackColor = true;
			this.ButtonAddRecipeFromUrl.Click += new System.EventHandler(this.ButtonAddRecipeFromUrl_Click);
			// 
			// ButtonAddRecipeManually
			// 
			this.ButtonAddRecipeManually.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonAddRecipeManually.FlatAppearance.BorderSize = 0;
			this.ButtonAddRecipeManually.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddRecipeManually.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddRecipeManually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddRecipeManually.Location = new System.Drawing.Point(12, 42);
			this.ButtonAddRecipeManually.Name = "ButtonAddRecipeManually";
			this.ButtonAddRecipeManually.Size = new System.Drawing.Size(186, 27);
			this.ButtonAddRecipeManually.TabIndex = 7;
			this.ButtonAddRecipeManually.Text = "Add Recipe Manually";
			this.ButtonAddRecipeManually.UseVisualStyleBackColor = true;
			this.ButtonAddRecipeManually.Click += new System.EventHandler(this.ButtonAddRecipeManually_Click);
			// 
			// ButtonManageCheckRecipes
			// 
			this.ButtonManageCheckRecipes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonManageCheckRecipes.FlatAppearance.BorderSize = 0;
			this.ButtonManageCheckRecipes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonManageCheckRecipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonManageCheckRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonManageCheckRecipes.Location = new System.Drawing.Point(5, 80);
			this.ButtonManageCheckRecipes.Name = "ButtonManageCheckRecipes";
			this.ButtonManageCheckRecipes.Size = new System.Drawing.Size(199, 27);
			this.ButtonManageCheckRecipes.TabIndex = 8;
			this.ButtonManageCheckRecipes.Text = "Manage/Check Recipes";
			this.ButtonManageCheckRecipes.UseVisualStyleBackColor = true;
			this.ButtonManageCheckRecipes.Click += new System.EventHandler(this.ButtonManageCheckRecipes_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.ButtonAddRecipeFromUrl, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonManageCheckRecipes, 0, 2);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonAddRecipeManually, 0, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(205, 106);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 3;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(210, 114);
			this.tableLayoutPanelMain.TabIndex = 9;
			// 
			// HomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.Name = "HomeScreen";
			this.Size = new System.Drawing.Size(210, 114);
			this.Enter += new System.EventHandler(this.HomeScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonAddRecipeFromUrl;
		private System.Windows.Forms.Button ButtonAddRecipeManually;
		private System.Windows.Forms.Button ButtonManageCheckRecipes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
