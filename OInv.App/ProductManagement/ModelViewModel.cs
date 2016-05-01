using OInv.App.BaseClasses;
using OInv.Bussiness;
using OInv.Bussiness.Interfaces;
using OInv.Common.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace OInv.App.ProductManagement
{
    public class ModelViewModel: ViewModelBase
    {
        private IModelManagement modelManagement;
        private IProductManagement productManagement;
        private IManufactureManager manufactureManager;

        public ModelViewModel(IModelManagement modelManagement,IProductManagement productManagement,IManufactureManager manufactureManager)
        {
            this.modelManagement = modelManagement;
            this.productManagement = productManagement;
            this.manufactureManager = manufactureManager;

            GetProductTypes();
            getAllManufatures();
            getAllModels();
        }

        private string modelSku;
        private string modelName;
        private int modelId;
        private ObservableCollection<Model> models;

        private ObservableCollection<Manufature> manufactures;
        private IEnumerable<ProductType> productTypes;
        private IEnumerable<ProductSubType> productSubTypes;
        private int productTypeId;
        private int ProductSubTypeId;
        private int ManufactureId;

        private Model currentModel;

        private RelayCommand saveModelCommand;
        private RelayCommand updateMModelCommand;



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

        public ObservableCollection<Model> Models
        {
            get { return models; }
            set
            {
                models = value;
                NotifyPropertyChanged("Models");
            }
        }

        private void GetProductTypes()
        {
            ProductTypes = productManagement.getAllProductTypes();

        }

        public ObservableCollection<Manufature> Manufactures
        {
            get { return manufactures; }
            set
            {
                manufactures = value;
                NotifyPropertyChanged("Manufactures");
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

        public Model CurrentModel
        {
            get { return currentModel; }
            set
            {
                currentModel = value;

                //ManufaturerId = currentManufaturer.ManufactureId;
                //ManufaturerTxt = currentManufaturer.ManufactureName;
                NotifyPropertyChanged("CurrentModel");

            }

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
        private void getAllManufatures()
        {
            Manufactures = new ObservableCollection<Manufature>(manufactureManager.getAllManufatures());
        }

        private void getAllModels()
        {
            models = new ObservableCollection<Model>(modelManagement.getAllModels());
        }
    }
}
