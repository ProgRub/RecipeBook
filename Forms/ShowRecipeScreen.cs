using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Entities;
using Services;
using Services.DTOs;

namespace Forms
{
	public partial class ShowRecipeScreen : BaseControl
	{
		protected RecipeDTO RecipeToShow { get; set; }

		public ShowRecipeScreen()
		{
			InitializeComponent();
		}

		private void ShowRecipeScreen_Enter(object sender, EventArgs e)
		{
			MaximizeWindow();
		}

		protected void SetRecipeInRichTextBox(RecipeDTO recipe)
		{
			var list = new List<string>
			{
				"Name: " + recipe.Name,
				"URL: " + recipe.Url,
				"Preparation Time: " + recipe.PrepTime,
				"Cooking Time: " + recipe.CookTime,
				"Yield: " + recipe.Yield,
				"Ingredients:"
			};
			int index;
			foreach (var key in recipe.IngredientsByComponent.Keys)
			{
				if (!string.IsNullOrWhiteSpace(key))
				{
					list.Add(key + ":");
				}

				for (index = 0; index < recipe.IngredientsByComponent[key].Count; index++)
				{
					if (recipe.IngredientsByComponent[key][index].Quantity == 0 &&
					    recipe.IngredientsByComponent[key][index].Measurement == Measurement.Unit)
					{
						list.Add(recipe.IngredientsByComponent[key][index].Name);
					}
					else
					{
						list.Add(recipe.IngredientsByComponent[key][index].Quantity + " " +
						         (recipe.IngredientsByComponent[key][index].Measurement != Measurement.Unit
							         ? recipe.IngredientsByComponent[key][index].Measurement +
							           (recipe.IngredientsByComponent[key][index].Quantity > 1 ? "s " : " ")
							         : "") + recipe.IngredientsByComponent[key][index].Name);
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

			RichTextBoxRecipeInfo.Lines = list.ToArray();
			var lengthLinesBefore = 0;
			for (index = 0; index < RichTextBoxRecipeInfo.Lines.Length; index++)
			{
				if (RichTextBoxRecipeInfo.Lines[index].Contains(":"))
				{
					RichTextBoxRecipeInfo.Select(lengthLinesBefore + RichTextBoxRecipeInfo.Lines[index].IndexOf(":"),
						RichTextBoxRecipeInfo.Lines[index].Length - RichTextBoxRecipeInfo.Lines[index]
							.Substring(0, RichTextBoxRecipeInfo.Lines[index].IndexOf(":")).Length + 1);
					RichTextBoxRecipeInfo.SelectionFont = new Font(RichTextBoxRecipeInfo.Font, FontStyle.Regular);
				}
				else
				{
					RichTextBoxRecipeInfo.Select(lengthLinesBefore, RichTextBoxRecipeInfo.Lines[index].Length);
					RichTextBoxRecipeInfo.SelectionFont = new Font(RichTextBoxRecipeInfo.Font, FontStyle.Regular);
				}

				lengthLinesBefore += RichTextBoxRecipeInfo.Lines[index].Length + 1;
			}
		}

		private void SetSelectedScaleButtonColor(ButtonBase selectedButton)
		{
			selectedButton.BackColor = Color.Lime;
			selectedButton.FlatAppearance.MouseDownBackColor = Color.Lime;
			selectedButton.FlatAppearance.MouseOverBackColor = Color.Lime;
			selectedButton.ForeColor = Color.FromArgb(0, 32, 0);
			foreach (var button in Controls.OfType<Button>().Where(e => e.Text.Contains("x")))
			{
				if (button == selectedButton) continue;
				button.BackColor = Color.FromArgb(0, 32, 0);
				button.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 32, 0);
				button.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 32, 0);
				button.ForeColor = Color.Lime;
			}
		}

		private void ButtonQuarterScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonQuarterScale);
			SetRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 0.25));
		}

		private void ButtonHalfScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonHalfScale);
			SetRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 0.5));
		}

		private void ButtonOneScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonOneScale);
			SetRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 1));
		}

		private void ButtonDoubleScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonDoubleScale);
			SetRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 2));
		}

		private void ButtonQuadrupleScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonQuadrupleScale);
			SetRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 4));
		}

		private void ButtonTableSpoonToTeaSpoon_Click(object sender, EventArgs e)
		{
			SetRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.TableSpoon_To_TeaSpoon, ButtonTableSpoonToTeaSpoon.Text != "Tbsp. -> Tsp."));
			ButtonTableSpoonToTeaSpoon.Text =
				ButtonTableSpoonToTeaSpoon.Text == "Tbsp. -> Tsp." ? "Tsp. -> Tbsp." : "Tbsp. -> Tsp.";
		}

		private void ButtonCupToTableSpoon_Click(object sender, EventArgs e)
		{
			SetRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Cup_To_TableSpoon,  ButtonCupToTableSpoon.Text != "Cup -> Tbsp."));
			ButtonCupToTableSpoon.Text =
				ButtonCupToTableSpoon.Text == "Cup -> Tbsp." ? "Tbsp. -> Cup" : "Cup -> Tbsp.";
		}

		private void ButtonCupToTeaSpoon_Click(object sender, EventArgs e)
		{
			SetRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Cup_To_TeaSpoon,  ButtonCupToTeaSpoon.Text != "Cup -> Tsp."));
			ButtonCupToTeaSpoon.Text =
				ButtonCupToTeaSpoon.Text == "Cup -> Tsp." ? "Tsp. -> Cup" : "Cup -> Tsp.";
		}

		private void ButtonResetConversions_Click(object sender, EventArgs e)
		{
			SetRecipeInRichTextBox(RecipeToShow);
		}
	}
}