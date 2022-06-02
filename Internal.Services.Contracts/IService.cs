﻿using Internal.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Services.Contracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFaultInfo))]
        ServiceModel ServiceMethod(string input);
    }
}
