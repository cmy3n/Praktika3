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
using Praktika3.DataSet1TableAdapters;

namespace Praktika3
{
    public partial class MainWindow : Window
    {
        ClientsTableAdapter clients = new ClientsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();

            DataGrid1.ItemsSource = clients.SelectAll();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid1.Columns[0].Visibility = Visibility.Collapsed;
        }
    }
}
