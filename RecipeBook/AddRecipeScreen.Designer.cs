
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxURL.Location = new System.Drawing.Point(75, 399);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(484, 23);
            this.textBoxURL.TabIndex = 2;
            // 
            // labelRecipeURL
            // 
            this.labelRecipeURL.AutoSize = true;
            this.labelRecipeURL.Location = new System.Drawing.Point(3, 402);
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
            this.buttonSubmitURL.Location = new System.Drawing.Point(565, 397);
            this.buttonSubmitURL.Name = "buttonSubmitURL";
            this.buttonSubmitURL.Size = new System.Drawing.Size(79, 25);
            this.buttonSubmitURL.TabIndex = 4;
            this.buttonSubmitURL.Text = "Submit URL";
            this.buttonSubmitURL.UseVisualStyleBackColor = true;
            this.buttonSubmitURL.Click += new System.EventHandler(this.buttonSubmitURL_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(75, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 393);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Name:\nPrep Time:\nCook Time:\nYield:\nIngredients:\nInstructions:";
            // 
            // AddRecipeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSubmitURL);
            this.Controls.Add(this.labelRecipeURL);
            this.Controls.Add(this.textBoxURL);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.Name = "AddRecipeScreen";
            this.Size = new System.Drawing.Size(752, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelRecipes;
        private System.Windows.Forms.Button buttonSubmitURL;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelRecipeURL;
    }
}
