using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Media;
using System.Net;

namespace RecipeBook
{
    public partial class AddRecipeScreen : UserControl
    {
        public AddRecipeScreen()
        {
            InitializeComponent();
        }

        private void ScrapeRecipe(string url)
        {
            Debug.WriteLine("HERE");
            var htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load(url);
            var recipeName = htmlDoc.DocumentNode.Descendants("h2").ToList()[0].InnerText;
            var recipeBasics = htmlDoc.DocumentNode.Descendants("span");
            TimeSpan cookTime = ConvertStringToTimeSpan(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-cook-time").ToList()[0].InnerText);
            TimeSpan prepTime = ConvertStringToTimeSpan(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-prep-time").ToList()[0].InnerText);
            Yield yield = ConvertInfoToYield(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-yield").ToList()[0].Descendants("span").Where(x => x.GetAttributeValue("data-amount", "nothing") != "nothing" ).ToList());
            Debug.WriteLine(yield.Measurement+" "+yield.MinimumQuantity+" "+yield.MaximumQuantity);
            foreach (var item in htmlDoc.DocumentNode.Descendants("div"))
            {
                Debug.WriteLine(item.GetAttributeValue("class", "nothing"));
            }
        }

        private Measurement ConvertStringToMeasurement(string measurementString)
        {
            switch (measurementString)
            {
                case "cup":
                    return Measurement.Cup;
                case "serving":
                    return Measurement.Serving;
                default:
                    return Measurement.Unit;
            }
        }

        private TimeSpan ConvertStringToTimeSpan(string timeString)
        {
            var timeSplit = timeString.Split(new char[] { ' ' });
            int totalMinutes = 0;
            for (int index = 0; index < timeSplit.Length; index+=2)
            {
                if(timeSplit[index+1].ToLower().Contains( "min"))
                {
                    totalMinutes += int.Parse(timeSplit[index]);
                }else if (timeSplit[index + 1].ToLower().Contains("hour"))
                {
                    totalMinutes += int.Parse(timeSplit[index])*60;
                }
            }
            return new TimeSpan(totalMinutes/60,totalMinutes%60,0);
        }

        private Ingredient ConvertStringToIngredient(string ingredientString)
        {
            return new Ingredient(0, "", Measurement.Celsius);
        }

        private Yield ConvertInfoToYield(List<HtmlNode> yieldInfo)
        {
            foreach (var item in yieldInfo.Take(yieldInfo.Count-1))
            {
                Debug.WriteLine(item.GetAttributeValue("data-amount","nothing"));
            }
            double minimum = double.Parse(yieldInfo[0].GetAttributeValue("data-amount", "nothing")),maximum;
            try
            {
                 maximum= double.Parse(yieldInfo[1].GetAttributeValue("data-amount", "nothing"));
            }
            catch (Exception)
            {
                 maximum = minimum;
            }
            return new Yield(ConvertStringToMeasurement(yieldInfo[0].GetAttributeValue("data-unit", "serving")), minimum,maximum);
        }

        private void buttonSubmitURL_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("HERE");
            ScrapeRecipe(this.textBoxURL.Text);
        }
    }
}
