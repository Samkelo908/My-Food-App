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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private List<Recipe> recipes;


        public HomePage(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            
        }

        
        private void DisplayRecipesButton_Click(object sender, RoutedEventArgs e) // Navigate to Display Recipes page
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToDisplayRecipesPage(); //Stack Overflow.2008
        }
        
        private void ScaleRecipeButton_Click(object sender, RoutedEventArgs e) // Navigate to Scale Recipe page
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToScaleRecipePage(); //Stack Overflow.2008
        }

        private void ResetQuantitiesButton_Click(object sender, RoutedEventArgs e)   // Navigate to Reset Quantities page
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToResetQuantitiesPage();
        }

        private void NavigateToResetQuantitiesPage_Click(object sender, RoutedEventArgs e)   // Navigate to Reset Quantities page
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToResetQuantitiesPage();
        }

        private void NavigateToScaleRecipePage_Click(object sender, RoutedEventArgs e) // Navigate to Scale Recipes page
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToScaleRecipePage();
        }

        private void NavigateToDisplayRecipesPage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToDisplayRecipesPage(); //Stack Overflow.2008
        }

        private void NavigateToEnterDetailsPage_Click(object sender, RoutedEventArgs e) // Navigate to Enter Details page
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToEnterDetailsPage();
        }

        private void ClearAllDataButton_Click(object sender, RoutedEventArgs e)
        {
            recipes.Clear();

            // Optionally, display a message to the user
            MessageBox.Show("All recipes have been cleared.", "Data Cleared", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void NavigateToFilterRecipesPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FilterRecipesPage(recipes));
        }

        private void NavigateToEnterDetailPage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToEnterDetailsPage();
        }

        private void NavigateToDisplayRecipePage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToDisplayRecipesPage(); //Stack Overflow.2008

        }

        private void NavigateToResetQuantitiePage_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).NavigateToResetQuantitiesPage();
        }

        private void NavigateToChartsPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChartsPage(recipes));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using Food App", "Goodbye", MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Shutdown();
        }
    }
}
//Tutorialspoint.com. Available at: https://www.tutorialspoint.com/wpf/index.htm (Accessed:29 May 2024).
//Stackoverflow.com. Available at: https://stackoverflow.com/questions/18959304/wpf-listbox-selectionchanged-mvvm (Accessed:29 May  2024).

//Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector.selectionchanged?view=windowsdesktop-8.0 (Accessed:30 May 2024).
//Microsoft.com.Available at: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/get-started/create-app-visual-studio?view=netdesktop-8.0 (Accessed: May 30, 2024).
//GeeksforGeeks.2019 Console.Clear method in C#, [Online]. Available at: https://www.geeksforgeeks.org/console-clear-method-in-c-sharp/  (Accessed:16 March 2024).

//Stack Overflow.2008.Application.Current.MainWindow vs. Window.GetWindow(this) (no date)  Available at: https://stackoverflow.com/questions/18939176/application-current-mainwindow-vs-window-getwindowthis (Accessed: June 4, 2024).
//W3schools.com. 1998. C# arrays.[Online] Available at: https://www.w3schools.com/cs/cs_arrays.php (Accessed: 18 March 2024).

//W3schools.com. 1998. C# methods. Available at: https://www.w3schools.com/cs/cs_methods.php (Accessed: April 16, 2024).

//Stack Overflow. 2008. Bool statement in a while loop c#. Stack Overflow. Available at: https://stackoverflow.com/questions/35262972/bool-statement-in-a-while-loop-c-sharp  (Accessed:16 April 2024).

//W3schools.com.1998.C# break and continue.[Online] Available at: https://www.w3schools.com/cs/cs_break.php (Accessed: April 16, 2024).

//Stack Overflow. 2008.How the int.TryParse actually works. Available at: https://stackoverflow.com/questions/15294878/how-the-int-tryparse-actually-works (Accessed: April 16, 2024).

//W3schools.com. 1998. C# for loop.[Online]. Available at: https://www.w3schools.com/cs/cs_for_loop.php (Accessed: April 16, 2024).