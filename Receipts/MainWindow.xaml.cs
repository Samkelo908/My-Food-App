using System.ComponentModel;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes;

        public MainWindow()
        {
            InitializeComponent();
            recipes = new List<Recipe>();
        }
        
        public void NavigateToEnterDetailsPage() // Navigate to Enter Details Page
        {
            MainFrame.Navigate(new EnterDetailsPage(recipes));
        }
        
        public void NavigateToDisplayRecipesPage() // Navigate to Display Recipes Page
        {
            MainFrame.Navigate(new DisplayRecipePage(recipes)); //Stack Overflow.2008
        }
       
        public void NavigateToScaleRecipePage()  // Navigate to Scale Recipe Page
        {
            MainFrame.Navigate(new ScaleRecipePage(recipes));
        }
        
        public void NavigateToResetQuantitiesPage() // Navigate to Reset Quantities Page
        {
            MainFrame.Navigate(new ResetQuantitiesPage(recipes)); //Stack Overflow.2008
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            // Handle navigation events if necessary
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage( recipes); // Pass the recipes list if needed


            // Hide the welcome message and the "Let's Start" button
            WelcomeMessage.Visibility = Visibility.Collapsed;
            StartButton.Visibility = Visibility.Collapsed; //Stack Overflow.2008
            // Navigate to the HomePage
            MainFrame.Navigate(homePage); //Stack Overflow.2008
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
