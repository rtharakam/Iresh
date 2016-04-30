using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OIvn.Data.Interfaces
{
    public interface IProductManagementDataAccess
    {
        IEnumerable<OInv.Common.Entities.ProductType> getAllProductTypes();
        IEnumerable<OInv.Common.Entities.ProductSubType> getSubTypesByProductUd(int productTypeId);
        IEnumerable<OInv.Common.Entities.Manufature> getAllManufatures();

        IEnumerable<OInv.Common.Entities.Model> getAllModels();

        IEnumerable<OInv.Common.Entities.Location> getAllLocations();




        OInv.Common.Entities.Manufature addNewManufaturer(OInv.Common.Entities.Manufature manufacture);

        OInv.Common.Entities.Model addNewMmodel(OInv.Common.Entities.Model model);

        OInv.Common.Entities.Location addNewLocation(OInv.Common.Entities.Location location);
    }
}
