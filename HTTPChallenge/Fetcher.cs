//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using IronWebScraper;
//using Newtonsoft.Json;

//namespace HTTPChallenge
//{
//    public class Fetcher
//    {
//        public static async Task<List<Getbin>> Get()
//        {
//            var client = new HttpClient();
//            var getJson = await client.GetStringAsync("https://httpbin.org/get");
//            var posts = JsonConvert.DeserializeObject<List<Getbin>>(getJson);
//            return posts;
//        }
//    }

//    public class Getbin
//    {
//        public Args args { get; set; }
//        public Headers headers { get; set; }
//        public string origin { get; set; }
//        public string url { get; set; }
//    }

//    public class Args
//    {
//    }

//    public class Headers
//    {
//        public string Accept { get; set; }
//        public string Host { get; set; }

//        public string Accept_Encoding { get; set; }
//    public string __invalid_name__Accept_Language { get; set; }
//        public string Host { get; set; }
//public string __invalid_name__Sec-Fetch-Mode { get; set; }
//        public string __invalid_name__Sec-Fetch-Site { get; set; }
//        public string __invalid_name__Upgrade-Insecure-Requests { get; set; }
//        public string __invalid_name__User-Agent { get; set; }
//        public string __invalid_name__X-Amzn-Trace-Id { get; set; }
//        }
//}
