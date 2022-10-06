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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_10_06_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static SongOperations songOperations = new SongOperations();

        public string Seter { get; set; }


        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserControl1_TextInput(object sender, TextCompositionEventArgs e)
        {

            String msg = "Shubham";
                 

         
          


        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
