using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Components;

namespace RecipeBook
{
    public partial class CheckRecipesScreen : UserControl
    {
        private Recipe recipe;
        public CheckRecipesScreen(int recipeIndex)
        {
            InitializeComponent();
            recipe = Recipe.Recipes[recipeIndex];
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (Parent as Form1).Controls.OfType<ManageRecipesScreen>().ToList()[0].Visible = true;
            (Parent as Form1).ActiveControl = (Parent as Form1).Controls.OfType<ManageRecipesScreen>().ToList()[0];
            Dispose();
        }

        private void ColorButtonUncolorOthers(Button button)
        {
            button.ForeColor = Color.FromArgb(255, 0, 40, 7);
            button.BackColor = Color.FromArgb(255, 69, 255, 49);
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.FlatAppearance.MouseDownBackColor = button.BackColor;
            foreach (var control in Controls.OfType<Button>().Where(x => x != button && x != buttonBack).ToList())
            {
                control.BackColor = Color.FromArgb(255, 0, 40, 7);
                control.FlatAppearance.MouseOverBackColor = control.BackColor;
                control.FlatAppearance.MouseDownBackColor = control.BackColor;
                control.ForeColor = Color.FromArgb(255, 69, 255, 49);
            }
        }

        private void buttonScaleQuarter_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(buttonScaleQuarter);
            recipe.Scale(0.25);
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);
        }

        private void buttonScaleHalf_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(buttonScaleHalf);
            recipe.Scale(0.5);
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);
        }

        private void buttonScaleOne_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(buttonScaleOne);
            recipe.Scale(1);
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);
        }

        private void buttonScaleDouble_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(buttonScaleDouble);
            recipe.Scale(2);
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);
        }

        private void buttonScaleTriple_Click(object sender, EventArgs e)
        {
            ColorButtonUncolorOthers(buttonScaleTriple);
            recipe.Scale(3);
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);
        }
    }
}
