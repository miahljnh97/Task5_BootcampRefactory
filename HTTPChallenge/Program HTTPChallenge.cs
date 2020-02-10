using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HTTPChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
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
                foreach(var l in k.Addresses)
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
                if(A == 3)
                {
                    born.Add(k.First_name + k.Last_name);
                }
            }

            Console.WriteLine(String.Join(",", born));
            Console.WriteLine(" ");
        }
        
    }
}
