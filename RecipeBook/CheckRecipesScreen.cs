using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class CheckRecipesScreen : UserControl
    {
        private Recipe recipe;
        public CheckRecipesScreen(int recipeIndex)
        {
            InitializeComponent();
            this.recipe = Recipe.Recipes[recipeIndex];
            this.recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (this.Parent as Form1).Controls.OfType<ManageRecipesScreen>().ToList()[0].Visible = true;
            (this.Parent as Form1).ActiveControl = (this.Parent as Form1).Controls.OfType<ManageRecipesScreen>().ToList()[0];
            this.Dispose();
        }

        private void ColorButtonUncolorOthers(Button button)
        {
            button.ForeColor = Color.FromArgb(255, 0, 40, 7);
            button.BackColor = Color.FromArgb(255, 69, 255, 49);
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.FlatAppearance.MouseDownBackColor = button.BackColor;
            foreach (var control in this.Controls.OfType<Button>().Where(x => x != button && x != this.buttonBack).ToList())
            {
                control.BackColor = Color.FromArgb(255, 0, 40, 7);
                control.FlatAppearance.MouseOverBackColor = control.BackColor;
                control.FlatAppearance.MouseDownBackColor = control.BackColor;
                control.ForeColor = Color.FromArgb(255, 69, 255, 49);
            }
        }

        private void buttonScaleQuarter_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(this.buttonScaleQuarter);
            this.recipe.Scale(0.25);
            this.recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);
        }

        private void buttonScaleHalf_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(this.buttonScaleHalf);
            this.recipe.Scale(0.5);
            this.recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);
        }

        private void buttonScaleOne_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(this.buttonScaleOne);
            this.recipe.Scale(1);
            this.recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);
        }

        private void buttonScaleDouble_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(this.buttonScaleDouble);
            this.recipe.Scale(2);
            this.recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);
        }

        private void buttonScaleTriple_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(this.buttonScaleTriple);
            this.recipe.Scale(3);
            this.recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);
        }
    }
}
