using System;
using System.Linq;
using System.Windows.Forms;

namespace RecipeBook
{
    public partial class ManageRecipesScreen : UserControl
    {
        public ManageRecipesScreen()
        {
            InitializeComponent();
            foreach (Recipe recipe in Recipe.Recipes)
            {
                this.listBoxRecipes.Items.Add(recipe.Name);
            }
        }

        private void listBoxRecipes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                for (int index = 0; index < this.listBoxRecipes.Items.Count; index++)
                {
                    if (this.listBoxRecipes.GetSelected(index))
                    {
                        Recipe.Recipes.RemoveAt(index);
                        this.listBoxRecipes.Items.RemoveAt(index);
                        index--;
                    }
                }
            }
        }

        private void listBoxRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            CheckRecipesScreen aux = new CheckRecipesScreen(this.listBoxRecipes.SelectedIndex)
            {
                Dock = DockStyle.Fill
            };
            (this.Parent as Form1).Controls.Add(aux);
            (this.Parent as Form1).ActiveControl = aux;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (this.Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0].Visible = true;
            (this.Parent as Form1).ActiveControl = (this.Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0];
            this.Dispose();
        }
    }
}
