using OInv.Bussiness.Interfaces;
using OInv.Common.Entities;
using OIvn.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OInv.Bussiness
{
    public partial class ProductManagement : IProductManagement
    {
        IProductManagementDataAccess productManagement;

        public ProductManagement(IProductManagementDataAccess productManagement)
        {
            this.productManagement = productManagement;
        }

        IEnumerable<ProductType> IProductManagement.getAllProductTypes()
        {
            return productManagement.getAllProductTypes();
        }

        IEnumerable<ProductSubType> IProductManagement.getSubTypesByProductUd(int productTypeId)
        {
            return productManagement.getSubTypesByProductUd(productTypeId);
        }
    }
}
