using Internal.Services.Contracts;
using Internal.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InternalServices
{
    public class InternalService : IService
    {
        public ServiceModel ServiceMethod(string input)
        {
            ServiceModel result = null;
            try
            {
                result = new ServiceModel(input);
            }
            catch (FaultException fex)
            {
                // In case of a fault exception.
                
            }
            catch (Exception ex)
            {
                // do nothing at the moment.
            }
            return result;


        }
    }
}
