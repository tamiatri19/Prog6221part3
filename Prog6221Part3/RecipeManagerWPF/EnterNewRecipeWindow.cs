using RecipeManagerWFP;
using System.Windows;

namespace RecipeManagerWPF
{
    public partial class EnterNewRecipe : Window
    {
        private RecipeManager recipeManager;

        public EnterNewRecipe(RecipeManager recipeManager)
        {
            InitializeComponent();
            this.recipeManager = recipeManager;
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Collect data and add the new recipe
            // For example:
            var newRecipe = new Recipe { Name = RecipeNameTextBox.Text };
            // Add ingredients and steps
            recipeManager.AddRecipe(newRecipe);
            this.Close();
        }
    }
}
