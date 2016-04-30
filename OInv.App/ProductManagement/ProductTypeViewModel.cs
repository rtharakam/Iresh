using OInv.App.BaseClasses;
using OInv.Bussiness.Interfaces;
using OInv.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OInv.App.ProductManagement
{
    public class ProductTypeViewModel:ViewModelBase
    {
        private IProductManagement productManagement;

        public ProductTypeViewModel(IProductManagement productManagement)
        {
            this.productManagement = productManagement;
        }

        private string productTypeTxt;
        private int productTypeId;
        private IEnumerable<ProductType> productTypes;
        private IEnumerable<ProductSubType> productSubTypes;

        public string ProductTypeTxt
        {
            get { return productTypeTxt; }
            set
            {
                productTypeTxt = value;
                NotifyPropertyChanged("ProductTypeTxt");
            }
        }
        public int ProductTypeId
        {
            get { return productTypeId; }
            set
            {
                productTypeId = value;
                NotifyPropertyChanged("ProductTypeId");
                LoadProductSubTypes();
            }
        }
        public IEnumerable<ProductType> ProductTypes
        {
            get { return productTypes; }
            set
            {
                productTypes = value;
                NotifyPropertyChanged("ProductTypes");
                
            }
        }

        public IEnumerable<ProductSubType> ProductSubTypes
        {
            get { return productSubTypes; }
            set
            {
                productSubTypes = value;
                NotifyPropertyChanged("ProductSubTypes");
            }
        }



        private RelayCommand loadProductTypesCommand;

        public RelayCommand LoadProductTypesCommand
        {
            get
            {
                return loadProductTypesCommand ?? (loadProductTypesCommand = new RelayCommand(x => LoadProductTypes() ));
            }
            set { loadProductTypesCommand = value; }
        }

        private void LoadProductTypes()
        {
            GetProductTypes();
        }

        private void GetProductTypes()
        {
            ProductTypes = productManagement.getAllProductTypes();

        }

        private void LoadProductSubTypes()
        {
            if (this.productTypeId != 0)
            {
                GetProductSubTypesByType(productTypeId);
            }
        }

        private void GetProductSubTypesByType(int productTypeId)
        {
            ProductSubTypes = productManagement.getSubTypesByProductUd(productTypeId);
        }
    }
}
