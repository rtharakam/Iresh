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
    public partial class InsertData : Window
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowingData SW = new ShowingData();
            SW.Show();
            
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ItemTypes IT = new ItemTypes();
            IT.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Model m = new Model();
            m.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Manufacture m = new Manufacture();
            m.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Location l = new Location();
            l.Show();
        }
    }
}
