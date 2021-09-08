using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Services.DTOs;

namespace Forms
{
	public partial class ManageRecipesScreen : BaseControl
	{
		private IEnumerable<RecipeDTO> _recipes;
		public ManageRecipesScreen()
		{
			InitializeComponent();
		}

		private void ManageRecipesScreen_Enter(object sender, EventArgs e)
		{
			_recipes = ServicesFacade.Instance.GetAllRecipes();
			ListBoxRecipes.Items.Clear();
			foreach (var recipe in _recipes)
			{
				ListBoxRecipes.Items.Add(recipe.Name);
			}
		}

		private RecipeDTO GetSelectedRecipe()
		{
			return _recipes.First(recipe => recipe.Name == ListBoxRecipes.Items[ListBoxRecipes.SelectedIndex].ToString());
		}

		private void ListBoxRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ServicesFacade.Instance.SetSelectedRecipe(GetSelectedRecipe());
			MoveToScreen(new CheckRecipeScreen(),this);
		}
	}
}
