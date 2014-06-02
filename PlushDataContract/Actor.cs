using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PlushContract
{
    [DataContract]
    public class Director
    {
        [DataMember]
        public int DirectorID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Image { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Awards { get; set; }
    }

    [DataContract]
    public class directorobject
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }

    [DataContract]
    public class tvodproducts
    {
        [DataMember]
        public int products_id { get; set; }

        [DataMember]
        public string products_name { get; set; }

        [DataMember]
        public string products_image_big { get; set; }
    }

    [DataContract]
    public class ListDirector
    {
        [DataMember]
        public int DirectorID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class languageobject
    {
        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string image { get; set; }

        [DataMember]
        public List<category> categories { get; set; }

    }

    [DataContract]
    public class category
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

    }
    

    [DataContract]
    public class countryobject
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }

    [DataContract]
    public class actor
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }

    //[DataContract]
    //public class Actor
    //{

    //    [DataMember]
    //    public int ActorID { get; set; }

    //    [DataMember]
    //    public string Name { get; set; }

    //    [DataMember]
    //    public string Image { get; set; }

    //    [DataMember]
    //    public DateTime BirthDate { get; set; }

    //    [DataMember]
    //    public string Description { get; set; }

    //    [DataMember]
    //    public string Awards { get; set; }
    //}

    [DataContract]
    public class Studio
    {

        [DataMember]
        public int StudioID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Image { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Awards { get; set; }
    }

    [DataContract]
    public class ListStudio
    {

        [DataMember]
        public int StudioID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class studioobject
    {

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }
    }

    [DataContract]
    public class Review
{
        [DataMember]
        public int ReviewID { get; set; }

        [DataMember]
        public DateTime PublishedOn { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public string Desc { get; set; }

}

    [DataContract]
    public class ListActor
    {
        [DataMember]
        public int ActorID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    //[DataContract]
    //public class ListCategory
    //{
    //    [DataMember]
    //    public int CategoryID { get; set; }

    //    [DataMember]
    //    public string LanguageShortAlpha { get; set; }

    //    [DataMember]
    //    public string CategoryName { get; set; }
    //}

    [DataContract]
    public class audiosubtitle
    {
        [DataMember]
        public int audio_id { get; set; }

        [DataMember]
        public string audio_short { get; set; }

        [DataMember]
        public int subtitle_id { get; set; }

        [DataMember]
        public string subtitle_short { get; set; }
    }
   
}
