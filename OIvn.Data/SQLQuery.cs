using OIvn.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OInv.Common.Entities;

namespace OIvn.Data
{
    public class SQLQuery : IProductManagementDataAccess
    {
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
