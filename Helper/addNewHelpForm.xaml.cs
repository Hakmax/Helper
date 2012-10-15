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
using System.Windows.Shapes;

namespace Helper
{
    /// <summary>
    /// Interaction logic for addNewHelpForm.xaml
    /// </summary>
    public partial class addNewHelpForm : Window
    {
        public static RoutedCommand AddNewHelpCommand = new RoutedCommand();
        public addNewHelpForm()
        {
            InitializeComponent();
            languageComboBox.ItemsSource = DataAccess.GetAllCategories();
            languageComboBox.DisplayMemberPath = "name_TypeHelp";
        }

        private void addNewHelp_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (languageComboBox.SelectedIndex==-1 || headerTextBox.Text.Trim().Length <= 2 || helpTextBox.Text.Trim().Length <= 5)
                e.CanExecute = false;
            else e.CanExecute = true;
        }

        private void addNewHelp_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (!DataAccess.AddNewHelp(new helps() { dateAdd = DateTime.Now, headerHelp = headerTextBox.Text, helpText = helpTextBox.Text, id_Type = (languageComboBox.SelectedItem as helpType).id_HelpType }))
                MessageBox.Show("Подсказка с таким заголовком уже имеется в базе!");
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
            
        }
    }
}
