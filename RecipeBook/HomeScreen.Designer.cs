
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
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonManageRecipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.AutoSize = true;
            this.buttonAddRecipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddRecipe.FlatAppearance.BorderSize = 0;
            this.buttonAddRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecipe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddRecipe.Location = new System.Drawing.Point(15, 0);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(96, 30);
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
            this.buttonManageRecipes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManageRecipes.Location = new System.Drawing.Point(0, 36);
            this.buttonManageRecipes.Name = "buttonManageRecipes";
            this.buttonManageRecipes.Size = new System.Drawing.Size(128, 30);
            this.buttonManageRecipes.TabIndex = 5;
            this.buttonManageRecipes.Text = "Manage Recipes";
            this.buttonManageRecipes.UseVisualStyleBackColor = true;
            this.buttonManageRecipes.Click += new System.EventHandler(this.buttonManageRecipes_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonManageRecipes);
            this.Controls.Add(this.buttonAddRecipe);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(670, 358);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonManageRecipes;
    }
}
