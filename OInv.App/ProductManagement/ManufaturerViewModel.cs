using OInv.App.BaseClasses;
using OInv.Bussiness.Interfaces;
using OInv.Common.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace OInv.App.ProductManagement 
{
    public class ManufaturerViewModel : ViewModelBase
    {
        private IManufactureManager manufactureManager;

        public ManufaturerViewModel(IManufactureManager manufactureManager)
        {
            this.manufactureManager = manufactureManager;

            getAllManufatures();

        }


        private string manufaturerTxt;
        private int manufaturerId;
        private ObservableCollection<Manufature> manufactures;

        private Manufature currentManufaturer;

        private RelayCommand saveManufactureCommand;
        private RelayCommand updateManufactureCommand;

        public string ManufaturerTxt
        {
            get { return manufaturerTxt; }
            set
            {
                manufaturerTxt = value;
                if(CurrentManufaturer != null)
                {
                    CurrentManufaturer.ManufactureName = value;
                    NotifyPropertyChanged("CurrentManufaturer");
                    
                }
                NotifyPropertyChanged("ManufaturerTxt");
            }
        }

        public int ManufaturerId
        {
            get { return manufaturerId; }
            set
            {
                manufaturerId = value;
                NotifyPropertyChanged("ManufaturerId");
            }
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


        public Manufature CurrentManufaturer
        {
            get { return currentManufaturer; }
            set {
                currentManufaturer = value;

                ManufaturerId = currentManufaturer.ManufactureId;
                ManufaturerTxt = currentManufaturer.ManufactureName;
                NotifyPropertyChanged("CurrentManufaturer");

            }

        }


        public RelayCommand SaveManufacture
        {
            get
            {
                return saveManufactureCommand ?? (saveManufactureCommand = new RelayCommand(x => saveManufaturer()));
            }
            set { saveManufactureCommand = value; }
        }
        public RelayCommand UpdateManufacture
        {
            get
            {
                return updateManufactureCommand ?? (updateManufactureCommand = new RelayCommand(x => updateManufaturer()));
            }
            set { saveManufactureCommand = value; }
        }


        private void saveManufaturer()
        {
            manufactureManager.createOrUpdateManufaturer(new Manufature { ManufactureName = manufaturerTxt });
        }
         private void updateManufaturer()
        {
            manufactureManager.createOrUpdateManufaturer(currentManufaturer);
        }


        private void getAllManufatures()
        {
            Manufactures =new ObservableCollection<Manufature>(manufactureManager.getAllManufatures());
        }

    }
}
