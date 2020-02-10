//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using IronWebScraper;
//using Newtonsoft.Json;

//namespace HTTPTraining
//{
//    class Program
//    {
//        public static async Task Main(string[] args)
//        {
//            //var result = await GetUser();
//            //var posts = await GetPosts();

//            //Console.WriteLine("Nama User : ");
//            //foreach (var item in result)
//            //{
//            //    Console.WriteLine(item.Name);
//            //}
//            //Console.WriteLine("");

//            //Console.WriteLine("Post Id : ");
//            //posts.ForEach(item =>
//            //{
//            //    Console.WriteLine(item.Id);
//            //});
//            //Console.WriteLine("");

//            ////Console.WriteLine(result);
//            ////Console.WriteLine(posts);
//            ///
//            var scrape = new BlogScrapper();
//            await scrape.StartAsync();
//            //scrape.Start();

//        }

//        //public static async Task<List<User>> GetUser()
//        //{
//        //    var client = new HttpClient();
//        //    var resultAs = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
//        //    var users = JsonConvert.DeserializeObject<List<User>>(resultAs);
//        //    return users;
//        //}

//        //public static async Task<List<Post>> GetPosts()
//        //{
//        //    var client = new HttpClient();
//        //    var resultPo = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
//        //    var posts = JsonConvert.DeserializeObject<List<Post>>(resultPo);
//        //    return posts;
//        //}

//    }

//    //public class User
//    //{
//    //    public int Id { get; set; }
//    //    public string Name { get; set; }
//    //}

//    //public class Post
//    //{
//    //    public int Id { get; set; }
//    //    public string Title { get; set; }
//    //    public string Body { get; set; }
//    //}

//internal class BlogScrapper : WebScraper
//{
//    public override void Init()
//    {
//        LoggingLevel = WebScraper.LogLevel.All;
//        Request("https://blog.scrapinghub.com", Parse);
//    }

//    //public override void Parse(Response response)
//    //{
//    //    foreach(var result in response.Css("div.post-header > h2"))
//    //    {
//    //        string title = result.TextContentClean;
//    //        Console.WriteLine(title);
//    //    }
//    //}


//    public override void Parse(Response response)
//    {
//        foreach (var result in response.Css("span.date"))
//        {
//            string title = result.Css("a[href]")[0].Attributes["href"];
//            Console.WriteLine(title);
//        }
    }
//    }
//}
