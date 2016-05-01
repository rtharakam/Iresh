using OInv.Bussiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OInv.Common.Entities;
using OIvn.Data.Interfaces;

namespace OInv.Bussiness
{
    public class ManufactureManager : IManufactureManager
    {
        IProductManagementDataAccess productManagement;

        public ManufactureManager(IProductManagementDataAccess productManagement)
        {
            this.productManagement = productManagement;
        }

        public bool createOrUpdateManufaturer(Manufature anufature)
        {
            return true;
        }

        public IEnumerable<Manufature> getAllManufatures()
        {
            return productManagement.getAllManufatures();
        }
    }
}
