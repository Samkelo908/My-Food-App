using System;
using System.Collections;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Receipts
{
    public partial class EnterDetailsPage : Page
    {
        private List<Recipe> recipes;

        public EnterDetailsPage(List<Recipe> recipes) // Constructor to initialize the page with a list of recipes

        {
            InitializeComponent();
            this.recipes = recipes;
            PopulateFoodGroupComboBox();
            FoodGroupComboBox.SelectedIndex = 0; 
            UnitComboBox.SelectedIndex = 0; 

            RecipeListBox.ItemsSource = recipes.OrderBy(r => r.Name).ToList();
            RecipeListBox.DisplayMemberPath = "Name";
        }

        private void PopulateFoodGroupComboBox()// Populate the ComboBox with food groups
        {
            foreach (var foodGroup in FoodGroups.All)
            {
                FoodGroupComboBox.Items.Add(new ComboBoxItem { Content = foodGroup });
            }
        }

        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)// Handle the add recipe button click event
        {
            string recipeName = RecipeNameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(recipeName))
            {
                MessageBox.Show("Please enter a valid Recipe name.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Recipe newRecipe = new Recipe(recipeName);
            newRecipe.CalorieExceeded += Recipe_CalorieExceeded;
            recipes.Add(newRecipe);
            RecipeListBox.ItemsSource = null;
            RecipeListBox.ItemsSource = recipes.OrderBy(r => r.Name).ToList();
            RecipeNameTextBox.Clear();
        }

        private void Recipe_CalorieExceeded(object sender, EventArgs e)
        {
           
        }

       private void AddIngredientButton_Click(object sender, RoutedEventArgs e)// Handle the add ingredient button click event
        {
        Recipe selectedRecipe = RecipeListBox.SelectedItem as Recipe;
        if (selectedRecipe == null)
        {
            MessageBox.Show("Please select a recipe to add ingredients.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        string ingredientName = IngredientNameTextBox.Text.Trim();
        if (string.IsNullOrWhiteSpace(ingredientName))
        {
            MessageBox.Show("Please enter a valid Ingredient name.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (!int.TryParse(CaloriesTextBox.Text, out int calories))
        {
            MessageBox.Show("Please enter a valid Calories value.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        string foodGroup = (FoodGroupComboBox.SelectedItem as ComboBoxItem).Content.ToString();// Check if the total calories exceed 300
            string unitOfMeasurement = (UnitComboBox.SelectedItem as ComboBoxItem).Content.ToString();

        Ingredient newIngredient = new Ingredient(ingredientName, calories, foodGroup, unitOfMeasurement);

        var totalCalories = selectedRecipe.TotalCalories + newIngredient.Calories;
        if (totalCalories > 300)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Calories exceed 300. Do you want to continue?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (dialogResult != MessageBoxResult.Yes)
            {
                MessageBox.Show("Ingredient not added.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        }

        selectedRecipe.AddIngredient(newIngredient);

        // Display a message that the ingredient has been added
        MessageBox.Show("Ingredient added", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

        // Refresh the IngredientListBox
        IngredientListBox.ItemsSource = null;
        IngredientListBox.ItemsSource = selectedRecipe.Ingredients;

        TotalCaloriesLabel.Content = $"Total Calories: {selectedRecipe.TotalCalories}";

        IngredientNameTextBox.Clear();
        CaloriesTextBox.Clear();
        FoodGroupComboBox.SelectedIndex = 0;
        UnitComboBox.SelectedIndex = 0;
    }

        private void AddStepButton_Click(object sender, RoutedEventArgs e)// Handle the add step button click event

        {
            Recipe selectedRecipe = RecipeListBox.SelectedItem as Recipe;
            if (selectedRecipe == null)
            {
                MessageBox.Show("Please select a recipe to add steps.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string step = StepsTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(step))
            {
                MessageBox.Show("Please enter a valid Step.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            selectedRecipe.AddStep(step);
            StepsTextBox.Clear();
        }

        private void RecipeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)// Handle the recipe selection change event
        {
            Recipe selectedRecipe = RecipeListBox.SelectedItem as Recipe;
            if (selectedRecipe != null)
            {
                // Populate ingredient list box
                IngredientListBox.ItemsSource = selectedRecipe.Ingredients;
                TotalCaloriesLabel.Content = $"Total Calories: {selectedRecipe.TotalCalories}";

                // Optionally, populate the ingredient text boxes and combo boxes with the first ingredient's details
                if (selectedRecipe.Ingredients.Count > 0)
                {
                    var firstIngredient = selectedRecipe.Ingredients[0];
                    IngredientNameTextBox.Text = firstIngredient.Name;
                    CaloriesTextBox.Text = firstIngredient.Calories.ToString();
                    FoodGroupComboBox.SelectedItem = FoodGroupComboBox.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Content.ToString() == firstIngredient.FoodGroup);
                    UnitComboBox.SelectedItem = UnitComboBox.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Content.ToString() == firstIngredient.UnitOfMeasurement);
                }
                else
                {
                    // Clear the text boxes if no ingredients exist
                    IngredientNameTextBox.Clear();
                    CaloriesTextBox.Clear();
                    FoodGroupComboBox.SelectedIndex = 0;
                    UnitComboBox.SelectedIndex = 0;
                }

                // Optionally, populate steps (if needed)
                if (selectedRecipe.Steps.Count > 0)
                {
                    StepsTextBox.Text = selectedRecipe.Steps[0]; // Adjust logic to show all steps as needed
                }
                else
                {
                    StepsTextBox.Clear();
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void NavigateToDisplayRecipesPage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToDisplayRecipesPage();
        }

        private void NavigateToScaleRecipePage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToScaleRecipePage();
        }

        private void NavigateToResetQuantitiesPage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToResetQuantitiesPage();
        }

        private void IngredientNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).


//W3schools.com. 1998. C# arrays.[Online] Available at: https://www.w3schools.com/cs/cs_arrays.php (Accessed: 18 March 2024).

//W3schools.com. 1998. C# methods. Available at: https://www.w3schools.com/cs/cs_methods.php (Accessed: April 16, 2024).

//  GeeksforGeeks.2018.C# . Available at: https://www.geeksforgeeks.org/c-sharp-isnullorwhitespace-method/ (Accessed: June 4, 2024).
// Stack Overflow.2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: June 4, 2024).

//Stack Overflow. 2008. Bool statement in a while loop c#. Stack Overflow. Available at: https://stackoverflow.com/questions/35262972/bool-statement-in-a-while-loop-c-sharp  (Accessed:16 April 2024).

//W3schools.com.1998.C# break and continue.[Online] Available at: https://www.w3schools.com/cs/cs_break.php (Accessed: April 16, 2024).
// Stack Overflow.2008.ListBox.SelectedItem. Available at: https://stackoverflow.com/questions/11110778/listbox-selecteditem (Accessed: June 4, 2024).

//Stack Overflow. 2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: April 16, 2024).

//W3schools.com. 1998. C# for loop.[Online]. Available at: https://www.w3schools.com/cs/cs_for_loop.php (Accessed: April 16, 2024).
//Tutorialspoint.com. Available at: https://www.tutorialspoint.com/wpf/index.htm (Accessed: May 30, 2024).
//Stackoverflow.com. Available at: https://stackoverflow.com/questions/18959304/wpf-listbox-selectionchanged-mvvm (Accessed: May 30, 2024).
//Stack Overflow.2008.How to navigate to other page with button in WPF. Available at: https://stackoverflow.com/questions/20787622/how-to-navigate-to-other-page-with-button-in-wpf (Accessed: June 4, 2024).

//Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector.selectionchanged?view=windowsdesktop-8.0 (Accessed: May 30, 2024).
//Microsoft.com.Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/get-started/create-app-visual-studio?view=netdesktop-8.0 (Accessed: May 30, 2024).
//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).

//Navigate to MainPage from frame (no date) Stack Overflow. Available at: https://stackoverflow.com/questions/23837222/navigate-to-mainpage-from-frame (Accessed: June 4, 2024).