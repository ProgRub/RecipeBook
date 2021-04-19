
namespace RecipeBook
{
    partial class AddRecipeScreen
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
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelRecipeURL = new System.Windows.Forms.Label();
            this.buttonSubmitURL = new System.Windows.Forms.Button();
            this.richTextBoxRecipe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxURL.Location = new System.Drawing.Point(285, 565);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(484, 23);
            this.textBoxURL.TabIndex = 2;
            // 
            // labelRecipeURL
            // 
            this.labelRecipeURL.AutoSize = true;
            this.labelRecipeURL.Location = new System.Drawing.Point(213, 568);
            this.labelRecipeURL.Name = "labelRecipeURL";
            this.labelRecipeURL.Size = new System.Drawing.Size(66, 15);
            this.labelRecipeURL.TabIndex = 3;
            this.labelRecipeURL.Text = "Recipe URL";
            // 
            // buttonSubmitURL
            // 
            this.buttonSubmitURL.AutoSize = true;
            this.buttonSubmitURL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubmitURL.FlatAppearance.BorderSize = 0;
            this.buttonSubmitURL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSubmitURL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSubmitURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitURL.Location = new System.Drawing.Point(775, 563);
            this.buttonSubmitURL.Name = "buttonSubmitURL";
            this.buttonSubmitURL.Size = new System.Drawing.Size(79, 25);
            this.buttonSubmitURL.TabIndex = 4;
            this.buttonSubmitURL.Text = "Submit URL";
            this.buttonSubmitURL.UseVisualStyleBackColor = true;
            this.buttonSubmitURL.Click += new System.EventHandler(this.buttonSubmitURL_Click);
            // 
            // richTextBoxRecipe
            // 
            this.richTextBoxRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.richTextBoxRecipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxRecipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxRecipe.Location = new System.Drawing.Point(75, 0);
            this.richTextBoxRecipe.Name = "richTextBoxRecipe";
            this.richTextBoxRecipe.Size = new System.Drawing.Size(900, 559);
            this.richTextBoxRecipe.TabIndex = 6;
            this.richTextBoxRecipe.Text = "Name:\nPrep Time:\nCook Time:\nYield:\nIngredients:\nInstructions:\nNotes:";
            // 
            // AddRecipeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.richTextBoxRecipe);
            this.Controls.Add(this.buttonSubmitURL);
            this.Controls.Add(this.labelRecipeURL);
            this.Controls.Add(this.textBoxURL);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.Name = "AddRecipeScreen";
            this.Size = new System.Drawing.Size(1151, 674);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelRecipes;
        private System.Windows.Forms.Button buttonSubmitURL;
        private System.Windows.Forms.RichTextBox richTextBoxRecipe;
        private System.Windows.Forms.Label labelRecipeURL;
    }
}
