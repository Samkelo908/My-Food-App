namespace Total
{
    [TestClass]
    public class UnitTest1
    {
        private bool calorieExceededEventRaised;

        [TestMethod]
        public void TotalCalories_CaloriesExceed300_RaisesCalorieExceededEvent()// Test method to verify if the CalorieExceeded event is raised when calories exceed 300.
        {
            
            var recipe = new Recipe("Test Recipe");
            recipe.CalorieExceeded += Recipe_CalorieExceeded;
            calorieExceededEventRaised = false;

            
            recipe.AddIngredient(new Ingredient("Sugar", 200, "Sweets", "Grams"));
            recipe.AddIngredient(new Ingredient("Butter", 150, "Dairy", "Grams"));

            
            Assert.IsTrue(calorieExceededEventRaised);
        }

        private void Recipe_CalorieExceeded(object sender, EventArgs e) // Event handler method for the CalorieExceeded event.
        {
            calorieExceededEventRaised = true;
        }

        [TestMethod] // Test method to verify if TotalCalories property correctly calculates the total calories.
        public void TotalCalories_CorrectlyCalculatesTotalCalories()
        {
           
            var recipe = new Recipe("Test Recipe");

            
            recipe.AddIngredient(new Ingredient("Sugar", 100, "Sweets", "Grams"));
            recipe.AddIngredient(new Ingredient("Butter", 50, "Dairy", "Grams"));

            
            Assert.AreEqual(150, recipe.TotalCalories);
        }
    }
}