﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Components;

namespace RecipeBook
{
    public interface IShowRecipeScreen
    {
        public static void SetRecipeInRichTextBox(RichTextBox richTextBox,Recipe recipe)
        {
            var list = new List<string>();
            list.Add("Name: " + recipe.Name);
            list.Add("URL: " + recipe.URL);
            list.Add("Preparation Time: " + recipe.PrepTime);
            list.Add("Cooking Time: " + recipe.CookTime);
            list.Add("Yield: " + recipe.Yield);
            list.Add("Ingredients:");
            int index;
            foreach (var key in recipe.Ingredients.Keys)
            {
                if (key != "")
                {
                    list.Add(key+":");
                }
                for (index = 0; index < recipe.Ingredients[key].Count; index++)
                {
                    if (recipe.Ingredients[key][index].Quantity == 0 && recipe.Ingredients[key][index].Measurement == Measurement.Unit)
                    {
                        list.Add(recipe.Ingredients[key][index].Name);
                    }
                    else
                    {
                        list.Add(recipe.Ingredients[key][index].Quantity + " " + (recipe.Ingredients[key][index].Measurement != Measurement.Unit ? recipe.Ingredients[key][index].Measurement.ToString() + (recipe.Ingredients[key][index].Quantity > 1 ? "s " : " ") : "") + recipe.Ingredients[key][index].Name);
                    }
                }
            }
            list.Add("Instructions:");
            for (index = 0; index < recipe.Instructions.Count; index++)
            {
                list.Add(recipe.Instructions[index]);
            }
            list.Add("Notes:");
            for (index = 0; index < recipe.Notes.Count; index++)
            {
                list.Add(recipe.Notes[index]);
            }
            richTextBox.Lines = list.ToArray();
            var lenghtLinesBefore = 0;
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
    }
}