using System;
using System.Linq;
using System.Windows.Forms;
using Components;
using Components.RecipeScrapers;

namespace RecipeBook
{
    public partial class AddRecipeScreen : UserControl, IShowRecipeScreen
    {
        private string[] _baseRecipeText;
        public AddRecipeScreen()
        {
            InitializeComponent();
            _baseRecipeText = richTextBoxRecipe.Lines;
        }

        private void GetRecipe(string url)
        {
            Recipe recipe = null;
            foreach (var item in Recipe.Recipes)
            {
                if (item.URL == url)
                {
                    recipe = item;
                }
            }
            if (recipe == null)
            {
                if (url.Contains("gimmesomeoven") || url.Contains("pinchofyum"))
                {
                    recipe = TastyRecipeScraper.Instance.ScrapeRecipe(url);
                }
                else if (url.Contains("delish"))
                {
                    recipe = DelishRecipeScraper.Instance.ScrapeRecipe(url);
                }
            }
            UpdateRecipeTextBox(recipe);
        }

        private void UpdateRecipeTextBox(Recipe recipe)
        {
            richTextBoxRecipe.Lines = _baseRecipeText;
            IShowRecipeScreen.SetRecipeInRichTextBox(richTextBoxRecipe, recipe);

        }
        private void buttonSubmitURL_Click(object sender, EventArgs e)
        {
            GetRecipe(textBoxURL.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0].Visible = true;
            (Parent as Form1).ActiveControl = (Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0];
            Dispose();
        }
    }
}
