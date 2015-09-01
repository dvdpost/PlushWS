using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace PlushContract
{

    [DataContract]
    public class TopCategory
    {
        [DataMember]
        public int a { get; set; }

        [DataMember]
        public int topid { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class VodConfirmationEmail // returns result for Add methods
    {
        [DataMember]
        public string slug { get; set; } // director's slug

        [DataMember]
        public string directors_name { get; set; } //director's name

        [DataMember]
        public string imdb_id { get; set; } //movie's imdb_id

        [DataMember]
        public decimal? rate { get; set; } // movie's rating

        [DataMember]
        public string products_name { get; set; } //products's name

        [DataMember]
        public string products_year { get; set; } //products's year

        [DataMember]
        public string products_image_big { get; set; } //products's year

        [DataMember]
        public string products_description { get; set; } //products's year        

    }

    [DataContract]
    public class vodaudsub
    {
        [DataMember]
        public int vodid { get; set; }

        [DataMember]
        public string aud { get; set; }

        [DataMember]
        public string sub { get; set; }
    }

    [DataContract]
    public class TopMovie
    {
        [DataMember]
        public int imdb_id_serie { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string dcrp { get; set; }

        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class SearchMovie
    {
        [DataMember]
        public Int64 imdb_id_serie { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string dcrp { get; set; }

        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class trailerobject
    {
        [DataMember]
        public string aud_sub { get; set; }

        [DataMember]
        public string token { get; set; }
    }

    [DataContract]
    public class hptrailer
    {
        [DataMember]
        public Int64 imdb_id { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }
    }

    [DataContract]
    public class ListMovie
    {
        [DataMember]
        public int imdb_id { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string img { get; set; }

        [DataMember]
        public decimal? rate { get; set; }

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

        [DataMember]
        public decimal? price { get; set; }
    }

    [DataContract]
    public class FreeMovie
    {
        [DataMember]
        public string imdb_id { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string dcrp { get; set; }

        [DataMember]
        public string img { get; set; }

        [DataMember]
        public decimal? rate { get; set; }

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

        [DataMember]
        public decimal? price { get; set; }
    }

    [DataContract]
    public class ListMovieWatched
    {
        [DataMember]
        public int imdb_id { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }       

        [DataMember]
        public string img { get; set; }

        [DataMember]
        public decimal? rate { get; set; }

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

        [DataMember]
        public decimal price { get; set; }

        [DataMember]
        public string watchedat { get; set; }

    }

    [DataContract]
    public class MovieDetailRequest
    {
        [DataMember]
        public int lng_id { get; set; }

        [DataMember]
        public int imdb_id_serie { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }
    }

    [DataContract]
    public class MovieRevision
    {
        [DataMember]
        int MovieID { get; set; }
    }

    [DataContract]
    [KnownType(typeof(MovieDetailRow))]
    [KnownType(typeof(DVDChannel))]
    [KnownType(typeof(vodaudsub))]
    [KnownType(typeof(Recommand))]
    [KnownType(typeof(MovieReview))]
    public class md
    {

        [DataMember]
        public string imdb_id { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string mname { get; set; }

        [DataMember]
        public int mpublic { get; set; }

        [DataMember]
        public string mrating { get; set; }

        [DataMember]
        public int myear { get; set; }

        [DataMember]
        public string mpicture { get; set; }

        [DataMember]
        public string mdscrp { get; set; }

        [DataMember]
        public List<actor> mactors { get; set; }

        [DataMember]
        public string mdirector { get; set; }

        [DataMember]
        public string mstudio { get; set; }

        [DataMember]
        public int mlength { get; set; }

        [DataMember]
        public List<category> mcategories { get; set; }

        [DataMember]
        public string movie_type { get; set; }

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

        [DataMember]
        public string price { get; set; }

        [DataMember]
        public List<vodaudsub> vodlngs { get; set; }
        [DataMember]
        public List<ListMovie> recomm { get; set; }        
    }

    [DataContract]
    public class Recommand
    {
        [DataMember]
        public Int64 imdb_id_serie { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string dcrp { get; set; }

        [DataMember]
        public string img { get; set; }
    }

    [DataContract]
    public class DVDChannel
    {
        [DataMember]
        public string ch { get; set; } //DVD, Blue Ray

        [DataMember]
        public int id { get; set; } //products_id

        [DataMember]
        public string a { get; set; } // list audio - ',' - separator

        [DataMember]
        public string b { get; set; } // list subtitile - ',' - separator

    }

    [DataContract]
    public class VODChannel
    {
        //[DataMember]
        //public int id { get; set; } // streaming_products_id

        [DataMember]
        public string a { get; set; } // list audio-subtitile pairs ','-pair separator, ':'- pair elements' (id:audio short alpha:subtitle sort alpha )separator
    }

    [DataContract]
    public class VodTokenLengs // Vod Token and Languages
    {
        [DataMember]
        public string t { get; set; } // token

        [DataMember]
        public string a { get; set; } // list audio-subtitile pairs ','-pair separator, ':'- pair elements' (id:audio short alpha:subtitle sort alpha )separator
    }

    [DataContract]
    public class VodTokenAuthXMLLengs // Vod Token and Languages
    {
        [DataMember]
        public string authxml { get; set; } // authorisation xml

        [DataMember]
        public string t { get; set; } // token

        [DataMember]
        public string a { get; set; } // list audio-subtitile pairs ','-pair separator, ':'- pair elements' (id:audio short alpha:subtitle sort alpha )separator
    }

    [DataContract]
    public class VodEnabled // Vod Token and Languages
    {
        [DataMember]
        public int isvodavailable { get; set; } // flag

        [DataMember]
        public string message { get; set; } // message to customer
    }

    [DataContract]
    public class RegistrationAllowed // Vod Token and Languages
    {
        [DataMember]
        public int isregistrationallowed { get; set; } // flag 1 -accepted; 0- rejected

        [DataMember]
        public string message { get; set; } // message to customer
    }

    [DataContract]
    public class DeliveredProducts
    {
        [DataMember]
        public int pdid { get; set; } // products_id product's identifier

        [DataMember]
        public string name { get; set; } // movie name

        [DataMember]
        public string delivered { get; set; } //date of delivering
    }

    [DataContract]    
    public class MovieRow
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<ListActor> Actors { get; set; }

        [DataMember]
        public int Mark { get; set; }

        [DataMember]
        public Director Director { get; set; }

        [DataMember]
        public Studio Studio { get; set; }

        [DataMember]
        public string Length { get; set; }

        [DataMember]
        public List<ListCategory> Categories { get; set; }
        
        [DataMember]
        public string Country { get; set; }
        
        [DataMember]
        public string Public { get; set; }

        [DataMember]
        public string OfficialSite { get; set; }

        [DataMember]
        public string Triler { get; set; }

        [DataMember]
        public List<string> Audio { get; set; }

        [DataMember]
        public List<string> SubTitles { get; set; }

        [DataMember]
        public string Picture  { get; set; }

        [DataMember]
        public string SoundDetails { get; set; }

        [DataMember]
        public List<Review> UserReviews { get; set; }

        [DataMember]
        public bool Synopsis { get; set; }

        [DataMember]
        public bool ViewInStreaming { get; set; }
    }

    [DataContract]
    [KnownType(typeof(audiosubtitle))]
    [KnownType(typeof(ListCategory))]
    [KnownType(typeof(ListActor))]
    [KnownType(typeof(ListDirector))]
    public class vod
    {
        [DataMember]
        public int products_id { get; set; }

        [DataMember]
        public int runtime { get; set; }

        [DataMember]
        public int year { get; set; }

        [DataMember]
        public int imdb_id { get; set; }

        [DataMember]
        public decimal price { get; set; }

        [DataMember]
        public int publicage { get; set; }

        [DataMember]
        public int rating { get; set; }

        [DataMember]
        public Boolean  available{ get; set; }

        [DataMember]
        public string status { get; set; }

        [DataMember]
        public string available_from { get; set; }

        [DataMember]
        public string expire_at { get; set; }

        [DataMember]
        public string updated_at { get; set; }

        [DataMember]
        public string filename { get; set; }

        [DataMember]
        public List<audiosubtitle> version { get; set; }

        [DataMember]
        public directorobject director { get; set; }

        [DataMember]
        public studioobject studio { get; set; }

        [DataMember]
        public List<actor> actors { get; set; }

        [DataMember]
        public List<countryobject> country { get; set; }

        [DataMember]
        public languageobject fr { get; set; }

        [DataMember]
        public languageobject nl { get; set; }

        [DataMember]
        public languageobject en { get; set; }
    }

    [DataContract]
    public class BestRatedMovie
    {
        [DataMember]
        public int a { get; set; }

        [DataMember]
        public uint imdb_id { get; set; }

        [DataMember]
        public int imdb_id_serie { get; set; }

        [DataMember]
        public long? disk_id { get; set; }

        [DataMember]
        public long? season_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string image { get; set; }

        [DataMember]
        public long? rank { get; set; }

        [DataMember]
        public string average { get; set; }

        [DataMember]
        public decimal? count { get; set; }
    }

    [DataContract]
    public class BestReviewer
    {
        [DataMember]
        public int a { get; set; }

        [DataMember]
        public int customer_id { get; set; }

        [DataMember]
        public string nickname { get; set; }

        [DataMember]
        public string firstname { get; set; }

        [DataMember]
        public string lastname { get; set; }

        [DataMember]
        public string image { get; set; }

        [DataMember]
        public int? rank { get; set; }

        [DataMember]
        public int? position { get; set; }

        [DataMember]
        public int day { get; set; }

        [DataMember]
        public int ratings_count { get; set; }

        [DataMember]
        public int reviews_count { get; set; }
    }

    [DataContract]
    public class BestReview
    {
        [DataMember]
        public int a { get; set; }

        [DataMember]
        public uint imdb_id { get; set; }

        [DataMember]
        public long? disk_id { get; set; }

        [DataMember]
        public long? season_id { get; set; }

        [DataMember]
        public string movie_name { get; set; }

        [DataMember]
        public string movie_image { get; set; }

        [DataMember]
        public int? rank { get; set; }

        [DataMember]
        public int? reviewsrating { get; set; }

        [DataMember]
        public int languageid { get; set; }

        [DataMember]
        public string reviewstext { get; set; }

        [DataMember]
        public int customerid { get; set; }

        [DataMember]
        public string customernickname { get; set; }

        [DataMember]
        public int badrating{ get; set; }

        [DataMember]
        public int bestrating { get; set; }

        [DataMember]
        public int? dvdrating { get; set; }
    }

    [DataContract]
    public class MovieReview
    {
        [DataMember]
        public int r { get; set; } //review rate

        [DataMember]
        public int l { get; set; } //language_id

        [DataMember]
        public string  t { get; set; } //review text

        [DataMember]
        public int id { get; set; } //customer_id

        [DataMember]
        public int nbr { get; set; } //number of customer reviews

        [DataMember]
        public string n { get; set; }// customers nick name

        [DataMember]
        public byte[]  a { get; set; } // avatar - customers picture
    }

    [DataContract]
    public class MostDiscussedMovies
    {
        [DataMember]
        public int a { get; set; }

        [DataMember]
        public uint imdb_id { get; set; }

        [DataMember]
        public long? disk_id { get; set; }

        [DataMember]
        public long? season_id { get; set; }

        [DataMember]
        public string movie_name { get; set; }

        [DataMember]
        public string movie_image { get; set; }

        [DataMember]
        public int? rank { get; set; }

        [DataMember]
        public float average { get; set; }

        [DataMember]
        public int count { get; set; }

        [DataMember]
        public int? plus { get; set; }

        [DataMember]
        public int? minder{ get; set; }
    }

    public class MovieDetailRow
    {
        [DataMember]
        public string imdb_id { get; set; }

        [DataMember]
        public int? disk_id { get; set; }

        [DataMember]
        public int? season_id { get; set; }

        [DataMember]
        public string mname { get; set; }

        [DataMember]
        public int mpublic { get; set; }

        [DataMember]
        public string mrating { get; set; }

        [DataMember]
        public int myear { get; set; }

        [DataMember]
        public string mpicture { get; set; }

        [DataMember]
        public string mdscrp { get; set; }

        [DataMember]
        public string mactors { get; set; }      

        [DataMember]
        public string mdirector { get; set; }        

        [DataMember]
        public string mstudio { get; set; }

        [DataMember]
        public int mlength { get; set; }

        [DataMember]
        public string mcategories { get; set; }

        [DataMember]
        public string movie_type { get; set; }

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

        [DataMember]
        public string price { get; set; }

        [DataMember]
        public int language_id { get; set; }
    }

    [DataContract]
    public class MyListMovie
    {

        [DataMember]
        public int pd_vod_id { get; set; } // if format = DVD, BlueRay then pd_vod_id = pdid else pdid_imdb = vodid

        [DataMember]
        public string imdb_id_serie { get; set; } // used if movie detaisl is needed

        [DataMember]
        public int? disk_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public int? season_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public string  name  { get; set; } //

        [DataMember]
        public string audiotitle  { get; set; } // supported audio and subtitles, separated by ':'

        [DataMember]
        public int? priority  { get; set; }

        [DataMember]
        public string delivered  { get; set; }

        [DataMember]
        public string frmt  { get; set; } // format DVD, BlueRay, VOD

        [DataMember]
        public decimal? rate  { get; set; }

        [DataMember]
        public string img  { get; set; }

        [DataMember]
        public string vod  { get; set; } // if 0 movie has no vod else if > 0 movie has vod

        [DataMember]
        public string trailer { get; set; }

        [DataMember]
        public string broadcast { get; set; }
    }

    [DataContract]
    public class CustVodWishList
    {
        [DataMember]
        public string imdb_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public int? disk_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public int? season_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public string name { get; set; } //

        [DataMember]
        public string crtd { get; set; } // created

        [DataMember]
        public decimal? rate { get; set; }

        [DataMember]
        public string img { get; set; }

        [DataMember]
        public string price { get; set; } // if 0 movie is svod else if > 0 movie is tvod

        [DataMember]
        public string at { get; set; } // supported audio and subtitles, separated by ':'

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

    }

    [DataContract]
    public class VodAtCustomer
    {
        [DataMember]
        public string imdb_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public int? disk_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public int? season_id { get; set; } // used if movie detaisl is needed

        [DataMember]
        public string name { get; set; } //

        [DataMember]
        public string expire { get; set; } // supported audio and subtitles, separated by ':'

        [DataMember]
        public decimal? rate { get; set; }

        [DataMember]
        public string img { get; set; }

        [DataMember]
        public string price { get; set; } // if 0 movie is svod, else if > 0 movie is tvod

        [DataMember]
        public string at { get; set; } // supported audio and subtitles, separated by ':'

        [DataMember]
        public string trailer_aud_sub { get; set; }

        [DataMember]
        public string trailer_token { get; set; }

        [DataMember]
        public int remc { get; set; }


    }
}
