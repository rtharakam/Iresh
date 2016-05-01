using OInv.Bussiness.Interfaces;
using OIvn.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OInv.Common.Entities;

namespace OInv.Bussiness
{
    public class ModelManagement: IModelManagement
    {
        IProductManagementDataAccess productManagement;

        public ModelManagement(IProductManagementDataAccess productManagement)
        {
            this.productManagement = productManagement;
        }

        public bool createOrUpdateMModel(Model model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model> getAllModels()
        {
          return  productManagement.getAllModels();
        }
    }
}
