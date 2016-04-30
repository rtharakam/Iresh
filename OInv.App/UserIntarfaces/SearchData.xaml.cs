using System;
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
using System.Windows.Shapes;

namespace OInv.App.UserIntarfaces
{
    /// <summary>
    /// Interaction logic for SearchData.xaml
    /// </summary>
    public partial class SearchData : Window
    {
        public SearchData()
        {
            InitializeComponent();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {
            ShowingData SD = new ShowingData();
            SD.Show();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
