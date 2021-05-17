using System;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;
using Components;

namespace RecipeBook
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadRecipes();
            Application.Run(new Form1());
            SaveRecipes();

        }

        static void LoadRecipes()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Recipes.xml");
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                XDocument newDocument = new();
                newDocument.Add(new XElement("root", newDocument.Root));
                newDocument.Save(filePath);
                return;
            }
            var xmlDocument = XDocument.Load(filePath);

            foreach (var recipeElement in xmlDocument.Root.Elements("Recipe"))
            {
                var prepTimeString = recipeElement.Attribute("prepTime").Value;
                var prepTimeStringSplit = prepTimeString.Split(":");
                var cookTimeString = recipeElement.Attribute("cookTime").Value;
                var cookTimeStringSplit = cookTimeString.Split(":");
                var recipe=new Recipe(recipeElement.Attribute("name").Value, new TimeSpan(int.Parse(prepTimeStringSplit[0]), int.Parse(prepTimeStringSplit[1]), int.Parse(prepTimeStringSplit[2])), new TimeSpan(int.Parse(cookTimeStringSplit[0]), int.Parse(cookTimeStringSplit[1]), int.Parse(cookTimeStringSplit[2])), recipeElement.Attribute("yield").Value, recipeElement.Attribute("url").Value);
                foreach (var ingredient in recipeElement.Descendants("Ingredient")){
                    recipe.AddIngredient(ingredient.Attribute("for").Value, new Ingredient(double.Parse(ingredient.Attribute("quantity").Value), ingredient.Value, (Measurement)Enum.Parse(typeof(Measurement), ingredient.Attribute("measurement").Value)));
                }
                foreach (var instruction in recipeElement.Descendants("Instruction")){
                    recipe.AddInstruction(instruction.Value);
                }
                foreach (var note in recipeElement.Descendants("Note"))
                {
                    recipe.AddNote(note.Value);
                }
            }
        }

        static void SaveRecipes()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Recipes.xml");
            var xmlDocument = XDocument.Load(filePath);
            xmlDocument.Root.RemoveAll();
            foreach (var recipe in Recipe.Recipes)
            {
                recipe.Scale(1);
                var xElementRecipe= new XElement("Recipe");
                xElementRecipe.SetAttributeValue("name", recipe.Name);
                xElementRecipe.SetAttributeValue("prepTime", recipe.PrepTime.ToString());
                xElementRecipe.SetAttributeValue("cookTime", recipe.CookTime.ToString());
                xElementRecipe.SetAttributeValue("yield", recipe.Yield);
                xElementRecipe.SetAttributeValue("url", recipe.URL);
                foreach (var key in recipe.Ingredients.Keys)
                {
                    foreach (var ingredient in recipe.Ingredients[key])
                    {
                        var xElementIngredient = new XElement("Ingredient");
                        xElementIngredient.SetAttributeValue("measurement", ingredient.Measurement);
                        xElementIngredient.SetAttributeValue("quantity", ingredient.Quantity);
                        xElementIngredient.SetAttributeValue("for", key);
                        xElementIngredient.Value = ingredient.Name;
                        xElementRecipe.Add(xElementIngredient);
                    }
                }
                foreach (var instruction in recipe.Instructions)
                {
                    var xElementInstruction = new XElement("Instruction", instruction);
                    xElementRecipe.Add(xElementInstruction);
                }
                foreach (var note in recipe.Notes)
                {
                    var xElementNote = new XElement("Note", note);
                    xElementRecipe.Add(xElementNote);
                }
                xmlDocument.Root.Add(xElementRecipe);
            }
            xmlDocument.Save(filePath);
        }

    }
}
