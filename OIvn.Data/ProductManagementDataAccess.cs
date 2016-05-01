using OIvn.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OInv.Common.Entities;

namespace OIvn.Data
{
    public class ProductManagementDataAccess : IProductManagementDataAccess
    {
        public bool createOrUpdateLocation(OInv.Common.Entities.Location location)
        {
            try
            {
                using (var db = new MainDatabaseEntities())
                {
                    if (location.LocationId == 0)
                    {
                        db.Locations.Add(new Location { Location_Id = location.LocationId, Location_Description = location.LocationDescription,Location_Code=location.LocationCode });
                        db.SaveChanges();
                    }
                    else
                    {
                        Location manu = db.Locations.Where(x => x.Location_Id == location.LocationId).FirstOrDefault();
                        manu.Location_Description = location.LocationDescription;
                        manu.Location_Code = location.LocationCode;
                       
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool createOrUpdateManufaturer(OInv.Common.Entities.Manufature manufacture)
        {
            try {
                using (var db = new MainDatabaseEntities())
                {
                    if (manufacture.ManufactureId == 0)
                    {
                        db.Manufatures.Add(new Manufature { Manufacture_Id = manufacture.ManufactureId, Manufacture_Name = manufacture.ManufactureName });
                        db.SaveChanges();
                    }
                    else
                    {
                        Manufature manu = db.Manufatures.Where(x => x.Manufacture_Id == manufacture.ManufactureId).FirstOrDefault();
                        manu.Manufacture_Name = manufacture.ManufactureName;
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool createOrUpdateMmodel(OInv.Common.Entities.Model model)
        {
            try
            {
                using (var db = new MainDatabaseEntities())
                {
                    if (model.ModelId == 0)
                    {
                        db.Models.Add(new Model { Model_Id = model.ModelId, Model_Name = model.ModelName ,Model_SKU=model.ModelName, Model_Type=model.ModelType,Model_SubType=model.ModelSubType});
                        db.SaveChanges();
                    }
                    else
                    {
                        Model manu = db.Models.Where(x => x.Model_Id == model.ModelId).FirstOrDefault();
                        manu.Model_Name = model.ModelName;
                        manu.Model_SKU = model.ModelSKU;
                        manu.Model_Type = model.ModelType;
                        manu.Model_SubType = model.ModelSubType;
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<OInv.Common.Entities.Location> getAllLocations()
        {
            using (var db = new MainDatabaseEntities())
            {
                var locations = db.Locations.ToList();
                var result = new List<OInv.Common.Entities.Location>();
                foreach (Location location in locations)
                {
                    result.Add(new OInv.Common.Entities.Location() { LocationId = location.Location_Id, LocationCode = location.Location_Code ,LocationDescription=location.Location_Description});
                }
                return result;
            }
        }

        public IEnumerable<OInv.Common.Entities.Manufature> getAllManufatures()
        {
            using (var db = new MainDatabaseEntities())
            {
                var manufatures = db.Manufatures.ToList();
                var result = new List<OInv.Common.Entities.Manufature>();
                foreach(Manufature manufature in manufatures)
                {
                    result.Add(new OInv.Common.Entities.Manufature() { ManufactureId = manufature.Manufacture_Id, ManufactureName = manufature.Manufacture_Name });
                }
                return result;
                    
                    
                 
            }
        }

        public IEnumerable<OInv.Common.Entities.Model> getAllModels()
        {
            using (var db = new MainDatabaseEntities())
            {
                var models = db.Models.ToList();
                var result = new List<OInv.Common.Entities.Model>();
                foreach (Model model in models)
                {
                    result.Add(new OInv.Common.Entities.Model() { ModelId = model.Model_Id, ModelName = model.Model_Name ,ModelManufaturer=model.Model_Manufaturer,ModelType=model.Model_Type,ModelSKU=model.Model_SKU,ModelSubType=model.Model_SubType});
                }
                return result;
            }
        }

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
