using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeBook
{
    public class Recipe
    {
        public static List<Recipe> Recipes = new List<Recipe>();
        private TimeSpan _cookTime;
        private Dictionary<string,List<Ingredient>> _ingredients;
        private List<string> _instructions;
        private List<string> _notes;
        private string _name;
        private TimeSpan _prepTime;
        private string _yield;
        private string _url;

        public Recipe(string name, TimeSpan prepTime, TimeSpan cookTime, string yield,string url)
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

        public void AddIngredient(string key,Ingredient ingredient)
        {
            if (!this.Ingredients.ContainsKey(key))
            {
                this.Ingredients.Add(key, new List<Ingredient>());
            }
            this.Ingredients[key].Add(ingredient);
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