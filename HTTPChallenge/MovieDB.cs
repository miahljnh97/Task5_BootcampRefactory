using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IronWebScraper;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    public class Soal4
    {
        public static async Task<Nomor4> Indonesia()
        {
            var json1 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=62f751fec695f5d8c228bf931aada3dd&language=en-US&sort_by=popularity.asc&include_adult=false&include_video=false&page=1&with_original_language=id");
            var data1 = JsonConvert.DeserializeObject<Nomor4>(json1);
            return data1;
        }

        public static async Task<Nomor4> Keanu()
        {
            var json2 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=62f751fec695f5d8c228bf931aada3dd&language=en-US&sort_by=popularity.asc&include_adult=false&include_video=false&page=1&with_people=6384");
            var data2 = JsonConvert.DeserializeObject<Nomor4>(json2);
            return data2;
        }

        public static async Task<Nomor4> DowneyHolland()
        {
            var json3 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=62f751fec695f5d8c228bf931aada3dd&language=en-US&sort_by=popularity.asc&include_adult=false&include_video=false&page=1&with_people=3223%2C1136406");
            var data3 = JsonConvert.DeserializeObject<Nomor4>(json3);
            return data3;
        }

        public static async Task<Nomor4> popularMovies()
        {
            var json4 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=62f751fec695f5d8c228bf931aada3dd&language=en-US&sort_by=popularity.asc&include_adult=false&include_video=false&page=1&primary_release_year=2016&vote_average.gte=7.5");
            var data4 = JsonConvert.DeserializeObject<Nomor4>(json4);
            return data4;
        }

    }

    public class Result
    {
        public double popularity { get; set; }
        public int id { get; set; }
        public bool video { get; set; }
        public int vote_count { get; set; }
        public double vote_average { get; set; }
        public string title { get; set; }
        public string release_date { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public string backdrop_path { get; set; }
        public bool adult { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
    }

    public class Nomor4
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<Result> results { get; set; }
    }

}
