using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SWAPI.Models
{
    [DataContract]
    public class Film 
    {
        [DataMember]
        public short episode_id { get; set;}

        [DataMember]
        public string[] vehicles
        {
            get;
            set;
        }

        [DataMember]
        public string url
        {
            get;
            set;
        }


        [DataMember]
        public string[] starships
        {
            get;
            set;
        }

        [DataMember]
        public string title
        {
            get;
            set;
        }

        [DataMember]
        public string[] species
        {
            get;
            set;
        }

        [DataMember]
        public string producer
        {
            get;
            set;
        }

        [DataMember]
        public string[] planets
        {
            get;
            set;
        }

        [DataMember]
        public string director
        {
            get;
            set;
        }

        [DataMember]
        public string[] characters
        {
            get;
            set;
        }
        [DataMember]
        public string opening_crawl
        {
            get;
            set;
        }
    }
}