using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.Tvs;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;
using TMDbApiDom.Dto.Tvs.SubClasses;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro TvTest
    /// </summary>
    [TestClass]
    public class TvTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task TvDetailsTest ()
        {
            Tv tv = await mdb.GetTvDetails(63926, new UrlParameters { });

            Console.WriteLine("tv name : {0}", tv.name);

            Assert.AreEqual("One-Punch Man", tv.name);
            Assert.AreEqual(63926, tv.id);
        }

        [TestMethod]
        public async Task SimilarTvTest()
        {
            ResultObject<SimilarTv> similarTv = await mdb.GetSimilarTv(63926, new UrlParameters { });

            Console.WriteLine("Similar tv total result : {0}", similarTv.total_results);

            Assert.IsTrue(similarTv.results != null);
        }

		[TestMethod]
		public async Task TopRatedTvsTest()
		{
			ResultObject<TvTopRated> topTv = await mdb.GetTopRatedTvShows(new UrlParameters { });

			Console.WriteLine("Top rated tv total result : {0}", topTv.total_results);

			Assert.IsTrue(topTv.results != null);
		}

		[TestMethod]
		public async Task TvKeywordTest()
		{
			TvKeywords tvKeywords = await mdb.TvKeywords(63926, new UrlParameters { });

			Console.WriteLine("keywords: {0}", tvKeywords.results[0].name);

			Assert.IsTrue(tvKeywords != null);
		}

		[TestMethod]
		public async Task TvExternalIdsTest()
		{
			TvExternalID TvExt = await mdb.TvExternalId(63926, new UrlParameters { });

			Console.WriteLine("id: {0}", TvExt.id);
			Console.WriteLine("fb id: {0}", TvExt.facebook_id);
			Console.WriteLine("ig id: {0}", TvExt.instagram_id);
			Console.WriteLine("imdb id: {0}", TvExt.imdb_id);
			Console.WriteLine("twitter id: {0}", TvExt.twitter_id);
			Console.WriteLine("freebase id: {0}", TvExt.freebase_id);

			Assert.IsTrue(TvExt != null);
		}

		[TestMethod]
		public async Task TvCreditTest()
		{
			TvCredit tvCredits = await mdb.TvCredit(63926, new UrlParameters { });

			Console.WriteLine("id: {0}", tvCredits.id);
			Console.WriteLine("cast length: {0}", tvCredits.cast.Length);
			Console.WriteLine("cast id: {0}", tvCredits.cast[0].cast_id);
			Console.WriteLine("cast name [0]: {0}", tvCredits.cast[0].name);
			Console.WriteLine("crew length [0]: {0}", tvCredits.crew.Length);

			Assert.IsTrue(tvCredits != null);
		}

		[TestMethod]
		public async Task TvChangesTest()
		{
			TvChanges<Changes<TvItems>> tvChanges = await mdb.TvChanges(63926, new UrlParameters { });

			Console.WriteLine("movieChanges length: {0}", tvChanges.changes.Length);
			/*Console.WriteLine("movieChanges key: {0}", movieChanges.changes[0].key);
            Console.WriteLine("movieChanges items length: {0}", movieChanges.changes[0].items.Length);
            Console.WriteLine("movieChanges items id: {0}", movieChanges.changes[0].items[0].id);
            Console.WriteLine("movieChanges items action: {0}", movieChanges.changes[0].items[0].action);*/

			Assert.IsTrue(tvChanges != null);
		}

		[TestMethod]
		public async Task TvAlternativeTitles()
		{
			TvAlternativeTitles tvAlternativeTitles = await mdb.TvAlternativeTitles(63926, new UrlParameters { });

			Console.WriteLine("movieAlternativeTitles id: {0}", tvAlternativeTitles.id);
			Console.WriteLine("movieAlternativeTitles length {0}", tvAlternativeTitles.results.Length);
			Console.WriteLine("movieAlternativeTitles length title: {0}", tvAlternativeTitles.results[5].title);
			Console.WriteLine("movieAlternativeTitles length type: {0}", tvAlternativeTitles.results[5].type);
			Console.WriteLine("movieAlternativeTitles length iso: {0}", tvAlternativeTitles.results[5].iso_3166_1);

			Assert.IsTrue(tvAlternativeTitles != null);
		}

		[TestMethod]
		public async Task TvTranslationsTest()
		{
			Translations<TranslationObject<TvTranslations>> tvTranslation = await mdb.TvTranslation(63926, new UrlParameters { });

			Console.WriteLine("movieTranslation id : {0}", tvTranslation.id);
			Console.WriteLine("movieTranslation length: {0}", tvTranslation.translations.Length);
			Console.WriteLine("movieTranslation data Title: {0}", tvTranslation.translations[0].data.name);
			Console.WriteLine("movieTranslation data Homepage: {0}", tvTranslation.translations[0].data.homepage);
			Console.WriteLine("movieTranslation data Overwiev: {0}", tvTranslation.translations[0].data.overview);

			Assert.IsTrue(tvTranslation != null);
		}

		[TestMethod]
		public async Task TvRecomendTest()
		{
			ResultObject<TvRecommendations> tvRecomen = await mdb.TvRecomend(63926, new UrlParameters { });

			Console.WriteLine("movieRecomen total_pages: {0}", tvRecomen.total_pages);
			Console.WriteLine("movieRecomen total_results: {0}", tvRecomen.total_results);
			Console.WriteLine("movieRecomen results: {0}", tvRecomen.results[0].name);

			Assert.IsTrue(tvRecomen != null);
		}

		[TestMethod]
		public async Task TvReviewTest()
		{
			ResultObject<TvReview> tvReview = await mdb.TvReview(1399, new UrlParameters { });

			Console.WriteLine("tvReview id: {0}", tvReview.id);
			Console.WriteLine("tvReview total_pages: {0}", tvReview.total_pages);
			Console.WriteLine("tvReview total_results: {0}", tvReview.total_results);
			Console.WriteLine("tvReview result id: {0}", tvReview.results[0].id);
			Console.WriteLine("tvReview result author: {0}", tvReview.results[0].author);
			Console.WriteLine("tvReview result content: {0}", tvReview.results[0].content);
			Console.WriteLine("tvReview result url: {0}", tvReview.results[0].url);

			Assert.IsTrue(tvReview != null);
		}

		[TestMethod]
		public async Task TvPopularTest()
		{
			ResultObject<TvPopular> tvPopular = await mdb.TvPopular(new UrlParameters { });

			Console.WriteLine("tvPopular id: {0}", tvPopular.id);
			Console.WriteLine("tvPopular total_pages: {0}", tvPopular.total_pages);
			Console.WriteLine("tvPopular total_results: {0}", tvPopular.total_results);
			Console.WriteLine("tvPopular result id: {0}", tvPopular.results[5].id);
			Console.WriteLine("tvPopular result title: {0}", tvPopular.results[5].name);

			Assert.IsTrue(tvPopular != null);
		}

		[TestMethod]
		public async Task TvVideoWrapperTest()
		{
			VideosWrapper tvVideo = await mdb.GetTvVideos(63926, new UrlParameters { });

			Console.WriteLine("Start");

			Console.WriteLine("tvVideo length : {0}", tvVideo.results.Length);
			Console.WriteLine("tvVideo name : {0}", tvVideo.results[0].name);

			Assert.IsTrue(tvVideo != null);
		}

		[TestMethod]
		public async Task TvImgWrapperTest()
		{
			ImagesWrapper tvImg = await mdb.GetTvImages(63926, new UrlParameters { });

			Console.WriteLine("tvImg backdrop length : {0}", tvImg.backdrops.Length);
			Console.WriteLine("tvImg backdrop file_path : {0}", tvImg.backdrops[0].file_path);
			Console.WriteLine("tvImg posters length : {0}", tvImg.posters.Length);
			Console.WriteLine("tvImg posters file_path : {0}", tvImg.posters[0].file_path);

			Assert.IsTrue(tvImg != null);
		}
	}
}
