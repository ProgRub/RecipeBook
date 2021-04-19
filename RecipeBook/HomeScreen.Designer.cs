
namespace RecipeBook
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
            this.buttonChooseDirectory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRecipes = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonManageRecipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChooseDirectory
            // 
            this.buttonChooseDirectory.AutoSize = true;
            this.buttonChooseDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChooseDirectory.FlatAppearance.BorderSize = 0;
            this.buttonChooseDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseDirectory.Location = new System.Drawing.Point(526, 37);
            this.buttonChooseDirectory.Name = "buttonChooseDirectory";
            this.buttonChooseDirectory.Size = new System.Drawing.Size(46, 25);
            this.buttonChooseDirectory.TabIndex = 0;
            this.buttonChooseDirectory.Text = "Open";
            this.buttonChooseDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseDirectory.Click += new System.EventHandler(this.buttonChooseDirectory_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(115, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(405, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelRecipes
            // 
            this.labelRecipes.AutoSize = true;
            this.labelRecipes.Location = new System.Drawing.Point(26, 42);
            this.labelRecipes.Name = "labelRecipes";
            this.labelRecipes.Size = new System.Drawing.Size(83, 15);
            this.labelRecipes.TabIndex = 2;
            this.labelRecipes.Text = "Recipes Folder";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(115, 21);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(53, 15);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Location";
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.AutoSize = true;
            this.buttonAddRecipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddRecipe.FlatAppearance.BorderSize = 0;
            this.buttonAddRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecipe.Location = new System.Drawing.Point(246, 68);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(77, 25);
            this.buttonAddRecipe.TabIndex = 4;
            this.buttonAddRecipe.Text = "Add Recipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // buttonManageRecipes
            // 
            this.buttonManageRecipes.AutoSize = true;
            this.buttonManageRecipes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonManageRecipes.FlatAppearance.BorderSize = 0;
            this.buttonManageRecipes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonManageRecipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonManageRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageRecipes.Location = new System.Drawing.Point(246, 99);
            this.buttonManageRecipes.Name = "buttonManageRecipes";
            this.buttonManageRecipes.Size = new System.Drawing.Size(103, 25);
            this.buttonManageRecipes.TabIndex = 5;
            this.buttonManageRecipes.Text = "Manage Recipes";
            this.buttonManageRecipes.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonManageRecipes);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelRecipes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonChooseDirectory);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(670, 358);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseDirectory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRecipes;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonManageRecipes;
    }
}
