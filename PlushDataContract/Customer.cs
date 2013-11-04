using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace PlushContract
{
    [DataContract]
    public class CustomerDetails
    {
        [DataMember]
        public CustomerDetailsRow cdr { get; set; } // Customer detail row bject

        [DataMember]
        public int? err { get; set; } // error ID (1-no customer with such un, 2 - wrong pass, 3 -system error, 4,5,6, n - to be defined)

    }

    [DataContract]
    public class CustomerDetailsRow
    {
        [DataMember]
        public string cn { get; set; } //Customer number( customers_id)

        [DataMember]
        public string un { get; set; } // user name is customer's email

        [DataMember]
        public string pswd { get; set; } //password

        [DataMember]
        public string frst { get; set; } // firstname

        [DataMember]
        public string lstn { get; set; } // lastname

        [DataMember]
        public string gndr { get; set; } //gender (m-man, f -female

        [DataMember]
        public string em { get; set; } // email

        //[DataMember]
        //public string emcp { get; set; } // copy by email

        [DataMember]
        public string phnm { get; set; } //phone number

        //[DataMember]
        //public string fax { get; set; } //fax number

        [DataMember]
        public string bd { get; set; } //birth date

        //[DataMember]
        //public byte[] avtr { get; set; } // customer's img

        [DataMember]
        public string stnm { get; set; } //street with number

        [DataMember]
        public string zipc { get; set; } //postal code

        [DataMember]
        public string city { get; set; } 

        [DataMember]
        public string rvst { get; set; } // my reviewer status

        [DataMember]
        public string myid { get; set; } // nickname

        //[DataMember]
        //public int? myrp { get; set; } // points, my referal points

        [DataMember]
        public int? revw { get; set; } // number of cust reviews

        //[DataMember]
        //public int? nadl { get; set; } //newsletter adult

        [DataMember]
        public int? ndvd { get; set; } //newsletters from dvdpost

        [DataMember]
        public int nprt { get; set; } //partners newsletter

        [DataMember]
        public int isac { get; set; } // is customer active
        
        [DataMember]
        public int? sbst { get; set; } // subscription type id

        [DataMember]
        public int? sbnt { get; set; } // next subscription type id

        [DataMember]
        public int susp { get; set; } // suspended

        [DataMember]
        public string sbsn { get; set; } // name of subscription package

        //[DataMember]
        //public int? qhom { get; set; } // max number of dvd at home

        //[DataMember]
        //public string crdt { get; set; } // credit by subscription

        //[DataMember]
        //public int mdvd { get; set; } // max dvd by subscription 

        //[DataMember]
        //public int nath { get; set; } // number of norm dvd at home 

        //[DataMember]
        //public int? aath { get; set; } // number of adult dvd at home 

        //[DataMember]
        //public int crnh { get; set; } // number of current norm dvd at home

        //[DataMember]
        //public int crah { get; set; } // number of current adult dvd at home

        [DataMember]
        public string vald { get; set; } //subscription valid to

        //[DataMember]
        //public int? remc { get; set; } // customers remain credit

        //[DataMember]
        //public int? remd { get; set; } // customers remain credit for dvd 

        [DataMember]
        public string pmt { get; set; } // payment type id ( needed codelist of payments' type)

        //[DataMember]
        //public string dcnm { get; set; } // domiciliation number

        //[DataMember]
        //public string ogreg { get; set; } //domiciliation account

        [DataMember]
        public int ogreg { get; set; } //ogone registered

        [DataMember]
        public string octp { get; set; } // ogone card type
        
        [DataMember]
        public string ocno { get; set; } // ogone card type

        [DataMember]
        public string oexp { get; set; } // ogone card expire

        [DataMember]
        public string oown { get; set; } // ogone card owner

        //[DataMember]
        //public int? blcl { get; set; } // black listed

        //[DataMember]
        //public int? redl { get; set; } // red listed

        [DataMember]
        public int? dsid { get; set; } // discount code id 

        [DataMember]
        public string dstp { get; set; } // discount code type

        [DataMember]
        public int? lng { get; set; } // customers default language
    
        [DataMember]
        public string accr { get; set ; } // customer account created
        
        [DataMember]
        public string acmd { get; set; } // customer account modified

        //[DataMember]
        //public string ovod { get; set; } // only vod
    }
  
    [DataContract]
    public class HomePage
    {
        [DataMember]
        public hpupper hpup { get; set; }        

        [DataMember]
        public List<hpcategory> hpctgr { get; set; }
    
        [DataMember]
        public List<ListMovie> hpctgrmovie { get; set; }

    }

    [DataContract]
    public class hpupper
    {
        [DataMember]
        public List<hpupmovie> movielst { get; set; }

        [DataMember]
        public List<hpuptoptheme> topthmlst { get; set; }

    }
    [DataContract]
    public class hpupmovie
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string kind  { get; set; }
        [DataMember]
        public int? ordered  { get; set; }
        [DataMember]
        public int? imdb_id_serie  { get; set; }
        [DataMember]
        public int? disk_id  { get; set; }
        [DataMember]
        public int? season_id  { get; set; }
        [DataMember]
        public string name  { get; set; }
        [DataMember]
        public string awards  { get; set; }
        [DataMember]
        public string dcrp  { get; set; }
        [DataMember]
        public string img  { get; set; }
        [DataMember]
        public decimal? rate  { get; set; }
        [DataMember]
        public string trailer  { get; set; }
        [DataMember]
        public string broadcast { get; set; }
        [DataMember]
        public int? vod { get; set; }

    }

    [DataContract]
    public class hpuptoptheme
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string kind { get; set; }
        [DataMember]
        public int? ordered { get; set; }
        [DataMember]
        public int topthemeid { get; set; }
        [DataMember]
        public string name { get; set; }
    }

    [DataContract]
    public class hpcategory
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string refclient { get; set; }
        [DataMember]
        public int? refclientid { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class catalogcommunity
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string refclient { get; set; }
        [DataMember]
        public int? refclientid { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class hpcategorymovie
    {
        [DataMember]
        public int? imdb_id_serie { get; set; }
        [DataMember]
        public int? disk_id { get; set; }
        [DataMember]
        public int? season_id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class CodeListCountries
    {
        [DataMember]
        public int id{ get; set; }

        [DataMember]
        public string cntry { get; set; }
    }

    [DataContract]
    public class CodeListLanguages
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string lng { get; set; }

        [DataMember]
        public string lngshort { get; set; }

        [DataMember]
        public string shortalpha { get; set; }
    }

    [DataContract]
    public class CodeListTitle
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string lng { get; set; }

        [DataMember]
        public string lngshort { get; set; }

        [DataMember]
        public string shortalpha { get; set; }
    }
}
