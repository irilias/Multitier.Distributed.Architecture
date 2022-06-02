using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Services.Models
{
    [DataContract]
    public class ServiceModel
    {
        [DataMember]
        public string MyProperty { get; set; }
        public ServiceModel(string input)
        {
            MyProperty = input;
        }
    }
}
