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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OInv.App.UserIntarfaces
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            InsertData indate = new InsertData();
            indate.Show();
            this.Close();
        }

        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {
            SearchData SD = new SearchData();
            SD.Show();
            this.Close();
        }
    }
}
