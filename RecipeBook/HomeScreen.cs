using System;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecipeScreen aux = new AddRecipeScreen()
            {
                Dock = DockStyle.Fill
            };
            (this.Parent as Form1).Controls.Add(aux);
            (this.Parent as Form1).ActiveControl = aux;
        }

        private void buttonManageRecipes_Click(object sender, EventArgs e)
        {

            this.Hide();
            ManageRecipesScreen aux = new ManageRecipesScreen()
            {
                Dock = DockStyle.Fill
            };
            (this.Parent as Form1).Controls.Add(aux);
            (this.Parent as Form1).ActiveControl = aux;
        }
    }
}
