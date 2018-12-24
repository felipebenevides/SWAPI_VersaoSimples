using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SWAPI.Models
{
    [DataContract]
    public class People
    {
        public List<People> ListaPessoas { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        string birth_year { get; set; }
        [DataMember]
        string eye_color { get; set; }
        [DataMember]
        string gender { get; set; }
        [DataMember]
        string hair_color { get; set; }
        [DataMember]
        string height { get; set; }
        [DataMember]
        string mass { get; set; }
        [DataMember]
        string skin_color { get; set; }
        [DataMember]
        string homeworld { get; set; }
        [DataMember]
        string created { get; set; }
        [DataMember]
        string edited { get; set; }
        [DataMember]
        string url { get; set; }

        [DataMember]
        public string[] Films { get; set; }

        [DataMember]
        string[] species { get; set; }
        [DataMember]
        string[] starships { get; set; }
        [DataMember]
        string[] vehicles { get; set; }

        //public class Rootobject
        //{
        //    public string[] required { get; set; }
        //    public string description { get; set; }
        //    public string title { get; set; }
        //    public Properties properties { get; set; }
        //    public string schema { get; set; }
        //    public string type { get; set; }
        //}

        //public class Properties
        //{
        //    public Species species { get; set; }
        //    public Created created { get; set; }
        //    public Vehicles vehicles { get; set; }
        //    public Hair_Color hair_color { get; set; }
        //    public Skin_Color skin_color { get; set; }
        //    public Birth_Year birth_year { get; set; }
        //    public Starships starships { get; set; }
        //    public Name name { get; set; }
        //    public Url url { get; set; }
        //    public Height height { get; set; }

        //    public Mass mass { get; set; }
        //    public Edited edited { get; set; }
        //    public Homeworld homeworld { get; set; }
        //    public Gender gender { get; set; }
        //    public Eye_Color eye_color { get; set; }
        //}

        //public class Species
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Created
        //{
        //    public string format { get; set; }
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Vehicles
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Hair_Color
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Skin_Color
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Birth_Year
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Starships
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Name
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Url
        //{
        //    public string format { get; set; }
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Height
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}


        //public class Mass
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Edited
        //{
        //    public string format { get; set; }
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Homeworld
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Gender
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

        //public class Eye_Color
        //{
        //    public string description { get; set; }
        //    public string type { get; set; }
        //}

    }
}
