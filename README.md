# TMDb library by dom53

A library/wrapper of TMDb's API - themoviedb.org 
Still in alpha! 
You can also use my java library http://doc.java.tmdbapi.mandinecdominik.cz

 __Required__ Newtonsoft.Json

## Warning
Always use try - catch to wrapper your code
```c#
try
{
    //your code
}
catch (ApiException ex)
{
    Console.WriteLine(ex);
}
```

## Examples
### Movies
Getting basic info for "The Lord of the Rings: The Return of the King".
```c#
TmdbClient mdbClient = new TmdbClient("your_api_key");
Movie movie = await mdbClient.GetMovieDetails(122, new UrlParameters {
    {"append_to_response", "videos,images"}
});

Console.WriteLine("Movie      : {0}", movie.title);
Console.WriteLine("Popularity : {0}", movie.popularity);
Console.WriteLine("Runtime    : {0}", movie.runtime);
```
Simple example of Discover movies.
Discover search movie by UrlParameters.
### Discover

```c#
TmdbClient mdbClient = new TmdbClient("your_api_key");
ResultObject<DiscoverMovie> movieObject = await mdbClient.DiscoverMovie(new UrlParameters {
    {"language", "cs-CZ"},
    {"include_adult", "false" },
    {"primary_release_year", "2019" }
});

Console.WriteLine(movieObject.total_results);       // Get number of total result
Console.WriteLine(movieObject.total_pages);         // Get number of total pages
Console.WriteLine(movieObject.page);                // Get page

foreach (var movie_item in movieObject.results)
{
    Console.WriteLine("Title: {0}\nVote: {1}", movie_item.title, movie_item.vote_average);
}
```

## Tips
- All methods are `async` and awaitable
- Most methods are very straightforward, and do as they are named (you get info as they are named), `movie`, `person` etc.
- Each Class has its own `toString` method for prinit basic info about movie, tv etc...
- All `UrlParameters` you can find on official TMDb api doc (table Query String) for example: UrlParameters for DiscoverMovie

## ResultObject class
List of classes they require ResultObject
- `DiscoverMovie`
- `DiscoverTv`
- `SearchMovie`
- `SearchTvShows`
- `SimilarMovie`
- `SimilarTv`
- `TrendingMovie`

## Plans to the future

- Authentication
- Account
- Create all get method
