using SWAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SWAPI.ViewModels
{
    [DataContract]
    public class HumanViewModel
    {
        [DataMember]
        public string [] people  {get; set;}
        [DataMember]
        public string [] mass { get; set; }

        [DataMember]
        public List<People> results { get; set; }
    }
}
