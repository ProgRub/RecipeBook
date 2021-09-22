
namespace Forms
{
	partial class AddRecipeManuallyScreen
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
			this.LabelRecipeTitle = new System.Windows.Forms.Label();
			this.LabelPrepTime = new System.Windows.Forms.Label();
			this.LabelCookTime = new System.Windows.Forms.Label();
			this.LabelYield = new System.Windows.Forms.Label();
			this.LabelIngredients = new System.Windows.Forms.Label();
			this.TextBoxRecipeTitle = new System.Windows.Forms.TextBox();
			this.DateTimePickerPrepTime = new System.Windows.Forms.DateTimePicker();
			this.DateTimePickerCookTime = new System.Windows.Forms.DateTimePicker();
			this.TextBoxYield = new System.Windows.Forms.TextBox();
			this.TreeViewIngredients = new System.Windows.Forms.TreeView();
			this.TextBoxInstructions = new System.Windows.Forms.TextBox();
			this.LabelInstructions = new System.Windows.Forms.Label();
			this.LabelNotes = new System.Windows.Forms.Label();
			this.TextBoxNotes = new System.Windows.Forms.TextBox();
			this.ButtonSaveRecipe = new System.Windows.Forms.Button();
			this.ButtonAddIngredient = new System.Windows.Forms.Button();
			this.ButtonUndo = new System.Windows.Forms.Button();
			this.ButtonRedo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonBack
			// 
			this.ButtonBack.FlatAppearance.BorderSize = 0;
			this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			// 
			// LabelRecipeTitle
			// 
			this.LabelRecipeTitle.AutoSize = true;
			this.LabelRecipeTitle.Location = new System.Drawing.Point(78, 13);
			this.LabelRecipeTitle.Name = "LabelRecipeTitle";
			this.LabelRecipeTitle.Size = new System.Drawing.Size(103, 17);
			this.LabelRecipeTitle.TabIndex = 6;
			this.LabelRecipeTitle.Text = "Recipe Title:";
			// 
			// LabelPrepTime
			// 
			this.LabelPrepTime.AutoSize = true;
			this.LabelPrepTime.Location = new System.Drawing.Point(89, 44);
			this.LabelPrepTime.Name = "LabelPrepTime";
			this.LabelPrepTime.Size = new System.Drawing.Size(92, 17);
			this.LabelPrepTime.TabIndex = 7;
			this.LabelPrepTime.Text = "Prep Time:";
			// 
			// LabelCookTime
			// 
			this.LabelCookTime.AutoSize = true;
			this.LabelCookTime.Location = new System.Drawing.Point(85, 71);
			this.LabelCookTime.Name = "LabelCookTime";
			this.LabelCookTime.Size = new System.Drawing.Size(96, 17);
			this.LabelCookTime.TabIndex = 8;
			this.LabelCookTime.Text = "Cook Time:";
			// 
			// LabelYield
			// 
			this.LabelYield.AutoSize = true;
			this.LabelYield.Location = new System.Drawing.Point(130, 100);
			this.LabelYield.Name = "LabelYield";
			this.LabelYield.Size = new System.Drawing.Size(51, 17);
			this.LabelYield.TabIndex = 9;
			this.LabelYield.Text = "Yield:";
			// 
			// LabelIngredients
			// 
			this.LabelIngredients.AutoSize = true;
			this.LabelIngredients.Location = new System.Drawing.Point(76, 126);
			this.LabelIngredients.Name = "LabelIngredients";
			this.LabelIngredients.Size = new System.Drawing.Size(105, 17);
			this.LabelIngredients.TabIndex = 10;
			this.LabelIngredients.Text = "Ingredients:";
			// 
			// TextBoxRecipeTitle
			// 
			this.TextBoxRecipeTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TextBoxRecipeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxRecipeTitle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxRecipeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TextBoxRecipeTitle.Location = new System.Drawing.Point(187, 10);
			this.TextBoxRecipeTitle.Name = "TextBoxRecipeTitle";
			this.TextBoxRecipeTitle.Size = new System.Drawing.Size(688, 24);
			this.TextBoxRecipeTitle.TabIndex = 13;
			// 
			// DateTimePickerPrepTime
			// 
			this.DateTimePickerPrepTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerPrepTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerPrepTime.Location = new System.Drawing.Point(187, 40);
			this.DateTimePickerPrepTime.Name = "DateTimePickerPrepTime";
			this.DateTimePickerPrepTime.Size = new System.Drawing.Size(89, 24);
			this.DateTimePickerPrepTime.TabIndex = 14;
			this.DateTimePickerPrepTime.Value = new System.DateTime(2021, 9, 22, 0, 0, 0, 0);
			// 
			// DateTimePickerCookTime
			// 
			this.DateTimePickerCookTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DateTimePickerCookTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerCookTime.Location = new System.Drawing.Point(187, 71);
			this.DateTimePickerCookTime.Name = "DateTimePickerCookTime";
			this.DateTimePickerCookTime.Size = new System.Drawing.Size(89, 24);
			this.DateTimePickerCookTime.TabIndex = 15;
			this.DateTimePickerCookTime.Value = new System.DateTime(2021, 9, 22, 0, 0, 0, 0);
			// 
			// TextBoxYield
			// 
			this.TextBoxYield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TextBoxYield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxYield.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxYield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TextBoxYield.Location = new System.Drawing.Point(187, 100);
			this.TextBoxYield.Name = "TextBoxYield";
			this.TextBoxYield.Size = new System.Drawing.Size(688, 24);
			this.TextBoxYield.TabIndex = 16;
			// 
			// TreeViewIngredients
			// 
			this.TreeViewIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TreeViewIngredients.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TreeViewIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TreeViewIngredients.Location = new System.Drawing.Point(187, 130);
			this.TreeViewIngredients.Name = "TreeViewIngredients";
			this.TreeViewIngredients.Size = new System.Drawing.Size(688, 555);
			this.TreeViewIngredients.TabIndex = 17;
			// 
			// TextBoxInstructions
			// 
			this.TextBoxInstructions.AcceptsReturn = true;
			this.TextBoxInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TextBoxInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxInstructions.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TextBoxInstructions.Location = new System.Drawing.Point(1003, 11);
			this.TextBoxInstructions.Multiline = true;
			this.TextBoxInstructions.Name = "TextBoxInstructions";
			this.TextBoxInstructions.Size = new System.Drawing.Size(862, 425);
			this.TextBoxInstructions.TabIndex = 19;
			// 
			// LabelInstructions
			// 
			this.LabelInstructions.AutoSize = true;
			this.LabelInstructions.Location = new System.Drawing.Point(888, 14);
			this.LabelInstructions.Name = "LabelInstructions";
			this.LabelInstructions.Size = new System.Drawing.Size(109, 17);
			this.LabelInstructions.TabIndex = 20;
			this.LabelInstructions.Text = "Instructions:";
			// 
			// LabelNotes
			// 
			this.LabelNotes.AutoSize = true;
			this.LabelNotes.Location = new System.Drawing.Point(939, 444);
			this.LabelNotes.Name = "LabelNotes";
			this.LabelNotes.Size = new System.Drawing.Size(58, 17);
			this.LabelNotes.TabIndex = 22;
			this.LabelNotes.Text = "Notes:";
			// 
			// TextBoxNotes
			// 
			this.TextBoxNotes.AcceptsReturn = true;
			this.TextBoxNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.TextBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxNotes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TextBoxNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.TextBoxNotes.Location = new System.Drawing.Point(1003, 442);
			this.TextBoxNotes.Multiline = true;
			this.TextBoxNotes.Name = "TextBoxNotes";
			this.TextBoxNotes.Size = new System.Drawing.Size(862, 425);
			this.TextBoxNotes.TabIndex = 21;
			// 
			// ButtonSaveRecipe
			// 
			this.ButtonSaveRecipe.AutoSize = true;
			this.ButtonSaveRecipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonSaveRecipe.FlatAppearance.BorderSize = 0;
			this.ButtonSaveRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonSaveRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSaveRecipe.Location = new System.Drawing.Point(900, 873);
			this.ButtonSaveRecipe.Name = "ButtonSaveRecipe";
			this.ButtonSaveRecipe.Size = new System.Drawing.Size(111, 27);
			this.ButtonSaveRecipe.TabIndex = 23;
			this.ButtonSaveRecipe.Text = "Save Recipe";
			this.ButtonSaveRecipe.UseVisualStyleBackColor = true;
			this.ButtonSaveRecipe.Click += new System.EventHandler(this.ButtonSaveRecipe_Click);
			// 
			// ButtonAddIngredient
			// 
			this.ButtonAddIngredient.AutoSize = true;
			this.ButtonAddIngredient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAddIngredient.FlatAppearance.BorderSize = 0;
			this.ButtonAddIngredient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddIngredient.Location = new System.Drawing.Point(464, 691);
			this.ButtonAddIngredient.Name = "ButtonAddIngredient";
			this.ButtonAddIngredient.Size = new System.Drawing.Size(137, 27);
			this.ButtonAddIngredient.TabIndex = 24;
			this.ButtonAddIngredient.Text = "Add Ingredient";
			this.ButtonAddIngredient.UseVisualStyleBackColor = true;
			this.ButtonAddIngredient.Click += new System.EventHandler(this.ButtonAddIngredient_Click);
			// 
			// ButtonUndo
			// 
			this.ButtonUndo.AutoSize = true;
			this.ButtonUndo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonUndo.FlatAppearance.BorderSize = 0;
			this.ButtonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonUndo.Image = global::Forms.Properties.Resources.Undo;
			this.ButtonUndo.Location = new System.Drawing.Point(501, 726);
			this.ButtonUndo.Name = "ButtonUndo";
			this.ButtonUndo.Size = new System.Drawing.Size(22, 22);
			this.ButtonUndo.TabIndex = 25;
			this.ButtonUndo.UseVisualStyleBackColor = true;
			this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
			// 
			// ButtonRedo
			// 
			this.ButtonRedo.AutoSize = true;
			this.ButtonRedo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonRedo.FlatAppearance.BorderSize = 0;
			this.ButtonRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonRedo.Image = global::Forms.Properties.Resources.Redo;
			this.ButtonRedo.Location = new System.Drawing.Point(539, 726);
			this.ButtonRedo.Name = "ButtonRedo";
			this.ButtonRedo.Size = new System.Drawing.Size(22, 22);
			this.ButtonRedo.TabIndex = 26;
			this.ButtonRedo.UseVisualStyleBackColor = true;
			this.ButtonRedo.Click += new System.EventHandler(this.ButtonRedo_Click);
			// 
			// AddRecipeManuallyScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ButtonRedo);
			this.Controls.Add(this.ButtonUndo);
			this.Controls.Add(this.ButtonAddIngredient);
			this.Controls.Add(this.ButtonSaveRecipe);
			this.Controls.Add(this.LabelNotes);
			this.Controls.Add(this.TextBoxNotes);
			this.Controls.Add(this.LabelInstructions);
			this.Controls.Add(this.TextBoxInstructions);
			this.Controls.Add(this.TreeViewIngredients);
			this.Controls.Add(this.TextBoxYield);
			this.Controls.Add(this.DateTimePickerCookTime);
			this.Controls.Add(this.DateTimePickerPrepTime);
			this.Controls.Add(this.TextBoxRecipeTitle);
			this.Controls.Add(this.LabelIngredients);
			this.Controls.Add(this.LabelYield);
			this.Controls.Add(this.LabelCookTime);
			this.Controls.Add(this.LabelPrepTime);
			this.Controls.Add(this.LabelRecipeTitle);
			this.Name = "AddRecipeManuallyScreen";
			this.Size = new System.Drawing.Size(1976, 943);
			this.Enter += new System.EventHandler(this.AddRecipeManuallyScreen_Enter);
			this.Controls.SetChildIndex(this.LabelRecipeTitle, 0);
			this.Controls.SetChildIndex(this.LabelPrepTime, 0);
			this.Controls.SetChildIndex(this.LabelCookTime, 0);
			this.Controls.SetChildIndex(this.LabelYield, 0);
			this.Controls.SetChildIndex(this.LabelIngredients, 0);
			this.Controls.SetChildIndex(this.TextBoxRecipeTitle, 0);
			this.Controls.SetChildIndex(this.DateTimePickerPrepTime, 0);
			this.Controls.SetChildIndex(this.DateTimePickerCookTime, 0);
			this.Controls.SetChildIndex(this.TextBoxYield, 0);
			this.Controls.SetChildIndex(this.TreeViewIngredients, 0);
			this.Controls.SetChildIndex(this.TextBoxInstructions, 0);
			this.Controls.SetChildIndex(this.LabelInstructions, 0);
			this.Controls.SetChildIndex(this.TextBoxNotes, 0);
			this.Controls.SetChildIndex(this.LabelNotes, 0);
			this.Controls.SetChildIndex(this.ButtonSaveRecipe, 0);
			this.Controls.SetChildIndex(this.ButtonAddIngredient, 0);
			this.Controls.SetChildIndex(this.ButtonUndo, 0);
			this.Controls.SetChildIndex(this.ButtonRedo, 0);
			this.Controls.SetChildIndex(this.ButtonBack, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelRecipeTitle;
		private System.Windows.Forms.Label LabelPrepTime;
		private System.Windows.Forms.Label LabelCookTime;
		private System.Windows.Forms.Label LabelYield;
		private System.Windows.Forms.Label LabelIngredients;
		private System.Windows.Forms.TextBox TextBoxRecipeTitle;
		private System.Windows.Forms.DateTimePicker DateTimePickerPrepTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerCookTime;
		private System.Windows.Forms.TextBox TextBoxYield;
		private System.Windows.Forms.TreeView TreeViewIngredients;
		private System.Windows.Forms.TextBox TextBoxInstructions;
		private System.Windows.Forms.Label LabelInstructions;
		private System.Windows.Forms.Label LabelNotes;
		private System.Windows.Forms.TextBox TextBoxNotes;
		private System.Windows.Forms.Button ButtonSaveRecipe;
		private System.Windows.Forms.Button ButtonAddIngredient;
		private System.Windows.Forms.Button ButtonUndo;
		private System.Windows.Forms.Button ButtonRedo;
	}
}
