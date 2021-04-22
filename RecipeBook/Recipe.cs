using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RecipeBook
{
    public class Recipe
    {
        public static List<Recipe> Recipes = new List<Recipe>();
        private TimeSpan _cookTime;
        private Dictionary<string, List<Ingredient>> _ingredients;
        private List<string> _instructions;
        private List<string> _notes;
        private string _name;
        private TimeSpan _prepTime;
        private string _yield;
        private string _url;
        private double scale = 1;

        public Recipe(string name, TimeSpan prepTime, TimeSpan cookTime, string yield, string url)
        {
            this._name = name;
            this._prepTime = prepTime;
            this._cookTime = cookTime;
            this._yield = yield;
            this._ingredients = new Dictionary<string, List<Ingredient>>();
            this._instructions = new List<string>();
            this._notes = new List<string>();
            this._url = url;
            Recipes.Add(this);
        }

        public void AddInstruction(string instruction)
        {
            this.Instructions.Add(instruction);
        }

        public void AddNote(string note)
        {
            this.Notes.Add(note);
        }

        public void AddIngredient(string key, Ingredient ingredient)
        {
            if (!this.Ingredients.ContainsKey(key))
            {
                this.Ingredients.Add(key, new List<Ingredient>());
            }
            this.Ingredients[key].Add(ingredient);
        }

        public void Scale(double multiplier)
        {
            if (multiplier != this.scale)
            {
                if (multiplier == 1)
                {
                    multiplier = 1 / this.scale;
                    this.scale = 1;
                }
                else
                {
                    foreach (string key in this.Ingredients.Keys)
                    {
                        foreach (Ingredient ingredient in this.Ingredients[key])
                        {
                            ingredient.Quantity /= this.scale;
                        }
                    }
                    this.scale = multiplier;
                }
                foreach (string key in this.Ingredients.Keys)
                {
                    foreach (Ingredient ingredient in this.Ingredients[key])
                    {
                        ingredient.Quantity *= multiplier;
                    }
                }
            }
        }


        public void SetRecipeInRichTextBox(RichTextBox richTextBox)
        {
            var list = new List<string>();
            list.Add("Name: " + this.Name);
            list.Add("Preparation Time: " + this.PrepTime);
            list.Add("Cooking Time: " + this.CookTime);
            list.Add("Yield: " + this.Yield);
            list.Add("Ingredients:");
            int index;
            foreach (var key in this.Ingredients.Keys)
            {
                if (key != "")
                {
                    list.Add(key);
                }
                for (index = 0; index < this.Ingredients[key].Count; index++)
                {
                    if (this.Ingredients[key][index].Quantity == 0 && this.Ingredients[key][index].Measurement == Measurement.Unit)
                    {
                        list.Add(this.Ingredients[key][index].Name);
                    }
                    else
                    {
                        list.Add(this.Ingredients[key][index].Quantity + " " + (this.Ingredients[key][index].Measurement != Measurement.Unit ? this.Ingredients[key][index].Measurement.ToString() + (this.Ingredients[key][index].Quantity > 1 ? "s " : " ") : "") + this.Ingredients[key][index].Name);
                    }
                }
            }
            list.Add("Instructions:");
            for (index = 0; index < this.Instructions.Count; index++)
            {
                list.Add(this.Instructions[index]);
            }
            list.Add("Notes:");
            for (index = 0; index < this.Notes.Count; index++)
            {
                list.Add(this.Notes[index]);
            }
            richTextBox.Lines = list.ToArray();
            int lenghtLinesBefore = 0;
            for (index = 0; index < richTextBox.Lines.Length; index++)
            {
                if (richTextBox.Lines[index].Contains(":"))
                {
                    richTextBox.Select(lenghtLinesBefore + richTextBox.Lines[index].IndexOf(":"), richTextBox.Lines[index].Length - richTextBox.Lines[index].Substring(0, richTextBox.Lines[index].IndexOf(":")).Length + 1);
                    richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
                }
                else
                {
                    richTextBox.Select(lenghtLinesBefore, richTextBox.Lines[index].Length);
                    richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
                }
                lenghtLinesBefore += richTextBox.Lines[index].Length + 1;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
            }
        }

        public TimeSpan PrepTime
        {
            get => _prepTime;
            set
            {
            }
        }

        public TimeSpan CookTime
        {
            get => _cookTime;
            set
            {
            }
        }

        public string Yield
        {
            get => _yield;
            set
            {
            }
        }

        public List<string> Instructions
        {
            get => _instructions;
            set
            {
            }
        }

        public List<string> Notes
        {
            get => _notes;
            set
            {
            }
        }

        public Dictionary<string, List<Ingredient>> Ingredients
        {
            get => _ingredients;
            set
            {
            }
        }

        public string URL
        {
            get => _url;
            set
            {
            }
        }
    }
}