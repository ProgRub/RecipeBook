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
	public partial class CheckRecipeScreen : ShowRecipeScreen
	{
		public CheckRecipeScreen()
		{
			InitializeComponent();
		}

		private void CheckRecipeScreen_Enter(object sender, EventArgs e)
		{
			RecipeToShow = ServicesFacade.Instance.GetSelectedRecipe();
			WriteRecipeInRichTextBox(RecipeToShow);
		}
	}
}
