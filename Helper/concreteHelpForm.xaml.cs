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
    /// Interaction logic for concreteHelpForm.xaml
    /// </summary>
    public partial class concreteHelpForm : Window
    {
        public concreteHelpForm(helps selectedHelp)
        {
            InitializeComponent();
            if (selectedHelp != null)
            {
                DataContext = selectedHelp;
            }
        }
    }
}
