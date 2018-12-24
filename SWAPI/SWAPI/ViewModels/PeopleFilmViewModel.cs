using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SWAPI.ViewModels
{
    [DataContract]
    public class PeopleFilmViewModel
    {
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string birth_year { get; set; }
            [DataMember]
            public string[] films { get; set; }

            public List<string> filmslist { get; set; }
    }
}
