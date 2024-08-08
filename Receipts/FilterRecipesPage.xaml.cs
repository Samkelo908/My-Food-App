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
    /// Interaction logic for FilterRecipesPage.xaml
    /// </summary>
    public partial class FilterRecipesPage : Page
    {
        private List<Recipe> recipes;


        // Constructor to initialize the page with a list of recipes
        public FilterRecipesPage(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            PopulateFoodGroupComboBox();
        }
        // Populate the ComboBox with food groups
        private void PopulateFoodGroupComboBox()
        {
            foreach (var foodGroup in FoodGroups.All)
            {
                FoodGroupComboBox.Items.Add(new ComboBoxItem { Content = foodGroup });
            }
        }

        // Handle the filter button click event
        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            string ingredient = IngredientTextBox.Text.Trim();
            string? foodGroup = (FoodGroupComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string maxCaloriesText = MaxCaloriesTextBox.Text.Trim();
            int.TryParse(maxCaloriesText, out int maxCalories); //Microsoft.com.1975

            // Filter recipes based on the input criteria 
            var filteredRecipes = recipes.Where(r =>//Microsoft.com.1975
                (string.IsNullOrWhiteSpace(ingredient) || r.Ingredients.Any(i => i.Name.Contains(ingredient, StringComparison.OrdinalIgnoreCase))) &&
                (foodGroup == null || r.Ingredients.Any(i => i.FoodGroup.Equals(foodGroup, StringComparison.OrdinalIgnoreCase))) &&
                (maxCalories == 0 || r.TotalCalories <= maxCalories))
                .OrderBy(r => r.Name)  //Microsoft.com.1975
                .ToList();
            // Display the filtered recipes
            FilteredRecipesListBox.ItemsSource = filteredRecipes;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        // Clear the placeholder text when the ingredient text box gains focus
        private void IngredientTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (IngredientTextBox.Text == "Enter ingredient") //Stack Overflow.2008
            {
                IngredientTextBox.Text = string.Empty;
            }
        }
        // Restore the placeholder text if the ingredient text box loses focus and is empty

        private void IngredientTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IngredientTextBox.Text))
            {
                IngredientTextBox.Text = "Enter ingredient"; //Stack Overflow.2008
            }
        }

        private void IngredientTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void FoodGroupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        // Clear the placeholder text when the max calories text box gains focus
        private void MaxCaloriesTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MaxCaloriesTextBox.Text == "Enter max calories") //Stack Overflow.2008
            {
                MaxCaloriesTextBox.Text = string.Empty;
            }
        }

        private void MaxCaloriesTextBox_LostFocus(object sender, RoutedEventArgs e)    // Restore the placeholder text if the max calories text box loses focus and is empty

        {
            if (string.IsNullOrWhiteSpace(MaxCaloriesTextBox.Text))
            {
                MaxCaloriesTextBox.Text = "Enter max calories"; //Stack Overflow.2008
            }
        }

        private void MaxCaloriesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }
    }
}

//Stack Overflow.2008. In WPF can you filter a CollectionViewSource without code behind?. Available at: https://stackoverflow.com/questions/6461826/in-wpf-can-you-filter-a-collectionviewsource-without-code-behind (Accessed:19 June 2024).

//Microsoft.com.1975. Filtering collections - Windows apps. Available at: https://learn.microsoft.com/en-us/windows/apps/design/controls/listview-filtering (Accessed:19 June 2024).