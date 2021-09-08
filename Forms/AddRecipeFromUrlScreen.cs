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

namespace Forms
{
	public partial class AddRecipeFromUrlScreen : ShowRecipeScreen
	{
		public AddRecipeFromUrlScreen()
		{
			InitializeComponent();
		}

		private void ButtonSubmitUrl_Click(object sender, EventArgs e)
		{
			var recipe = ServicesFacade.GetRecipe(TextBoxRecipeUrl.Text);
			RecipeToShow = recipe;
			SetRecipeInRichTextBox(RecipeToShow);
		}
	}
}
