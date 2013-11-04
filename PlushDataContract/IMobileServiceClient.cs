using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace PlushContract
{
    [ServiceContract(Namespace = "http://testSiteName")]
    public interface IMobileServiceClient : IMobileService
    {
        //[OperationContract(AsyncPattern = true, Action = "getBestRatedMovies", ReplyAction = "getBestRatedMovies")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getBestRatedMovies?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //IAsyncResult BegingetBestRatedMovies(int lngid,AsyncCallback callback, object asyncState);

        //List<BestRatedMovie> EndgetBestRatedMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getBestReviewers", ReplyAction = "getBestReviewers")]
        [WebInvoke(Method = "GET", UriTemplate = "/getBestReviewers?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetBestReviewers(int lngid, AsyncCallback callback, object asyncState);

        List<BestReviewer> EndgetBestReviewers(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getBestReviews", ReplyAction = "getBestReviews")]
        [WebInvoke(Method = "GET", UriTemplate = "/getBestReviews?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetBestReviews(int lngid, AsyncCallback callback, object asyncState);

        List<BestReview> EndgetBestReviews(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMostDiscussed", ReplyAction = "getMostDiscussed")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMostDiscussed?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMostDiscussed(int lngid, AsyncCallback callback, object asyncState);

        List<MostDiscussedMovies> EndgetMostDiscussed(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMovieDetails", ReplyAction = "getMovieDetails")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMovieDetails?lngid={lngid}&imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMovieDetails(int lngid, int imdb_id, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState);

        md EndgetMovieDetails(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getTopCategories", ReplyAction = "getTopCategories")]
        [WebInvoke(Method = "GET", UriTemplate = "/getTopCategories?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetTopCategories(int lngid, AsyncCallback callback, object asyncState);

        List<TopCategory> EndgetTopCategories(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getTopCategoryMovies", ReplyAction = "getTopCategoryMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getTopCategoryMovies?topid={topid}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetTopCategoryMovies(int topid, int lngid, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetTopCategoryMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getListMovies", ReplyAction = "getListMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getListMovies?search={search}&publicDown={publicDown}&publicUp={publicUp}&technologys={technologys}&countryID={countryID}&yearDown={yearDown}&yearUp={yearUp}&ratingDown={ratingDown}&ratingUp={ratingUp}&ourfavorite={ourfavorite}&audios={audios}&titles={titles}&lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetListMovies(string search, int publicDown, int publicUp,
                                                    string technologys, int countryID, int yearDown, int yearUp, int ratingDown, int ratingUp,
                                                    int ourfavorite, string audios, string titles, int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetListMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustomerDetails", ReplyAction = "getCustomerDetails")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustomerDetails?un={un}&pswd={pswd}&device={device}&dvcnmbr={dvcnmbr}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustomerDetails(string un, string pswd, int device, string dvcnmbr, AsyncCallback callback, object asyncState);

        CustomerDetails EndgetCustomerDetails(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getVodUrl", ReplyAction = "getVodUrl")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodUrl?vodid={vodid}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetVodUrl(int vodid, int cn, AsyncCallback callback, object asyncState);

        string EndgetVodUrl(IAsyncResult result);

        //[OperationContract(AsyncPattern = true, Action = "getCategoriesLeft", ReplyAction = "getCategoriesHP")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getCategoriesLeft?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //IAsyncResult BegingetCategoriesLeft(int lngid, AsyncCallback callback, object asyncState);

        //List<ListCategory> EndgetCategoriesLeft(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getSubCategories", ReplyAction = "getSubCategories")]
        [WebInvoke(Method = "GET", UriTemplate = "/getSubCategories?ctgid={ctgid}&lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetSubCategories(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn, AsyncCallback callback, object asyncState);

        List<ListCategory> EndgetSubCategories(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCategoryMovies", ReplyAction = "getCategoryMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCategoryMovies?ctgid={ctgid}&lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCategoryMovies(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetCategoryMovies(IAsyncResult result);

        //[OperationContract(AsyncPattern = true, Action = "getHomePage", ReplyAction = "getHomePage")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getHomePage?lngid={lngid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //IAsyncResult BegingetHomePage(int lngid, int cn, int device, AsyncCallback callback, object asyncState);

        //HomePage EndgetHomePage(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getHomePageCategoryMovies", ReplyAction = "getHomePageCategoryMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getHomePageCategoryMovies?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&refclient={refclient}&refclientid={refclientid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetHomePageCategoryMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetHomePageCategoryMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getVodTokenAndLngs", ReplyAction = "getVodTokenAndLngs")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodTokenAndLngs?imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetVodTokenAndLngs(int imdb_id, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState);

        VodTokenLengs EndgetVodTokenAndLngs(IAsyncResult result);

        //[OperationContract(AsyncPattern = true, Action = "getVodTokenAndLngsNew", ReplyAction = "getVodTokenAndLngsNew")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getVodTokenAndLngsNew?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //IAsyncResult BegingetVodTokenAndLngsNew(int imdb_id_serie, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState);

        //VodTokenLengs EndgetVodTokenAndLngsNew(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustRecommendations", ReplyAction = "getCustRecommendations")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustRecommendations?cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustRecommendations(int cn, int lngid, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetCustRecommendations(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getVodCatalogue", ReplyAction = "getVodCatalogue")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodCatalogue?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetVodCatalogue(int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);
        
        List<ListMovie> EndgetVodCatalogue(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustProdWishList", ReplyAction = "getCustProdWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustProdWishList?lngid={lngid}&adult={adult}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustProdWishList(int lngid, int cn, int device, AsyncCallback callback, object asyncState);

        List<MyListMovie> EndgetCustProdWishList(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "addProductToWishList", ReplyAction = "addProductToWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/addProductToWishList?pdid={pdid}&prty={prty}&wlsrcid={wlsrcid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginaddProductToWishList(int pdid, int prty, int wlsrcid, int cn, int device, AsyncCallback callback, object asyncState);

        int EndaddProductToWishList(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "addVodToWishList", ReplyAction = "addVodToWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/addVodToWishList?imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginaddVodToWishList(int imdb_id, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState);

        int EndaddVodToWishList(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMovieDVDBlueRay", ReplyAction = "getMovieDVDBlueRay")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMovieDVDBlueRay?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMovieDVDBlueRay(int imdb_id_serie, int disk_id, int season_id, AsyncCallback callback, object asyncState);

        List<DVDChannel> EndgetMovieDVDBlueRay(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMovieDVDBlueRay_1", ReplyAction = "getMovieDVDBlueRay_1")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMovieDVDBlueRay_1?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMovieDVDBlueRay_1(int imdb_id_serie, int disk_id, int season_id, int lngid, AsyncCallback callback, object asyncState);

        List<DVDChannel> EndgetMovieDVDBlueRay_1(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getProductsAtCustomer", ReplyAction = "getProductAtCustomer")]
        [WebInvoke(Method = "GET", UriTemplate = "/getProductsAtCustomer?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetProductsAtCustomer(int c, int lngid, int device, AsyncCallback callback, object asyncState);

        List<MyListMovie> EndgetProductsAtCustomer(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "addMovieSeen", ReplyAction = "addMovieSeen")]
        [WebInvoke(Method = "GET", UriTemplate = "/addMovieSeen?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginaddMovieSeen(int imdb_id_serie, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState);

        int EndaddMovieSeen(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "addMovieUninterested", ReplyAction = "addMovieUninterested")]
        [WebInvoke(Method = "GET", UriTemplate = "/addMovieUninterested?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginaddMovieUninterested(int imdb_id_serie, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState);

        int EndaddMovieUninterested(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "addMovieRate", ReplyAction = "addMovieRate")]
        [WebInvoke(Method = "GET", UriTemplate = "/addMovieRate?imdb_id_serie={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&rate={rate}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginaddMovieRate(int imdb_id, int disk_id, int season_id, int cn, int rate, AsyncCallback callback, object asyncState);

        int EndaddMovieRate(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "RemoveProdFromWishlist", ReplyAction = "RemoveProdFromWishlist")]
        [WebInvoke(Method = "GET", UriTemplate = "/RemoveProdFromWishlist?pdid={pdid}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginRemoveProdFromWishlist(int pdid, int cn, AsyncCallback callback, object asyncState);

        int EndRemoveProdFromWishlist(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "setVodOnly", ReplyAction = "setVodOnly")]
        [WebInvoke(Method = "GET", UriTemplate = "/setVodOnly?cn={cn}&ovod={ovod}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginsetVodOnly(int cn, int ovod, AsyncCallback callback, object asyncState);

        int EndsetVodOnly(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesNewTitles", ReplyAction = "getMoviesNewTitles")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesNewTitles?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesNewTitles(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesNewTitles(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesLastChance", ReplyAction = "getMoviesLastChance")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesLastChance?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesLastChance(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesLastChance(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesLastAdded", ReplyAction = "getMoviesLastAdded")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesLastAdded?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesLastAdded(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesLastAdded(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMostPopularMovies", ReplyAction = "getMostPopularMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMostPopularMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMostPopularMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMostPopularMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getBestRatedMovies", ReplyAction = "getBestRatedMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getBestRatedMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetBestRatedMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetBestRatedMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getOurFavoritesMovies", ReplyAction = "getOurFavoritesMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getOurFavoritesMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetOurFavoritesMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetOurFavoritesMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getAllCatalogueMovies", ReplyAction = "getAllCatalogueMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getAllCatalogueMovies?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetAllCatalogueMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetAllCatalogueMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesSoon_1", ReplyAction = "getMoviesSoon_1")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesSoon_1?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&vodOnly={vodOnly}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesSoon_1(int lngid, int pageNumber, int pageSize, int vodOnly, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesSoon_1(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesBestReview", ReplyAction = "getMoviesBestReview")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesBestReview?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesBestReview(int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesBestReview(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesSoon", ReplyAction = "getMoviesSoon")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesSoon?lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesSoon(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesSoon(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getMoviesInCinema", ReplyAction = "getMoviesInCinema")]
        [WebInvoke(Method = "GET", UriTemplate = "/getMoviesInCinema?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetMoviesInCinema(int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetMoviesInCinema(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getVodAtCustomer", ReplyAction = "getVodAtCustomer")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodAtCustomer?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetVodAtCustomer(int cn, int lngid, int device, AsyncCallback callback, object asyncState);

        List<VodAtCustomer> EndgetVodAtCustomer(IAsyncResult result);

        //[OperationContract(AsyncPattern = true, Action = "getCustVodWishList", ReplyAction = "getCustVodWishList")]
        //[WebInvoke(Method = "GET", UriTemplate = "/getCustVodWishList?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //IAsyncResult BegingetCustVodWishList(int cn, int lngid, int device, AsyncCallback callback, object asyncState);

        //List<CustVodWishList> EndgetCustVodWishList(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustVodWishList", ReplyAction = "getCustVodWishList")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustVodWishList?cn={cn}&lngid={lngid}&show_tvod={show_tvod}&show_svod={show_svod}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustVodWishList(int cn, int lngid, bool show_tvod, bool show_svod, int device, AsyncCallback callback, object asyncState);

        List<CustVodWishList> EndgetCustVodWishList(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustVodSoon", ReplyAction = "getCustVodSoon")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustVodSoon?cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustVodSoon(int cn, int lngid, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetCustVodSoon(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCodeListCountries", ReplyAction = "getCodeListCountries")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCodeListCountries", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCodeListCountries(AsyncCallback callback, object asyncState);

        List<CodeListCountries> EndgetCodeListCountries(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCodeListAudios", ReplyAction = "getCodeListAudios")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCodeListAudios?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCodeListAudios(int lngid, AsyncCallback callback, object asyncState);

        List<CodeListLanguages> EndgetCodeListAudios(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCodeListTitles", ReplyAction = "getCodeListTitles")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCodeListTitles?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCodeListTitles(int lngid, AsyncCallback callback, object asyncState);

        List<CodeListTitle> EndgetCodeListTitles(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustProdWishListSoon", ReplyAction = "getCustProdWishListSoon")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustProdWishListSoon?cn={cn}&lngid={lngid}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustProdWishListSoon(int cn, int lngid, int device, AsyncCallback callback, object asyncState);

        List<MyListMovie> EndgetCustProdWishListSoon(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustProdWishListUnavlb", ReplyAction = "getCustProdWishListUnavlb")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustProdWishListUnavlb?cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustProdWishListUnavlb(int cn, int lngid, AsyncCallback callback, object asyncState);

        List<MyListMovie> EndgetCustProdWishListUnavlb(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "addProductAtCustomerComplain", ReplyAction = "addProductAtCustomerComplain")]
        [WebInvoke(Method = "GET", UriTemplate = "/addProductAtCustomerComplain?cn={cn}&cmpln={cmpln}&pdid={pdid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginaddProductAtCustomerComplain(int cn, string cmpln, int pdid, AsyncCallback callback, object asyncState);

        int EndaddProductAtCustomerComplain(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "setProductWishlistPriority", ReplyAction = "setProductWishlistPriority")]
        [WebInvoke(Method = "GET", UriTemplate = "/setProductWishlistPriority?pdid={pdid}&cn={cn}&prty={prty}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginsetProductWishlistPriority(int pdid, int cn, int prty, AsyncCallback callback, object asyncState);

        int EndsetProductWishlistPriority(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "RemoveVodFromWishlist", ReplyAction = "RemoveVodFromWishlist")]
        [WebInvoke(Method = "GET", UriTemplate = "/RemoveVodFromWishlist?imdb_id={imdb_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginRemoveVodFromWishlist(int imdb_id, int cn, AsyncCallback callback, object asyncState);

        int EndRemoveVodFromWishlist(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCatalogCommunity", ReplyAction = "getCatalogCommunity")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCatalogCommunity?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCatalogCommunity(int lngid, AsyncCallback callback, object asyncState);

        List<catalogcommunity> EndgetCatalogCommunity(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCatalogCommunityMovies", ReplyAction = "getCatalogCommunityMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCatalogCommunityMovies?lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}&refclient={refclient}&refclientid={refclientid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCatalogCommunityMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetCatalogCommunityMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustomerCreditForVod", ReplyAction = "getCustomerCreditForVod")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustomerCreditForVod?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustomerCreditForVod(int imdb_id_serie, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState);

        int EndgetCustomerCreditForVod(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getVodTokenAndLngsTest", ReplyAction = "getVodTokenAndLngsTest")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVodTokenAndLngsTest?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetVodTokenAndLngsTest(int imdb_id_serie, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState);

        VodTokenLengs EndgetVodTokenAndLngsTest(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "setErrorLog", ReplyAction = "setErrorLog")]
        [WebInvoke(Method = "GET", UriTemplate = "/setErrorLog?cn={cn}&call_method={call_method}&call_parameters={call_parameters}&error_message={error_message}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginsetErrorLog(int cn, string call_method, string call_parameters, string error_message, int device, AsyncCallback callback, object asyncState);

        int EndsetErrorLog(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "IsVodEnabled", ReplyAction = "IsVodEnabled")]
        [WebInvoke(Method = "GET", UriTemplate = "/IsVodEnabled?imdb_id_serie={imdb_id_serie}&disk_id={disk_id}&season_id={season_id}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginIsVodEnabled(int imdb_id_serie, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState);

        VodEnabled EndIsVodEnabled(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "SetRegistration", ReplyAction = "SetRegistration")]
        [WebInvoke(Method = "GET", UriTemplate = "/SetRegistration?email={email}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginSetRegistration(string email, int lngid, AsyncCallback callback, object asyncState);

        RegistrationAllowed EndSetRegistration(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCustWatched", ReplyAction = "getCustWatched")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCustWatched?cn={cn}&lngid={lngid}&pageNumber={pageNumber}&pageSize={pageSize}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCustWatched(int cn, int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState);

        List<ListMovieWatched> EndgetCustWatched(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getTodaysMovies", ReplyAction = "getTodaysMovies")]
        [WebInvoke(Method = "GET", UriTemplate = "/getTodaysMovies?lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetTodaysMovies(int lngid, AsyncCallback callback, object asyncState);

        List<ListMovie> EndgetTodaysMovies(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getVODLanguages", ReplyAction = "getVODLanguages")]
        [WebInvoke(Method = "GET", UriTemplate = "/getVODLanguages?imdb_id={imdb_id}&disk_id={disk_id}&season_id={season_id}&cn={cn}&lngid={lngid}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetVODLanguages(int imdb_id, int disk_id, int season_id, int cn, int lngid, AsyncCallback callback, object asyncState);

        string EndgetVODLanguages(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getHomePage", ReplyAction = "getHomePage")]
        [WebInvoke(Method = "GET", UriTemplate = "/getHomePage?lngid={lngid}&cn={cn}&device={device}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetHomePage(int lngid, int cn, int device, AsyncCallback callback, object asyncState);

        hp EndgetHomePage(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCategories", ReplyAction = "getCategories")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCategories?lngid={lngid}&device={device}&show_tvod={show_tvod}&show_svod={show_svod}&cn={cn}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCategories(int lngid, int device, bool show_tvod, bool show_svod, int cn, AsyncCallback callback, object asyncState);

        List<ListCategory> EndgetCategories(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "getCataloguePage_1", ReplyAction = "getCataloguePage_1")]
        [WebInvoke(Method = "GET", UriTemplate = "/getCataloguePage_1?lngid={lngid}&cn={cn}&device={device}&vodOnly={vodOnly}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BegingetCataloguePage_1(int lngid, int cn, int device, int vodOnly, AsyncCallback callback, object asyncState);

        CataloguePage_1 EndgetCataloguePage_1(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "letMeKnow", ReplyAction = "letMeKnow")]
        [WebInvoke(Method = "GET", UriTemplate = "/letMeKnow", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IAsyncResult BeginletMeKnow( AsyncCallback callback, object asyncState);

        bool EndletMeKnow(IAsyncResult result);
    }
}
