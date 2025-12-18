using System.Windows;

namespace EmployeeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainListBox.ItemsSource = DatabaseControl.GetEmployeeList();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            mainListBox.ItemsSource = null;
            mainListBox.ItemsSource = DatabaseControl.GetEmployeeList();
        }
    }
}
