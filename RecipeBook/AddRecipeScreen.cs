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
            var list = new List<string>(this.richTextBoxRecipe.Lines);
            list[0] += " " + recipe.Name;
            list[1] += " " + recipe.PrepTime;
            list[2] += " " + recipe.CookTime;
            list[3] += " " + recipe.Yield;
            int index = 0;
            int lineIndex = 5;
            foreach (var key in recipe.Ingredients.Keys)
            {
                if (key != "")
                {
                    list.Insert(lineIndex, key);
                    lineIndex++;
                }
                for (index = 0; index < recipe.Ingredients[key].Count; index++)
                {
                    if(recipe.Ingredients[key][index].Quantity==0 && recipe.Ingredients[key][index].Measurement == Measurement.Unit)
                    {
                        list.Insert(lineIndex, recipe.Ingredients[key][index].Name);
                    }
                    else { 
                    list.Insert(lineIndex, recipe.Ingredients[key][index].Quantity + " " + recipe.Ingredients[key][index].Measurement.ToString() + (recipe.Ingredients[key][index].Quantity > 1 ? "s " : " ") + recipe.Ingredients[key][index].Name);
                    }
                    lineIndex++;
                }
            }
            lineIndex++;
            for (index = 0; index < recipe.Instructions.Count; index++)
            {
                list.Insert(lineIndex, recipe.Instructions[index]); lineIndex++;
            }
            lineIndex++;
            for (index = 0; index < recipe.Notes.Count; index++)
            {
                list.Add(recipe.Notes[index]); lineIndex++;
            }
            this.richTextBoxRecipe.Lines = list.ToArray();
            int lenghtLinesBefore = 0;
            bool afterIngredients = false;
            for (index = 0; index < this.richTextBoxRecipe.Lines.Length; index++)
            {
                if (this.richTextBoxRecipe.Lines[index] == "Instructions:")
                {
                    afterIngredients = true;
                }
                if (this.richTextBoxRecipe.Lines[index].Contains(":"))
                {
                    this.richTextBoxRecipe.Select(lenghtLinesBefore + this.richTextBoxRecipe.Lines[index].IndexOf(":"), this.richTextBoxRecipe.Lines[index].Length - this.richTextBoxRecipe.Lines[index].Substring(0, this.richTextBoxRecipe.Lines[index].IndexOf(":")).Length+1);
                    this.richTextBoxRecipe.SelectionFont = new Font(this.richTextBoxRecipe.Font, FontStyle.Regular);
                }
                else if (afterIngredients&&this.richTextBoxRecipe.Lines[index].Contains("."))
                {
                    this.richTextBoxRecipe.Select(lenghtLinesBefore + this.richTextBoxRecipe.Lines[index].IndexOf("."), this.richTextBoxRecipe.Lines[index].Length - this.richTextBoxRecipe.Lines[index].Substring(0, this.richTextBoxRecipe.Lines[index].IndexOf(".")).Length+1);
                    this.richTextBoxRecipe.SelectionFont = new Font(this.richTextBoxRecipe.Font, FontStyle.Regular);
                }
                else
                {
                    this.richTextBoxRecipe.Select(lenghtLinesBefore, this.richTextBoxRecipe.Lines[index].Length);
                    this.richTextBoxRecipe.SelectionFont = new Font(this.richTextBoxRecipe.Font, FontStyle.Regular);
                }
                Debug.WriteLine(this.richTextBoxRecipe.Lines[index]);
                lenghtLinesBefore += this.richTextBoxRecipe.Lines[index].Length+1;
            }

        }
        private void buttonSubmitURL_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("HERE");
            GetRecipe(this.textBoxURL.Text);
        }
    }
}
