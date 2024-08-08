using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Receipts
{
    /// <summary>
    /// Interaction logic for ResetQuantitiesPage.xaml
    /// </summary>
    public partial class ResetQuantitiesPage : Page
    {
        private List<Recipe> recipes;
        // Constructor that takes a list of recipes and initializes the page
        public ResetQuantitiesPage(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeListBox.ItemsSource = recipes; // Set the recipe listbox's item source to the list of recipes
            RecipeListBox.DisplayMemberPath = "Name";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e) // Event handler for the reset button click event
        {
            if (RecipeListBox.SelectedItem is Recipe selectedRecipe) // Loop through each ingredient in the selected recipe and reset its calories to the original value
            {
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    // Assuming you have a property called OriginalCalories or something similar
                    ingredient.Calories = ingredient.OriginalCalories; // Reset to original quantity
                }
                MessageBox.Show("Recipe quantities reset successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a valid recipe.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void BackButton_Click(object sender, RoutedEventArgs e) // Event handler for the back button click event
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack(); // Navigate to the previous page
            }
        }

        private void RecipeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
 }
//Tutorialspoint.com. Available at: https://www.tutorialspoint.com/wpf/index.htm (Accessed: May 30, 2024).
//Stackoverflow.com. Available at: https://stackoverflow.com/questions/18959304/wpf-listbox-selectionchanged-mvvm (Accessed: May 30, 2024).

//Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector.selectionchanged?view=windowsdesktop-8.0 (Accessed: May 30, 2024).
//Microsoft.com.Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/get-started/create-app-visual-studio?view=netdesktop-8.0 (Accessed: May 30, 2024).
//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).


//W3schools.com. 1998. C# arrays.[Online] Available at: https://www.w3schools.com/cs/cs_arrays.php (Accessed: 18 March 2024).

//W3schools.com. 1998. C# methods. Available at: https://www.w3schools.com/cs/cs_methods.php (Accessed: April 16, 2024).

//Stack Overflow. 2008. Bool statement in a while loop c#. Stack Overflow. Available at: https://stackoverflow.com/questions/35262972/bool-statement-in-a-while-loop-c-sharp  (Accessed:16 April 2024).

//W3schools.com.1998.C# break and continue.[Online] Available at: https://www.w3schools.com/cs/cs_break.php (Accessed: April 16, 2024).

//Stack Overflow. 2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: April 16, 2024).

//W3schools.com. 1998. C# for loop.[Online]. Available at: https://www.w3schools.com/cs/cs_for_loop.php (Accessed: April 16, 2024).
