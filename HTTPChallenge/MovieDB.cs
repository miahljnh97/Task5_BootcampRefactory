﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IronWebScraper;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    //public class MovieDB : WebScraper
    //{
    //    public override void Init()
    //    {
    //        LoggingLevel = WebScraper.LogLevel.All;
    //        Request("https://www.themoviedb.org/", Parse);
    //    }

    //    public override string Parse(Response response)
    //    {
    //        foreach(var k in response.Css(""))
    //        {
    //            string title = k.TextContentClean;
    //            return title;
    //        }
    //    }
    //}
}