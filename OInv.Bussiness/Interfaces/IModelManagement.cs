using OInv.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OInv.Bussiness.Interfaces
{
    public interface IModelManagement
    {
        IEnumerable<Model> getAllModels();
        bool createOrUpdateMModel(Model model);
        
    }
}
