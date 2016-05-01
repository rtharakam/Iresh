using OInv.App.ProductManagement;
using OIvn.Data;
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
    /// Interaction logic for Manufacture.xaml
    /// </summary>
    public partial class Manufacture : Window
    {
        public Manufacture()
        {
            this.DataContext = new ManufaturerViewModel(new OInv.Bussiness.ManufactureManager(new ProductManagementDataAccess()));
            InitializeComponent();
        }

    }
}
