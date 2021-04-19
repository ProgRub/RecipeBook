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
using HtmlAgilityPack;
using System.Media;
using System.Net;

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

        private void ScrapeRecipe(string url)
        {
            Debug.WriteLine("HERE");
            Recipe recipe = null;
            if (url.Contains("gimmesomeoven") || url.Contains("pinchofyum"))
            {
                recipe = new TastyRecipeScraper().ScrapeRecipe(url);
            }
            UpdateRecipeTextBox(recipe);
        }

        private void UpdateRecipeTextBox(Recipe recipe)
        {
            this.richTextBoxRecipe.Lines = this._baseRecipeText;
            var list = new List<string>(this.richTextBoxRecipe.Lines);
            list[0] += " " + recipe.Name;
            list[1] += " " + recipe.PrepTime;
            list[2] += " " + recipe.CookTime;
            list[3] += " " + recipe.Yield;
            int index;
            for (index = 0; index < recipe.Ingredients.Count; index++)
            {
                list.Insert(5 + index, recipe.Ingredients[index].Name);
            }
            int lineIndex = 6 + index;
            for (index = 0; index < recipe.Instructions.Count; index++)
            {
                list.Insert(lineIndex + index, recipe.Instructions[index]);
            }
            for (index = 0; index < recipe.Notes.Count; index++)
            {
                list.Add(recipe.Notes[index]);
            }
            this.richTextBoxRecipe.Lines =list.ToArray();
            
        }
        private void buttonSubmitURL_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("HERE");
            ScrapeRecipe(this.textBoxURL.Text);
        }
    }
}
