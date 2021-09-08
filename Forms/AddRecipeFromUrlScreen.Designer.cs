
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
			this.LabelRecipeUrl.AutoSize = true;
			this.LabelRecipeUrl.Location = new System.Drawing.Point(359, 949);
			this.LabelRecipeUrl.Name = "LabelRecipeUrl";
			this.LabelRecipeUrl.Size = new System.Drawing.Size(95, 17);
			this.LabelRecipeUrl.TabIndex = 7;
			this.LabelRecipeUrl.Text = "Recipe URL";
			// 
			// TextBoxRecipeUrl
			// 
			this.TextBoxRecipeUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TextBoxRecipeUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxRecipeUrl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxRecipeUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TextBoxRecipeUrl.Location = new System.Drawing.Point(460, 947);
			this.TextBoxRecipeUrl.Name = "TextBoxRecipeUrl";
			this.TextBoxRecipeUrl.Size = new System.Drawing.Size(808, 24);
			this.TextBoxRecipeUrl.TabIndex = 8;
			// 
			// ButtonSubmitUrl
			// 
			this.ButtonSubmitUrl.AutoSize = true;
			this.ButtonSubmitUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSubmitUrl.FlatAppearance.BorderSize = 0;
			this.ButtonSubmitUrl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSubmitUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSubmitUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSubmitUrl.Location = new System.Drawing.Point(1274, 944);
			this.ButtonSubmitUrl.Name = "ButtonSubmitUrl";
			this.ButtonSubmitUrl.Size = new System.Drawing.Size(108, 27);
			this.ButtonSubmitUrl.TabIndex = 9;
			this.ButtonSubmitUrl.Text = "Submit URL";
			this.ButtonSubmitUrl.UseVisualStyleBackColor = true;
			this.ButtonSubmitUrl.Click += new System.EventHandler(this.ButtonSubmitUrl_Click);
			// 
			// AddRecipeFromUrlScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonSubmitUrl);
			this.Controls.Add(this.TextBoxRecipeUrl);
			this.Controls.Add(this.LabelRecipeUrl);
			this.Name = "AddRecipeFromUrlScreen";
			this.Size = new System.Drawing.Size(1701, 987);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.LabelRecipeUrl, 0);
			this.Controls.SetChildIndex(this.TextBoxRecipeUrl, 0);
			this.Controls.SetChildIndex(this.ButtonSubmitUrl, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LabelRecipeUrl;
		private System.Windows.Forms.TextBox TextBoxRecipeUrl;
		private System.Windows.Forms.Button ButtonSubmitUrl;
	}
}
