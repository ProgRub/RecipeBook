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
            Hide();
            var aux = new AddRecipeScreen()
            {
                Dock = DockStyle.Fill
            };
            (Parent as Form1).Controls.Add(aux);
            (Parent as Form1).ActiveControl = aux;
        }

        private void buttonManageRecipes_Click(object sender, EventArgs e)
        {

            Hide();
            var aux = new ManageRecipesScreen()
            {
                Dock = DockStyle.Fill
            };
            (Parent as Form1).Controls.Add(aux);
            (Parent as Form1).ActiveControl = aux;
        }
    }
}
