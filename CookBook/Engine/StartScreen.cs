using CookBook.Common;
using CookBook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Engine
{
    public partial class StartScreen : Form
    {
        protected Recipes AllRecipes { get; set; }

        public StartScreen(Recipes collection)
        {
            InitializeComponent();
            //Initial set of the main field where recipes are displayed
            this.AllRecipes = collection;
            RecipesDisplay.Text = this.AllRecipes.SortByTypeThenbyName().ToString();
            RecipesDisplay.ReadOnly = true;

            //set the values of the recipe type combo box
            var types = Enum.GetNames(typeof(RecipeType)).ToList();
            types.Insert(0, String.Empty); // Empty value inserted
            TypeComboBox.DataSource = types;

            // set the values of the recipe name combo box
            var recipeNamesList = this.AllRecipes.GetRecipeNames().ToList();
            recipeNamesList.Insert(0, ""); // Empty value inserted
            nameComboBox.DataSource = recipeNamesList;

            //set the values of the product name combo box
            var productNamesList = this.AllRecipes.GetProductNames().ToList();
            productNamesList.Insert(0, "");
            productComboBox.DataSource = productNamesList;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var recipesToDisplay = AllRecipes.SortByTypeThenbyName();

            if (nameComboBox.Text.IsNotNullAndNotEmpty())
            {
                recipesToDisplay = recipesToDisplay.ByName(nameComboBox.Text);
            }
            else
            {
                if (productComboBox.Text.IsNotNullAndNotEmpty())
                {
                    recipesToDisplay = recipesToDisplay.ByProduct(productComboBox.Text);
                }
                if (TypeComboBox.Text.IsNotNullAndNotEmpty())
                {
                    recipesToDisplay = recipesToDisplay.ByType(TypeComboBox.Text);
                }
                if (DurationTextBox.Text.IsNotNullAndNotEmpty())
                {
                    recipesToDisplay = recipesToDisplay.ByPreparationTime(DurationTextBox.Text);
                }
                if (PriceTextBox.Text.IsNotNullAndNotEmpty())
                {
                    recipesToDisplay = recipesToDisplay.ByPrice(PriceTextBox.Text);
                }
            }


            RecipesDisplay.Text = recipesToDisplay.ToString();
        }

        private void DurationTextBox_Leave(object sender, EventArgs e)
        {
            int some;
            if (!int.TryParse(DurationTextBox.Text, out some))
            {
                DurationTextBox.Text = String.Empty;
            }
        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            int some;
            if (!int.TryParse(PriceTextBox.Text, out some))
            {
                PriceTextBox.Text = String.Empty;
            }
        }
    }
}
