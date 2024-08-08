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
    /// Interaction logic for ScaleRecipePage.xaml
    /// </summary>
    public partial class ScaleRecipePage : Page
    {
        private List<Recipe> recipes;

        public ScaleRecipePage(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            RecipeListBox.ItemsSource = recipes; // Bind the list of recipes to the ListBox
            RecipeListBox.DisplayMemberPath = "Name"; // Display the recipe names in the ListBox
        }

        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe selectedRecipe = RecipeListBox.SelectedItem as Recipe;// Get the selected recipe
            if (selectedRecipe != null)
            {
                if (double.TryParse(ScaleFactorTextBox.Text, out double scaleFactor) && scaleFactor > 0)// Try to parse the scale factor from the input TextBox and ensure it is a positive number
                {
                    foreach (var ingredient in selectedRecipe.Ingredients) // Scale each ingredient's calories by the scale factor
                    {
                        ingredient.Calories = (int)(ingredient.Calories * scaleFactor);
                    }
                    MessageBox.Show($"Recipe {selectedRecipe.Name} has been scaled by a factor of {scaleFactor}.", "Scale Successful", MessageBoxButton.OK, MessageBoxImage.Information); // Show a success message
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number for the scale factor.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);// Show an error message if the scale factor is invalid
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to scale.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);  // Show an error message if no recipe is selected
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();// Navigate back to the previous page if possible
            }
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