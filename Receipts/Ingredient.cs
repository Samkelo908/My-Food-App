using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Receipts
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public int OriginalCalories { get; set; } // New property for storing original calories
        public string FoodGroup { get; set; }// Stores the original calories of the ingredient
        public string UnitOfMeasurement { get; set; }

        public Ingredient(string name, int calories, string foodGroup, string unitOfMeasurement)
        {
            Name = name;
            Calories = calories;
            OriginalCalories = calories; // Initialize OriginalCalories with Calories
            FoodGroup = foodGroup;
            UnitOfMeasurement = unitOfMeasurement;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
//return $"{Name} ({Calories} cal) - {FoodGroup} {UnitOfMeasurement}";

//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).


//W3schools.com. 1998. C# arrays.[Online] Available at: https://www.w3schools.com/cs/cs_arrays.php (Accessed: 18 March 2024).

//W3schools.com. 1998. C# methods. Available at: https://www.w3schools.com/cs/cs_methods.php (Accessed: April 16, 2024).

//Stack Overflow. 2008. Bool statement in a while loop c#. Stack Overflow. Available at: https://stackoverflow.com/questions/35262972/bool-statement-in-a-while-loop-c-sharp  (Accessed:16 April 2024).

//W3schools.com.1998.C# break and continue.[Online] Available at: https://www.w3schools.com/cs/cs_break.php (Accessed: April 16, 2024).

//Stack Overflow. 2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: April 16, 2024).

//W3schools.com. 1998. C# for loop.[Online]. Available at: https://www.w3schools.com/cs/cs_for_loop.php (Accessed: April 16, 2024).