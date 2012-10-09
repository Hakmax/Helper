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
    /// Interaction logic for addNewCategory.xaml
    /// </summary>
    public partial class addNewCategory : Window
    {
        public static RoutedCommand RemoveCategoryCommand = new RoutedCommand();
        public static RoutedCommand AddCategoryCommand = new RoutedCommand();
        public static RoutedCommand ShowEditPanelCategoryCommand = new RoutedCommand();
        public static RoutedCommand EditCategoryCommand = new RoutedCommand();       



        public addNewCategory()
        {
            InitializeComponent();
            categoriesListView.ItemsSource = DataAccess.GetAllCategories();

            DataAccess.CategoriesChanged+=new Action(()=>{
                categoriesListView.ItemsSource = DataAccess.GetAllCategories();
            });
        }

        private void RemoveCategory_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (categoriesListView.SelectedItem == null)
                e.CanExecute = false;
            else e.CanExecute = true;
        }

        private void RemoveCategory_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы действительно хотите удалить категорию: " + (categoriesListView.SelectedItem as helpType).name_TypeHelp + "?", "", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel))
                return;
            DataAccess.RemoveCategory((helpType)categoriesListView.SelectedItems[0]);
        }

        private void AddNewCategory_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (categoryTextBox.Text.Trim().Length <= 1)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }

        private void AddNewCategory_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            if (DataAccess.AddCategory(categoryTextBox.Text.Trim()))
                if (checkBox1.IsChecked.Value)
                {
                    okButton.IsDefault = false;
                    categoryTextBox.Text = string.Empty;
                }
                else
                    okButton.IsDefault = true;
            else
            {
                MessageBox.Show("Данная категория уже содержится в базе!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                okButton.IsDefault = false;
            }
        }

        private void ShowEditPanelCategory_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Visible;
            okButton.IsDefault = false;
            cancelButton.IsCancel = false;
            editCategoryTextBox.Text = (categoriesListView.SelectedItem as helpType).name_TypeHelp;
        }

        private void EditCategory_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (editCategoryTextBox.Text.Trim().Length <= 1)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }

        private void EditCategory_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            if (DataAccess.UpdateExistingCategory((categoriesListView.SelectedItem as helpType), editCategoryTextBox.Text.Trim()))
            {
                InputBox.Visibility = System.Windows.Visibility.Collapsed;
                okButton.IsDefault = true;
                cancelButton.IsCancel = true;
            }
            else
                MessageBox.Show("Данная категория уже содержится в базе!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void NoButton_Click_1(object sender, RoutedEventArgs e)
        {
            okButton.IsDefault = true;
            cancelButton.IsCancel = true;
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
