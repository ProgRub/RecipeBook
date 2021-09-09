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
		private IDictionary<Button, string> _conversionButtonsInitialText { get; }

		public ShowRecipeScreen()
		{
			InitializeComponent();
			_conversionButtonsInitialText = new Dictionary<Button, string>
			{
				{ButtonTableSpoonToTeaSpoon, ButtonTableSpoonToTeaSpoon.Text},
				{ButtonCupToTableSpoon, ButtonCupToTableSpoon.Text},
				{ButtonCupToTeaSpoon, ButtonCupToTeaSpoon.Text},
				{ButtonCupToFluidOunce, ButtonCupToFluidOunce.Text},
				{ButtonGallonToQuart, ButtonGallonToQuart.Text},
				{ButtonQuartToPint, ButtonQuartToPint.Text},
				{ButtonPintToCup, ButtonPintToCup.Text},
				{ButtonCelsiusToFahrenheit, ButtonCelsiusToFahrenheit.Text},
				{ButtonOunceToGram, ButtonOunceToGram.Text},
				{ButtonKgToGram, ButtonKgToGram.Text},
				{ButtonTableSpoonToMilliLiter, ButtonTableSpoonToMilliLiter.Text},
				{ButtonTeaSpoonToMilliLitter, ButtonTeaSpoonToMilliLitter.Text},
				{ButtonCupToMilliLiter, ButtonCupToMilliLiter.Text},
				{ButtonGallonToLiter, ButtonGallonToLiter.Text}, {ButtonPoundToGram, ButtonPoundToGram.Text}
			};
		}

		private void ShowRecipeScreen_Enter(object sender, EventArgs e)
		{
			MaximizeWindow();
		}

		protected void WriteRecipeInRichTextBox(RecipeDTO recipe)
		{
			var outputLines = new List<string>
			{
				"Name: " + recipe.Name,
				"URL: " + recipe.Url,
				"Preparation Time: " + recipe.PrepTime,
				"Cooking Time: " + recipe.CookTime,
				"Yield: " + recipe.Yield,
				"Ingredients:"
			};
			WriteIngredients(recipe, outputLines);

			WriteInstructions(recipe, outputLines);

			WriteNotes(recipe, outputLines);

			RichTextBoxRecipeInfo.Lines = outputLines.ToArray();
			FormattingRecipe();
		}

		private static void WriteIngredients(RecipeDTO recipe, List<string> outputLines)
		{
			foreach (var key in recipe.IngredientsByComponent.Keys)
			{
				if (!string.IsNullOrWhiteSpace(key))
				{
					outputLines.Add(key + ":");
				}

				int index;
				for (index = 0; index < recipe.IngredientsByComponent[key].Count; index++)
				{
					if (recipe.IngredientsByComponent[key][index].Quantity == 0 &&
					    recipe.IngredientsByComponent[key][index].Measurement == Measurement.Unit)
					{
						outputLines.Add(recipe.IngredientsByComponent[key][index].Name);
					}
					else
					{
						outputLines.Add(recipe.IngredientsByComponent[key][index].Quantity + " " +
						                (recipe.IngredientsByComponent[key][index].Measurement != Measurement.Unit
							                ? recipe.IngredientsByComponent[key][index].Measurement +
							                  (recipe.IngredientsByComponent[key][index].Quantity > 1 ? "s " : " ")
							                : "") + recipe.IngredientsByComponent[key][index].Name);
					}
				}
			}
		}

		private static void WriteInstructions(RecipeDTO recipe, List<string> outputLines)
		{
			int index;
			outputLines.Add("Instructions:");
			for (index = 0; index < recipe.Instructions.Count; index++)
			{
				outputLines.Add(recipe.Instructions[index]);
			}
		}

		private static void WriteNotes(RecipeDTO recipe, List<string> outputLines)
		{
			int index;
			outputLines.Add("Notes:");
			for (index = 0; index < recipe.Notes.Count; index++)
			{
				outputLines.Add(recipe.Notes[index]);
			}
		}

		private void FormattingRecipe()
		{
			int index;
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

		#region ScaleButtonMethodsAndEventHandlers

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
			WriteRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 0.25));
		}

		private void ButtonHalfScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonHalfScale);
			WriteRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 0.5));
		}

		private void ButtonOneScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonOneScale);
			WriteRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 1));
		}

		private void ButtonDoubleScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonDoubleScale);
			WriteRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 2));
		}

		private void ButtonQuadrupleScale_Click(object sender, EventArgs e)
		{
			SetSelectedScaleButtonColor(ButtonQuadrupleScale);
			WriteRecipeInRichTextBox(ServicesFacade.GetScaledRecipe(RecipeToShow, 4));
		}

		#endregion

		#region ConversionButtonEventHandlers

		private void ButtonResetConversions_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(RecipeToShow);
		}

		private void ReverseConversionButtonText(Button button)
		{
			var textSplit = button.Text.Split(" -> ");
			button.Text = textSplit.Last() + " -> " + textSplit.First();
		}

		private void ButtonTableSpoonToTeaSpoon_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.TableSpoon_To_TeaSpoon, ButtonTableSpoonToTeaSpoon.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonTableSpoonToTeaSpoon);
		}

		private void ButtonCupToTableSpoon_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Cup_To_TableSpoon, ButtonCupToTableSpoon.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonCupToTableSpoon);
		}

		private void ButtonCupToTeaSpoon_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Cup_To_TeaSpoon, ButtonCupToTeaSpoon.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonCupToTeaSpoon);
		}

		private void ButtonCupToFluidOunce_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Cup_To_FluidOunce, ButtonCupToFluidOunce.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonCupToFluidOunce);
		}

		private void ButtonGallonToQuart_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Gallon_To_Quart, ButtonGallonToQuart.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonGallonToQuart);
		}

		private void ButtonQuartToPint_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Quart_To_Pint, ButtonQuartToPint.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonQuartToPint);
		}

		private void ButtonPintToCup_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Pint_To_Cup, ButtonPintToCup.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonPintToCup);
		}

		private void ButtonCelsiusToFahrenheit_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Celsius_To_Fahrenheit, ButtonCelsiusToFahrenheit.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonCelsiusToFahrenheit);
			// Find a way to convert temperatures in instructions
		}

		private void ButtonOunceToGram_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Ounce_To_Gram, ButtonOunceToGram.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonOunceToGram);
		}

		private void ButtonKgToGram_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Kilogram_To_Gram, ButtonKgToGram.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonKgToGram);
		}

		private void ButtonTableSpoonToMilliLiter_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.TableSpoon_To_Milliliter, ButtonTableSpoonToMilliLiter.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonTableSpoonToMilliLiter);
		}

		private void ButtonTeaSpoonToMilliLitter_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.TeaSpoon_To_Milliliter, ButtonTeaSpoonToMilliLitter.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonTeaSpoonToMilliLitter);
		}

		private void ButtonCupToMilliLiter_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Cup_To_Milliliter, ButtonCupToMilliLiter.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonCupToMilliLiter);
		}

		private void ButtonGallonToLiter_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Gallon_To_Liter, ButtonGallonToLiter.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText(ButtonGallonToLiter);
		}

		private void ButtonPoundToGram_Click(object sender, EventArgs e)
		{
			WriteRecipeInRichTextBox(ServicesFacade.ConvertRecipeMeasurements(RecipeToShow,
				ConversionType.Pound_To_Gram,  ButtonPoundToGram.Text != _conversionButtonsInitialText[(Button) sender]));
			ReverseConversionButtonText( ButtonPoundToGram);
		}

		#endregion
	}
}