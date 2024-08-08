using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipts
{
    public delegate void CalorieExceededEventHandler(object sender, EventArgs e);

    public class Recipe
    {
        public event CalorieExceededEventHandler CalorieExceeded;
        public string Name { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public List<string> Steps { get; private set; }

        private bool hasShownWarning = false; // Flag to track if the warning has been shown

        public int TotalCalories
        {
            get
            {
                int totalCalories = Ingredients.Sum(i => i.Calories);
                if (totalCalories > 300 && !hasShownWarning)
                {
                    hasShownWarning = true;
                    CalorieExceeded?.Invoke(this, EventArgs.Empty);
                }
                return totalCalories;
            }
        }

        private List<Ingredient> originalIngredients;

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
            originalIngredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            originalIngredients.Add(new Ingredient(ingredient.Name, ingredient.Calories, ingredient.FoodGroup, ingredient.UnitOfMeasurement));
            
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public void ResetQuantities()
        {
            Ingredients.Clear();
            foreach (var ingredient in originalIngredients)
            {
                Ingredients.Add(new Ingredient(ingredient.Name, ingredient.Calories, ingredient.FoodGroup, ingredient.UnitOfMeasurement));
            }
            hasShownWarning = false; // Reset the warning flag when quantities are reset
        }

        public override string ToString()
        {
            var ingredients = string.Join("\n", Ingredients.Select(i => $"{i.Name} ({i.Calories} cal) - {i.FoodGroup} {i.UnitOfMeasurement}"));
            var steps = string.Join("\n", Steps.Select((s, index) => $"{index + 1}. {s}"));
            return $" {Name}";
        }
    }
}

//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).


//W3schools.com. 1998. C# arrays.[Online] Available at: https://www.w3schools.com/cs/cs_arrays.php (Accessed: 18 March 2024).

//W3schools.com. 1998. C# methods. Available at: https://www.w3schools.com/cs/cs_methods.php (Accessed: April 16, 2024).

//Stack Overflow. 2008. Bool statement in a while loop c#. Stack Overflow. Available at: https://stackoverflow.com/questions/35262972/bool-statement-in-a-while-loop-c-sharp  (Accessed:16 April 2024).

//W3schools.com.1998.C# break and continue.[Online] Available at: https://www.w3schools.com/cs/cs_break.php (Accessed: April 16, 2024).

//Stack Overflow. 2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: April 16, 2024).
//Event vs EventHandler (no date) Stack Overflow. Available at: https://stackoverflow.com/questions/46824524/event-vs-eventhandler (Accessed: 29 may, 2024).
//W3schools.com. 1998. C# for loop.[Online]. Available at: https://www.w3schools.com/cs/cs_for_loop.php (Accessed: April 16, 2024).