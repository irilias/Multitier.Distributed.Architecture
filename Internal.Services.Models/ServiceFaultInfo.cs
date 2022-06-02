using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Services.Models
{
    [DataContract]
    public class ServiceFaultInfo
    {
        [DataMember]
        public string Reason { get; set; }
        public ServiceFaultInfo(string input)
        {
            Reason = input;
        }
    }
}
