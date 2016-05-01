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
    /// Interaction logic for Model.xaml
    /// </summary>
    public partial class Model : Window
    {
        public Model()
        {
            this.DataContext = new ModelViewModel(new OInv.Bussiness.ModelManagement(new ProductManagementDataAccess()),new OInv.Bussiness.ProductManagement(new ProductManagementDataAccess()), new OInv.Bussiness.ManufactureManager(new ProductManagementDataAccess()));
            InitializeComponent();
        }
    }
}
