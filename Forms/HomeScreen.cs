using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
	public partial class HomeScreen : BaseControl
	{
		public HomeScreen()
		{
			InitializeComponent();
		}

		private void ButtonAddRecipeFromUrl_Click(object sender, EventArgs e)
		{
			MoveToScreen(new AddRecipeFromUrlScreen(), this);
		}

		private void ButtonAddRecipeManually_Click(object sender, EventArgs e)
		{
			MoveToScreen(new AddRecipeManuallyScreen(), this);
		}

		private void ButtonManageCheckRecipes_Click(object sender, EventArgs e)
		{
			MoveToScreen(new ManageRecipesScreen(), this);
		}

		private void HomeScreen_Enter(object sender, EventArgs e)
		{
			SetWindowMinimumSizeBasedOnTableLayout(tableLayoutPanelMain,false);
		}
	}
}