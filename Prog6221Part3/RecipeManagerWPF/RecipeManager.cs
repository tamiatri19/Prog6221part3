using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipeManagerWPF.Models
{
    public class RecipeManager
    {
        private List<Recipe> _recipes = new List<Recipe>();
        public event Action<Recipe> CaloriesExceeded;

        public void AddRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipes.OrderBy(r => r.Name);
        }

        public void OnCaloriesExceeded(Recipe recipe)
        {
            CaloriesExceeded?.Invoke(recipe);
        }
    }

    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<string> Steps { get; set; } = new List<string>();
        public int TotalCalories { get; private set; }

        public bool CalculateTotalCalories()
        {
            int total = Ingredients.Sum(i => i.Calories);
            if (total > 300)
            {
                return false;
            }
            TotalCalories = total;
            return true;
        }
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }
    }
}
