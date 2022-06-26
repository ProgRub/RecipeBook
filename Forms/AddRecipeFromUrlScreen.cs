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
			WriteRecipeInRichTextBox(RecipeToShow);
		}

		private void AddRecipeFromUrlScreen_Enter(object sender, EventArgs e)
		{
			tableLayoutPanelScreen.Location = new Point(0, 0);
			tableLayoutPanelScreen.SendToBack();
			tableLayoutPanelScreen.MinimumSize = new Size(tableLayoutPanelMain.MinimumSize.Width+50, tableLayoutPanelMain.MinimumSize.Height+100);
			tableLayoutPanelScreen.Controls.Add(tableLayoutPanelMain, 1, 1);
			tableLayoutPanelScreen.SetColumnSpan(tableLayoutPanelMain, 3);
			tableLayoutPanelScreen.Dock = DockStyle.Fill;
			tableLayoutPanelMain.Dock= DockStyle.Fill;
			tableLayoutPanelMain.ColumnStyles[0]= new ColumnStyle(SizeType.Absolute,0);
			SetWindowMinimumSizeBasedOnTableLayout(tableLayoutPanelScreen, true);
		}
	}
}
