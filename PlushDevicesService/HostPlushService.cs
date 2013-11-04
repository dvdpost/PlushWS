using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Net;
using System.Xml.Schema;
using System.Xml.Linq;
using MySql;
using MySql.Data.MySqlClient;
using MySql.Data;
using DbLinq.Factory;
using PlushContract;
using DVDPostBuziness;
using System.Collections;
using CountryLookupProj;

namespace PlushService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class HostPlushService : IMobileService
    {
        private System.Diagnostics.EventLog _hosteventLog;
        
       //public List<BestRatedMovie> getBestRatedMovies(int lngid)
       // {
       //     OperationContext context = OperationContext.Current;
       //     MessageProperties prop = context.IncomingMessageProperties;
       //     RemoteEndpointMessageProperty endpoint =
       //     prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
       //     string ip = endpoint.Address;

       //     string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
       //     List<BestRatedMovie> lbrt = new List<BestRatedMovie>();

       //     try
       //     {
       //         DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

       //         var lstMovies = from vmovie in modelcontext.BestRatedMovies
       //                         where vmovie.LanguageID == lngid
       //                         select vmovie;

       //         foreach (BestRatedMovies bestRatedMovie in lstMovies)
       //         {
       //             BestRatedMovie brt = new BestRatedMovie();
       //             brt.a = 1;
       //             brt.average = bestRatedMovie.Average.ToString() ;
       //             brt.count = bestRatedMovie.Count;
       //             brt.disk_id = bestRatedMovie.DiskID;
       //             brt.image = bestRatedMovie.MovieImage;
       //             brt.imdb_id = bestRatedMovie.IMDbID;
       //             brt.imdb_id_serie = -1;
       //             brt.name = bestRatedMovie.MovieName;
       //             brt.rank = bestRatedMovie.Rank;
       //             brt.season_id = bestRatedMovie.SeasonID;

       //             lbrt.Add(brt);
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         _hosteventLog.WriteEntry("getBestRatedMovies.Exception: " + ex.Message + "InnerException: " + ex.InnerException.Message);
       //     }
       //     return lbrt;

       // }

        public List<BestReviewer> getBestReviewers(int lngid)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint =
            prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            string ip = endpoint.Address;

            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<BestReviewer> lbrv = new List<BestReviewer>();


            try
            {
                DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                var lstMovies = from vmovie in modelcontext.BestReviewers
                                select vmovie;

                foreach (BestReviewers bestReviewer in lstMovies)
                {
                    BestReviewer  brv = new BestReviewer();
                    brv.a = 2;
                    brv.customer_id = bestReviewer.CustomersID ;
                    brv.firstname = bestReviewer.CustomersFirstName  ;

                    brv.image = Convert.ToBase64String(bestReviewer.Avatar);
                    brv.lastname = bestReviewer.CustomersLastName ;
                    brv.nickname = bestReviewer.Nickname; 
                    brv.rank = bestReviewer.Rank ;
                    brv.ratings_count = bestReviewer.RatingsCount ;
                    brv.reviews_count = bestReviewer.ReviewsCount; 
                    brv.position = bestReviewer.Position;

                    lbrv.Add(brv);
                }
            }
            catch (Exception ex)
            {
                _hosteventLog.WriteEntry("getBestReviewer.Exception: " + ex.Message + "InnerException: " + ex.InnerException.Message);
            }
            return lbrv;

        }

        public List<TopCategory> getTopCategories(int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<TopCategory> lTopCtgr = new List<TopCategory>();

            try
            {
                DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                var lstMovies = from vmovie in modelcontext.TopMovies
                                where vmovie.Language == lngid
                                select vmovie;

                foreach (TopMovies ctgry in lstMovies)
                {
                    TopCategory topctgr = new TopCategory();
                    topctgr.a = 5;
                    topctgr.topid  = ctgry.ID ;
                    topctgr.name = ctgry.Name;
                    topctgr.img = "ctgry.img";

                    lTopCtgr.Add(topctgr);
                }
            }
            catch (Exception ex)
            {
                _hosteventLog.WriteEntry("getBestReviewer.Exception: " + ex.Message + "InnerException: " + ex.InnerException.Message);
            }
            return lTopCtgr;

        }

        public List<ListMovie> getTopCategoryMovies(int topid, int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();

            try
            {
                DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_top_movies_list({0},{1}, {2})", topid, lngid, Utilities.GetClientCoutry() );
                return mm.ToList<ListMovie>();
           
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getTopCategoryMovies.Exception: topid  " + topid);
                _hosteventLog.WriteEntry("getTopCategoryMovies.Exception: " + ex.Message);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getTopCategoryMovies InnerException: " + ex.InnerException.Message);
                }
                throw null;
            }
        }

        public List<ListMovie> getListMovies(string search, int publicDown, int publicUp, 
                                                    string technologys, int countryID, int yearDown, int yearUp, int ratingDown, int ratingUp,  
                                                    int ourfavorite, string audios, string titles , int lngid, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            string sss = string.Empty;
            try
            {
                search = search.Replace(' ', '%');
                search = search.Replace('\'', '%');
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                Utilities.InsertMobileLog(-1, "getListMovies", search, -1, modelcontext); 

                sss = string.Format("CALL sp_search_movie('{0}',{1},{2},'{3}',{4},{5},{6},{7},{8},{9},'{10}','{11}',{12},'{13}')",
                                                                                search, publicDown, publicUp, technologys , countryID, yearDown, yearUp, ratingDown, ratingUp,
                                                                                ourfavorite, audios ,  titles , lngid, Utilities.GetClientCoutry()  );
                IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>(sss).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return mm.ToList<ListMovie>();

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getListMovies call sp::   " + sss, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getListMovies.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getListMovies InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            finally
            {
                modelcontext.Connection.Close();
                modelcontext.Connection.Dispose();
            }
        }

        public List<BestReview> getBestReviews(int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<BestReview> lbrv = new List<BestReview>();

            try
            {
                DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                var lstMovies = from vmovie in modelcontext.BestReviews
                                where vmovie.LanguagesID== lngid
                                select vmovie;

                foreach (BestReviews bestReview in lstMovies)
                {
                    BestReview brv = new BestReview();
                    brv.a = 3;
                    brv.badrating = bestReview.CustomersBadRating;
                    brv.bestrating = bestReview.CustomersBestRating;
                    brv.customernickname = bestReview.CustomersName;
                    brv.disk_id = bestReview.DiskID;
                    brv.dvdrating = bestReview.DVdPostRating;
                    brv.imdb_id = bestReview.IMDbID;
                    brv.rank = bestReview.Rank;
                    brv.languageid = bestReview.LanguagesID;
                    brv.movie_image = bestReview.MovieImage;
                    brv.movie_name = bestReview.MovieName;
                    brv.reviewsrating = bestReview.ReviewsRating;
                    brv.reviewstext = bestReview.ReviewsText;
                    brv.season_id = bestReview.SeasonID; 

                    lbrv.Add(brv);
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getBestReviewer.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getBestReviews InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                throw ex;
            }
            return lbrv;

        }

        public md getMovieDetails(int lngid, int imdb_id, int disk_id, int season_id, int cn)
        {
            this._hosteventLog = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
            _hosteventLog.Source = "PlushServiceSource";
            _hosteventLog.Log = "PlushServiceLog";
            //
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            string connstrRecommendations = ConfigurationManager.ConnectionStrings["recommendationsDB"].ConnectionString;
            string nbrRecommanded = ConfigurationManager.AppSettings["NmbrRecommanded"];

            bool useDVDPostRecommendations = false;
            string spParameter = string.Empty;

            md md = new md();
            md.vodlngs = new List<vodaudsub>();
            md.mactors = new List<actor>();
            md.mcategories = new List<category>();
            DVdPostMobileApIWS modelcontext = null;

            string request = "";
            try
            {
                bool tmp = bool.TryParse(ConfigurationManager.AppSettings["UseDVDPostRecommendations"], out useDVDPostRecommendations);

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<MovieDetailRow> mm = modelcontext.ExecuteQuery<MovieDetailRow>("CALL spMovie({0},{1},{2},{3})", imdb_id, disk_id, season_id, Utilities.GetClientCoutry()).Where(m => m.language_id == lngid);                
                IEnumerable<VODChannel> vodch = modelcontext.ExecuteQuery<VODChannel>("CALL spmovie_vod_products({0},{1},{2},{3})", imdb_id, disk_id, season_id, Utilities.GetClientCoutry());
                IEnumerable<MovieReview> reviews = modelcontext.ExecuteQuery<MovieReview>("CALL spmovie_reviews({0},{1},{2},{3})", imdb_id, disk_id, season_id, lngid);
                IEnumerable<DVDChannel> dvdch = modelcontext.ExecuteQuery<DVDChannel>("CALL spmovie_dvd_products({0},{1},{2},{3})", imdb_id, disk_id, season_id, lngid);   
                //
                MovieDetailRow mdr = mm.FirstOrDefault<MovieDetailRow>();
                md.trailer_aud_sub = mdr.trailer_aud_sub;
                md.disk_id = mdr.disk_id;
                md.imdb_id = mdr.imdb_id;
                md.mdirector = mdr.mdirector;
                md.mdscrp = mdr.mdscrp;
                md.mlength = mdr.mlength;
                md.mname = mdr.mname;
                md.movie_type = mdr.movie_type;
                md.mpicture = mdr.mpicture;
                md.mpublic = mdr.mpublic;
                md.mrating = mdr.mrating;
                md.mstudio = mdr.mstudio;
                md.myear = mdr.myear;
                md.season_id = mdr.season_id;
                md.trailer_token = mdr.trailer_token;
                md.price = mdr.price;

                if (mdr.mactors != null)
                {
                    md.mactors = new List<actor>();
                    string[] actorstrings = mdr.mactors.Split(',');
                    for (int i = 0; i < actorstrings.Length; i++)
                    {
                        string[] actr = actorstrings[i].Split(':').ToArray();
                        md.mactors.Add(new actor { id = int.Parse(actr[0]), name = actr[1] });
                    }
                }
                if (mdr.mcategories != null)
                {
                    md.mcategories = new List<category>();
                    string[] ctrgrstrings = mdr.mcategories.Split(',');
                    for (int i = 0; i < ctrgrstrings.Length; i++)
                    {
                        string[] ctgr = ctrgrstrings[i].Split(':').ToArray();
                        md.mcategories.Add(new category { id = int.Parse(ctgr[0]), name = ctgr[1] });
                    }
                }            
                //
                if (vodch != null && vodch.Count() > 0)
                {
                    List<VODChannel> vodlist = vodch.ToList<VODChannel>();
                    string[] vodlngstrings = vodlist.ToArray()[0].a.Split(',');
                    for (int i = 0; i < vodlngstrings.Length; i++)
                    {
                        string[] vods = vodlngstrings[i].Split(':').ToArray();
                        md.vodlngs.Add(new vodaudsub { vodid = int.Parse(vods[0]), aud = vods[1], sub = vods[2] });
                    }
                    //int vodid = int.Parse(vodlngstrings[0].Split(':').ToArray()[0]);
                }
                List<DVDChannel> dvdlist = dvdch.ToList<DVDChannel>(); 
                //
                //if (useDVDPostRecommendations)
                //{                    
                //    request = ConfigurationManager.AppSettings["DVDPostRecommendationsUrl"];

                //    if (cn == 0)
                //    {
                //        request = request.Replace("custID={0}&", "");
                //        request = string.Format(request, 0, imdb_id, nbrRecommanded, false);
                //    }
                //    else
                //    {
                //        request = string.Format(request, cn, imdb_id, nbrRecommanded, false);
                //    }


                //    //string responseContent;
                //    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(request);
                //    HttpWebResponse webResponse = null;

                //    webResponse = (HttpWebResponse)webRequest.GetResponse();
                //    Stream responseStream = webResponse.GetResponseStream();
                //    StreamReader responseStreamReader = new StreamReader(responseStream);
                //    spParameter = responseStreamReader.ReadToEnd();
                //    responseStreamReader.Close();
                //    spParameter = spParameter.TrimEnd(',').Replace("\"", "");

                //}
                //else
                //{
                //    if (dvdlist.Count > 0)
                //    {                        
                //        if (lngid == 1)
                //        {                            
                //            request = ConfigurationManager.AppSettings["WEBSERVICERECOMMENDATIONSFR"]; //"http://api181.thefilter.com/dvdpost/live/video(" + dvdlist[0].id + ")/recommendation/video?$take=" + nbrRecommanded + "&$filter=genre%20eq%20DVD_NORM%20AND%20language%20eq%20French%20AND%20vod%20eq%201";
                //        }
                //        else if (lngid == 3)
                //        {
                //            request = ConfigurationManager.AppSettings["WEBSERVICERECOMMENDATIONSEN"];//"http://api181.thefilter.com/dvdpost/live/video(" + dvdlist[0].id + ")/recommendation/video?$take=" + nbrRecommanded + "&$filter=genre%20eq%20DVD_NORM%20AND%20language%20eq%20English%20AND%20vod%20eq%201";
                //        }
                //        else if (lngid == 2)
                //        {
                //            request = ConfigurationManager.AppSettings["WEBSERVICERECOMMENDATIONSNL"];//"http://api181.thefilter.com/dvdpost/live/video(" + dvdlist[0].id + ")/recommendation/video?$stop=" + nbrRecommanded + "&$filter=genre%20eq%20DVD_NORM%20AND%20subTitleLanguage%20eq%20Dutch%20AND%20vod%20eq%201";
                //        }
                //        request = string.Format(request, dvdlist[0].id, nbrRecommanded);
                //        string responseContent;
                //        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(request);
                //        HttpWebResponse webResponse = null;

                //        webResponse = (HttpWebResponse)webRequest.GetResponse();
                //        Stream responseStream = webResponse.GetResponseStream();
                //        StreamReader responseStreamReader = new StreamReader(responseStream);
                //        responseContent = responseStreamReader.ReadToEnd();
                //        responseStreamReader.Close();
                //        XmlDocument xd = new XmlDocument();
                //        XDocument xs = XDocument.Parse(responseContent);

                //        xd.LoadXml(responseContent);
                //        XmlNodeList ln = xd.GetElementsByTagName("Item");

                //        foreach (XmlNode xn in ln)
                //        {
                //            spParameter += xn.Attributes["id"].Value + ",";
                //        }
                //        spParameter = spParameter.TrimEnd(',');
                //    }
                //}                
                //if (spParameter != string.Empty)
                //{
                //    IEnumerable<ListMovie> recomandList = modelcontext.ExecuteQuery<ListMovie>("CALL sp_recomanded_movies({0},{1},{2})", spParameter, lngid, Utilities.GetClientCoutry());
                //    md.recomm = recomandList.ToList<ListMovie>();
                //}

            }
            catch (Exception ex)
            {
                _hosteventLog.WriteEntry("getMovieDetailes: lngid, imdb_id_serie, disk_id, season_id, cn: request " + lngid + ", " + imdb_id + ", " + disk_id + ", " + season_id + ", " + cn.ToString() + ", " + request + " error msg " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMovieDetailes InnerEx: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
            }
            return md;
        }

        public List<MostDiscussedMovies> getMostDiscussed(int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<MostDiscussedMovies> lbrv = new List<MostDiscussedMovies>();

            try
            {
                DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));                
                var lstMovies = from vmovie in modelcontext.MostDiscusEdMovies
                                where vmovie.LanguageID == lngid
                                select vmovie;

                foreach (MostDiscusEdMovies mostDiscuss in lstMovies)
                {
                    MostDiscussedMovies md = new MostDiscussedMovies();
                    md.a = 4;
                    md.average = mostDiscuss.Average;
                    md.count = mostDiscuss.Count;
                    md.disk_id = mostDiscuss.DiskID;
                    md.imdb_id = mostDiscuss.IMDbID;
                    md.minder = mostDiscuss.MindER;
                    md.movie_image = mostDiscuss.MovieImage;
                    md.movie_name = mostDiscuss.MovieName;
                    md.plus = mostDiscuss.Plus;
                    md.rank = mostDiscuss.Rank;
                    md.season_id = mostDiscuss.SeasonID;                     

                    lbrv.Add(md);
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMostDiscussed.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMostDiscussed InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                throw ex;
            }
            return lbrv;

        }

        public CustomerDetails getCustomerDetails(string un, string pswd, int device, string dvcnmbr)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = null;
            CustomerDetails cd = new CustomerDetails();
            bool checkPassword = true;

            try
            {                  
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                IEnumerable<CustomerDetailsRow> cdr = modelcontext.ExecuteQuery<CustomerDetailsRow>("CALL sp_customer_get({0},{1})", un, string.Empty);
                  
                if (cdr.Count() > 0)
                {
                    cd.cdr = cdr.FirstOrDefault<CustomerDetailsRow>();
                    Utilities.InsertMobileApplicationLog(int.Parse(cd.cdr.cn), "getCustomerDetails", dvcnmbr,string.Empty, device); 
                    if (checkPassword)
                    {
                        if (Utilities.wrongPass(pswd, cd.cdr.pswd))
                        {
                            cd.cdr = null; // password not send to client
                            cd.err = 2;
                            return cd;
                        }
                    }

                    cd.cdr.pswd = null;
                    cd.err = null;
                    return cd;
                }
                else
                {
                    cd.cdr = null;
                    cd.err = 1;
                    return cd;
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "SmartTVServiceSource";
                _hosteventLog.Log = "SmartTVServiceLog";
                _hosteventLog.WriteEntry("getCustomerDetails.Exception: 5 un, pswd: " + un + ", " + pswd + ", error " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustomerDetails InnerException: 5 " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                cd.cdr = null;
                cd.err = 3;
                return cd;
            }
        }

        public string getVodUrl(int vodid, int cn)
        {
            string ipaddress = string.Empty;
                string ipcountry;
                int imdb_id = 0;
                string fileName = string.Empty;
                string token = string.Empty;
                string connstr_mobile_api_ws = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
                string vodUrl;
                bool geoCheck = false;
                bool isParsed = bool.TryParse(ConfigurationManager.AppSettings["GeoCheck"], out geoCheck);
                vodUrl = ConfigurationManager.AppSettings["VodUrl"];

                string notGeoCustomer = ConfigurationManager.AppSettings["NotGeoCustomer"];
                ArrayList notGeoCustomerList = new ArrayList();
                notGeoCustomerList.AddRange(notGeoCustomer.Split(new char[] { ',' }));
                //
                string geoCountries = ConfigurationManager.AppSettings["GeoCountries"];
                ArrayList geoCountriesList = new ArrayList();
                geoCountriesList.AddRange(geoCountries.Split(new char[] { ',' }));

                VodStreamingInfo vsi = null;
                DVdPostMobileApIWS contextMobileApiWs = null;
                DVdPostMobileApIWS contextBeProd = null;
                IEnumerable<VodStreamingInfo> fn;
                //                        
                CustomerDetailsRow cd = new CustomerDetailsRow();

                //geo check
                string filePath = ConfigurationManager.AppSettings["countryFilePath"];
                CountryLookup cl = new CountryLookup(filePath);
                ipcountry = Utilities.GetClientCoutry();// cl.lookupCountryCode(ipaddress);
                if (geoCheck && !notGeoCustomerList.Contains(cn.ToString()))
                {
                    OperationContext context = OperationContext.Current;
                    MessageProperties prop = context.IncomingMessageProperties;
                    RemoteEndpointMessageProperty endpoint =
                    prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                    ipaddress = endpoint.Address;
                    if (geoCheck && !notGeoCustomerList.Contains(cn.ToString()) && !geoCountries.Contains(ipcountry))
                    {
                        this._hosteventLog = new System.Diagnostics.EventLog();
                        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                        _hosteventLog.Source = "PlushServiceSource";
                        _hosteventLog.Log = "PlushServiceLog";
                        _hosteventLog.WriteEntry("getVodUrl.Exception: 4 vodid, cn, cntry: " + vodid + ", " + cn + ", error: " + ipcountry, System.Diagnostics.EventLogEntryType.Error);

                        return "4";
                    }
                }
                //

                try
                {
                    contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                    string sql = QueriesDB.getVodStreamingInfo(vodid);

                    fn = contextBeProd.ExecuteQuery<VodStreamingInfo>(sql, null);

                    if (fn.Count() == 0)
                    {
                        return "5";
                    }
                    vsi = fn.ToList<VodStreamingInfo>()[0];
                    imdb_id = vsi.imdb_id;
                    fileName = vsi.filename;
                    //chect if token already exists
                    string sqlGetToken = QueriesDB.getToken(imdb_id, cn);
                    var listToken = contextBeProd.ExecuteQuery<Utilities.Token>(sqlGetToken);
                    if (listToken.Count<Utilities.Token>() > 0)
                    {
                        return listToken.ToList()[0].token;
                    }

                }
                catch (Exception ex)
                {
                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "PlushServiceSource";
                    _hosteventLog.Log = "PlushServiceLog";
                    _hosteventLog.WriteEntry("getVodUrl.Exception: 0.1 vodid, cn: " + vodid + ", " + cn + ", error: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    if (ex.InnerException != null)
                    {
                        _hosteventLog.WriteEntry("getVodUrl InnerException: 0.1 " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                    return "0.1";
                }
                try
                {
                    contextMobileApiWs = new DVdPostMobileApIWS(new MySqlConnection(connstr_mobile_api_ws));
                    contextMobileApiWs.ObjectTrackingEnabled = false;
                    contextMobileApiWs.QueryCacheEnabled = true;
                    //contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                    string sqlISSVOD = QueriesDB.getIsSOVD(imdb_id);
                    IEnumerable<numberresult> svodcount = contextBeProd.ExecuteQuery<numberresult>(sqlISSVOD, null);
                    bool isSVOD = svodcount.First().r > 0;

                    IEnumerable<CustomerDetailsRow> cdr = contextMobileApiWs.ExecuteQuery<CustomerDetailsRow>("CALL sp_customer_getbyid({0})", cn);

                    if (cdr.Count() > 0)
                    {
                        cd = cdr.ToList()[0];
                    }
                    else
                    {
                        return "1"; //no customer
                    }
                    if (!isSVOD && cd.ogreg == 0)
                    {
                        return "2"; //not ogone registerd
                    }
                    if ((cd.isac == 0))
                    {
                        return "3"; //not active
                    }
                    if (cd.susp > 0)
                    {
                        return "6"; //suspended
                    }

                }
                catch (Exception ex)
                {
                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "PlushServiceSource";
                    _hosteventLog.Log = "PlushServiceLog";
                    _hosteventLog.WriteEntry("getVodUrl.Exception: 1 vodid, cn: " + vodid + ", " + cn + ", error: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    if (ex.InnerException != null)
                    {
                        _hosteventLog.WriteEntry("getVodUrl InnerException: 1 " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                    return "0.2";
                }

                //string sql = MobileDevicesService.QueriesDB.getVodStreamingInfo(vodid);

                try
                {
                    //fn = contextBeProd.ExecuteQuery<VodStreamingInfo>(sql, null);

                    //if (fn.Count() == 0)
                    //{
                    //    return "4";
                    //}
                    //vsi = fn.ToList<VodStreamingInfo>()[0];
                    //imdb_id = vsi.imdb_id;
                    //fileName = vsi.filename;
                    ////chect if token already exists
                    //string sqlGetToken = QueriesDB.getToken(imdb_id, cn);
                    //var listToken = contextBeProd.ExecuteQuery<Utilities.Token>( sqlGetToken);
                    //if (listToken.Count<Utilities.Token>() > 0)
                    //{
                    //    return listToken.ToList()[0].token ;
                    //}
                    ////
                    string request = string.Empty;
                    if (ConfigurationManager.AppSettings["NewTokenUrl"].Equals("New"))
                        request = vodUrl + fileName + "&lifetime=172800&simultIp=2&test=false";
                    else
                        request = vodUrl + fileName + "&lifetime=172800&simultIp=2";
                    string responseContent;
                    HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(request);
                    webRequest.Credentials = new NetworkCredential("dvdpost", "sup3rnov4$$");
                    HttpWebResponse webResponse = null;

                    webResponse = (HttpWebResponse)webRequest.GetResponse();
                    Stream responseStream = webResponse.GetResponseStream();
                    StreamReader responseStreamReader = new StreamReader(responseStream);
                    responseContent = responseStreamReader.ReadToEnd();
                    responseStreamReader.Close();
                    XmlDocument xd = new XmlDocument();
                    XDocument xs = XDocument.Parse(responseContent);

                    xd.LoadXml(responseContent);
                    if (ConfigurationManager.AppSettings["NewTokenUrl"].Equals("New"))
                        token = (xd.SelectSingleNode("Webservice_Model_FacadeToken/createToken/response")).InnerText;
                    else
                        token = (xd.SelectSingleNode("OttVod_Token_Facade/create/response")).InnerText;

                }
                catch (Exception ex)
                {
                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "PlushServiceSource";
                    _hosteventLog.Log = "PlushServiceLog";
                    _hosteventLog.WriteEntry("getVodUrl.Exception: 2 vodid, cn: " + vodid + ", " + cn + ", error: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    if (ex.InnerException != null)
                    {
                        _hosteventLog.WriteEntry("getVodUrl InnerException: 2 " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                    return "0.3";
                }
                IDbTransaction trans = null;
                try
                {
                    if (contextBeProd.Connection.State != ConnectionState.Open)
                    {
                        contextBeProd.Connection.Open();
                    }
                    trans = contextBeProd.Connection.BeginTransaction();

                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "SmartTVServiceSource";
                    _hosteventLog.Log = "SmartTVServiceLog";

                    //string sqlInsertToken = QueriesDB.getInsertToken(cn, token, imdb_id);

                    //string sqlDecreaseCredit = QueriesDB.getDecreaseCredit(cn, vsi.credits);

                    //string sqlInsertCreditHistory = Utilities.GetInsertCreditHistory(cd.remc.Value, cn, cd.sbst, vsi.credits);

                    //
                    //contextBeProd.ExecuteCommand(sqlInsertToken);
                    contextBeProd.ExecuteCommand("call sp_smarttv_token_insert({0},{1},{2},{3},{4})", cn, token, imdb_id, ipaddress, ipcountry);

                    //contextBeProd.ExecuteCommand(sqlDecreaseCredit);

                    //contextBeProd.ExecuteCommand(sqlInsertCreditHistory);

                    // send email
                    DataTable dt = new DataTable("customermail");
                    dt.Columns.Add("customers_firstname", typeof(string));
                    dt.Columns.Add("customers_lastname", typeof(string));
                    dt.Columns.Add("customers_name", typeof(string));
                    dt.Columns.Add("customers_gender", typeof(string));
                    dt.Columns.Add("customers_email_address", typeof(string));
                    dt.Columns.Add("customers_language", typeof(int));
                    dt.Columns.Add("customers_id", typeof(int));
                    dt.Columns.Add("products_id", typeof(int));
                    dt.Columns.Add("customers_abo_payment_method", typeof(int));
                    dt.Columns.Add("customers_abo", typeof(int));
                    dt.Columns.Add("customers_abo_dvd_home_norm", typeof(int));
                    dt.Columns.Add("customers_abo_dvd_home_adult", typeof(int));
                    dt.Columns.Add("date_sent", typeof(DateTime));


                    DataRow dr = dt.NewRow();
                    dr["customers_firstname"] = cd.frst;
                    dr["customers_lastname"] = cd.lstn;
                    dr["customers_name"] = cd.frst + " " + cd.lstn;
                    dr["customers_gender"] = cd.gndr;
                    dr["customers_email_address"] = cd.em;
                    dr["customers_language"] = cd.lng;
                    dr["customers_id"] = cd.cn;
                    dr["products_id"] = contextBeProd.ExecuteCommand(QueriesDB.GetProductFromVod(vodid));// 120619;                
                    dr["customers_abo_payment_method"] = cd.sbst;
                    dr["customers_abo"] = cd.isac;
                    //dr["customers_abo_dvd_home_norm"] = cd.nath;
                    //dr["customers_abo_dvd_home_adult"] = cd.aath;
                    dr["date_sent"] = DateTime.Now;
                    DvdPostData.clsConnection.typeEnv = "prod";
                    DVDPostBuziness.clsMail.SendMail(dr, clsMail.Mail.MAIL_VOD_CONFIRMATION);

                    trans.Commit();
                    return token;

                    //
                }
                catch (Exception ex)
                {
                    if (trans != null)
                    {
                        trans.Rollback();
                    }
                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "PlushServiceSource";
                    _hosteventLog.Log = "PlushServiceLog";
                    _hosteventLog.WriteEntry("getVodUrl.Exception: 3 vodid, cn: " + vodid + ", " + cn + ", error: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    if (ex.InnerException != null)
                    {
                        _hosteventLog.WriteEntry("getVodUrl InnerException: 3 " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                    return "0.4";
                }
                //return token;
            
        }

        //public List<ListCategory> getCategoriesLeft(int lngid)
        //{
        //    string connstr_mobile_api_ws = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
        //    DVdPostMobileApIWS contextMobileApiWs = null;
        //    //                        
        //    CustomerDetailsRow cd = new CustomerDetailsRow();
        //    try
        //    {
        //        contextMobileApiWs = new DVdPostMobileApIWS(new MySqlConnection(connstr_mobile_api_ws));
        //        var ctg = from catg in contextMobileApiWs.Categories
        //                  where catg.LanguageID == lngid && catg.ParentID == 0 && catg.DisplayGroup >= 2 && catg.DisplayGroup <= 7
        //                  select catg;
        //        List<ListCategory> lc = new List<ListCategory>();
        //        foreach (Categories c in ctg.ToList<Categories >())
        //        {
        //            ListCategory listcatg = new ListCategory ();
        //            listcatg.CategoryID = c.CategoriesID;
        //            listcatg.CategoryName = c.CategoriesName;
        //            listcatg.LanguageShortAlpha = string.Empty;
        //            lc.Add(listcatg);
        //        }
        //        return lc;
        //    }
        //    catch (Exception ex)
        //    {
        //        this._hosteventLog = new System.Diagnostics.EventLog();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
        //        _hosteventLog.Source = "PlushServiceSource";
        //        _hosteventLog.Log = "PlushServiceLog";
        //        _hosteventLog.WriteEntry("getCategoriesLeft.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
        //        if (ex.InnerException != null)
        //        {
        //            _hosteventLog.WriteEntry("getCategoriesLeft InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
        //        }
        //        return null;
        //    }
        //}

        public List<ListCategory> getSubCategories(int ctgid, int lngid, bool show_tvod,  bool show_svod, int cn)
        {
            string connstr_mobile_api_ws = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS contextMobileApiWs = null;
            //                        
            CustomerDetailsRow cd = new CustomerDetailsRow();
            try
            {
                contextMobileApiWs = new DVdPostMobileApIWS(new MySqlConnection(connstr_mobile_api_ws));
                var ctg = from catg in contextMobileApiWs.Categories
                          where catg.ParentID == ctgid && catg.LanguageID == lngid && catg.vod_exists > 0
                          select catg;
                List<ListCategory> lc = new List<ListCategory>();
                foreach (Categories c in ctg.ToList<Categories>())
                {
                    ListCategory listcatg = new ListCategory();
                    listcatg.categoryid = c.CategoriesID;
                    listcatg.name = c.CategoriesName;
                    
                    lc.Add(listcatg);
                }
                return lc;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getSubCategories.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getSubCategories InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getCategoryMovies(int ctgid, int lngid, bool show_tvod,  bool show_svod, int cn, int pageNumber, int pageSize)
        {
            //OperationContext context = OperationContext.Current;            
            //System.ServiceModel.Channels.MessageProperties prop = context.IncomingMessageProperties;
            //System.ServiceModel.Channels.RemoteEndpointMessageProperty endpoint = 
            //prop[System.ServiceModel.Channels.RemoteEndpointMessageProperty.Name] as System.ServiceModel.Channels.RemoteEndpointMessageProperty;
            //string ip = endpoint.Address;

            //string retIp = "";
            //int ii = 0;
            //try
            //{

            //    OperationContext context = OperationContext.Current;

            //    MessageProperties prop = context.IncomingMessageProperties;

            //    HttpRequestMessageProperty endpointLoadBalancer =
            //    prop[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;

            //    if (endpointLoadBalancer.Headers["X-Forwarded-For"] != null)
            //    {
            //        retIp = endpointLoadBalancer.Headers["X-Forwarded-For"];
            //        ii = 1;
            //    }

            //    if (string.IsNullOrEmpty(retIp))
            //    {
            //        RemoteEndpointMessageProperty endpoint =
            //        prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            //        retIp = endpoint.Address;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this._hosteventLog = new System.Diagnostics.EventLog();
            //((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
            //_hosteventLog.Source = "PlushServiceSource";
            //_hosteventLog.Log = "PlushServiceLog";
            //_hosteventLog.WriteEntry("getCategoryMovies:" + ex.ToString());
            //}
            

            //this._hosteventLog = new System.Diagnostics.EventLog();
            //((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
            //_hosteventLog.Source = "PlushServiceSource";
            //_hosteventLog.Log = "PlushServiceLog";
            //_hosteventLog.WriteEntry("getCategoryMovies: ctgid, lngid, pageNUmber, pageSize, cntry" + ctgid + "," + lngid + "," + pageNumber + "," + pageSize + "," + retIp + ", :" + ii);

            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;

            try
            {
                DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_movie_getbycategory_tvod({0},{1},{2},{3})", ctgid, lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_movie_getbycategory_svod({0},{1},{2},{3})", ctgid, lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCategoryMovies.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCategoryMovies InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        //public HomePage getHomePage(int lngid, int cn, int device)
        //{
        //    HomePage hp = new HomePage();
        //    hp.hpctgr = new List<hpcategory>();
        //    hp.hpup = new hpupper();
        //    hp.hpup.movielst = new List<hpupmovie>();
        //    hp.hpup.topthmlst = new List<hpuptoptheme>();
        //    hp.hpctgrmovie = new List<ListMovie>();
 
        //    string connstr = string.Empty ;
        //    DVdPostMobileApIWS modelcontext;



        //    try
        //    {
        //        connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
        //        modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

        //        Utilities.InsertMobileLog(cn, "getHomePage", lngid.ToString(), device, modelcontext); 

        //        modelcontext.ObjectTrackingEnabled = false;
        //        modelcontext.QueryCacheEnabled = true;
        //        var hpctgry = from ctg in modelcontext.HpCategories
        //                      where ctg.LanguageID == lngid && ctg.Available == 1
        //                      orderby ctg.Ordered 
        //                               select ctg;
        //        List<HpCategories> hpctglst = hpctgry.OrderBy (o => o.Ordered ).ToList();

        //        foreach (HpCategories hpctg in hpctglst)
        //        {
        //            string imagePath = string.Empty;
        //            if (device == 0)
        //                imagePath = hpctg.Image.Replace("dvd/", "landscape/");
        //            else
        //                imagePath = hpctg.Image;
 
        //            hp.hpctgr.Add (new hpcategory(){id = hpctg.ID, name = hpctg.Name, img = imagePath, refclient = hpctg.RefClient, refclientid = hpctg.RefClientID }); 
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        this._hosteventLog = new System.Diagnostics.EventLog();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
        //        _hosteventLog.Source = "PlushServiceSource";
        //        _hosteventLog.Log = "PlushServiceLog";
        //        _hosteventLog.WriteEntry("getHomePage. 1 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
        //        _hosteventLog.WriteEntry("getHomePage.Exception 1: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
        //        if (ex.InnerException != null)
        //        {
        //            _hosteventLog.WriteEntry("getHomePage InnerException 1: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
        //        }
        //        return null;
        //    }
        //    try
        //    {
        //        IEnumerable<ListMovie> hpCategoryMovies = modelcontext.ExecuteQuery<ListMovie>("CALL sp_best_reviews({0},{1})", lngid, Utilities.GetClientCoutry());
        //        hp.hpctgrmovie = hpCategoryMovies.ToList<ListMovie>();  
        //    }
        //    catch (Exception ex)
        //    {
        //        this._hosteventLog = new System.Diagnostics.EventLog();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
        //        _hosteventLog.Source = "PlushServiceSource";
        //        _hosteventLog.Log = "PlushServiceLog";
        //        _hosteventLog.WriteEntry("getHomePage 2 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
        //        _hosteventLog.WriteEntry("getHomePage.Exception 2: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
        //        if (ex.InnerException != null)
        //        {
        //            _hosteventLog.WriteEntry("getHomePage InnerException 2: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
        //        }
        //        return null;
        //    }
          
        //    try
        //    {
        //        List<HpMovie> hpmovieList = modelcontext.HpMovie.Where(h=>h.LNGiD == lngid).OrderBy(o => o.Ordered).ToList<HpMovie>();
        //        string imgPath = "landingsiphone/";
        //        if (device == 1)
        //            imgPath = "landingsipad/";
        //        foreach (HpMovie movie in hpmovieList)
        //        {
        //            hpupmovie hpupmv = new SmartTVContract.hpupmovie ();
        //            hpupmv.awards = movie.Awards ;
        //            hpupmv.broadcast = movie.Broadcast ;
        //            hpupmv.dcrp = movie.DcRp ;
        //            hpupmv.disk_id = movie.DiskID ;
        //            hpupmv.id = imgPath + movie.ID + ".jpg";
        //            hpupmv.imdb_id_serie = movie.IMDbIDSErie ;
        //            hpupmv.img = movie.IMg;
        //            hpupmv.kind = movie.Kind ;
        //            hpupmv.name = movie.Name ;
        //            hpupmv.ordered = movie.Ordered ;
        //            hpupmv.rate = movie.Rate ;
        //            hpupmv.season_id = movie.SeasonID ;
        //            hpupmv.trailer = movie.Trailer ;
        //            hpupmv.vod = movie.VOd ;

        //            hp.hpup.movielst.Add(hpupmv);  
                    
        //        }

        //        List<HpTopTheme> tpthmeList = modelcontext.HpTopTheme.Where(h=>h.LNGiD == lngid).ToList<HpTopTheme>();

        //        foreach (HpTopTheme hptopthme in tpthmeList)
        //        {
        //            hpuptoptheme topthm = new hpuptoptheme();
        //            topthm.id = hptopthme.ID;
        //            topthm.kind = hptopthme.Kind;
        //            topthm.name = hptopthme.Name;
        //            topthm.ordered = hptopthme.Ordered;
        //            topthm.topthemeid = topthm.topthemeid;

        //            hp.hpup.topthmlst.Add(topthm);  
  
        //        }

        //        return hp;

        //    }
        //    catch (Exception ex)
        //    {
        //        this._hosteventLog = new System.Diagnostics.EventLog();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
        //        _hosteventLog.Source = "PlushServiceSource";
        //        _hosteventLog.Log = "PlushServiceLog";
        //        _hosteventLog.WriteEntry("getHomePage. 3 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
        //        _hosteventLog.WriteEntry("getHomePage.Exception 3: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
        //        if (ex.InnerException != null)
        //        {
        //            _hosteventLog.WriteEntry("getHomePage InnerException 3: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
        //        }
        //        return null;
        //    }
            
        //}

        public List<ListMovie> getHomePageCategoryMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid)
        {
            DVdPostMobileApIWS modelcontext ;
            List<HpCategories> hpctglst ;
            string connstr = string.Empty ;

            try
            {
                connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                var hpctgry = from ctg in modelcontext.HpCategories
                where ctg.LanguageID == lngid
                orderby ctg.Ordered 
                        select ctg;
                hpctglst = hpctgry.ToList();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getHomePageCategoryMovies. 1 lngid, refclient, refclientid: " + lngid + ", " + refclient + ", " + refclientid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getHomePageCategoryMovies.Exception 1: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getHomePageCategoryMovies 1 InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            try
            {
                HpCategories hpcategory = hpctglst.SingleOrDefault(m => m.RefClient == refclient);

                if (hpcategory.RefSourceID == 1)
                {
                    string sss = string.Format("CALL {0}({1},'{2}')", hpcategory.RefSource, lngid, Utilities.GetClientCoutry() );
                    IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>(sss).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                    return mm.ToList<ListMovie>();
                }
                else if (hpcategory.RefSourceID  == 2)
                {
                 //URL
                    return null;
                }
                else if (hpcategory.RefSourceID == 3)
                {
                    string sss = string.Format("CALL {0}({1}, {2}, '{3}')", hpcategory.RefSource, refclientid, lngid, Utilities.GetClientCoutry());
                    IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>(sss).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                    return mm.ToList<ListMovie>();
                }
                else 
                {
                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "PlushServiceSource";
                    _hosteventLog.Log = "PlushServiceLog";
                    _hosteventLog.WriteEntry("getHomePageCategoryMovies. 2 lngid, refclient, refclientid: " + lngid + ", " + refclient + ", " + refclientid);
                    return null;
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getHomePageCategoryMovies. 3 lngid, refclient, refclientid: " + lngid + ", " + refclient + ", " + refclientid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getHomePageCategoryMovies.Exception: 3 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getHomePageCategoryMovies InnerException: 3" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }    
        }

        public int getCustomerCreditForVod(int imdb_id_serie, int disk_id, int season_id, int cn)
        {
            DVdPostMobileApIWS contextBeProd = null;
            try
            {
                string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));

                Utilities.InsertMobileLog(cn, "getCustomerCreditForVod.imdb_id_serie, disk_id, season_id: ", imdb_id_serie.ToString() + ", " + disk_id.ToString() + ", " + season_id.ToString(), -1);
                string sqlGetToken = QueriesDB.getToken(imdb_id_serie, cn);
                var listToken = contextBeProd.ExecuteQuery<Utilities.Token>(sqlGetToken);
                if (listToken.Count<Utilities.Token>() > 0)
                {
                    Utilities.InsertMobileLog(cn, "getCustomerCreditForVod.return: ", "0 " , -1);
                    return 0;
                }
                string sqlCreditForVOD = QueriesDB.GetCreditForVod(imdb_id_serie, disk_id, season_id);
                
                IEnumerable<numberresult> res = contextBeProd.ExecuteQuery<numberresult>(sqlCreditForVOD);
                numberresult credit = res.FirstOrDefault<numberresult>();
                if (credit != null)
                {
                    Utilities.InsertMobileLog(cn, "getCustomerCreditForVod.return: ", credit.r.ToString(), -1);
                    return credit.r;
                }
                else
                {
                    Utilities.InsertMobileLog(cn, "getCustomerCreditForVod.return: ", "-1", -1);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustomerCreditForVod. imdb_id_serie, disk_id, season_id, cn :   " + imdb_id_serie + ", " + disk_id + ", " + season_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustomerCreditForVod.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustomerCreditForVod InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return -1;
            }    
        }

        public VodTokenLengs getVodTokenAndLngs(int imdb_id, int disk_id, int season_id, int cn, int device)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngs 1 ", imdb_id.ToString() + ", " + disk_id.ToString () + ", " + season_id.ToString (), device, modelcontext); 

                IEnumerable<VODChannel> vodch = modelcontext.ExecuteQuery<VODChannel>("CALL spmovie_vod_products({0},{1},{2},{3})", imdb_id, disk_id, season_id,Utilities.GetClientCoutry() );

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngs 2 ", imdb_id.ToString() + ", " + disk_id.ToString() + ", " + season_id.ToString(), device, modelcontext); 

                string[] vodidTmp = vodch.ToArray()[0].a.Split(','); 

                int vodid = int.Parse (vodidTmp [0].Split(':').ToArray()[0]);

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngs 3 vodid ", vodid.ToString(), device, modelcontext); 
                string token = getVodUrl(vodid, cn);
                Utilities.InsertMobileLog(cn, "getVodTokenAndLngs 4 token ", token, device, modelcontext); 
                //
                string AESkey = ConfigurationManager.AppSettings["AESkey"];
                string encryptedToken = AESCrypto.EncryptedString.EncryptString(token, AESkey);
                //
                Utilities.InsertMobileLog(cn, "getVodTokenAndLngs 5 encryptedToken ", encryptedToken, device, modelcontext); 
                VodTokenLengs vtl = new VodTokenLengs();
                vtl.t = encryptedToken;
                vtl.a = vodch.ToList()[0].a;
                Utilities.InsertMobileLog(cn, "getVodTokenAndLngs 6  vtl.a, vtl.t ", vtl.a + ", " +  vtl.t, device, modelcontext); 
                return vtl;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getVodTokenAndLngs. 1 imdb_id_serie, disk_id, season_id, cn :   " + imdb_id + ", " + disk_id + ", " + season_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getVodTokenAndLngs.Exception: 1 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getVodTokenAndLngs InnerException: 1" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }    
        }

        //public VodTokenLengs getVodTokenAndLngsNew(int imdb_id_serie, int disk_id, int season_id, int cn, int device)
        //{
        //    string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
        //    DVdPostMobileApIWS modelcontext = null;
        //    try
        //    {
        //        modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
        //        modelcontext.ObjectTrackingEnabled = false;
        //        modelcontext.QueryCacheEnabled = true;

        //        Utilities.InsertMobileLog(cn, "getVodTokenAndLngsNew 1 ", imdb_id_serie.ToString() + ", " + disk_id.ToString() + ", " + season_id.ToString(), device, modelcontext);

        //        IEnumerable<VODChannel> vodch = modelcontext.ExecuteQuery<VODChannel>("CALL spmovie_vod_products_new({0},{1},{2},{3})", imdb_id_serie, disk_id, season_id, Utilities.GetClientCoutry());

        //        Utilities.InsertMobileLog(cn, "getVodTokenAndLngsNew 2 ", imdb_id_serie.ToString() + ", " + disk_id.ToString() + ", " + season_id.ToString(), device, modelcontext);

        //        string[] vodidTmp = vodch.ToArray()[0].a.Split(',');

        //        int vodid = int.Parse(vodidTmp[0].Split(':').ToArray()[0]);

        //        Utilities.InsertMobileLog(cn, "getVodTokenAndLngsNew 3 vodid ", vodid.ToString(), device, modelcontext);
        //        string token = getVodUrl(vodid, cn);
        //        Utilities.InsertMobileLog(cn, "getVodTokenAndLngsNew 4 token ", token, device, modelcontext);
        //        //
        //        string AESkey = ConfigurationManager.AppSettings["AESkey"];
        //        string encryptedToken = AESCrypto.EncryptedString.EncryptString(token, AESkey);
        //        //
        //        Utilities.InsertMobileLog(cn, "getVodTokenAndLngsNew 5 encryptedToken ", encryptedToken, device, modelcontext);
        //        VodTokenLengs vtl = new VodTokenLengs();
        //        vtl.t = encryptedToken;
        //        vtl.a = vodch.ToList()[0].a;
        //        Utilities.InsertMobileLog(cn, "getVodTokenAndLngsNew 6  vtl.a, vtl.t ", vtl.a + ", " + vtl.t, device, modelcontext);
        //        return vtl;
        //    }
        //    catch (Exception ex)
        //    {
        //        this._hosteventLog = new System.Diagnostics.EventLog();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
        //        ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
        //        _hosteventLog.Source = "PlushServiceSource";
        //        _hosteventLog.Log = "PlushServiceLog";
        //        _hosteventLog.WriteEntry("getVodTokenAndLngsNew. 1 imdb_id_serie, disk_id, season_id, cn :   " + imdb_id_serie + ", " + disk_id + ", " + season_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
        //        _hosteventLog.WriteEntry("getVodTokenAndLngsNew.Exception: 1 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
        //        if (ex.InnerException != null)
        //        {
        //            _hosteventLog.WriteEntry("getVodTokenAndLngsNew InnerException: 1" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
        //        }
        //        return null;
        //    }
        //}

        public List<ListMovie> getCustRecommendations(int cn, int lngid)
        {
            List<ListMovie> lm = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            string nbrRecommanded = ConfigurationManager.AppSettings["NmbrRecommanded"];
            string WEBSERVICERECOMMENDATIONS = ConfigurationManager.AppSettings["WEBSERVICERECOMMENDATIONSFRUSER"];
            string request = string.Empty;
            try
            {
                if (lngid == 2)
                    WEBSERVICERECOMMENDATIONS = ConfigurationManager.AppSettings["WEBSERVICERECOMMENDATIONSNLUSER"];
                else if(lngid == 3 )
                    WEBSERVICERECOMMENDATIONS = ConfigurationManager.AppSettings["WEBSERVICERECOMMENDATIONSENUSER"];

                request = string.Format(WEBSERVICERECOMMENDATIONS, cn,nbrRecommanded);
                string responseContent;
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(request);
                HttpWebResponse webResponse = null;

                webResponse = (HttpWebResponse)webRequest.GetResponse();
                Stream responseStream = webResponse.GetResponseStream();
                StreamReader responseStreamReader = new StreamReader(responseStream);
                responseContent = responseStreamReader.ReadToEnd();
                responseStreamReader.Close();
                XmlDocument xd = new XmlDocument();
                XDocument xs = XDocument.Parse(responseContent);

                xd.LoadXml(responseContent);
                //XmlNodeList ln = xd.GetElementsByTagName("DVDs");
                XmlNodeList ln = xd.GetElementsByTagName("Item");
                string spParameter = string.Empty;
                foreach (XmlNode xn in ln)
                {
                    spParameter += xn.Attributes["id"].Value + ",";
                }
                if (spParameter != string.Empty)
                {
                    modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                    IEnumerable<ListMovie> recomandList = modelcontext.ExecuteQuery<ListMovie>("CALL sp_recomanded_movies({0},{1},{2})", spParameter.TrimEnd(','), lngid, Utilities.GetClientCoutry());

                    lm = recomandList.ToList<ListMovie>();
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustRecommendations. 1 cn, lngid, request :   " + cn + ", " + lngid + ", " + request, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustRecommendations.Exception: 1 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustRecommendations InnerException: 3" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }    


            return lm;
        }

        public List<ListMovie> getVodCatalogue(int lngid, int pageNumber, int pageSize)
        {
            List<ListMovie> lm = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));                 

                IEnumerable<ListMovie> recomandList = modelcontext.ExecuteQuery<ListMovie>("CALL sp_vodcatalogue({0},{1})", lngid, Utilities.GetClientCoutry() ).Skip((pageNumber - 1) * pageSize).Take(pageSize); 

                lm = recomandList.ToList<ListMovie>();
                return lm;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getVodCatalogue. lngid :   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getVodCatalogue.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getVodCatalogue InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<MyListMovie> getCustProdWishList(int lngid, int cn, int device)
        {
            List<MyListMovie> lm = new List<MyListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<MyListMovie> recomandList = modelcontext.ExecuteQuery<MyListMovie>("CALL sp_customer_wishlist({0},{1}, {2})", lngid, cn, Utilities.GetClientCoutry());

                lm =  recomandList.ToList<MyListMovie>();
                return lm;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustProdWishList. lngid,cn :   " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustProdWishList.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustProdWishList InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public int addProductToWishList(int pdid, int prty, int wlsrcid, int cn, int device)
        {
            Utilities.InsertMobileLog(cn, "addProductToWishList", pdid.ToString() + ", " + prty.ToString() + ", " + wlsrcid.ToString(), device);  

            List<ListMovie> lm = new List<ListMovie>();
            DVdPostMobileApIWS contextBeProd = null;
            try
            {
                string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;

                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                //
                string sqlWishlistExists = QueriesDB.GetProductWishlistExists(pdid, cn);
                IEnumerable<numberresult> res = contextBeProd.ExecuteQuery<numberresult>(sqlWishlistExists);
                numberresult exists = res.FirstOrDefault<numberresult>();
                if (exists.r == 0)
                {

                string sqlInsertWishList = QueriesDB.GetInsertWishList(pdid, prty, cn, wlsrcid);
                //
                contextBeProd.ExecuteCommand(sqlInsertWishList);
                }
                return 1;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("addProductToWishList. cn, pdid:   " + cn + ", " + pdid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("addProductToWishList.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("addProductToWishList InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                if (ex.Message.Contains ("Duplicate entry"))
                    return 2;
                else
                    return 0;
            }
        }

        public int addVodToWishList(int imdb_id, int disk_id, int season_id, int cn, int device)
        {            
              try
            {
                string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
                DVdPostMobileApIWS contextBeProd = null;

                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                  string sqlVodWishlistExists = QueriesDB.getVodWishListExists(imdb_id, disk_id, season_id, cn);

                string sqlAddVodToWishlist = QueriesDB.getVodToWishList (imdb_id, disk_id,season_id, cn);

                IEnumerable<numberresult> res = contextBeProd.ExecuteQuery<numberresult>(sqlVodWishlistExists);
                numberresult exists = res.FirstOrDefault<numberresult>();
                if (exists.r == 0)
                {
                    int result = contextBeProd.ExecuteCommand(sqlAddVodToWishlist);
                }
                return 1;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("addVodToWishList. imdb_id, disk_id, season_id, cn :   " + imdb_id + ", " +  disk_id + ", " +  season_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("addVodToWishList.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("addVodToWishList InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 0;
            }
        }

        public List<DVDChannel> getMovieDVDBlueRay(int imdb_id_serie, int disk_id, int season_id)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                IEnumerable<DVDChannel> dvdch = modelcontext.ExecuteQuery<DVDChannel>("CALL spmovie_dvd_products({0},{1},{2})", imdb_id_serie, disk_id, season_id);
                return dvdch.ToList<DVDChannel>();

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMovieDVDBlueRay. imdb_id_serie, disk_id, season_id :   " + imdb_id_serie + ", " + disk_id + ", " + season_id, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMovieDVDBlueRay.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMovieDVDBlueRay InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<DVDChannel> getMovieDVDBlueRay_1(int imdb_id_serie, int disk_id, int season_id, int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                IEnumerable<DVDChannel> dvdch = modelcontext.ExecuteQuery<DVDChannel>("CALL spmovie_dvd_products_1({0},{1},{2},{3})", imdb_id_serie, disk_id, season_id, lngid);
                return dvdch.ToList<DVDChannel>();

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMovieDVDBlueRay_1. imdb_id_serie, disk_id, season_id :   " + imdb_id_serie + ", " + disk_id + ", " + season_id, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMovieDVDBlueRay_1.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMovieDVDBlueRay_1 InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<MyListMovie> getProductsAtCustomer(int cn, int lngid, int device)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

            try
            {
                Utilities.InsertMobileLog(cn, "getProductsAtCustomer", lngid.ToString(), device,modelcontext);

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                IEnumerable<MyListMovie> dvdch = modelcontext.ExecuteQuery<MyListMovie>("CALL sp_products_at_customer({0},{1})", cn, lngid);
                return dvdch.ToList<MyListMovie>();

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getProductsAtCustomer. cn, lngid :   " + cn + ", " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getProductsAtCustomer.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getProductsAtCustomer InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public int addMovieSeen(int imdb_id, int disk_id, int season_id, int cn)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlRemoveWishlist = QueriesDB.GetInsertMovieSeen(imdb_id, disk_id, season_id, cn);
                //
                return contextBeProd.ExecuteCommand(sqlRemoveWishlist);
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("addMovieSeen. imdb_id_serie, disk_id, season_id:   " + imdb_id + ", " + disk_id + ", " + season_id, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("addMovieSeen.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("addMovieSeen InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 0;
            }
        }

        public int addMovieUninterested(int imdb_id, int disk_id, int season_id, int cn)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlRemoveWishlist = QueriesDB.GetInsertMovieUninterested(imdb_id, disk_id, season_id, cn);
                //
                return contextBeProd.ExecuteCommand(sqlRemoveWishlist);
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("addMovieUninterested. imdb_id_serie, disk_id, season_id:   " + imdb_id + ", " + disk_id + ", " + season_id, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("addMovieUninterested.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("addMovieUninterested InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 0;
            }
        }

        public int addMovieRate(int imdb_id, int disk_id, int season_id, int cn, int rate)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                //
                string sqlMovieRateExists = QueriesDB.GetMovieRateExists(imdb_id, disk_id, season_id, cn);
                IEnumerable<numberresult> res = contextBeProd.ExecuteQuery<numberresult>(sqlMovieRateExists);
                numberresult exists = res.FirstOrDefault<numberresult>();
                if (exists.r == 0)
                {

                    string sqlAddMovieRate = QueriesDB.GetInsertMovieRate(imdb_id, disk_id, season_id, cn, rate);
                    //
                    return contextBeProd.ExecuteCommand(sqlAddMovieRate);
                }
                return 0;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("addMovieRate. imdb_id, disk_id, season_id:   " + imdb_id + ", " + disk_id + ", " + season_id, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("addMovieRate.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("addMovieRate InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 1;
            }
        }

        public int RemoveProdFromWishlist(int pdid, int cn)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlRemoveWishlist = QueriesDB.GetDeleteWishlist (pdid,cn);
                //
                return  contextBeProd.ExecuteCommand(sqlRemoveWishlist);
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("RemoveProdFromWishlist. pdid, cn:   " + pdid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("RemoveProdFromWishlist.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("RemoveProdFromWishlist InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 0;
            }

        }

        public int RemoveVodFromWishlist(int imdb_id, int cn)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlRemoveWishlist = QueriesDB.GetDeleteVodWishlist(imdb_id, cn);
                //
                return contextBeProd.ExecuteCommand(sqlRemoveWishlist);
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("RemoveProdFromWishlist. imdb_id_serie, cn:   " + imdb_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("RemoveProdFromWishlist.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("RemoveProdFromWishlist InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 0;
            }

        }

        public int setVodOnly(int cn, int ovod)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlUpdateVodOnly = QueriesDB.GetUpdateVodOnly(cn,ovod);
                //
                return contextBeProd.ExecuteCommand(sqlUpdateVodOnly);
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("setVodOnly. ovod, cn:   " + ovod + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("setVodOnly.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("setVodOnly InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return 1;
            }

        }

        public List<ListMovie> getMoviesNewTitles(int lngid, bool show_tvod,  bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                               
                //mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_new_movies_vod({0},{1},{2},{3},{4})", lngid, Utilities.GetClientCoutry(), show_tvod,  show_svod, cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                
                //return mm.ToList<ListMovie>();

                //
                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_new_movies_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_new_movies_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesNewTitles. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesNewTitles.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesNewTitles InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMoviesLastChance(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                //
                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_last_chance_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_last_chance_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesNewTitles. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesNewTitles.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesNewTitles InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getAllCatalogueMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_all_movies_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn ).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_all_movies_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn ).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }
              
                if (tvod != null && svod != null)
                {
                    result  = tvod.Union<ListMovie>(svod);                    
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
                
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getAllCatalogueMovies. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getAllCatalogueMovies.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getAllCatalogueMovies InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMoviesSoon_1(int lngid, int pageNumber, int pageSize, int vodOnly)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> mm;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                if (vodOnly == 1)
                {
                    mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_soon_movies_vod({0},{1})", lngid, Utilities.GetClientCoutry()).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }
                else
                {
                    mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_soon_movies({0},{1})", lngid, Utilities.GetClientCoutry()).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }
                return mm.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesNewTitles. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesNewTitles.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesNewTitles InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMoviesLastAdded(int lngid,  bool show_tvod,  bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                //mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_last_added_vod({0},{1},{2},{3},{4})", lngid, Utilities.GetClientCoutry(),  show_tvod,  show_svod, cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);

                //return mm.ToList<ListMovie>();

                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_last_added_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_last_added_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesLastAdded. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesLastAdded.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesLastAdded InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMostPopularMovies(int lngid,  bool show_tvod,  bool show_svod, int cn,  int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                //mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_most_rented_movies_vod({0},{1},{2},{3},{4})", lngid, Utilities.GetClientCoutry(),  show_tvod,  show_svod, cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                
                //return mm.ToList<ListMovie>();

                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_most_rented_movies_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_most_rented_movies_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMostPopularMovies. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMostPopularMovies.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMostPopularMovies InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getBestRatedMovies(int lngid, bool show_tvod,  bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

               //mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_best_rated_movies_vod({0},{1},{2},{3},{4})", lngid, Utilities.GetClientCoutry(), show_tvod,  show_svod, cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
               
               // return mm.ToList<ListMovie>();

                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_best_rated_movies_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_best_rated_movies_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMostPopularMovies. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMostPopularMovies.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMostPopularMovies InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getOurFavoritesMovies(int lngid,  bool show_tvod,  bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                //mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_our_movies_vod({0},{1},{2},{3},{4})", lngid, Utilities.GetClientCoutry(), show_tvod, show_svod, cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
               
                //return mm.ToList<ListMovie>();


                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_our_movies_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_our_movies_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getOurFavoritesMovies. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getOurFavoritesMovies.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getOurFavoritesMovies InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMoviesBestReview(int lngid, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_best_reviews({0}, {1})", lngid, Utilities.GetClientCoutry()).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return mm.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesBestReview. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesBestReview.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesBestReview InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMoviesSoon(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<ListMovie> tvod = null;
            IEnumerable<ListMovie> svod = null;
            IEnumerable<ListMovie> result = null;

            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                //IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_soon_movie({0},{1})", lngid, Utilities.GetClientCoutry()).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                //return mm.ToList<ListMovie>();
                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_soon_movie_tvod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<ListMovie>("CALL sp_soon_movie_svod({0},{1},{2})", lngid, Utilities.GetClientCoutry(), cn).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<ListMovie>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<ListMovie>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<ListMovie>();
                }

                return result.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesSoon. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesSoon.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesSoon InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getMoviesInCinema(int lngid, int pageNumber, int pageSize)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_incinema_movie({0},{1})", lngid, Utilities.GetClientCoutry() ).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return mm.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesInCinema. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesInCinema.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesInCinema InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }
        // odavde
        public List<VodAtCustomer> getVodAtCustomer(int cn, int lngid, int device)
        {
            List<VodAtCustomer> lm = new List<VodAtCustomer>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                Utilities.InsertMobileLog(cn, "getVodAtCustomer", lngid.ToString (), device, modelcontext); 

                IEnumerable<VodAtCustomer> recomandList = modelcontext.ExecuteQuery<VodAtCustomer>("CALL sp_vod_at_customer({0},{1})", cn, lngid);

                lm = recomandList.ToList<VodAtCustomer>();
                return lm;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getVodAtCustomer. lngid,cn :   " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getVodAtCustomer.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getVodAtCustomer InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        //public List<CustVodWishList> getCustVodWishList(int cn, int lngid, int device)
        public List<CustVodWishList> getCustVodWishList(int cn, int lngid, bool show_tvod, bool show_svod, int device)
        {
            List<CustVodWishList> lm = new List<CustVodWishList>();
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<CustVodWishList> tvod = null;
            IEnumerable<CustVodWishList> svod = null;
            IEnumerable<CustVodWishList> result = null;
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                Utilities.InsertMobileLog(cn, "getCustVodWishList", lngid.ToString(), device, modelcontext); 

                //IEnumerable<CustVodWishList> recomandList = modelcontext.ExecuteQuery<CustVodWishList>("CALL sp_customer_vod_wishlist({0},{1})", cn, lngid);

                //lm = recomandList.ToList<CustVodWishList>();
                //return lm;
                if (show_tvod)
                {
                    tvod = modelcontext.ExecuteQuery<CustVodWishList>("CALL sp_customer_vod_wishlist_tvod({0},{1})", cn, lngid);
                }

                if (show_svod)
                {
                    svod = modelcontext.ExecuteQuery<CustVodWishList>("CALL sp_customer_vod_wishlist_svod({0},{1})", cn, lngid);
                }

                if (tvod != null && svod != null)
                {
                    result = tvod.Union<CustVodWishList>(svod);
                }
                if (tvod != null && svod == null)
                {
                    result = tvod.ToList<CustVodWishList>();
                }
                if (tvod == null && svod != null)
                {
                    result = svod.ToList<CustVodWishList>();
                }

                return result.ToList<CustVodWishList>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustVodWishList. lngid,cn :   " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustVodWishList.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustVodWishList InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getCustVodSoon(int cn, int lngid)
        {
            List<ListMovie> lm = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                IEnumerable<ListMovie> recomandList = modelcontext.ExecuteQuery<ListMovie>("CALL sp_cust_vod_soon({0},{1})", cn, lngid);

                lm = recomandList.ToList<ListMovie>();
                return lm;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustVodSoon. lngid,cn :   " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustVodSoon.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustVodSoon InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<CodeListCountries> getCodeListCountries()
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlCodeListCountries = QueriesDB.getCodeListCountries();
                //
                IEnumerable<CodeListCountries> clc = contextBeProd.ExecuteQuery< CodeListCountries>(sqlCodeListCountries);

                return clc.ToList();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCodeListCountries. : ", System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCodeListCountries.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCodeListCountries InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }

        }

        public List<CodeListLanguages> getCodeListAudios(int lngid)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlCodeListAudio = QueriesDB.getCodeListLanguage(lngid);
                //
                IEnumerable<CodeListLanguages> clc = contextBeProd.ExecuteQuery<CodeListLanguages>(sqlCodeListAudio);

                return clc.ToList();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCodeListAudios. : ", System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCodeListAudios.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCodeListAudios InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }

        }

        public List<CodeListTitle> getCodeListTitles(int lngid)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlCodeListTitles= QueriesDB.getCodeListTitles(lngid);
                //
                IEnumerable<CodeListTitle> clt = contextBeProd.ExecuteQuery<CodeListTitle>(sqlCodeListTitles);

                return clt.ToList();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCodeListTitles. : " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCodeListTitles.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCodeListTitles InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }

        }

        public List<MyListMovie> getCustProdWishListSoon(int cn, int lngid, int device)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                Utilities.InsertMobileLog(cn, "getCustProdWishListSoon", lngid.ToString(), device, modelcontext); 

                IEnumerable<MyListMovie> dvdch = modelcontext.ExecuteQuery<MyListMovie>("CALL sp_customer_wishlist_soon({0},{1})", cn, lngid);
                return dvdch.ToList<MyListMovie>();

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustProdWishListSoon. cn, lngid :   " + cn + ", " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustProdWishListSoon.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustProdWishListSoon InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<MyListMovie> getCustProdWishListUnavlb(int cn, int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                IEnumerable<MyListMovie> dvdch = modelcontext.ExecuteQuery<MyListMovie>("CALL sp_customer_wishlist_unavailable({0},{1},{2})", cn, lngid, Utilities.GetClientCoutry());
                return dvdch.ToList<MyListMovie>();

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustProdWishListUnavlb. cn, lngid :   " + cn + ", " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustProdWishListUnavlb.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustProdWishListUnavlb InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public int addProductAtCustomerComplain( int cn, string cmpln, int pdid)
        {

            return 0;
            //List<MyListMovie> lm = new List<MyListMovie>();
            //DVdPostMobileApIWS modelcontext = null;
            //try
            //{
            //    string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

            //    modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
            //    IEnumerable<MyListMovie> recomandList = modelcontext.ExecuteQuery<MyListMovie>("CALL sp_customer_wishlist({0},{1})", lngid, cn);

            //    lm = recomandList.ToList<MyListMovie>();
            //    return lm;
            //}
            //catch (Exception ex)
            //{
            //    this._hosteventLog = new System.Diagnostics.EventLog();
            //    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
            //    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
            //    _hosteventLog.Source = "PlushServiceSource";
            //    _hosteventLog.Log = "PlushServiceLog";
            //    _hosteventLog.WriteEntry("getCustProdWishList. lngid,cn :   " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
            //    _hosteventLog.WriteEntry("getCustProdWishList.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
            //    if (ex.InnerException != null)
            //    {
            //        _hosteventLog.WriteEntry("getCustProdWishList InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
            //    }
            //    return null;
            //}
        }

        public int setProductWishlistPriority(int pdid, int cn, int prty)
        {
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            //                        
            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sqlProductWishlistPriority = QueriesDB.GetSetWishlistPriority(pdid, cn, prty);
                //
                int result = contextBeProd.ExecuteCommand(sqlProductWishlistPriority);
                return 0;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("setProductWishlistPriority. pdid, cn, prty:   " + pdid + ", " + cn + ", " + prty, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("setProductWishlistPriority.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("setProductWishlistPriority InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return -1;
            }

        }

        public List<catalogcommunity> getCatalogCommunity(int lngid)
        {
            string connstr = string.Empty;
            DVdPostMobileApIWS modelcontext;
            List<catalogcommunity> returnList = new List<catalogcommunity> ();
            try
            {
                connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                var ctlgComunity = from ctg in modelcontext.CatalogCommunity
                              where ctg.LanguageID == lngid
                              select ctg;
                List<CatalogCommunity> catalogLst = ctlgComunity.ToList();

                foreach (CatalogCommunity ctgCmnty in catalogLst)
                {
                    returnList.Add(new catalogcommunity() { id = ctgCmnty.ID, name = ctgCmnty.Name, img = ctgCmnty.Image, refclient = ctgCmnty.RefClient, refclientid = ctgCmnty.RefClientID });
                }
                return returnList; ;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCatalogCommunity: lngid: " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCatalogCommunity.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCatalogCommunity InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getCatalogCommunityMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid)
        {
            DVdPostMobileApIWS modelcontext;
            List<CatalogCommunity> ctlgcmntylst;
            string connstr = string.Empty;

            try
            {
                connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                var ctlgcmnty = from ctg in modelcontext.CatalogCommunity
                              where ctg.LanguageID == lngid
                              select ctg;
                ctlgcmntylst = ctlgcmnty.ToList();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCatalogCommunityMovies. 1 lngid, refclient, refclientid: " + lngid + ", " + refclient + ", " + refclientid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCatalogCommunityMovies.Exception:1  " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCatalogCommunityMovies 1 InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            try
            {
                CatalogCommunity catalogComunity = ctlgcmntylst.SingleOrDefault(m => m.RefClient == refclient);

                if (catalogComunity.RefSourceID == 1)
                {
                    string sss = string.Format("CALL {0}({1},'{2}')", catalogComunity.RefSource, lngid, Utilities.GetClientCoutry());
                    IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>(sss).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                    return mm.ToList<ListMovie>();
                }
                else if (catalogComunity.RefSourceID == 2)
                {
                    //URL
                    return null;
                }
                else if (catalogComunity.RefSourceID == 3)
                {
                    string sss = string.Format("CALL {0}({1}, {2}, '{3}')", catalogComunity.RefSource, refclientid, lngid, Utilities.GetClientCoutry());
                    IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>(sss).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                    return mm.ToList<ListMovie>();
                }
                else
                {
                    this._hosteventLog = new System.Diagnostics.EventLog();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                    ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                    _hosteventLog.Source = "PlushServiceSource";
                    _hosteventLog.Log = "PlushServiceLog";
                    _hosteventLog.WriteEntry("getHomePageCategoryMovies. 2 lngid, refclient, refclientid: " + lngid + ", " + refclient + ", " + refclientid);
                    return null;
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCatalogCommunityMovies. 3 lngid, refclient, refclientid: " + lngid + ", " + refclient + ", " + refclientid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCatalogCommunityMovies.Exception: 3 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCatalogCommunityMovies InnerException: 3" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public VodTokenLengs getVodTokenAndLngsTest(int imdb_id_serie, int disk_id, int season_id, int cn, int device)
        {

            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngsTest 1 ", imdb_id_serie.ToString() + ", " + disk_id.ToString() + ", " + season_id.ToString(), device, modelcontext);

                IEnumerable<VODChannel> vodch = modelcontext.ExecuteQuery<VODChannel>("CALL spmovie_vod_products({0},{1},{2},{3})", imdb_id_serie, disk_id, season_id, Utilities.GetClientCoutry());

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngsTest 2 ", imdb_id_serie.ToString() + ", " + disk_id.ToString() + ", " + season_id.ToString(), device, modelcontext);

                string[] vodidTmp = vodch.ToArray()[0].a.Split(',');

                int vodid = int.Parse(vodidTmp[0].Split(':').ToArray()[0]);

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngsTest 3 vodid ", vodid.ToString(), device, modelcontext);
                string token = getVodUrl(vodid, cn);
                Utilities.InsertMobileLog(cn, "getVodTokenAndLngsTest 4 token ", token, device, modelcontext);
                //
                string AESkey = ConfigurationManager.AppSettings["AESkey"];
                string encryptedToken = AESCrypto.EncryptedString.EncryptString(token, AESkey);
                //
                Utilities.InsertMobileLog(cn, "getVodTokenAndLngsTest 5 encryptedToken ", encryptedToken, device, modelcontext);
                VodTokenLengs vtl = new VodTokenLengs();
                vtl.t = encryptedToken;
                vtl.a = vodch.ToList()[0].a;
                DateTime x = DateTime.Now.AddSeconds (45);

                while (x > DateTime.Now) ;

                Utilities.InsertMobileLog(cn, "getVodTokenAndLngsTest 6  vtl.a, vtl.t ", vtl.a + ", " + vtl.t, device, modelcontext);
                return vtl;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getVodTokenAndLngs. 1 imdb_id_serie, disk_id, season_id, cn :   " + imdb_id_serie + ", " + disk_id + ", " + season_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getVodTokenAndLngs.Exception: 1 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getVodTokenAndLngs InnerException: 1" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public int setErrorLog(int cn, string call_method, string call_parameters, string error_message, int device)
        {
            return Utilities.InsertMobileApplicationLog(cn, call_method, call_parameters, error_message, device);
        }

        public VodEnabled IsVodEnabled(int imdb_id_serie, int disk_id, int season_id, int cn, int device)
        {
            VodEnabled ve = new VodEnabled();

            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint =
            prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            string ip = endpoint.Address;

            //if (!Utilities.IsVodEnabledForThisIP(ip))
            //{
            //    ve.isvodavailable = 0;
            //    ve.message = "Sorry VOD not available in this sountry";

            //    return ve;
            //}            

            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));

            IEnumerable<numberresult> code_value = contextBeProd.ExecuteQuery<numberresult>(QueriesDB.getVOD_CREATE_TOKEN());

            if (code_value.Count() > 0 && code_value.ToArray()[0].r == 0)
            {
                ve.isvodavailable = 0;
                ve.message = "Sorry VOD not available";

                return ve;
            }

            code_value = contextBeProd.ExecuteQuery<numberresult>(QueriesDB.getVOD_ONLINE ());

            if (code_value.Count() > 0 && code_value.ToArray()[0].r == 0)
            {
                ve.isvodavailable = 0;
                ve.message = "Sorry VOD not available";

                return ve;
            }

            ve.isvodavailable = 1;
            ve.message = "";

            return ve;
        }

        public RegistrationAllowed SetRegistration(string email, int lngid)
        {
            string connstr_mobile = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            string connstr_prod = ConfigurationManager.ConnectionStrings["prod-WRITE"].ConnectionString;
            DVdPostMobileApIWS contextBeProd = null;
            DVdPostMobileApIWS contextMobileApiWs = null;
            RegistrationAllowed ra = new RegistrationAllowed();
            CustomerDetailsRow cd = new CustomerDetailsRow();

            try
            {
                contextBeProd = new DVdPostMobileApIWS(new MySqlConnection(connstr_prod));
                string sql = QueriesDB.GetDVDCount();
                //
                IEnumerable<numberresult> clt = contextBeProd.ExecuteQuery<numberresult>(sql);

                int count_dvd = clt.FirstOrDefault().r;
                //
                sql = QueriesDB.GetVodCount();
                clt = contextBeProd.ExecuteQuery<numberresult>(sql);

                int count_vod = clt.FirstOrDefault().r;
                //

                contextMobileApiWs = new DVdPostMobileApIWS(new MySqlConnection(connstr_mobile));

                IEnumerable<CustomerDetailsRow> cdr = contextMobileApiWs.ExecuteQuery<CustomerDetailsRow>("CALL sp_customer_getbyemail({0})", email);

                if (cdr.Count() > 0)
                {
                    string message = string.Empty;

                    if (lngid == 1)
                    {
                        message = "Inscription non réussie, cette adresse e-mail existe déjà dans notre base de données";
                    }
                    else if (lngid == 2)
                    {
                        message = "Registratie niet geslaagd, dit email adres bestaat al in onze database";
                    }
                    else
                    {
                        message = "Registration not successful, this e-mail address is already registered in system";
                    }
                    ra.isregistrationallowed = 0;
                    ra.message = message;
                    return ra;
                }

                // send email
                DataTable dt = new DataTable("customermail");
                dt.Columns.Add("customers_firstname", typeof(string));
                dt.Columns.Add("customers_lastname", typeof(string));
                dt.Columns.Add("customers_name", typeof(string));
                dt.Columns.Add("customers_gender", typeof(string));
                dt.Columns.Add("customers_email_address", typeof(string));
                dt.Columns.Add("customers_language", typeof(int));
                dt.Columns.Add("customers_id", typeof(int));
                dt.Columns.Add("products_id", typeof(int));
                dt.Columns.Add("customers_abo_payment_method", typeof(int));
                dt.Columns.Add("customers_abo", typeof(int));
                dt.Columns.Add("customers_abo_dvd_home_norm", typeof(int));
                dt.Columns.Add("customers_abo_dvd_home_adult", typeof(int));
                dt.Columns.Add("date_sent", typeof(DateTime));
                dt.Columns.Add("count_vod", typeof(int));
                dt.Columns.Add("avantage", typeof(int));
                dt.Columns.Add("count_movies", typeof(int));

                DataRow dr = dt.NewRow();
                dr["customers_firstname"] = string.Empty;
                dr["customers_lastname"] = string.Empty;
                dr["customers_name"] = string.Empty;
                dr["customers_gender"] = string.Empty;
                dr["customers_email_address"] = email;
                dr["customers_language"] = lngid;
                dr["customers_id"] = 0;
                dr["products_id"] = 0;
                dr["customers_abo_payment_method"] = 0;
                dr["customers_abo"] = 0;
                dr["customers_abo_dvd_home_norm"] = 0;
                dr["customers_abo_dvd_home_adult"] = 0;
                dr["date_sent"] = DateTime.Now;
                dr["count_vod"] = count_vod;
                dr["avantage"] = 1022;
                dr["count_movies"] = count_dvd;

                DvdPostData.clsConnection.typeEnv = "prod";
                DVDPostBuziness.clsMail.SendMail(dr, clsMail.Mail.MAIL_REGISTRATION);

                string messageOK = string.Empty;

                if (lngid == 1)
                {
                    messageOK = "Inscription reussie";
                }
                else if (lngid == 2)
                {
                    messageOK = "Registratie geslaagd";
                }
                else
                {
                    messageOK = "Registration successful";
                }

                ra.isregistrationallowed = 1;
                ra.message = messageOK;
                return ra;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("SetRegistration. 1 email, lngid :   " + email + ", " + lngid.ToString(), System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("SetRegistration.Exception: 1 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("SetRegistration InnerException: 1" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }


        }

        public List<ListMovieWatched> getCustWatched(int cn, int lngid, int pageNumber, int pageSize)
        {
            List<ListMovieWatched> lm = new List<ListMovieWatched>();
            DVdPostMobileApIWS modelcontext = null;
            try
            {
                string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;

                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<ListMovieWatched> recomandList = modelcontext.ExecuteQuery<ListMovieWatched>("CALL sp_customer_watched_tomobile({0},{1},{2})", lngid, cn, Utilities.GetClientCoutry()).Skip((pageNumber - 1) * pageSize).Take(pageSize); ;

                lm = recomandList.ToList<ListMovieWatched>();
                return lm;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCustWatched. lngid,cn :   " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCustWatched.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCustWatched InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListMovie> getTodaysMovies(int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            List<ListMovie> lbrv = new List<ListMovie>();
            DVdPostMobileApIWS modelcontext = null;

            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                IEnumerable<ListMovie> mm = modelcontext.ExecuteQuery<ListMovie>("CALL sp_todays_movie({0},{1})", lngid, Utilities.GetClientCoutry());
                return mm.ToList<ListMovie>();
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getMoviesSoon. lngid:   " + lngid, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getMoviesSoon.Exception: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getMoviesSoon InnerException: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public string getVODLanguages(int imdb_id, int disk_id, int season_id, int cn, int lngid)
        {
            string connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
            DVdPostMobileApIWS modelcontext = null;
            IEnumerable<VODChannel> vodch ;
            try
            {
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;
                if (lngid == 0)
                    vodch = modelcontext.ExecuteQuery<VODChannel>("CALL spmovie_vod_products_new({0},{1},{2},{3})", imdb_id, disk_id, season_id, Utilities.GetClientCoutry());
                else
                    vodch = modelcontext.ExecuteQuery<VODChannel>("CALL spmovie_vod_products_2({0},{1},{2},{3},{4})", imdb_id, disk_id, season_id, lngid, Utilities.GetClientCoutry());

                if (vodch == null || vodch.Count() == 0)
                    return null;
                else
                {
                    return vodch.First().a;
                }
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getVODLanguages. 1 imdb_id, disk_id, season_id, cn :   " + imdb_id + ", " + disk_id + ", " + season_id + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getVODLanguages.Exception: 1 " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getVODLanguages InnerException: 1" + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public hp getHomePage(int lngid, int cn, int device)
        {
            hp hp = new hp();
            hp.menu = new List<menuitem>();            
            hp.trailer = new hptrailer();
            hp.movies_svod = new List<ListMovie>();
            hp.movies_tvod = new List<ListMovie>();

            string connstr = string.Empty;            
            DVdPostMobileApIWS modelcontext;

            try
            {
                connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                var hpmenuVar = from ctg in modelcontext.HpMenu
                              where ctg.LanguageID == lngid && ctg.Available == 1
                              orderby ctg.Ordered
                              select ctg;
                List<HpMenu> hpmenulst = hpmenuVar.OrderBy(o => o.Ordered).ToList();

                foreach (HpMenu hpmenu in hpmenulst)
                {
                    string imagePath = string.Empty;
                   
                   imagePath = hpmenu.IMg.Replace("dvd/", "landscape/");                   

                    hp.menu.Add(new menuitem() { name = hpmenu.Name, method = hpmenu.MethodURL});
                }

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getHomePage. 1 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getHomePage.Exception 1: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getHomePage InnerException 1: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }

            try
            {
                hptrailer hptr = modelcontext.ExecuteQuery<hptrailer>("CALL sp_hptrailer({0})", lngid).First<hptrailer>() ;
                hp.trailer.disk_id = hptr.disk_id;
                hp.trailer.imdb_id = hptr.imdb_id;
                hp.trailer.name = hptr.name;
                hp.trailer.season_id = hptr.season_id;
                hp.trailer.trailer_aud_sub = hptr.trailer_aud_sub;
                hp.trailer.trailer_token = hptr.trailer_token;  
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getHomePage. 2 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getHomePage.Exception 2: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getHomePage InnerException 2: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            try
            {
                List<HpMovieSVOD> hpmovieList = modelcontext.HpMovieSVOD.Where(h => h.LNGiD == lngid).OrderBy(o => o.Ordered).ToList<HpMovieSVOD>();
                
                //string imgPath = "landingsiphone/";
                //if (device == 1)
                //    imgPath = "landingsipad/";

                foreach (HpMovieSVOD movie in hpmovieList)
                {
                    ListMovie hpmv = new ListMovie();
                    
                    hpmv.trailer_token = movie.Broadcast;
                    
                    hpmv.disk_id = movie.DiskID;                    
                    hpmv.imdb_id = movie.IMDbIDSErie;
                    hpmv.img = movie.IMg;                    
                    hpmv.name = movie.Name;                    
                    hpmv.rate = movie.Rate;
                    hpmv.season_id = movie.SeasonID;
                    hpmv.trailer_aud_sub = movie.Trailer;
                    hpmv.price = movie.price;

                    hp.movies_svod.Add(hpmv);

                }

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getHomePage. 3 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getHomePage.Exception 3: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getHomePage InnerException 3: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            try
            {
                List<HpMovieTVOD> hpmovieList = modelcontext.HpMovieTVOD.Where(h => h.LNGiD == lngid).OrderBy(o => o.Ordered).ToList<HpMovieTVOD>();

                //string imgPath = "landingsiphone/";
                //if (device == 1)
                //    imgPath = "landingsipad/";

                foreach (HpMovieTVOD movie in hpmovieList)
                {
                    ListMovie hpmv = new ListMovie();

                    hpmv.trailer_token = movie.Broadcast;

                    hpmv.disk_id = movie.DiskID;
                    hpmv.imdb_id = movie.IMDbIDSErie;
                    hpmv.img = movie.IMg;
                    hpmv.name = movie.Name;
                    hpmv.rate = movie.Rate;
                    hpmv.season_id = movie.SeasonID;
                    hpmv.trailer_aud_sub = movie.Trailer;
                    hpmv.price = movie.price;

                    hp.movies_tvod.Add(hpmv);

                }

                return hp;

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getHomePage. 3 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getHomePage.Exception 3: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getHomePage InnerException 3: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public CataloguePage_1 getCataloguePage_1(int lngid, int cn, int device, int vodOnly)
        {
            CataloguePage_1 cp = new CataloguePage_1();
            
            cp.ctlgcentralmenu = new List<menuitem>();
            cp.ctlgleftmenu = new List<menuitem>();
            cp.movielist = new MovieList_1();

            string connstr = string.Empty;
            DVdPostMobileApIWS modelcontext;

            
            //
            try
            {
                connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));                

                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;
                var hpmenu = from ctg in modelcontext.CtLGLeftMenu
                             where ctg.LanguageID == lngid && ctg.Available == 1
                             orderby ctg.Ordered
                             select ctg;
                List<CtLGLeftMenu> hpctglst = hpmenu.OrderBy(o => o.Ordered).ToList();

                foreach (CtLGLeftMenu hpctg in hpctglst)
                {
                    string imagePath = string.Empty;
                    if (device == 0)
                        imagePath = hpctg.IMg.Replace("dvd/", "landscape/");
                    else
                        imagePath = hpctg.IMg;

                    cp.ctlgleftmenu.Add(new menuitem() { name = hpctg.Name, method = hpctg.MethodURL });
                }

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCataloguePage_1. 2 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCataloguePage_1.Exception 2: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCataloguePage_1 InnerException 2: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            //
            try
            {
                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;
                var hpmenu = from ctg in modelcontext.CtLGCentralMenu
                             where ctg.LanguageID == lngid && ctg.Available == 1
                             orderby ctg.Ordered
                             select ctg;
                List<CtLGCentralMenu> hpctglst = hpmenu.OrderBy(o => o.Ordered).ToList();

                foreach (CtLGCentralMenu hpctg in hpctglst)
                {
                    string imagePath = string.Empty;
                    if (device == 0)
                        imagePath = hpctg.IMg.Replace("dvd/", "landscape/");
                    else
                        imagePath = hpctg.IMg;

                    cp.ctlgcentralmenu.Add(new menuitem() { name = hpctg.Name, method = hpctg.MethodURL });
                }

            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCataloguePage_1. 1 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCataloguePage_1.Exception 3: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCataloguePage_1 InnerException 3: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
            //
            try
            {
                IEnumerable<ListMovie> hpmovielist = modelcontext.ExecuteQuery<ListMovie>("CALL sp_todays_movie({0},{1})", lngid, Utilities.GetClientCoutry());
                cp.movielist.Title = ConfigurationManager.AppSettings["MovieListTitle" + lngid.ToString()]; ;
                cp.movielist.movielist = hpmovielist.ToList<ListMovie>();
                foreach (ListMovie lm in cp.movielist.movielist)
                {
                    string imagePath = string.Empty;
                    if (device == 0)
                    {
                        lm.img = lm.img.Replace("dvd/", "landscape/");
                    }
                }

                return cp;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCataloguePage_1 4 lngid, cn: " + lngid + ", " + cn, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCataloguePage_1.Exception 2: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCataloguePage_1 InnerException 4: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public List<ListCategory> getCategories(int lngid, int device, bool show_tvod,  bool show_svod, int cn)
        {
            string connstr = string.Empty;
            DVdPostMobileApIWS modelcontext;
            //
            try
            {
                connstr = ConfigurationManager.ConnectionStrings["mobileapiws"].ConnectionString;
                modelcontext = new DVdPostMobileApIWS(new MySqlConnection(connstr));

                modelcontext.ObjectTrackingEnabled = false;
                modelcontext.QueryCacheEnabled = true;

                IEnumerable<ListCategory> hpmovielist = modelcontext.ExecuteQuery<ListCategory>("CALL sp_catalogue_categories({0},{1})", lngid, device);

                List<ListCategory> list = hpmovielist.ToList<ListCategory>();

                //foreach (ListCategory ci in list)
                //{
                //    if (device == 0)
                //    {
                //        ci.img = ci.img.Replace("dvd/", "landscape/");
                //    }
                //}

                return list;
            }
            catch (Exception ex)
            {
                this._hosteventLog = new System.Diagnostics.EventLog();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this._hosteventLog)).EndInit();
                _hosteventLog.Source = "PlushServiceSource";
                _hosteventLog.Log = "PlushServiceLog";
                _hosteventLog.WriteEntry("getCategories lngid, device: " + lngid + ", " + device, System.Diagnostics.EventLogEntryType.Error);
                _hosteventLog.WriteEntry("getCategories.Exception : " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                if (ex.InnerException != null)
                {
                    _hosteventLog.WriteEntry("getCategories InnerException : " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                return null;
            }
        }

        public bool letMeKnow()
        {
            return (Utilities.GetClientCoutry() != "US" && Boolean.Parse(ConfigurationManager.AppSettings["ShowRegistration"]));
        }
    }
}
