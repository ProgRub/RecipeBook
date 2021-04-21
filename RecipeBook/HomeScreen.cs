using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

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
    }
}
