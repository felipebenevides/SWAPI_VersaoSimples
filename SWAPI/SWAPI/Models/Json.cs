using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{
    [DataContract]
  public class Json
    {
        [DataMember]
        public List<People> results { get; set; }
    }
}
