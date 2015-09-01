using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PlushContract
{
    [DataContract]
    public class hp
    {
        [DataMember]
        public List<ListMovie> movies_svod { get; set; }

        [DataMember]
        public List<ListMovie> movies_tvod { get; set; }

        [DataMember]
        public List<menuitem> menu { get; set; }

        [DataMember]
        public hptrailer trailer { get; set; }

        [DataMember]
        public List<hptrailer> pstrailers { get; set; }
    }

    [DataContract]
    public class MovieList_1
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public List<ListMovie> movielist { get; set; }
    }

    [DataContract]
    public class menuitem
    {
     
        [DataMember]
        public string name { get; set; }
        
        [DataMember]
        public string method { get; set; }
    }

    [DataContract]
    public class ListCategory
    {
        [DataMember]
        public int categoryid { get; set; }
        [DataMember]
        public string name { get; set; }
    }

    //[DataContract]
    //public class ListCategory
    //{
    //    [DataMember]
    //    public int categoryid { get; set; }        
    //    [DataMember]
    //    public string name { get; set; }
    //    [DataMember]
    //    public string img { get; set; }
    //    [DataMember]
    //    public string method { get; set; }
    //}

    [DataContract]
    public class CataloguePage_1
    {
        [DataMember]
        public List<menuitem> ctlgleftmenu { get; set; }

        [DataMember]
        public List<menuitem> ctlgcentralmenu { get; set; }

        [DataMember]
        public MovieList_1 movielist { get; set; }
    }
}
