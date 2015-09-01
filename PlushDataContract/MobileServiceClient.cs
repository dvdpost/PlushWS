using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace PlushContract
{
    public class MobileServiceClient : ClientBase<IMobileServiceClient>, IMobileServiceClient
    {
        public MobileServiceClient(Binding binding, EndpointAddress endpointAddress) :
            base(binding, endpointAddress)
        { }       

        //public IAsyncResult BegingetBestRatedMovies(int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetBestRatedMovies(lngid, callback, asyncState);
        //}

        //public List<BestRatedMovie> EndgetBestRatedMovies(IAsyncResult result)
        //{
        //    return this.Channel.EndgetBestRatedMovies(result);
        //}

        //public List<BestRatedMovie> getBestRatedMovies(int lngid)
        //{
        //    return this.Channel.getBestRatedMovies(lngid);
        //}

        ///////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetBestReviewers(int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetBestReviewers(lngid, callback, asyncState);
        //}

        //public List<BestReviewer> EndgetBestReviewers(IAsyncResult result)
        //{
        //    return this.Channel.EndgetBestReviewers(result);
        //}

        //public List<BestReviewer> getBestReviewers(int lngid)
        //{
        //    return this.Channel.getBestReviewers(lngid);
        //}

        ///////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetBestReviews(int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetBestReviews(lngid, callback, asyncState);
        //}

        //public List<BestReview> EndgetBestReviews(IAsyncResult result)
        //{
        //    return this.Channel.EndgetBestReviews(result);
        //}

        //public List<BestReview> getBestReviews(int lngid)
        //{
        //    return this.Channel.getBestReviews(lngid);
        //}

        ///////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetMostDiscussed(int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetMostDiscussed(lngid, callback, asyncState);
        //}

        //public List<MostDiscussedMovies> EndgetMostDiscussed(IAsyncResult result)
        //{
        //    return this.Channel.EndgetMostDiscussed(result);
        //}

        //public List<MostDiscussedMovies> getMostDiscussed(int lngid)
        //{
        //    return this.Channel.getMostDiscussed(lngid);
        //}        

        ///////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMovieDetails(int lngid, int imdb_id, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMovieDetails(lngid, imdb_id, disk_id, season_id, cn, device, callback, asyncState);
        }

        public md EndgetMovieDetails(IAsyncResult result)
        {
            return this.Channel.EndgetMovieDetails(result);
        }

        public md getMovieDetails(int lngid, int imdb_id, int disk_id, int season_id, int cn, int device)
        {
            return this.Channel.getMovieDetails(lngid, imdb_id, disk_id, season_id, cn, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetTopCategories(int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetTopCategories(lngid, callback, asyncState);
        }

        public List<TopCategory> EndgetTopCategories(IAsyncResult result)
        {
            return this.Channel.EndgetTopCategories(result);
        }

        public List<TopCategory> getTopCategories(int lngid)
        {
            return this.Channel.getTopCategories(lngid);
        }
        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetTopCategoryMovies(int topid, int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetTopCategoryMovies(topid, lngid, callback, asyncState);
        }

        public List<ListMovie> EndgetTopCategoryMovies(IAsyncResult result)
        {
            return this.Channel.EndgetTopCategoryMovies(result);
        }

        public List<ListMovie> getTopCategoryMovies(int topid, int lngid)
        {
            return this.Channel.getTopCategoryMovies(topid, lngid);
        }

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetListMovies(string search, int publicDown, int publicUp,
        //                                            string technologys, int countryID, int yearDown, int yearUp, int ratingDown, int ratingUp,
        //                                            int ourfavorite, string audios, string titles, int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetListMovies(search, publicDown, publicUp,
        //                                             technologys, countryID, yearDown, yearUp, ratingDown, ratingUp,
        //                                             ourfavorite, audios, titles, lngid, pageNumber, pageSize, callback, asyncState);
        //}

        //public List<ListMovie> EndgetListMovies(IAsyncResult result)
        //{
        //    return this.Channel.EndgetListMovies(result);
        //}

        //public List<ListMovie> getListMovies(string search, int publicDown, int publicUp,
        //                                            string technologys, int countryID, int yearDown, int yearUp, int ratingDown, int ratingUp,
        //                                            int ourfavorite, string audios, string titles, int lngid, int pageNumber, int pageSize)
        //{
        //    return this.Channel.getListMovies(search, publicDown, publicUp,
        //                                             technologys, countryID, yearDown, yearUp, ratingDown, ratingUp,
        //                                             ourfavorite, audios, titles, lngid, pageNumber, pageSize);
        //}

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustomerDetails(string un, string pswd, int device, string dvcnmbr, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustomerDetails(un, pswd, device, dvcnmbr, callback, asyncState);
        }

        public CustomerDetails EndgetCustomerDetails(IAsyncResult result)
        {
            return this.Channel.EndgetCustomerDetails(result);
        }

        public CustomerDetails getCustomerDetails(string un, string pswd, int device, string dvcnmbr)
        {
            return this.Channel.getCustomerDetails(un, pswd, device, dvcnmbr);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetVodUrl(int vodid, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetVodUrl(vodid, cn, device, callback, asyncState);
        }

        public string EndgetVodUrl(IAsyncResult result)
        {
            return this.Channel.EndgetVodUrl(result);
        }

        public string getVodUrl(int vodid, int cn, int device)
        {
            return this.Channel.getVodUrl(vodid, cn, device);
        }

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetCategoriesLeft(int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetCategoriesLeft(lngid, callback, asyncState);
        //}

        //public List<ListCategory > EndgetCategoriesLeft(IAsyncResult result)
        //{
        //    return this.Channel.EndgetCategoriesLeft(result);
        //}

        //public List<ListCategory> getCategoriesLeft(int lngid)
        //{
        //    return this.Channel.getCategoriesLeft(lngid);
        //}

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetSubCategories(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetSubCategories(ctgid, lngid, show_tvod, show_svod, cn, callback, asyncState);
        }

        public List<ListCategory> EndgetSubCategories(IAsyncResult result)
        {
            return this.Channel.EndgetSubCategories(result);
        }

        public List<ListCategory> getSubCategories(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn)
        {
            return this.Channel.getSubCategories(ctgid, lngid, show_tvod, show_svod, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCategoryMovies(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCategoryMovies(ctgid, lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetCategoryMovies(IAsyncResult result)
        {
            return this.Channel.EndgetCategoryMovies(result);
        }

        public List<ListMovie> getCategoryMovies(int ctgid, int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getCategoryMovies(ctgid, lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetHomePage(int lngid, int cn, int device, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetHomePage(lngid, cn, device, callback, asyncState);
        //}

        //public HomePage EndgetHomePage(IAsyncResult result)
        //{
        //    return this.Channel.EndgetHomePage(result);
        //}

        //public HomePage getHomePage(int lngid, int cn, int device )
        //{
        //    return this.Channel.getHomePage(lngid, cn, device);
        //}

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetHomePageCategoryMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetHomePageCategoryMovies( lngid, pageNumber, pageSize, refclient, refclientid, callback, asyncState);
        }

        public List<ListMovie> EndgetHomePageCategoryMovies(IAsyncResult result)
        {
            return this.Channel.EndgetHomePageCategoryMovies(result);
        }

        public List<ListMovie> getHomePageCategoryMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid)
        {
            return this.Channel.getHomePageCategoryMovies(lngid, pageNumber, pageSize, refclient, refclientid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetVodTokenAndLngs(int imdb_id, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetVodTokenAndLngs(imdb_id, disk_id, season_id, cn, device, callback, asyncState);
        }

        public VodTokenLengs EndgetVodTokenAndLngs(IAsyncResult result)
        {
            return this.Channel.EndgetVodTokenAndLngs(result);
        }

        public VodTokenLengs getVodTokenAndLngs(int imdb_id, int disk_id, int season_id, int cn, int device)
        {
            return this.Channel.getVodTokenAndLngs(imdb_id, disk_id, season_id, cn, device);
        }

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetVodTokenAndLngsNew(int imdb_id_serie, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetVodTokenAndLngsNew(imdb_id_serie, disk_id, season_id, cn, device, callback, asyncState);
        //}

        //public VodTokenLengs EndgetVodTokenAndLngsNew(IAsyncResult result)
        //{
        //    return this.Channel.EndgetVodTokenAndLngsNew(result);
        //}

        //public VodTokenLengs getVodTokenAndLngsNew(int imdb_id_serie, int disk_id, int season_id, int cn, int device)
        //{
        //    return this.Channel.getVodTokenAndLngsNew(imdb_id_serie, disk_id, season_id, cn, device);
        //}

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetCustRecommendations(int cn, int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetCustRecommendations(cn, lngid, callback, asyncState);
        //}

        //public List<ListMovie> EndgetCustRecommendations(IAsyncResult result)
        //{
        //    return this.Channel.EndgetCustRecommendations(result);
        //}

        //public List<ListMovie> getCustRecommendations(int cn, int lngid)
        //{
        //    return this.Channel.getCustRecommendations(cn, lngid);
        //}

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetVodCatalogue(int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetVodCatalogue(lngid, pageNumber, pageSize, callback, asyncState);
        }

        public List<ListMovie> EndgetVodCatalogue(IAsyncResult result)
        {
            return this.Channel.EndgetVodCatalogue(result);
        }

        public List<ListMovie> getVodCatalogue( int lngid, int pageNumber, int pageSize)
        {
            return this.Channel.getVodCatalogue(lngid, pageNumber, pageSize);
        }

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetCustProdWishList(int lngid, int cn, int device, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetCustProdWishList(lngid, cn, device, callback, asyncState);
        //}

        //public List<MyListMovie> EndgetCustProdWishList(IAsyncResult result)
        //{
        //    return this.Channel.EndgetCustProdWishList(result);
        //}

        //public List<MyListMovie> getCustProdWishList(int lngid, int cn, int device)
        //{
        //    return this.Channel.getCustProdWishList(lngid, cn, device);
        //}

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BeginaddProductToWishList(int pdid, int prty, int wlsrcid, int cn, int device, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BeginaddProductToWishList(pdid, prty, wlsrcid, cn, device, callback, asyncState);
        //}

        //public int EndaddProductToWishList(IAsyncResult result)
        //{
        //    return this.Channel.EndaddProductToWishList(result);
        //}

        //public int addProductToWishList(int pdid, int prty, int wlsrcid, int cn, int device)
        //{
        //    return this.Channel.addProductToWishList(pdid, prty, wlsrcid, cn, device);
        //}

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginaddVodToWishList(int imdb_id, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginaddVodToWishList(imdb_id, disk_id, season_id, cn, device, callback, asyncState);
        }

        public int EndaddVodToWishList(IAsyncResult result)
        {
            return this.Channel.EndaddVodToWishList(result);
        }

        public int addVodToWishList(int imdb_id, int disk_id, int season_id, int cn, int device)
        {
            return this.Channel.addVodToWishList(imdb_id, disk_id, season_id, cn, device);
        }

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetMovieDVDBlueRay(int imdb_id_serie, int disk_id, int season_id, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetMovieDVDBlueRay( imdb_id_serie,  disk_id,  season_id, callback, asyncState);
        //}

        //public List<DVDChannel> EndgetMovieDVDBlueRay(IAsyncResult result)
        //{
        //    return this.Channel.EndgetMovieDVDBlueRay(result);
        //}

        //public List<DVDChannel> getMovieDVDBlueRay(int imdb_id_serie, int disk_id, int season_id)
        //{
        //    return this.Channel.getMovieDVDBlueRay( imdb_id_serie,  disk_id,  season_id);
        //}

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetMovieDVDBlueRay_1(int imdb_id_serie, int disk_id, int season_id, int lngid, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetMovieDVDBlueRay_1(imdb_id_serie, disk_id, season_id, lngid, callback, asyncState);
        //}

        //public List<DVDChannel> EndgetMovieDVDBlueRay_1(IAsyncResult result)
        //{
        //    return this.Channel.EndgetMovieDVDBlueRay_1(result);
        //}

        //public List<DVDChannel> getMovieDVDBlueRay_1(int imdb_id_serie, int disk_id, int season_id, int lngid)
        //{
        //    return this.Channel.getMovieDVDBlueRay_1(imdb_id_serie, disk_id, season_id, lngid);
        //}

        ////////////////////////////////////////////////////////////

        //public IAsyncResult BegingetProductsAtCustomer(int cn, int lngid, int device, AsyncCallback callback, object asyncState)
        //{
        //    return this.Channel.BegingetProductsAtCustomer( cn,  lngid, device, callback, asyncState);
        //}

        //public List<MyListMovie> EndgetProductsAtCustomer(IAsyncResult result)
        //{
        //    return this.Channel.EndgetProductsAtCustomer(result);
        //}

        //public List<MyListMovie> getProductsAtCustomer(int cn, int lngid, int device)
        //{
        //    return this.Channel.getProductsAtCustomer(cn, lngid, device);
        //}

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginaddMovieSeen(int imdb_id_serie, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginaddMovieSeen(imdb_id_serie, disk_id, season_id, cn, callback, asyncState);
        }

        public int EndaddMovieSeen(IAsyncResult result)
        {
            return this.Channel.EndaddMovieSeen(result);
        }

        public int addMovieSeen(int imdb_id_serie, int disk_id, int season_id, int cn)
        {
            return this.Channel.addMovieSeen(imdb_id_serie, disk_id, season_id, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginaddMovieUninterested(int imdb_id_serie, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginaddMovieUninterested(imdb_id_serie, disk_id, season_id, cn, callback, asyncState);
        }

        public int EndaddMovieUninterested(IAsyncResult result)
        {
            return this.Channel.EndaddMovieUninterested(result);
        }

        public int addMovieUninterested(int imdb_id_serie, int disk_id, int season_id, int cn)
        {
            return this.Channel.addMovieUninterested(imdb_id_serie, disk_id, season_id, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginaddMovieRate(int imdb_id, int disk_id, int season_id, int cn, int rate, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginaddMovieRate(imdb_id, disk_id, season_id, cn, rate, callback, asyncState);
        }

        public int EndaddMovieRate(IAsyncResult result)
        {
            return this.Channel.EndaddMovieRate(result);
        }

        public int addMovieRate(int imdb_id, int disk_id, int season_id, int cn, int rate)
        {
            return this.Channel.addMovieRate(imdb_id, disk_id, season_id, cn, rate);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginRemoveProdFromWishlist(int pdid, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginRemoveProdFromWishlist(pdid, cn, callback, asyncState);
        }

        public int EndRemoveProdFromWishlist(IAsyncResult result)
        {
            return this.Channel.EndaddMovieRate(result);
        }

        public int RemoveProdFromWishlist(int pdid, int cn)
        {
            return this.Channel.RemoveProdFromWishlist(pdid, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginsetVodOnly(int cn, int ovod, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginsetVodOnly(cn, ovod, callback, asyncState);
        }

        public int EndsetVodOnly(IAsyncResult result)
        {
            return this.Channel.EndsetVodOnly(result);
        }

        public int setVodOnly(int cn, int ovod)
        {
            return this.Channel.setVodOnly(cn, ovod);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesNewTitles(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesNewTitles(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesNewTitles(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesNewTitles(result);
        }

        public List<ListMovie> getMoviesNewTitles(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getMoviesNewTitles(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesLastChance(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesLastChance(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesLastChance(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesLastChance(result);
        }

        public List<ListMovie> getMoviesLastChance(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getMoviesLastChance(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesLastAdded(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesLastAdded(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesLastAdded(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesLastAdded(result);
        }

        public List<ListMovie> getMoviesLastAdded(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getMoviesLastAdded(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMostPopularMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMostPopularMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetMostPopularMovies(IAsyncResult result)
        {
            return this.Channel.EndgetMostPopularMovies(result);
        }

        public List<ListMovie> getMostPopularMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getMostPopularMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetOurFavoritesMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetOurFavoritesMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetOurFavoritesMovies(IAsyncResult result)
        {
            return this.Channel.EndgetOurFavoritesMovies(result);
        }

        public List<ListMovie> getOurFavoritesMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getOurFavoritesMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetBestRatedMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetBestRatedMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetBestRatedMovies(IAsyncResult result)
        {
            return this.Channel.EndgetBestRatedMovies(result);
        }

        public List<ListMovie> getBestRatedMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getBestRatedMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetAllCatalogueMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetAllCatalogueMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device, callback, asyncState);
        }

        public List<ListMovie> EndgetAllCatalogueMovies(IAsyncResult result)
        {
            return this.Channel.EndgetAllCatalogueMovies(result);
        }

        public List<ListMovie> getAllCatalogueMovies(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getAllCatalogueMovies(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesSoon_1(int lngid, int pageNumber, int pageSize, int vodOnly, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesSoon_1(lngid, pageNumber, pageSize, vodOnly, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesSoon_1(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesSoon_1(result);
        }

        public List<ListMovie> getMoviesSoon_1(int lngid, int pageNumber, int pageSize, int vodOnly)
        {
            return this.Channel.getMoviesSoon_1(lngid, pageNumber, pageSize, vodOnly);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesBestReview(int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesBestReview(lngid, pageNumber, pageSize, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesBestReview(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesBestReview(result);
        }

        public List<ListMovie> getMoviesBestReview(int lngid, int pageNumber, int pageSize)
        {
            return this.Channel.getMoviesBestReview(lngid, pageNumber, pageSize);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesSoon(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesSoon(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesSoon(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesSoon(result);
        }

        public List<ListMovie> getMoviesSoon(int lngid, bool show_tvod, bool show_svod, int cn, int pageNumber, int pageSize, int device)
        {
            return this.Channel.getMoviesSoon(lngid, show_tvod, show_svod, cn, pageNumber, pageSize, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMoviesInCinema(int lngid, int pageNumber, int pageSize, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMoviesInCinema(lngid, pageNumber, pageSize, callback, asyncState);
        }

        public List<ListMovie> EndgetMoviesInCinema(IAsyncResult result)
        {
            return this.Channel.EndgetMoviesInCinema(result);
        }

        public List<ListMovie> getMoviesInCinema(int lngid, int pageNumber, int pageSize)
        {
            return this.Channel.getMoviesInCinema(lngid, pageNumber, pageSize);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetVodAtCustomer(int cn, int lngid, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetVodAtCustomer(cn, lngid, device, callback, asyncState);
        }

        public List<VodAtCustomer> EndgetVodAtCustomer(IAsyncResult result)
        {
            return this.Channel.EndgetVodAtCustomer(result);
        }

        public List<VodAtCustomer> getVodAtCustomer(int cn, int lngid, int device)
        {
            return this.Channel.getVodAtCustomer(cn, lngid, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustVodWishList(int cn, int lngid, bool show_tvod, bool show_svod, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustVodWishList(cn, lngid, show_tvod, show_svod, device, callback, asyncState);
        }

        public List<CustVodWishList> EndgetCustVodWishList(IAsyncResult result)
        {
            return this.Channel.EndgetCustVodWishList(result);
        }

        public List<CustVodWishList> getCustVodWishList(int cn, int lngid, bool show_tvod, bool show_svod, int device)
        {
            return this.Channel.getCustVodWishList(cn, lngid, show_tvod, show_svod, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustVodSoon(int cn, int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustVodSoon(cn, lngid, callback, asyncState);
        }

        public List<ListMovie> EndgetCustVodSoon(IAsyncResult result)
        {
            return this.Channel.EndgetCustVodSoon(result);
        }

        public List<ListMovie> getCustVodSoon(int cn, int lngid)
        {
            return this.Channel.getCustVodSoon(cn, lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCodeListCountries( AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCodeListCountries(callback, asyncState);
        }

        public List<CodeListCountries> EndgetCodeListCountries(IAsyncResult result)
        {
            return this.Channel.EndgetCodeListCountries(result);
        }

        public List<CodeListCountries> getCodeListCountries()
        {
            return this.Channel.getCodeListCountries();
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCodeListTitles(int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCodeListTitles(lngid, callback, asyncState);
        }

        public List<CodeListTitle> EndgetCodeListTitles(IAsyncResult result)
        {
            return this.Channel.EndgetCodeListTitles(result);
        }

        public List<CodeListTitle> getCodeListTitles(int lngid)
        {
            return this.Channel.getCodeListTitles(lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCodeListAudios(int lngid,AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCodeListAudios(lngid, callback, asyncState);
        }

        public List<CodeListLanguages> EndgetCodeListAudios(IAsyncResult result)
        {
            return this.Channel.EndgetCodeListAudios(result);
        }

        public List<CodeListLanguages> getCodeListAudios(int lngid)
        {
            return this.Channel.getCodeListAudios(lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustProdWishListSoon(int cn, int lngid, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustProdWishListSoon(cn, lngid, device, callback, asyncState);
        }

        public List<MyListMovie > EndgetCustProdWishListSoon(IAsyncResult result)
        {
            return this.Channel.EndgetCustProdWishListSoon(result);
        }

        public List<MyListMovie> getCustProdWishListSoon(int cn, int lngid, int device)
        {
            return this.Channel.getCustProdWishListSoon(cn, lngid, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustProdWishListUnavlb(int cn, int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustProdWishListUnavlb(cn,lngid, callback, asyncState);
        }

        public List<MyListMovie> EndgetCustProdWishListUnavlb(IAsyncResult result)
        {
            return this.Channel.EndgetCustProdWishListUnavlb(result);
        }

        public List<MyListMovie> getCustProdWishListUnavlb(int cn, int lngid)
        {
            return this.Channel.getCustProdWishListUnavlb(cn, lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginaddProductAtCustomerComplain(int cn, string cmpln, int pdid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginaddProductAtCustomerComplain(cn, cmpln, pdid, callback, asyncState);
        }

        public int EndaddProductAtCustomerComplain(IAsyncResult result)
        {
            return this.Channel.EndaddProductAtCustomerComplain(result);
        }

        public int addProductAtCustomerComplain(int cn, string cmpln, int pdid)
        {
            return this.Channel.addProductAtCustomerComplain(cn, cmpln, pdid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginsetProductWishlistPriority(int pdid, int cn, int prty, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginsetProductWishlistPriority(pdid, cn, prty, callback, asyncState);
        }

        public int EndsetProductWishlistPriority(IAsyncResult result)
        {
            return this.Channel.EndsetProductWishlistPriority(result);
        }

        public int setProductWishlistPriority(int pdid, int cn,  int prty)
        {
            return this.Channel.setProductWishlistPriority(pdid, cn, prty);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginRemoveVodFromWishlist(int imdb_id, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginRemoveVodFromWishlist(imdb_id, cn, callback, asyncState);
        }

        public int EndRemoveVodFromWishlist(IAsyncResult result)
        {
            return this.Channel.EndRemoveVodFromWishlist(result);
        }

        public int RemoveVodFromWishlist(int imdb_id, int cn)
        {
            return this.Channel.RemoveVodFromWishlist(imdb_id, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCatalogCommunity(int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCatalogCommunity(lngid, callback, asyncState);
        }

        public List<catalogcommunity> EndgetCatalogCommunity(IAsyncResult result)
        {
            return this.Channel.EndgetCatalogCommunity(result);
        }

        public List<catalogcommunity> getCatalogCommunity(int lngid)
        {
            return this.Channel.getCatalogCommunity( lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCatalogCommunityMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCatalogCommunityMovies(lngid, pageNumber, pageSize, refclient, refclientid, callback, asyncState);
        }

        public List<ListMovie> EndgetCatalogCommunityMovies(IAsyncResult result)
        {
            return this.Channel.EndgetCatalogCommunityMovies(result);
        }

        public List<ListMovie> getCatalogCommunityMovies(int lngid, int pageNumber, int pageSize, string refclient, int refclientid)
        {
            return this.Channel.getCatalogCommunityMovies(lngid, pageNumber, pageSize, refclient, refclientid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustomerCreditForVod(int imdb_id_serie, int disk_id, int season_id, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustomerCreditForVod(imdb_id_serie, disk_id, season_id, cn, callback, asyncState);
        }

        public int EndgetCustomerCreditForVod(IAsyncResult result)
        {
            return this.Channel.EndgetCustomerCreditForVod(result);
        }

        public int getCustomerCreditForVod(int imdb_id_serie, int disk_id, int season_id, int cn)
        {
            return this.Channel.getCustomerCreditForVod(imdb_id_serie, disk_id, season_id, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetVodTokenAndLngsTest(int imdb_id_serie, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetVodTokenAndLngsTest(imdb_id_serie, disk_id, season_id, cn, device, callback, asyncState);
        }

        public VodTokenLengs EndgetVodTokenAndLngsTest(IAsyncResult result)
        {
            return this.Channel.EndgetVodTokenAndLngsTest(result);
        }

        public VodTokenLengs getVodTokenAndLngsTest(int imdb_id_serie, int disk_id, int season_id, int cn, int device)
        {
            return this.Channel.getVodTokenAndLngsTest(imdb_id_serie, disk_id, season_id, cn, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginsetErrorLog(int cn, string call_method, string call_parameters, string error_message, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginsetErrorLog(cn, call_method, call_parameters, error_message, device, callback, asyncState);
        }

        public int EndsetErrorLog(IAsyncResult result)
        {
            return this.Channel.EndsetErrorLog(result);
        }

        public int setErrorLog(int cn, string call_method, string call_parameters, string error_message, int device)
        {
            return this.Channel.setErrorLog(cn, call_method, call_parameters, error_message, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginIsVodEnabled(int imdb_id_serie, int disk_id, int season_id, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginIsVodEnabled(imdb_id_serie, disk_id, season_id, cn, device, callback, asyncState);
        }

        public VodEnabled EndIsVodEnabled(IAsyncResult result)
        {
            return this.Channel.EndIsVodEnabled(result);
        }

        public VodEnabled IsVodEnabled(int imdb_id_serie, int disk_id, int season_id, int cn, int device)
        {
            return this.Channel.IsVodEnabled(imdb_id_serie, disk_id, season_id, cn, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginSetRegistration(string email, int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginSetRegistration(email, lngid, callback, asyncState);
        }

        public RegistrationAllowed EndSetRegistration(IAsyncResult result)
        {
            return this.Channel.EndSetRegistration(result);
        }

        public RegistrationAllowed SetRegistration(string email, int lngid)
        {
            return this.Channel.SetRegistration(email, lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCustWatched(int cn, int lngid, int device, int pageNumber, int pageSize, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCustWatched(cn, lngid, device, pageNumber, pageSize, callback, asyncState);
        }

        public List<ListMovieWatched> EndgetCustWatched(IAsyncResult result)
        {
            return this.Channel.EndgetCustWatched(result);
        }

        public List<ListMovieWatched> getCustWatched(int cn, int lngid, int device, int pageNumber, int pageSize)
        {
            return this.Channel.getCustWatched(cn, lngid, device, pageNumber, pageSize);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetTodaysMovies(int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetTodaysMovies(lngid, callback, asyncState);
        }

        public List<ListMovie> EndgetTodaysMovies(IAsyncResult result)
        {
            return this.Channel.EndgetTodaysMovies(result);
        }

        public List<ListMovie> getTodaysMovies(int lngid)
        {
            return this.Channel.getTodaysMovies(lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetVODLanguages(int imdb_id, int disk_id, int season_id, int cn, int lngid, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetVODLanguages(imdb_id, disk_id, season_id, cn, lngid, callback, asyncState);
        }

        public string EndgetVODLanguages(IAsyncResult result)
        {
            return this.Channel.EndgetVODLanguages(result);
        }

        public string getVODLanguages(int imdb_id, int disk_id, int season_id, int cn, int lngid)
        {
            return this.Channel.getVODLanguages(imdb_id, disk_id, season_id, cn, lngid);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetHomePage(int lngid, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetHomePage(lngid, cn, device, callback, asyncState);
        }

        public hp EndgetHomePage(IAsyncResult result)
        {
            return this.Channel.EndgetHomePage(result);
        }

        public hp getHomePage(int lngid, int cn, int device)
        {
            return this.Channel.getHomePage(lngid, cn, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCategories(int lngid, int device, bool show_tvod, bool show_svod, int cn, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCategories(lngid, device, show_tvod, show_svod, cn, callback, asyncState);
        }

        public List<ListCategory> EndgetCategories(IAsyncResult result)
        {
            return this.Channel.EndgetCategories(result);
        }

        public List<ListCategory> getCategories(int lngid, int device, bool show_tvod, bool show_svod, int cn)
        {
            return this.Channel.getCategories(lngid, device, show_tvod, show_svod, cn);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetCataloguePage_1(int lngid, int cn, int device, int vodOnly, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetCataloguePage_1(lngid, cn, device, vodOnly, callback, asyncState);
        }

        public CataloguePage_1 EndgetCataloguePage_1(IAsyncResult result)
        {
            return this.Channel.EndgetCataloguePage_1(result);
        }

        public CataloguePage_1 getCataloguePage_1(int lngid, int cn, int device, int vodOnly)
        {
            return this.Channel.getCataloguePage_1(lngid, cn, device, vodOnly);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BegingetMovieFree(int lngid, int cn, int device, AsyncCallback callback, object asyncState)
        {
            return this.Channel.BegingetMovieFree(lngid, cn, device, callback, asyncState);
        }

        public List<FreeMovie> EndgetMovieFree(IAsyncResult result)
        {
            return this.Channel.EndgetMovieFree(result);
        }

        public List<FreeMovie> getMovieFree(int lngid, int cn, int device)
        {
            return this.Channel.getMovieFree(lngid, cn, device);
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginletMeKnow( AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginletMeKnow( callback, asyncState);
        }

        public bool EndletMeKnow(IAsyncResult result)
        {
            return this.Channel.EndletMeKnow(result);
        }

        public bool letMeKnow()
        {
            return this.Channel.letMeKnow();
        }

        ////////////////////////////////////////////////////////////

        public IAsyncResult BeginsetTVODCustomerSubscription(AsyncCallback callback, object asyncState)
        {
            return this.Channel.BeginsetTVODCustomerSubscription(callback, asyncState);
        }

        public int EndsetTVODCustomerSubscription(IAsyncResult result)
        {
            return this.Channel.EndsetTVODCustomerSubscription(result);
        }

        public int setTVODCustomerSubscription(string em, string pswd, int device, string dvcnmbr, int lngid)
        {
            return this.Channel.setTVODCustomerSubscription( em, pswd, device, dvcnmbr, lngid);
        }
    }
}
