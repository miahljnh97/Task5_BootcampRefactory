using System;
using IronWebScraper;

namespace HTTPChallenge
{
    public class CGVclass
    {
        public class CGV : WebScraper
        {
            public override void Init()
            {
                LoggingLevel = WebScraper.LogLevel.All;
                Request("https://www.cgv.id/", Parse);
            }

            public override void Parse(Response response)
            {
                foreach (var result in response.Css("ul.slides > li >a"))
                {
                    string url = result.Attributes["href"];
                    this.Request(url, Parse2);
                }
            }

            public void Parse2(Response response)
            {
                Console.WriteLine(response.Css("div.movie-info-title").First().InnerText.Replace("\t", ""));
                foreach (var result in response.Css("div.movie-add-info > ul"))
                {
                    Console.WriteLine(X.InnerText.Replace("\t", ""));
                }
                Console.WriteLine(response.Css("div.movie-synopsis").First().InnerText.Replace("\t", ""));
            }

        }
    }
}
