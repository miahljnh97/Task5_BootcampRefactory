using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Nomor 1
            //var getJsonResponse = await Fetcher.Post();
            //Console.WriteLine(getJsonResponse);

            //Nomor 2
            var result = await Employees.employeesData();

            Console.WriteLine("Employees that has salary more than 15 Million are : ");
            List<string> salary = new List<string>();
            foreach (var k in result)
            {
                if (k.Salary > 15000000)
                {
                    salary.Add(k.First_name + k.Last_name);
                }
            }
            Console.WriteLine(String.Join(",", salary));
            Console.WriteLine(" ");

            Console.WriteLine("Employees that life in Jakarta are : ");
            List<string> jkt = new List<string>();
            foreach (var k in result)
            {
                foreach (var l in k.Addresses)
                {
                    if (l.City == "DKI Jakarta")
                    {
                        jkt.Add(k.First_name + k.Last_name);
                    }
                }

            }
            var JKT = jkt.Distinct();
            Console.WriteLine(String.Join(",", JKT));
            Console.WriteLine(" ");

            Console.WriteLine("Employees that born on March are : ");
            List<string> born = new List<string>();
            foreach (var k in result)
            {
                var A = Convert.ToInt32((k.Birthday).Substring(5, 2));
                if (A == 3)
                {
                    born.Add(k.First_name + k.Last_name);
                }
            }

            Console.WriteLine(String.Join(",", born));
            Console.WriteLine(" ");

            Console.WriteLine("Employees that absences in October 2019 are : ");
            List<int> Absences = new List<int>();

            List<string> Nama = new List<string>();
            foreach (var k in result)
            {
                int count = 0;
                foreach (var l in k.Presence_list)
                {
                    var A = Convert.ToInt32(l.Substring(5, 2));
                    if (A == 10)
                    {
                        count++;
                    }
                }
                Absences.Add(count);

                Nama.Add(k.First_name + k.Last_name);

            }
            Console.WriteLine(String.Join(",", Nama));
            Console.WriteLine(String.Join(",", Absences));
            Console.WriteLine("Nomor 2 is done.");
            Console.WriteLine(" ");


            //Nomor 3

            var client = new HttpClient();
            var post = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            var posts = JsonConvert.DeserializeObject<List<Soal3.Nomor3>>(post);
            var user = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var users = JsonConvert.DeserializeObject<List<Soal3.User>>(user);
            var hasil = new List<Soal3.Nomor3>();
            foreach (var k in posts)
            {
                foreach (var l in users)
                {
                    if (k.userId == l.id)
                    {
                        hasil.Add(new Soal3.Nomor3
                        {
                            userId = k.userId,
                            id = k.id,
                            title = k.title,
                            body = k.body,
                            user = new Soal3.User
                            {
                                id = l.id,
                                name = l.name,
                                username = l.username,
                                email = l.email,
                                address = new Soal3.Address3
                                {
                                    street = l.address.street,
                                    suite = l.address.suite,
                                    city = l.address.city,
                                    zipcode = l.address.zipcode,
                                    geo = new Soal3.Geo
                                    {
                                        lat = l.address.geo.lat,
                                        lng = l.address.geo.lng
                                    }
                                },
                                phone = l.phone,
                                website = l.website,
                                company = new Soal3.Company
                                {
                                    name = l.company.name,
                                    catchPhrase = l.company.catchPhrase,
                                    bs = l.company.bs
                                }
                            }
                        });
                    }
                }
            }

            var Num3 = JsonConvert.SerializeObject(hasil);
            File.WriteAllText(@"/Users/user/Projects/Task5_BootcampRefactory/HTTPChallenge/Num3.json", Num3);
            Console.WriteLine("Nomor 3 is done. See Num3.json to know the results.");
            Console.WriteLine("");


            ////Nomor 4
            //var scrape = new MovieDB();
            //await scrape.StartAsync();
            //Console.WriteLine("Nomor 4 is done.");
            //Console.WriteLine("")
            ////scrape.Start();

            //Nomor 5
            var scrapes = new Kompas.BlogScrapper();
            await scrapes.StartAsync();
            Console.WriteLine("Nomor 5 is done.");
            Console.WriteLine("");
            //scrape.Start();

        }

    }
}
