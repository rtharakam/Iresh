﻿using OIvn.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OInv.Common.Entities;

namespace OIvn.Data
{
    public class ProductManagementDataAccess : IProductManagementDataAccess
    {
        public IEnumerable<OInv.Common.Entities.ProductType> getAllProductTypes()
        {
            using (var db = new MainDatabaseEntities())
            {
                var productTypes = db.ProductTypes.ToList();
                var result = new List<OInv.Common.Entities.ProductType > ();
                foreach (ProductType productType in productTypes)
                {
                    result.Add(new OInv.Common.Entities.ProductType() { ProductTypeId= productType.ProductType_Id, ProductTypeName= productType.ProductType_Name });
                }
                return result;
            }
        }

        public IEnumerable<OInv.Common.Entities.ProductSubType> getSubTypesByProductUd(int productTypeId)
        {
            using (var db = new MainDatabaseEntities())
            {
                var productSubTypes = db.ProductSubTypes.Where(x => x.ProductSubType_MainType == productTypeId).ToList();
                var result = new List<OInv.Common.Entities.ProductSubType>();
                foreach (ProductSubType productSubType in productSubTypes)
                {
                    result.Add(new OInv.Common.Entities.ProductSubType() {ProductSubTypeId= productSubType.ProductSubType_Id,ProductSubTypeName= productSubType.ProductSubType_Name });
                }
                return result;
            }
        }
        
    }
}
