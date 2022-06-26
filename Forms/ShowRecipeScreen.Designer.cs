
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
			this.ButtonResetConversions = new System.Windows.Forms.Button();
			this.ButtonQuartToPint = new System.Windows.Forms.Button();
			this.ButtonGallonToQuart = new System.Windows.Forms.Button();
			this.ButtonCupToFluidOunce = new System.Windows.Forms.Button();
			this.ButtonOunceToGram = new System.Windows.Forms.Button();
			this.ButtonCelsiusToFahrenheit = new System.Windows.Forms.Button();
			this.ButtonPintToCup = new System.Windows.Forms.Button();
			this.ButtonTableSpoonToMilliLiter = new System.Windows.Forms.Button();
			this.ButtonTeaSpoonToMilliLitter = new System.Windows.Forms.Button();
			this.ButtonKgToGram = new System.Windows.Forms.Button();
			this.ButtonGallonToLiter = new System.Windows.Forms.Button();
			this.ButtonPoundToGram = new System.Windows.Forms.Button();
			this.ButtonCupToMilliLiter = new System.Windows.Forms.Button();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelMain.SuspendLayout();
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
			this.RichTextBoxRecipeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RichTextBoxRecipeInfo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.RichTextBoxRecipeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.RichTextBoxRecipeInfo.Location = new System.Drawing.Point(63, 3);
			this.RichTextBoxRecipeInfo.Name = "RichTextBoxRecipeInfo";
			this.RichTextBoxRecipeInfo.ReadOnly = true;
			this.tableLayoutPanelMain.SetRowSpan(this.RichTextBoxRecipeInfo, 23);
			this.RichTextBoxRecipeInfo.Size = new System.Drawing.Size(1076, 715);
			this.RichTextBoxRecipeInfo.TabIndex = 7;
			this.RichTextBoxRecipeInfo.Text = "Name:\nURL:\nPrep Time:\nCook Time:\nYield:\nIngredients:\nInstructions:\nNotes:";
			// 
			// LabelScale
			// 
			this.LabelScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LabelScale.AutoSize = true;
			this.LabelScale.Location = new System.Drawing.Point(1145, 6);
			this.LabelScale.Name = "LabelScale";
			this.LabelScale.Size = new System.Drawing.Size(54, 17);
			this.LabelScale.TabIndex = 8;
			this.LabelScale.Text = "Scale:";
			this.LabelScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonQuarterScale
			// 
			this.ButtonQuarterScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonQuarterScale.FlatAppearance.BorderSize = 0;
			this.ButtonQuarterScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuarterScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuarterScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonQuarterScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonQuarterScale.Location = new System.Drawing.Point(1145, 34);
			this.ButtonQuarterScale.Name = "ButtonQuarterScale";
			this.ButtonQuarterScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonQuarterScale.TabIndex = 9;
			this.ButtonQuarterScale.Text = "1/4x";
			this.ButtonQuarterScale.UseVisualStyleBackColor = true;
			this.ButtonQuarterScale.Click += new System.EventHandler(this.ButtonQuarterScale_Click);
			// 
			// ButtonHalfScale
			// 
			this.ButtonHalfScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonHalfScale.FlatAppearance.BorderSize = 0;
			this.ButtonHalfScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonHalfScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonHalfScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonHalfScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonHalfScale.Location = new System.Drawing.Point(1145, 65);
			this.ButtonHalfScale.Name = "ButtonHalfScale";
			this.ButtonHalfScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonHalfScale.TabIndex = 10;
			this.ButtonHalfScale.Text = "1/2x";
			this.ButtonHalfScale.UseVisualStyleBackColor = true;
			this.ButtonHalfScale.Click += new System.EventHandler(this.ButtonHalfScale_Click);
			// 
			// ButtonOneScale
			// 
			this.ButtonOneScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonOneScale.BackColor = System.Drawing.Color.Lime;
			this.ButtonOneScale.FlatAppearance.BorderSize = 0;
			this.ButtonOneScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.ButtonOneScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.ButtonOneScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOneScale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(0)))));
			this.ButtonOneScale.Location = new System.Drawing.Point(1145, 96);
			this.ButtonOneScale.Name = "ButtonOneScale";
			this.ButtonOneScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonOneScale.TabIndex = 11;
			this.ButtonOneScale.Text = "1x";
			this.ButtonOneScale.UseVisualStyleBackColor = false;
			this.ButtonOneScale.Click += new System.EventHandler(this.ButtonOneScale_Click);
			// 
			// ButtonDoubleScale
			// 
			this.ButtonDoubleScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonDoubleScale.FlatAppearance.BorderSize = 0;
			this.ButtonDoubleScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonDoubleScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonDoubleScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDoubleScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonDoubleScale.Location = new System.Drawing.Point(1145, 127);
			this.ButtonDoubleScale.Name = "ButtonDoubleScale";
			this.ButtonDoubleScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonDoubleScale.TabIndex = 12;
			this.ButtonDoubleScale.Text = "2x";
			this.ButtonDoubleScale.UseVisualStyleBackColor = true;
			this.ButtonDoubleScale.Click += new System.EventHandler(this.ButtonDoubleScale_Click);
			// 
			// ButtonQuadrupleScale
			// 
			this.ButtonQuadrupleScale.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonQuadrupleScale.FlatAppearance.BorderSize = 0;
			this.ButtonQuadrupleScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuadrupleScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuadrupleScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonQuadrupleScale.ForeColor = System.Drawing.Color.Lime;
			this.ButtonQuadrupleScale.Location = new System.Drawing.Point(1145, 158);
			this.ButtonQuadrupleScale.Name = "ButtonQuadrupleScale";
			this.ButtonQuadrupleScale.Size = new System.Drawing.Size(75, 23);
			this.ButtonQuadrupleScale.TabIndex = 13;
			this.ButtonQuadrupleScale.Text = "4x";
			this.ButtonQuadrupleScale.UseVisualStyleBackColor = true;
			this.ButtonQuadrupleScale.Click += new System.EventHandler(this.ButtonQuadrupleScale_Click);
			// 
			// LabelConversions
			// 
			this.LabelConversions.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LabelConversions.AutoSize = true;
			this.LabelConversions.Location = new System.Drawing.Point(1145, 192);
			this.LabelConversions.Name = "LabelConversions";
			this.LabelConversions.Size = new System.Drawing.Size(110, 17);
			this.LabelConversions.TabIndex = 14;
			this.LabelConversions.Text = "Conversions:";
			this.LabelConversions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonTableSpoonToTeaSpoon
			// 
			this.ButtonTableSpoonToTeaSpoon.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonTableSpoonToTeaSpoon.FlatAppearance.BorderSize = 0;
			this.ButtonTableSpoonToTeaSpoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonTableSpoonToTeaSpoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonTableSpoonToTeaSpoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonTableSpoonToTeaSpoon.ForeColor = System.Drawing.Color.Lime;
			this.ButtonTableSpoonToTeaSpoon.Location = new System.Drawing.Point(1145, 250);
			this.ButtonTableSpoonToTeaSpoon.Name = "ButtonTableSpoonToTeaSpoon";
			this.ButtonTableSpoonToTeaSpoon.Size = new System.Drawing.Size(123, 25);
			this.ButtonTableSpoonToTeaSpoon.TabIndex = 15;
			this.ButtonTableSpoonToTeaSpoon.Text = "Tbsp. -> Tsp.";
			this.ButtonTableSpoonToTeaSpoon.UseVisualStyleBackColor = true;
			this.ButtonTableSpoonToTeaSpoon.Click += new System.EventHandler(this.ButtonTableSpoonToTeaSpoon_Click);
			// 
			// ButtonCupToTableSpoon
			// 
			this.ButtonCupToTableSpoon.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonCupToTableSpoon.FlatAppearance.BorderSize = 0;
			this.ButtonCupToTableSpoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTableSpoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTableSpoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCupToTableSpoon.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCupToTableSpoon.Location = new System.Drawing.Point(1145, 281);
			this.ButtonCupToTableSpoon.Name = "ButtonCupToTableSpoon";
			this.ButtonCupToTableSpoon.Size = new System.Drawing.Size(126, 25);
			this.ButtonCupToTableSpoon.TabIndex = 16;
			this.ButtonCupToTableSpoon.Text = "Cup -> Tbsp.";
			this.ButtonCupToTableSpoon.UseVisualStyleBackColor = true;
			this.ButtonCupToTableSpoon.Click += new System.EventHandler(this.ButtonCupToTableSpoon_Click);
			// 
			// ButtonCupToTeaSpoon
			// 
			this.ButtonCupToTeaSpoon.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonCupToTeaSpoon.FlatAppearance.BorderSize = 0;
			this.ButtonCupToTeaSpoon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTeaSpoon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToTeaSpoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCupToTeaSpoon.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCupToTeaSpoon.Location = new System.Drawing.Point(1145, 312);
			this.ButtonCupToTeaSpoon.Name = "ButtonCupToTeaSpoon";
			this.ButtonCupToTeaSpoon.Size = new System.Drawing.Size(126, 25);
			this.ButtonCupToTeaSpoon.TabIndex = 17;
			this.ButtonCupToTeaSpoon.Text = "Cup -> Tsp.";
			this.ButtonCupToTeaSpoon.UseVisualStyleBackColor = true;
			this.ButtonCupToTeaSpoon.Click += new System.EventHandler(this.ButtonCupToTeaSpoon_Click);
			// 
			// ButtonResetConversions
			// 
			this.ButtonResetConversions.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonResetConversions.FlatAppearance.BorderSize = 0;
			this.ButtonResetConversions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonResetConversions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonResetConversions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonResetConversions.ForeColor = System.Drawing.Color.Lime;
			this.ButtonResetConversions.Location = new System.Drawing.Point(1145, 219);
			this.ButtonResetConversions.Name = "ButtonResetConversions";
			this.ButtonResetConversions.Size = new System.Drawing.Size(162, 25);
			this.ButtonResetConversions.TabIndex = 18;
			this.ButtonResetConversions.Text = "Reset Conversions";
			this.ButtonResetConversions.UseVisualStyleBackColor = true;
			this.ButtonResetConversions.Click += new System.EventHandler(this.ButtonResetConversions_Click);
			// 
			// ButtonQuartToPint
			// 
			this.ButtonQuartToPint.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonQuartToPint.FlatAppearance.BorderSize = 0;
			this.ButtonQuartToPint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuartToPint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonQuartToPint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonQuartToPint.ForeColor = System.Drawing.Color.Lime;
			this.ButtonQuartToPint.Location = new System.Drawing.Point(1145, 405);
			this.ButtonQuartToPint.Name = "ButtonQuartToPint";
			this.ButtonQuartToPint.Size = new System.Drawing.Size(126, 25);
			this.ButtonQuartToPint.TabIndex = 21;
			this.ButtonQuartToPint.Text = "Quart -> Pint";
			this.ButtonQuartToPint.UseVisualStyleBackColor = true;
			this.ButtonQuartToPint.Click += new System.EventHandler(this.ButtonQuartToPint_Click);
			// 
			// ButtonGallonToQuart
			// 
			this.ButtonGallonToQuart.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonGallonToQuart.FlatAppearance.BorderSize = 0;
			this.ButtonGallonToQuart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonGallonToQuart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonGallonToQuart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonGallonToQuart.ForeColor = System.Drawing.Color.Lime;
			this.ButtonGallonToQuart.Location = new System.Drawing.Point(1145, 374);
			this.ButtonGallonToQuart.Name = "ButtonGallonToQuart";
			this.ButtonGallonToQuart.Size = new System.Drawing.Size(147, 25);
			this.ButtonGallonToQuart.TabIndex = 20;
			this.ButtonGallonToQuart.Text = "Gallon -> Quart";
			this.ButtonGallonToQuart.UseVisualStyleBackColor = true;
			this.ButtonGallonToQuart.Click += new System.EventHandler(this.ButtonGallonToQuart_Click);
			// 
			// ButtonCupToFluidOunce
			// 
			this.ButtonCupToFluidOunce.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonCupToFluidOunce.FlatAppearance.BorderSize = 0;
			this.ButtonCupToFluidOunce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToFluidOunce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToFluidOunce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCupToFluidOunce.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCupToFluidOunce.Location = new System.Drawing.Point(1145, 343);
			this.ButtonCupToFluidOunce.Name = "ButtonCupToFluidOunce";
			this.ButtonCupToFluidOunce.Size = new System.Drawing.Size(145, 25);
			this.ButtonCupToFluidOunce.TabIndex = 19;
			this.ButtonCupToFluidOunce.Text = "Cup -> Fluid Oz.";
			this.ButtonCupToFluidOunce.UseVisualStyleBackColor = true;
			this.ButtonCupToFluidOunce.Click += new System.EventHandler(this.ButtonCupToFluidOunce_Click);
			// 
			// ButtonOunceToGram
			// 
			this.ButtonOunceToGram.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonOunceToGram.FlatAppearance.BorderSize = 0;
			this.ButtonOunceToGram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonOunceToGram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonOunceToGram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonOunceToGram.ForeColor = System.Drawing.Color.Lime;
			this.ButtonOunceToGram.Location = new System.Drawing.Point(1145, 498);
			this.ButtonOunceToGram.Name = "ButtonOunceToGram";
			this.ButtonOunceToGram.Size = new System.Drawing.Size(126, 25);
			this.ButtonOunceToGram.TabIndex = 24;
			this.ButtonOunceToGram.Text = "Oz. -> Gram";
			this.ButtonOunceToGram.UseVisualStyleBackColor = true;
			this.ButtonOunceToGram.Click += new System.EventHandler(this.ButtonOunceToGram_Click);
			// 
			// ButtonCelsiusToFahrenheit
			// 
			this.ButtonCelsiusToFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonCelsiusToFahrenheit.FlatAppearance.BorderSize = 0;
			this.ButtonCelsiusToFahrenheit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCelsiusToFahrenheit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCelsiusToFahrenheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCelsiusToFahrenheit.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCelsiusToFahrenheit.Location = new System.Drawing.Point(1145, 467);
			this.ButtonCelsiusToFahrenheit.Name = "ButtonCelsiusToFahrenheit";
			this.ButtonCelsiusToFahrenheit.Size = new System.Drawing.Size(184, 25);
			this.ButtonCelsiusToFahrenheit.TabIndex = 23;
			this.ButtonCelsiusToFahrenheit.Text = "Celsius -> Fahrenheit";
			this.ButtonCelsiusToFahrenheit.UseVisualStyleBackColor = true;
			this.ButtonCelsiusToFahrenheit.Click += new System.EventHandler(this.ButtonCelsiusToFahrenheit_Click);
			// 
			// ButtonPintToCup
			// 
			this.ButtonPintToCup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonPintToCup.FlatAppearance.BorderSize = 0;
			this.ButtonPintToCup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonPintToCup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonPintToCup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonPintToCup.ForeColor = System.Drawing.Color.Lime;
			this.ButtonPintToCup.Location = new System.Drawing.Point(1145, 436);
			this.ButtonPintToCup.Name = "ButtonPintToCup";
			this.ButtonPintToCup.Size = new System.Drawing.Size(123, 25);
			this.ButtonPintToCup.TabIndex = 22;
			this.ButtonPintToCup.Text = "Pint -> Cup";
			this.ButtonPintToCup.UseVisualStyleBackColor = true;
			this.ButtonPintToCup.Click += new System.EventHandler(this.ButtonPintToCup_Click);
			// 
			// ButtonTableSpoonToMilliLiter
			// 
			this.ButtonTableSpoonToMilliLiter.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonTableSpoonToMilliLiter.FlatAppearance.BorderSize = 0;
			this.ButtonTableSpoonToMilliLiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonTableSpoonToMilliLiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonTableSpoonToMilliLiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonTableSpoonToMilliLiter.ForeColor = System.Drawing.Color.Lime;
			this.ButtonTableSpoonToMilliLiter.Location = new System.Drawing.Point(1145, 560);
			this.ButtonTableSpoonToMilliLiter.Name = "ButtonTableSpoonToMilliLiter";
			this.ButtonTableSpoonToMilliLiter.Size = new System.Drawing.Size(126, 25);
			this.ButtonTableSpoonToMilliLiter.TabIndex = 27;
			this.ButtonTableSpoonToMilliLiter.Text = "Tbsp. -> mL";
			this.ButtonTableSpoonToMilliLiter.UseVisualStyleBackColor = true;
			this.ButtonTableSpoonToMilliLiter.Click += new System.EventHandler(this.ButtonTableSpoonToMilliLiter_Click);
			// 
			// ButtonTeaSpoonToMilliLitter
			// 
			this.ButtonTeaSpoonToMilliLitter.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonTeaSpoonToMilliLitter.FlatAppearance.BorderSize = 0;
			this.ButtonTeaSpoonToMilliLitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonTeaSpoonToMilliLitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonTeaSpoonToMilliLitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonTeaSpoonToMilliLitter.ForeColor = System.Drawing.Color.Lime;
			this.ButtonTeaSpoonToMilliLitter.Location = new System.Drawing.Point(1145, 591);
			this.ButtonTeaSpoonToMilliLitter.Name = "ButtonTeaSpoonToMilliLitter";
			this.ButtonTeaSpoonToMilliLitter.Size = new System.Drawing.Size(126, 25);
			this.ButtonTeaSpoonToMilliLitter.TabIndex = 26;
			this.ButtonTeaSpoonToMilliLitter.Text = "Tsp. -> mL";
			this.ButtonTeaSpoonToMilliLitter.UseVisualStyleBackColor = true;
			this.ButtonTeaSpoonToMilliLitter.Click += new System.EventHandler(this.ButtonTeaSpoonToMilliLitter_Click);
			// 
			// ButtonKgToGram
			// 
			this.ButtonKgToGram.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonKgToGram.FlatAppearance.BorderSize = 0;
			this.ButtonKgToGram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonKgToGram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonKgToGram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonKgToGram.ForeColor = System.Drawing.Color.Lime;
			this.ButtonKgToGram.Location = new System.Drawing.Point(1145, 529);
			this.ButtonKgToGram.Name = "ButtonKgToGram";
			this.ButtonKgToGram.Size = new System.Drawing.Size(123, 25);
			this.ButtonKgToGram.TabIndex = 25;
			this.ButtonKgToGram.Text = "Kg. -> Gram";
			this.ButtonKgToGram.UseVisualStyleBackColor = true;
			this.ButtonKgToGram.Click += new System.EventHandler(this.ButtonKgToGram_Click);
			// 
			// ButtonGallonToLiter
			// 
			this.ButtonGallonToLiter.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonGallonToLiter.FlatAppearance.BorderSize = 0;
			this.ButtonGallonToLiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonGallonToLiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonGallonToLiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonGallonToLiter.ForeColor = System.Drawing.Color.Lime;
			this.ButtonGallonToLiter.Location = new System.Drawing.Point(1145, 653);
			this.ButtonGallonToLiter.Name = "ButtonGallonToLiter";
			this.ButtonGallonToLiter.Size = new System.Drawing.Size(130, 25);
			this.ButtonGallonToLiter.TabIndex = 30;
			this.ButtonGallonToLiter.Text = "Gallon -> Liter";
			this.ButtonGallonToLiter.UseVisualStyleBackColor = true;
			this.ButtonGallonToLiter.Click += new System.EventHandler(this.ButtonGallonToLiter_Click);
			// 
			// ButtonPoundToGram
			// 
			this.ButtonPoundToGram.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonPoundToGram.FlatAppearance.BorderSize = 0;
			this.ButtonPoundToGram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonPoundToGram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonPoundToGram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonPoundToGram.ForeColor = System.Drawing.Color.Lime;
			this.ButtonPoundToGram.Location = new System.Drawing.Point(1145, 687);
			this.ButtonPoundToGram.Name = "ButtonPoundToGram";
			this.ButtonPoundToGram.Size = new System.Drawing.Size(138, 27);
			this.ButtonPoundToGram.TabIndex = 29;
			this.ButtonPoundToGram.Text = "Pound -> Gram";
			this.ButtonPoundToGram.UseVisualStyleBackColor = true;
			this.ButtonPoundToGram.Click += new System.EventHandler(this.ButtonPoundToGram_Click);
			// 
			// ButtonCupToMilliLiter
			// 
			this.ButtonCupToMilliLiter.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ButtonCupToMilliLiter.FlatAppearance.BorderSize = 0;
			this.ButtonCupToMilliLiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToMilliLiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonCupToMilliLiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCupToMilliLiter.ForeColor = System.Drawing.Color.Lime;
			this.ButtonCupToMilliLiter.Location = new System.Drawing.Point(1145, 622);
			this.ButtonCupToMilliLiter.Name = "ButtonCupToMilliLiter";
			this.ButtonCupToMilliLiter.Size = new System.Drawing.Size(123, 25);
			this.ButtonCupToMilliLiter.TabIndex = 28;
			this.ButtonCupToMilliLiter.Text = "Cup -> mL";
			this.ButtonCupToMilliLiter.UseVisualStyleBackColor = true;
			this.ButtonCupToMilliLiter.Click += new System.EventHandler(this.ButtonCupToMilliLiter_Click);
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelMain.Controls.Add(this.RichTextBoxRecipeInfo, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonPoundToGram, 2, 22);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonGallonToLiter, 2, 21);
			this.tableLayoutPanelMain.Controls.Add(this.LabelScale, 2, 0);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonQuarterScale, 2, 1);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonCupToMilliLiter, 2, 20);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonHalfScale, 2, 2);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonTeaSpoonToMilliLitter, 2, 19);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonTableSpoonToMilliLiter, 2, 18);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonOneScale, 2, 3);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonDoubleScale, 2, 4);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonKgToGram, 2, 17);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonQuadrupleScale, 2, 5);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonOunceToGram, 2, 16);
			this.tableLayoutPanelMain.Controls.Add(this.LabelConversions, 2, 6);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonCelsiusToFahrenheit, 2, 15);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonResetConversions, 2, 7);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonPintToCup, 2, 14);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonTableSpoonToTeaSpoon, 2, 8);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonQuartToPint, 2, 13);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonCupToTableSpoon, 2, 9);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonGallonToQuart, 2, 12);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonCupToTeaSpoon, 2, 10);
			this.tableLayoutPanelMain.Controls.Add(this.ButtonCupToFluidOunce, 2, 11);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.MinimumSize = new System.Drawing.Size(1334, 721);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 23;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.546116F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.544299F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1334, 721);
			this.tableLayoutPanelMain.TabIndex = 31;
			// 
			// ShowRecipeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Name = "ShowRecipeScreen";
			this.Size = new System.Drawing.Size(1334, 721);
			this.Enter += new System.EventHandler(this.ShowRecipeScreen_Enter);
			this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
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
		private System.Windows.Forms.Button ButtonResetConversions;
		private System.Windows.Forms.Button ButtonQuartToPint;
		private System.Windows.Forms.Button ButtonGallonToQuart;
		private System.Windows.Forms.Button ButtonCupToFluidOunce;
		private System.Windows.Forms.Button ButtonOunceToGram;
		private System.Windows.Forms.Button ButtonCelsiusToFahrenheit;
		private System.Windows.Forms.Button ButtonPintToCup;
		private System.Windows.Forms.Button ButtonTableSpoonToMilliLiter;
		private System.Windows.Forms.Button ButtonTeaSpoonToMilliLitter;
		private System.Windows.Forms.Button ButtonKgToGram;
		private System.Windows.Forms.Button ButtonGallonToLiter;
		private System.Windows.Forms.Button ButtonPoundToGram;
		private System.Windows.Forms.Button ButtonCupToMilliLiter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
	}
}
