using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using RecipeManagerWFP;
using RecipeManagerWPF.Models;

namespace RecipeManagerWPF
{
    public partial class MainWindow : Window
    {
        private RecipeManager _recipeManager;

        public MainWindow()
        {
            InitializeComponent();
            _recipeManager = new RecipeManager();
            _recipeManager.CaloriesExceeded += RecipeManager_CaloriesExceeded;
        }

        private void AddNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Example of adding a new recipe (You can create a new window to collect recipe details)
            Recipe newRecipe = new Recipe
            {
                Name = "Sample Recipe",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Sugar", Quantity = 100, Unit = "g", Calories = 400, FoodGroup = "Carbs" }
                },
                Steps = new List<string> { "Mix ingredients", "Bake for 30 minutes" }
            };

            if (!newRecipe.CalculateTotalCalories())
            {
                _recipeManager.OnCaloriesExceeded(newRecipe);
            }
            else
            {
                _recipeManager.AddRecipe(newRecipe);
                MessageBox.Show("Recipe added successfully!");
            }
        }

        private void ListAllRecipes_Click(object sender, RoutedEventArgs e)
        {
            RecipeListBox.Items.Clear();
            foreach (var recipe in _recipeManager.GetAllRecipes())
            {
                RecipeListBox.Items.Add(recipe.Name);
            }
        }

        private void RecipeManager_CaloriesExceeded(Recipe recipe)
        {
            MessageBox.Show($"Warning: The recipe '{recipe.Name}' exceeds the calorie limit of 300 with a total of {recipe.TotalCalories} calories.");
        }
    }
}
