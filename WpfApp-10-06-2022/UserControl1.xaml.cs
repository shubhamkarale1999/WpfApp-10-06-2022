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

namespace WpfApp_10_06_2022
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public string Text { get; set; } = "Shubham";
        public UserControl1()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
