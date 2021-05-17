using System;
using System.Linq;
using System.Windows.Forms;
using Components;

namespace RecipeBook
{
    public partial class ManageRecipesScreen : UserControl
    {
        public ManageRecipesScreen()
        {
            InitializeComponent();
            foreach (var recipe in Recipe.Recipes)
            {
                listBoxRecipes.Items.Add(recipe.Name);
            }
        }

        private void listBoxRecipes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                for (var index = 0; index < listBoxRecipes.Items.Count; index++)
                {
                    if (listBoxRecipes.GetSelected(index))
                    {
                        Recipe.Recipes.RemoveAt(index);
                        listBoxRecipes.Items.RemoveAt(index);
                        index--;
                    }
                }
            }
        }

        private void listBoxRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Hide();
            var aux = new CheckRecipesScreen(listBoxRecipes.SelectedIndex)
            {
                Dock = DockStyle.Fill
            };
            (Parent as Form1).Controls.Add(aux);
            (Parent as Form1).ActiveControl = aux;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            (Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0].Visible = true;
            (Parent as Form1).ActiveControl = (Parent as Form1).Controls.OfType<HomeScreen>().ToList()[0];
            Dispose();
        }
    }
}
