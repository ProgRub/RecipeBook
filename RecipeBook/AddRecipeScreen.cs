using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class AddRecipeScreen : UserControl
    {
        private string[] _baseRecipeText;
        public AddRecipeScreen()
        {
            InitializeComponent();
            this._baseRecipeText = this.richTextBoxRecipe.Lines;
        }

        private void GetRecipe(string url)
        {
            Debug.WriteLine("HERE");
            Recipe recipe = null;
            foreach (Recipe item in Recipe.Recipes)
            {
                if (item.URL == url)
                {
                    recipe = item;
                }
            }
            if (recipe == null) { 
            if (url.Contains("gimmesomeoven") || url.Contains("pinchofyum"))
            {
                recipe = new TastyRecipeScraper().ScrapeRecipe(url);
            }
            }
            UpdateRecipeTextBox(recipe);
        }

        private void UpdateRecipeTextBox(Recipe recipe)
        {
            this.richTextBoxRecipe.Lines = this._baseRecipeText;
            recipe.SetRecipeInRichTextBox(this.richTextBoxRecipe);

        }
        private void buttonSubmitURL_Click(object sender, EventArgs e)
        {
            GetRecipe(this.textBoxURL.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (this.Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0].Visible = true;
            (this.Parent as Form1).ActiveControl = (this.Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0];
            this.Dispose();
        }
    }
}
