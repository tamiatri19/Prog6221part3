namespace RecipeManagerWPF
{
    internal class Recipe
    {
        internal object Name;
        internal object TotalCalories;
        internal object Ingredients;

        public object Steps { get; internal set; }
    }
}