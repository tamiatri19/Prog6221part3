using RecipeManagerWPF;
using System.Windows;

internal static class MainWindowHelpers
{

    private static void RecipeManager_CaloriesExceeded(Recipe recipe)
    {
        MessageBox.Show($"Warning: The recipe '{recipe.Name}' exceeds the calorie limit of 300 with a total of {recipe.TotalCalories} calories.", "Calories Exceeded", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
}