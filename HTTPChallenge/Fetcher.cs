using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using IronWebScraper;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    public class Fetcher
    {
        static HttpClient client = new HttpClient();

        public static async Task<string> Get(string link)
        {
            
            var gets = await client.GetStringAsync(link);
            return gets;
        }

        public static async Task<string> Delete(string link)
        {
            var deletes = await client.DeleteAsync(link);
            return deletes;
        }

        public static async Task<string> Post(string link)
        {
            var posts = await client.PostAsync(link);
            return posts;
        }

        public static async Task<string> Put(string link)
        {
            var puts = await client.PutAsync(link);
            return puts;
        }

        public static async Task<string> Patch(string link)
        {
            var patchs = await client.PatchAsync(link);
            return patchs;
        }
    }


}
