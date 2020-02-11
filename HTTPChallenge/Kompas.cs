using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IronWebScraper;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    public class Kompas
    {

        public class BlogScrapper : WebScraper
        {
            public override void Init()
            {
                LoggingLevel = WebScraper.LogLevel.All;
                Request("https://kompas.com", Parse);
            }


            public override void Parse(Response response)
            {
                foreach (var result in response.Css("div.headline.ga--headline.clearfix"))
                {
                    var t = result.InnerText;
                    Console.WriteLine(t);
                    Console.WriteLine("");

                    for (int i = 0; i < result.Css("a[href]").Length; i++)
                    {
                        Console.WriteLine(result.Css("a[href]")[i].Attributes["href"]);
                        Console.WriteLine("");
                    }

                }
            }
        }
    }
}
