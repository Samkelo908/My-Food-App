using LiveCharts.Wpf;
using LiveCharts;
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
    /// Interaction logic for ChartsPage.xaml
    /// </summary>
    public partial class ChartsPage : Page
    {
        private List<Recipe> recipes;

        public ChartsPage(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;

            // Populate FoodGroupListBox with food groups
            foreach (var foodGroup in FoodGroups.All)
            {
                FoodGroupListBox.Items.Add(foodGroup); 
            }
        }

        private void ShowChartButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedFoodGroups = FoodGroupListBox.SelectedItems.Cast<string>().ToList(); // Our Code World.2019

            if (!selectedFoodGroups.Any())
            {
                MessageBox.Show("Please select at least one food group.", "No Food Groups Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Count the number of ingredients in each selected food group
            var foodGroupCounts = new Dictionary<string, int>();

            foreach (var recipe in recipes)
            {
                foreach (var ingredient in recipe.Ingredients) //Stack Overflow. 2008
                {
                    if (selectedFoodGroups.Contains(ingredient.FoodGroup))
                    {
                        if (!foodGroupCounts.ContainsKey(ingredient.FoodGroup))//Stack Overflow. 2008
                        {
                            foodGroupCounts[ingredient.FoodGroup] = 0;
                        }
                        foodGroupCounts[ingredient.FoodGroup]++;
                    }
                }
            }

            var seriesCollection = new SeriesCollection();

            // Create a pie chart series for each food group
            foreach (var foodGroup in foodGroupCounts)
            {
                seriesCollection.Add(new PieSeries // Our Code World.2019
                {
                    Title = foodGroup.Key,
                    Values = new ChartValues<int> { foodGroup.Value },
                    DataLabels = true
                });
            }

            FoodGroupPieChart.Series = seriesCollection;// Our Code World.2019
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HomePage(recipes));
        }
    }
}


//Stack Overflow. 2008. Create pie chart slices in LiveCharts.Available at: https://stackoverflow.com/questions/41558338/create-pie-chart-slices-in-livecharts (Accessed: 20 June 2024).

// Our Code World.2019. How to create a Pie Chart using the LiveCharts library in WinForms C#, Available at: https://ourcodeworld.com/articles/read/583/how-to-create-a-pie-chart-using-the-livecharts-library-in-winforms-c-sharp (Accessed:20  June 2024).
