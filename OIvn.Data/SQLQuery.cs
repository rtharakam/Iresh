using OIvn.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OInv.Common.Entities;

namespace OIvn.Data
{
    public class SQLQuery 
    {
        public OInv.Common.Entities.Location addNewLocation(OInv.Common.Entities.Location location)
        {
            throw new NotImplementedException();
        }

        public OInv.Common.Entities.Manufature addNewManufaturer(OInv.Common.Entities.Manufature manufacture)
        {
            throw new NotImplementedException();
        }

        public OInv.Common.Entities.Model addNewMmodel(OInv.Common.Entities.Model model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OInv.Common.Entities.Location> getAllLocations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OInv.Common.Entities.Manufature> getAllManufatures()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OInv.Common.Entities.Model> getAllModels()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OInv.Common.Entities.ProductType> getAllProductTypes()
        {
            throw new NotImplementedException();//selenhedhbsajbj
        }

        public IEnumerable<OInv.Common.Entities.ProductSubType> getSubTypesByProductUd(int productTypeId)
        {
            throw new NotImplementedException();
        }
    }
}
