using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SWAPI.Models
{
    [DataContract]
    public class Json
    {
        [DataMember]
        public List<People> results { get; set; }

        [DataMember]
        public List<Specie> species { get;set; }
    }
}
