using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    public class Soal3
    {
        public static async Task<List<User>> GetUser()
        {
            var result = await Fetcher.Get("https://jsonplaceholder.typicode.com/users");
            var user = JsonConvert.DeserializeObject<List<User>>(result);
            return user;
        }
        public class Geo
        {
            public string lat { get; set; }
            public string lng { get; set; }
        }

        public class Address3
        {
            public string street { get; set; }
            public string suite { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public Geo geo { get; set; }
        }

        public class Company
        {
            public string name { get; set; }
            public string catchPhrase { get; set; }
            public string bs { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public string name { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public Address3 address { get; set; }
            public string phone { get; set; }
            public string website { get; set; }
            public Company company { get; set; }
        }

        public class Nomor3
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
            public User user { get; set; }
        }
    }
}
