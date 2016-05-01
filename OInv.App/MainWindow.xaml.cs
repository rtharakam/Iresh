using OInv.App.ProductManagement;
using OInv.Bussiness;
using System;
using OIvn.Data;
using System.Collections.Generic;
using System.Linq;
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
using OInv.App.UserIntarfaces;

namespace OInv.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new ProductTypeViewModel(new OInv.Bussiness.ProductManagement(new ProductManagementDataAccess()));
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window manu = new Manufacture();
            manu.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window model = new UserIntarfaces.Model();
            model.Show();
        }
    }
}
