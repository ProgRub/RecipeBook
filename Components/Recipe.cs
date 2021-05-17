using System;
using System.Collections.Generic;

namespace Components
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
            _name = name;
            _prepTime = prepTime;
            _cookTime = cookTime;
            _yield = yield;
            _ingredients = new Dictionary<string, List<Ingredient>>();
            _instructions = new List<string>();
            _notes = new List<string>();
            _url = url;
            Recipes.Add(this);
        }

        public void AddInstruction(string instruction)
        {
            Instructions.Add(instruction);
        }

        public void AddNote(string note)
        {
            Notes.Add(note);
        }

        public void AddIngredient(string key, Ingredient ingredient)
        {
            if (!Ingredients.ContainsKey(key))
            {
                Ingredients.Add(key, new List<Ingredient>());
            }
            Ingredients[key].Add(ingredient);
        }

        public void Scale(double multiplier)
        {
            if (multiplier != scale)
            {
                var yieldSplit = Yield.Split(null);
                double number;
                if (multiplier == 1)
                {
                    multiplier = 1 / scale;
                    scale = 1;
                }
                else
                {
                    for (var index = 0; index < yieldSplit.Length; index++)
                    {
                        if (yieldSplit[index].Contains("-"))
                        {
                            var aux = yieldSplit[index].Split('-');
                            for (var i = 0; i < aux.Length; i++)
                            {
                                aux[i] = (double.Parse(aux[i]) / scale).ToString();
                            }
                            yieldSplit[index] = string.Join('-', aux);
                        }
                        else if (double.TryParse(yieldSplit[index], out number))
                        {
                            yieldSplit[index] = (number / scale).ToString();
                        }
                    }
                    foreach (var key in Ingredients.Keys)
                    {
                        foreach (var ingredient in Ingredients[key])
                        {
                            ingredient.Quantity /= scale;
                        }
                    }
                    scale = multiplier;
                }
                for (var index = 0; index < yieldSplit.Length; index++)
                {
                    if (yieldSplit[index].Contains("-"))
                    {
                        var aux = yieldSplit[index].Split('-');
                        for (var i = 0; i < aux.Length; i++)
                        {
                            aux[i] = (double.Parse(aux[i]) * multiplier).ToString();
                        }
                        yieldSplit[index] = string.Join('-', aux);
                    }
                    else if (double.TryParse(yieldSplit[index], out number))
                    {
                        yieldSplit[index] = (number * multiplier).ToString();
                    }
                }
                _yield = string.Join(' ', yieldSplit);
                foreach (var key in Ingredients.Keys)
                {
                    foreach (var ingredient in Ingredients[key])
                    {
                        ingredient.Quantity *= multiplier;
                    }
                }
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