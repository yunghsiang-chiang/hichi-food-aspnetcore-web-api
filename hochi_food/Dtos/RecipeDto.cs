namespace hochi_food.Dtos
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Category { get; set; }
        public string ChefName { get; set; }
        public string MainIngredientName { get; set; }

        public string Description { get; set; }
        public List<RecipeStepDto> RecipeSteps { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
        public List<SeasoningDto> Seasonings { get; set; }
    }

}
