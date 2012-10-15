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

namespace Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.NewHelpAdded += new Action(() =>
            {
                helpersListView.ItemsSource = DataAccess.GetAllHelp();
            });
            helpersListView.ItemsSource = DataAccess.GetAllHelp();
        }

        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((helpersListView.SelectedItems[0] as helps).id_help.ToString());
        }

        private void helpersListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (helpersListView.SelectedItem == null)
                return;
            concreteHelpForm concreteForm = new concreteHelpForm((helpersListView.SelectedItems[0] as helps));
            concreteForm.Show();
        }

        private void exitButton_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void categoriesButton_Click_1(object sender, RoutedEventArgs e)
        {
            addNewCategory categoriesForm = new addNewCategory();
            categoriesForm.ShowDialog();

        }

        private void okAuthorPanelButton_Click_1(object sender, RoutedEventArgs e)
        {
            aboutAuthorPanel.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void authorButton_Click_1(object sender, RoutedEventArgs e)
        {
            aboutAuthorPanel.Visibility = System.Windows.Visibility.Visible;

        }

        private void Grid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (aboutAuthorPanel.Visibility == System.Windows.Visibility.Visible)
                e.Handled = true;
        }

        private void addHelperButton_Click(object sender, RoutedEventArgs e)
        {
            addNewHelpForm form = new addNewHelpForm();
            hiddenGrid.Visibility = System.Windows.Visibility.Visible;
            form.ShowDialog();
            hiddenGrid.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
