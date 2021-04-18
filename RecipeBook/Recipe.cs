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
        private List<Ingredient> _ingredients;
        private List<string> _instructions;
        private string _name;
        private TimeSpan _prepTime;
        private Yield _yield;

        public Recipe(string name, TimeSpan prepTime, TimeSpan cookTime, string yield)
        {
            this._name = name;
            this._prepTime = prepTime;
            this._cookTime = cookTime;
            Recipes.Add(this);
        }

        public void AddInstruction(string instruction)
        {
            this.Instructions.Add(instruction);
        }

        public void AddIngredient(string name, double quantity, string measurement)
        {
            this.Ingredients.Add(new Ingredient(quantity, Name, Measurement.Celsius));
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

        public Yield Yield
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

        public List<Ingredient> Ingredients
        {
            get => _ingredients;
            set
            {
            }
        }
    }
}