
namespace Forms
{
	partial class AddRecipeFromUrlScreen
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
			this.LabelRecipeUrl = new System.Windows.Forms.Label();
			this.TextBoxRecipeUrl = new System.Windows.Forms.TextBox();
			this.ButtonSubmitUrl = new System.Windows.Forms.Button();
			this.tableLayoutPanelScreen = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelScreen.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// LabelRecipeUrl
			// 
			this.LabelRecipeUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelRecipeUrl.AutoSize = true;
			this.LabelRecipeUrl.Location = new System.Drawing.Point(54, 216);
			this.LabelRecipeUrl.Name = "LabelRecipeUrl";
			this.LabelRecipeUrl.Size = new System.Drawing.Size(95, 8);
			this.LabelRecipeUrl.TabIndex = 7;
			this.LabelRecipeUrl.Text = "Recipe URL";
			// 
			// TextBoxRecipeUrl
			// 
			this.TextBoxRecipeUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxRecipeUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TextBoxRecipeUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxRecipeUrl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxRecipeUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TextBoxRecipeUrl.Location = new System.Drawing.Point(155, 219);
			this.TextBoxRecipeUrl.Name = "TextBoxRecipeUrl";
			this.TextBoxRecipeUrl.Size = new System.Drawing.Size(1042, 24);
			this.TextBoxRecipeUrl.TabIndex = 8;
			// 
			// ButtonSubmitUrl
			// 
			this.ButtonSubmitUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonSubmitUrl.AutoSize = true;
			this.ButtonSubmitUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSubmitUrl.FlatAppearance.BorderSize = 0;
			this.ButtonSubmitUrl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSubmitUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSubmitUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSubmitUrl.Location = new System.Drawing.Point(1203, 219);
			this.ButtonSubmitUrl.Name = "ButtonSubmitUrl";
			this.ButtonSubmitUrl.Size = new System.Drawing.Size(108, 2);
			this.ButtonSubmitUrl.TabIndex = 9;
			this.ButtonSubmitUrl.Text = "Submit URL";
			this.ButtonSubmitUrl.UseVisualStyleBackColor = true;
			this.ButtonSubmitUrl.Click += new System.EventHandler(this.ButtonSubmitUrl_Click);
			// 
			// tableLayoutPanelScreen
			// 
			this.tableLayoutPanelScreen.ColumnCount = 4;
			this.tableLayoutPanelScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanelScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
			this.tableLayoutPanelScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
			this.tableLayoutPanelScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelScreen.Controls.Add(this.LabelRecipeUrl, 1, 2);
			this.tableLayoutPanelScreen.Controls.Add(this.ButtonSubmitUrl, 3, 2);
			this.tableLayoutPanelScreen.Controls.Add(this.TextBoxRecipeUrl, 2, 2);
			this.tableLayoutPanelScreen.Location = new System.Drawing.Point(0, 740);
			this.tableLayoutPanelScreen.Name = "tableLayoutPanelScreen";
			this.tableLayoutPanelScreen.RowCount = 3;
			this.tableLayoutPanelScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96F));
			this.tableLayoutPanelScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
			this.tableLayoutPanelScreen.Size = new System.Drawing.Size(1329, 224);
			this.tableLayoutPanelScreen.TabIndex = 32;
			// 
			// AddRecipeFromUrlScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelScreen);
			this.Name = "AddRecipeFromUrlScreen";
			this.Size = new System.Drawing.Size(1832, 987);
			this.Enter += new System.EventHandler(this.AddRecipeFromUrlScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanelScreen, 0);
			this.tableLayoutPanelScreen.ResumeLayout(false);
			this.tableLayoutPanelScreen.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LabelRecipeUrl;
		private System.Windows.Forms.TextBox TextBoxRecipeUrl;
		private System.Windows.Forms.Button ButtonSubmitUrl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScreen;
	}
}
