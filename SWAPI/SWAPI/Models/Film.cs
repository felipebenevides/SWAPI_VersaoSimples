using StarWarsAPI.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharpTrooper.Entities
{
    /// <summary>
    /// A Star Wars film
    /// </summary>
    /// 

    [DataContract]
    public class Film : SharpEntity
    {
        /// <summary>
        /// The episode number of this film.
        /// </summary>
        /// 
        [DataMember]
        public short episode_id
        {
            get;
            set;
        }

        /// <summary>
        /// The vehicle resources featured within this film.
        /// </summary>
        [DataMember]
        public string[] vehicles
        {
            get;
            set;
        }

        /// <summary>
        /// The url of this resource
        /// </summary>
        /// 
        [DataMember]
        public string url
        {
            get;
            set;
        }

        /// <summary>
        /// An array of starship resources that this person has piloted
        /// </summary>
        /// 
        [DataMember]
        public string[] starships
        {
            get;
            set;
        }

        /// <summary>
        /// The title of this film.
        /// </summary>
        /// 
        [DataMember]
        public string title
        {
            get;
            set;
        }

        /// <summary>
        /// The url of the species resource that this person is.
        /// </summary>
        /// 
        [DataMember]
        public string[] species
        {
            get;
            set;
        }

        /// <summary>
        /// The producer(s) of this film.
        /// </summary>
        /// 
        [DataMember]
        public string producer
        {
            get;
            set;
        }

        /// <summary>
        /// The planet resources featured within this film.
        /// </summary>
        /// 
        [DataMember]
        public string[] planets
        {
            get;
            set;
        }

        /// <summary>
        /// The director of this film.
        /// </summary>
        /// 
        [DataMember]
        public string director
        {
            get;
            set;
        }

        /// <summary>
        /// The people resources featured within this film.
        /// </summary>
        /// 
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