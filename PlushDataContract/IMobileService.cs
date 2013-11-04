using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace PlushContract
{
    [ServiceContract(Namespace = "http://testSiteName")]
    public interface IMobileService
    {       
        //[OperationContract(Action = "getBestRatedMovies", ReplyAction = "getBestRatedMovies")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getBestRatedMovies?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //List<BestRatedMovie> getBestRatedMovies(int lngid);

        [OperationContract(Action = "getBestReviewers", ReplyAction = "getBestReviewers")]
        [WebInvoke(Method = "GET", UriTemplate = "/getBestReviewers?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<BestReviewer> getBestReviewers(int lngid);

        [OperationContract(Action = "getBestReviews", ReplyAction = "getBestReviews")]
        [WebInvoke(Method = "GET", UriTemplate = "/getBestReviews?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<BestReview> getBestReviews(int lngid);

        [OperationContract(Action = "getMostDiscussed", ReplyAction = "getMostDiscussed")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMostDiscussed?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<MostDiscussedMovies> getMostDiscussed(int lngid);

        [OperationContract(Action = "getMovieDetails", ReplyAction = "getMovieDetails")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMovieDetails?lngid={lngid}&imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        md getMovieDetails(int lngid, int imdb_id, int disk_id, int season_id, int cn);

        [OperationContract(Action = "getTopCategories", ReplyAction = "getTopCategories")]
        [WebInvoke(Method = "GET", UriTemplate = "/getTopCategories?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<TopCategory> getTopCategories(int lngid);

        [OperationContract(Action = "getTopCategoryMovies", ReplyAction = "getTopCategoryMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getTopCategoryMovies?topid={topid}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getTopCategoryMovies(int topid, int lngid);

        [OperationContract(Action = "getListMovies", ReplyAction = "getListMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getListMovies?search={search}&publicDown={publicDown}&publicUp={publicUp}&technologys={technologys}&countryID={countryID}&yearDown={yearDown}&yearUp={yearUp}&ratingDown={ratingDown}&ratingUp={ratingUp}&ourfavorite={ourfavorite}&audios={audios}&titles={titles}&lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getListMovies(string search, int publicDown, int publicUp,
                                                    string technologys, int countryID, int yearDown, int yearUp, int ratingDown, int ratingUp,
                                                    int ourfavorite, string audios, string titles, int lngid, int pageNumber, int pageSize);

        [OperationContract(Action = "getCustomerDetails", ReplyAction = "getCustomerDetails")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustomerDetails?un={un}&pswd={pswd}&device={device}&dvcnmbr={dvcnmbr}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        CustomerDetails getCustomerDetails(string un, string pswd, int device, string dvcnmbr);

        [OperationContract(Action = "getVodUrl", ReplyAction = "getVodUrl")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodUrl?vodid={vodid}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string getVodUrl(int vodid, int cn);

        //[OperationContract(Action = "getCategoriesLeft", ReplyAction = "getCategoriesLeft")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getCategoriesLeft?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //List<ListCategory> getCategoriesLeft(int lngid);

        [OperationContract(Action = "getSubCategories", ReplyAction = "getSubCategories")]
        [WebInvoke(Method = "GET", UriTemplate = "/getSubCategories?ctgid={ctgid}&lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListCategory> getSubCategories(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn);

        [OperationContract(Action = "getCategoryMovies", ReplyAction = "getCategoryMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCategoryMovies?ctgid={ctgid}&lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getCategoryMovies(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        //[OperationContract(Action = "getHomePage", ReplyAction = "getHomePage")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getHomePage?lngid={lngid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //HomePage getHomePage(int lngid, int cn, int device);

        [OperationContract(Action = "getHomePageCategoryMovies?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&refclient={refclient}&refclientid={refclientid}", ReplyAction = "getHomePageCategoryMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getHomePageCategoryMovies?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&refclient={refclient}&refclientid={refclientid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getHomePageCategoryMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid);

        [OperationContract(Action = "getVodTokenAndLngs", ReplyAction = "getVodTokenAndLngs")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodTokenAndLngs?imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        VodTokenLengs getVodTokenAndLngs(int imdb_id, int disk_id, int season_id, int cn, int device);

        //[OperationContract(Action = "getVodTokenAndLngsNew", ReplyAction = "getVodTokenAndLngsNew")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getVodTokenAndLngsNew?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //VodTokenLengs getVodTokenAndLngsNew(int imdb_id_serie, int disk_id, int season_id, int cn, int device);

        [OperationContract(Action = "getCustRecommendations", ReplyAction = "getCustReccomendations")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustRecommendations?cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getCustRecommendations(int cn, int lngid);

        [OperationContract(Action = "getVodCatalogue", ReplyAction = "getVodCatalogue")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodCatalogue?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getVodCatalogue(int lngid, int pageNumber, int pageSize);

        [OperationContract(Action = "getCustProdWishList", ReplyAction = "getCustProdWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustProdWishList?lngid={lngid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<MyListMovie> getCustProdWishList(int lngid, int cn, int device);

        [OperationContract(Action = "addProductToWishList", ReplyAction = "addProductToWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/addProductToWishList?pdid={pdid}&prty={prty}&wlsrcid={wlsrcid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int addProductToWishList(int pdid, int prty, int wlsrcid, int cn, int device);

        [OperationContract(Action = "addVodToWishList", ReplyAction = "addVodToWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/addVodToWishList?imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int addVodToWishList(int imdb_id, int disk_id, int season_id, int cn, int device);

        [OperationContract(Action = "getMovieDVDBlueRay_1", ReplyAction = "getMovieDVDBlueRay_1")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMovieDVDBlueRay_1?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<DVDChannel> getMovieDVDBlueRay_1(int imdb_id_serie, int disk_id, int season_id, int lngid);

        [OperationContract(Action = "getMovieDVDBlueRay", ReplyAction = "getMovieDVDBlueRay")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMovieDVDBlueRay?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<DVDChannel> getMovieDVDBlueRay(int imdb_id_serie, int disk_id, int season_id);

        [OperationContract(Action = "getProductsAtCustomer", ReplyAction = "getProductsAtCustomer")]
        [WebInvoke(Method = "GET", UriTemplate ="/getProductsAtCustomer?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<MyListMovie> getProductsAtCustomer(int cn, int lngid, int device);

        [OperationContract(Action = "addMovieSeen", ReplyAction = "addMovieSeen")]
        [WebInvoke(Method = "GET", UriTemplate = "/addMovieSeen?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int addMovieSeen(int imdb_id_serie, int disk_id, int season_id, int cn);

        [OperationContract(Action = "addMovieUninterested", ReplyAction = "addMovieUninterested")]
        [WebInvoke(Method = "GET", UriTemplate = "/addMovieUninterested?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int addMovieUninterested(int imdb_id_serie, int disk_id, int season_id, int cn);

        [OperationContract(Action = "addMovieRate", ReplyAction = "addMovieRate")]
        [WebInvoke(Method = "GET", UriTemplate = "/addMovieRate?imdb_id_serie={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&rate={rate}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int addMovieRate(int imdb_id, int disk_id, int season_id, int cn, int rate);

        [OperationContract(Action = "RemoveProdFromWishlist", ReplyAction = "RemoveProdFromWishlist")]
        [WebInvoke(Method = "GET", UriTemplate = "/RemoveProdFromWishlist?pdid={pdid}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int RemoveProdFromWishlist(int pdid,int cn);

        [OperationContract(Action = "setVodOnly", ReplyAction = "setVodOnly")]
        [WebInvoke(Method = "GET", UriTemplate = "/setVodOnly?cn={cn}&ovod={ovod}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int setVodOnly(int cn, int ovod);

        [OperationContract(Action = "getMoviesNewTitles", ReplyAction = "getMoviesNewTitles")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesNewTitles?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesNewTitles(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getMoviesLastChance", ReplyAction = "getMoviesLastChance")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesLastChance?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesLastChance(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);
        
        [OperationContract(Action = "getMoviesLastAdded", ReplyAction = "getMoviesLastAdded")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesLastAdded?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesLastAdded(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getMostPopularMovies", ReplyAction = "getMostPopularMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMostPopularMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMostPopularMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getBestRatedMovies", ReplyAction = "getBestRatedMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getBestRatedMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getBestRatedMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getOurFavoritesMovies", ReplyAction = "getOurFavoritesMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getOurFavoritesMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getOurFavoritesMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getAllCatalogueMovies", ReplyAction = "getAllCatalogueMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getAllCatalogueMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getAllCatalogueMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getMoviesSoon_1", ReplyAction = "getMoviesSoon_1")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesSoon_1?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&vodOnly={vodOnly}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesSoon_1(int lngid, int pageNumber, int pageSize, int vodOnly);

        [OperationContract(Action = "getMoviesBestReview", ReplyAction = "getMoviesBestReview")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesBestReview?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesBestReview(int lngid, int pageNumber, int pageSize);

        [OperationContract(Action = "getMoviesSoon", ReplyAction = "getMoviesSoon")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesSoon?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesSoon(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize);

        [OperationContract(Action = "getMoviesInCinema", ReplyAction = "getMoviesInCinema")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesInCinema?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getMoviesInCinema(int lngid, int pageNumber, int pageSize);

        [OperationContract(Action = "getVodAtCustomer", ReplyAction = "getVodAtCustomer")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodAtCustomer?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<VodAtCustomer> getVodAtCustomer(int cn, int lngid, int device);

        //[OperationContract(Action = "getCustVodWishList", ReplyAction = "getCustVodWishList")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getCustVodWishList?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //List<CustVodWishList> getCustVodWishList(int cn, int lngid, int device);

        [OperationContract(Action = "getCustVodWishList", ReplyAction = "getCustVodWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustVodWishList?cn={cn}&lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<CustVodWishList> getCustVodWishList(int cn, int lngid, bool show_tvod, bool show_svod, int device);

        [OperationContract(Action = "getCustVodSoon", ReplyAction = "getCustVodSoon")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustVodSoon?cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getCustVodSoon(int cn, int lngid);

        [OperationContract(Action = "getCodeListCountries", ReplyAction = "getCodeListCountries")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCodeListCountries", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<CodeListCountries> getCodeListCountries();

        [OperationContract(Action = "getCodeListAudios", ReplyAction = "getCodeListAudios")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCodeListAudios?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<CodeListLanguages> getCodeListAudios(int lngid);

        [OperationContract(Action = "getCodeListTitles", ReplyAction = "getCodeListTitles")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCodeListTitles?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<CodeListTitle> getCodeListTitles(int lngid);

        [OperationContract(Action = "getCustProdWishListSoon", ReplyAction = "getCustProdWishListSoon")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustProdWishListSoon?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<MyListMovie> getCustProdWishListSoon(int cn, int lngid, int device);

        [OperationContract(Action = "getCustProdWishListUnavlb", ReplyAction = "getCustProdWishListUnavlb")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustProdWishListUnavlb?cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<MyListMovie> getCustProdWishListUnavlb(int cn, int lngid);

        [OperationContract(Action = "addProductAtCustomerComplain", ReplyAction = "addProductAtCustomerComplain")]
        [WebInvoke(Method = "GET", UriTemplate = "/addProductAtCustomerComplain?cn={cn}&cmpln={cmpln}&pdid={pdid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int addProductAtCustomerComplain(int cn, string cmpln, int pdid);

        [OperationContract(Action = "setProductWishlistPriority", ReplyAction = "setProductWishlistPriority")]
        [WebInvoke(Method = "GET", UriTemplate = "/setProductWishlistPriority?pdid={pdid}&cn={cn}&prty={prty}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int setProductWishlistPriority(int pdid, int cn, int prty);

        [OperationContract(Action = "RemoveVodFromWishlist", ReplyAction = "RemoveVodFromWishlist")]
        [WebInvoke(Method = "GET", UriTemplate = "/RemoveVodFromWishlist?imdb_id={imdb_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int RemoveVodFromWishlist(int imdb_id, int cn);


        [OperationContract(Action = "getCatalogCommunity", ReplyAction = "getCatalogCommunity")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCatalogCommunity?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<catalogcommunity> getCatalogCommunity(int lngid);

        [OperationContract(Action = "getCatalogCommunityMovies", ReplyAction = "getCatalogCommunityMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCatalogCommunityMovies?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&refclient={refclient}&refclientid={refclientid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getCatalogCommunityMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid);

        [OperationContract(Action = "getCustomerCreditForVod", ReplyAction = "getCustomerCreditForVod")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustomerCreditForVod?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int getCustomerCreditForVod(int imdb_id_serie, int disk_id, int season_id, int cn);

        [OperationContract(Action = "getVodTokenAndLngsTest", ReplyAction = "getVodTokenAndLngsTest")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodTokenAndLngsTest?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        VodTokenLengs getVodTokenAndLngsTest(int imdb_id_serie, int disk_id, int season_id, int cn, int device);

        [OperationContract(Action = "setErrorLog", ReplyAction = "setErrorLog")]
        [WebInvoke(Method = "GET", UriTemplate = "/setErrorLog?cn={cn}&call_method={call_method}&call_parameters={call_parameters}&error_message={error_message}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int setErrorLog(int cn, string call_method, string call_parameters, string error_message, int device);

        [OperationContract(Action = "IsVodEnabled", ReplyAction = "IsVodEnabled")]
        [WebInvoke(Method = "GET", UriTemplate = "/IsVodEnabled?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        VodEnabled IsVodEnabled(int imdb_id_serie, int disk_id, int season_id, int cn, int device);

        [OperationContract(Action = "SetRegistration", ReplyAction = "SetRegistration")]
        [WebInvoke(Method = "GET", UriTemplate = "/SetRegistration?email={email}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        RegistrationAllowed SetRegistration(string email, int lngid);

        [OperationContract(Action = "getCustWatched", ReplyAction = "getCustWatched")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustWatched?cn={cn}&lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovieWatched> getCustWatched(int cn, int lngid, int pageNumber, int pageSize);

        [OperationContract(Action = "getTodaysMovies", ReplyAction = "getTodaysMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getTodaysMovies?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListMovie> getTodaysMovies( int lngid);

        [OperationContract(Action = "getVODLanguages", ReplyAction = "getVODLanguages")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVODLanguages?imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string getVODLanguages(int imdb_id, int disk_id, int season_id, int cn, int lngid);

        [OperationContract(Action = "getHomePage", ReplyAction = "getHomePage")]
        [WebInvoke(Method = "GET", UriTemplate = "/getHomePage?lngid={lngid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        hp getHomePage(int lngid, int cn, int device);

        [OperationContract(Action = "getCategories", ReplyAction = "getCategories")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCategories?lngid={lngid}&device={device}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<ListCategory> getCategories(int lngid, int device, bool show_tvod, bool show_svod, int cn);


        [OperationContract(Action = "getCataloguePage_1", ReplyAction = "getCataloguePage_1")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCataloguePage_1?lngid={lngid}&cn={cn}&device={device}&vodOnly={vodonly}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        CataloguePage_1 getCataloguePage_1(int lngid, int cn, int device, int vodOnly);

        [OperationContract(Action = "getletMeKnow", ReplyAction = "getletMeKnow")]
        [WebInvoke(Method = "GET", UriTemplate = "/letMeKnow", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool letMeKnow();
    }
}
