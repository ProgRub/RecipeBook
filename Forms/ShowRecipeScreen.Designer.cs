
namespace Forms
{
	partial class ShowRecipeScreen
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
			this.RichTextBoxRecipeInfo = new System.Windows.Forms.RichTextBox();
			this.LabelScale = new System.Windows.Forms.Label();
			this.ButtonQuarterScale = new System.Windows.Forms.Button();
			this.ButtonHalfScale = new System.Windows.Forms.Button();
			this.ButtonOneScale = new System.Windows.Forms.Button();
			this.ButtonDoubleScale = new System.Windows.Forms.Button();
			this.ButtonQuadrupleScale = new System.Windows.Forms.Button();
			this.LabelConversions = new System.Windows.Forms.Label();
			this.ButtonTableSpoonToTeaSpoon = new System.Windows.Forms.Button();
			this.ButtonCupToTableSpoon = new System.Windows.Forms.Button();
			this.ButtonCupToTeaSpoon = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// RichTextBoxRecipeInfo
			// 
			this.RichTextBoxRecipeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.RichTextBoxRecipeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.RichTextBoxRecipeInfo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.RichTextBoxRecipeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.RichTextBoxRecipeInfo.Location = new System.Drawing.Point(62, 7);
			this.RichTextBoxRecipeInfo.Name = "RichTextBoxRecipeInfo";
			this.RichTextBoxRecipeInfo.ReadOnly = true;
			this.RichTextBoxRecipeInfo.Size = new System.Drawing.Size(1566, 924);
			this.RichTextBoxRecipeInfo.TabIndex = 7;
			this.RichTextBoxRecipeInfo.Text = "Name:\nURL:\nPrep Time:\nCook Time:\nYield:\nIngredients:\nInstructions:\nNotes:";
			// 
			// LabelScale
			// 
			this.LabelScale.AutoSize = true;
			this.LabelScale.Location = new System.Drawing.Point(1652, 9);
			this.LabelScale.Name = "LabelScale";
			this.LabelScale.Size = new System.Drawing.Size(54, 17);
			this.LabelScale.TabIndex = 8;
			this.LabelScale.Text = "Scale:";
			// 
			// ButtonQuarterScale
			// 
			this.ButtonQuarterScale.FlatAppearance.BorderSize = 0;
			this.ButtonQuarterScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuarterScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuarterScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonQuarterScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonQuarterScale.Location = new System.Drawing.Point(1643, 40);
			this.ButtonQuarterScale.Name = "ButtonQuarterScale";
			this.ButtonQuarterScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonQuarterScale.TabIndex = 9;
			this.ButtonQuarterScale.Text = "1/4x";
			this.ButtonQuarterScale.UseVisualStyleBackColor = true;
			this.ButtonQuarterScale.Click += new System.EventHandler(this.ButtonQuarterScale_Click);
			// 
			// ButtonHalfScale
			// 
			this.ButtonHalfScale.FlatAppearance.BorderSize = 0;
			this.ButtonHalfScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonHalfScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonHalfScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonHalfScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonHalfScale.Location = new System.Drawing.Point(1643, 69);
			this.ButtonHalfScale.Name = "ButtonHalfScale";
			this.ButtonHalfScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonHalfScale.TabIndex = 10;
			this.ButtonHalfScale.Text = "1/2x";
			this.ButtonHalfScale.UseVisualStyleBackColor = true;
			this.ButtonHalfScale.Click += new System.EventHandler(this.ButtonHalfScale_Click);
			// 
			// ButtonOneScale
			// 
			this.ButtonOneScale.BackColor = System.Drawing.Color.Lime;
			this.ButtonOneScale.FlatAppearance.BorderSize = 0;
			this.ButtonOneScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.ButtonOneScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.ButtonOneScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOneScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
			this.ButtonOneScale.Location = new System.Drawing.Point(1643, 98);
			this.ButtonOneScale.Name = "ButtonOneScale";
			this.ButtonOneScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonOneScale.TabIndex = 11;
			this.ButtonOneScale.Text = "1x";
			this.ButtonOneScale.UseVisualStyleBackColor = false;
			this.ButtonOneScale.Click += new System.EventHandler(this.ButtonOneScale_Click);
			// 
			// ButtonDoubleScale
			// 
			this.ButtonDoubleScale.FlatAppearance.BorderSize = 0;
			this.ButtonDoubleScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonDoubleScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonDoubleScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDoubleScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonDoubleScale.Location = new System.Drawing.Point(1643, 127);
			this.ButtonDoubleScale.Name = "ButtonDoubleScale";
			this.ButtonDoubleScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonDoubleScale.TabIndex = 12;
			this.ButtonDoubleScale.Text = "2x";
			this.ButtonDoubleScale.UseVisualStyleBackColor = true;
			this.ButtonDoubleScale.Click += new System.EventHandler(this.ButtonDoubleScale_Click);
			// 
			// ButtonQuadrupleScale
			// 
			this.ButtonQuadrupleScale.FlatAppearance.BorderSize = 0;
			this.ButtonQuadrupleScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuadrupleScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuadrupleScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonQuadrupleScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonQuadrupleScale.Location = new System.Drawing.Point(1643, 156);
			this.ButtonQuadrupleScale.Name = "ButtonQuadrupleScale";
			this.ButtonQuadrupleScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonQuadrupleScale.TabIndex = 13;
			this.ButtonQuadrupleScale.Text = "4x";
			this.ButtonQuadrupleScale.UseVisualStyleBackColor = true;
			this.ButtonQuadrupleScale.Click += new System.EventHandler(this.ButtonQuadrupleScale_Click);
			// 
			// LabelConversions
			// 
			this.LabelConversions.AutoSize = true;
			this.LabelConversions.Location = new System.Drawing.Point(1652, 205);
			this.LabelConversions.Name = "LabelConversions";
			this.LabelConversions.Size = new System.Drawing.Size(110, 17);
			this.LabelConversions.TabIndex = 14;
			this.LabelConversions.Text = "Conversions:";
			// 
			// ButtonTableSpoonToTeaSpoon
			// 
			this.ButtonTableSpoonToTeaSpoon.AutoSize = true;
			this.ButtonTableSpoonToTeaSpoon.FlatAppearance.BorderSize = 0;
			this.ButtonTableSpoonToTeaSpoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonTableSpoonToTeaSpoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonTableSpoonToTeaSpoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonTableSpoonToTeaSpoon.ForeColor = System.Drawing.Color.Lime;
			this.ButtonTableSpoonToTeaSpoon.Location = new System.Drawing.Point(1652, 239);
			this.ButtonTableSpoonToTeaSpoon.Name = "ButtonTableSpoonToTeaSpoon";
			this.ButtonTableSpoonToTeaSpoon.Size = new System.Drawing.Size(123, 27);
			this.ButtonTableSpoonToTeaSpoon.TabIndex = 15;
			this.ButtonTableSpoonToTeaSpoon.Text = "Tbsp. -> Tsp.";
			this.ButtonTableSpoonToTeaSpoon.UseVisualStyleBackColor = true;
			this.ButtonTableSpoonToTeaSpoon.Click += new System.EventHandler(this.ButtonTableSpoonToTeaSpoon_Click);
			// 
			// ButtonCupToTableSpoon
			// 
			this.ButtonCupToTableSpoon.AutoSize = true;
			this.ButtonCupToTableSpoon.FlatAppearance.BorderSize = 0;
			this.ButtonCupToTableSpoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTableSpoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTableSpoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCupToTableSpoon.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCupToTableSpoon.Location = new System.Drawing.Point(1649, 272);
			this.ButtonCupToTableSpoon.Name = "ButtonCupToTableSpoon";
			this.ButtonCupToTableSpoon.Size = new System.Drawing.Size(126, 27);
			this.ButtonCupToTableSpoon.TabIndex = 16;
			this.ButtonCupToTableSpoon.Text = "Cup -> Tbsp.";
			this.ButtonCupToTableSpoon.UseVisualStyleBackColor = true;
			this.ButtonCupToTableSpoon.Click += new System.EventHandler(this.ButtonCupToTableSpoon_Click);
			// 
			// ButtonCupToTeaSpoon
			// 
			this.ButtonCupToTeaSpoon.AutoSize = true;
			this.ButtonCupToTeaSpoon.FlatAppearance.BorderSize = 0;
			this.ButtonCupToTeaSpoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTeaSpoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTeaSpoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCupToTeaSpoon.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCupToTeaSpoon.Location = new System.Drawing.Point(1643, 305);
			this.ButtonCupToTeaSpoon.Name = "ButtonCupToTeaSpoon";
			this.ButtonCupToTeaSpoon.Size = new System.Drawing.Size(126, 27);
			this.ButtonCupToTeaSpoon.TabIndex = 17;
			this.ButtonCupToTeaSpoon.Text = "Cup -> Tsp.";
			this.ButtonCupToTeaSpoon.UseVisualStyleBackColor = true;
			this.ButtonCupToTeaSpoon.Click += new System.EventHandler(this.ButtonCupToTeaSpoon_Click);
			// 
			// ShowRecipeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonCupToTeaSpoon);
			this.Controls.Add(this.ButtonCupToTableSpoon);
			this.Controls.Add(this.ButtonTableSpoonToTeaSpoon);
			this.Controls.Add(this.LabelConversions);
			this.Controls.Add(this.ButtonQuadrupleScale);
			this.Controls.Add(this.ButtonDoubleScale);
			this.Controls.Add(this.ButtonOneScale);
			this.Controls.Add(this.ButtonHalfScale);
			this.Controls.Add(this.ButtonQuarterScale);
			this.Controls.Add(this.LabelScale);
			this.Controls.Add(this.RichTextBoxRecipeInfo);
			this.Name = "ShowRecipeScreen";
			this.Size = new System.Drawing.Size(1800, 934);
			this.Enter += new System.EventHandler(this.ShowRecipeScreen_Enter);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.Controls.SetChildIndex(this.RichTextBoxRecipeInfo, 0);
			this.Controls.SetChildIndex(this.LabelScale, 0);
			this.Controls.SetChildIndex(this.ButtonQuarterScale, 0);
			this.Controls.SetChildIndex(this.ButtonHalfScale, 0);
			this.Controls.SetChildIndex(this.ButtonOneScale, 0);
			this.Controls.SetChildIndex(this.ButtonDoubleScale, 0);
			this.Controls.SetChildIndex(this.ButtonQuadrupleScale, 0);
			this.Controls.SetChildIndex(this.LabelConversions, 0);
			this.Controls.SetChildIndex(this.ButtonTableSpoonToTeaSpoon, 0);
			this.Controls.SetChildIndex(this.ButtonCupToTableSpoon, 0);
			this.Controls.SetChildIndex(this.ButtonCupToTeaSpoon, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox RichTextBoxRecipeInfo;
		private System.Windows.Forms.Label LabelScale;
		private System.Windows.Forms.Button ButtonQuarterScale;
		private System.Windows.Forms.Button ButtonHalfScale;
		private System.Windows.Forms.Button ButtonOneScale;
		private System.Windows.Forms.Button ButtonDoubleScale;
		private System.Windows.Forms.Button ButtonQuadrupleScale;
		private System.Windows.Forms.Label LabelConversions;
		private System.Windows.Forms.Button ButtonTableSpoonToTeaSpoon;
		private System.Windows.Forms.Button ButtonCupToTableSpoon;
		private System.Windows.Forms.Button ButtonCupToTeaSpoon;
	}
}
