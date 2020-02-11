using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HTTPChallenge
{
    public class Employees
    {
        public static async Task<List<Employees1>> employeesData()
        {
            var json2 = await Fetcher.Get("https://mul14.github.io/data/employees.json");
            var data2 = JsonConvert.DeserializeObject<List<Employees1>>(json2);
            return data2;
        }
    }


    public class Address
    {
        public string Label { get; set; }
        public string Addresses { get; set; }
        public string City { get; set; }
    }

    public class Phone
    {
        public string Label { get; set; }
        public string Phones { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
    }

    public class Position
    {
        public string Name { get; set; }
    }

    public class Employees1
    {
        public int Id { get; set; }
        public string Avatar_url { get; set; }
        public string Employee_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Birthday { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }
        public List<string> Presence_list { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
    }
}
