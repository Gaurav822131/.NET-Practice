using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console_APP
{
    class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8 };
            string[] nameArray = { "alok", "Rajat", "Sumit", "Priya", "Ayush", "Harshit", "Himanshu", "Mahi", "Mandabi", "Gaurav", "Yash" };
            //LINQ QUERIES

            //int dataToSearch = 120;
            //var result = from data in numArray where data == dataToSearch select data;

            //var result = from data in numArray
            //             where data%2==0 && data>20 select data;

            //Console.WriteLine("enter the data to search: ");
           // string dataToSearch = Console.ReadLine();
            //var result = from data in nameArray where data.StartsWith("A") select data;
            //var result = from data in nameArray where data.Contains("A")||data.Contains("a") select data;

            //var result = nameArray.Where(n => n == dataToSearch);

            
            var result = from data in nameArray orderby data select data;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void LinqToObjecrOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer{ID=101,Name="Alok",City="Pune"},
                new Customer(){ID=102,Name="Aliya",City="Mumbai"},
                new Customer{ID=103,Name="Aman",City="Pune"},
                new Customer{ID=104,Name="Gaurav",City="Chandigarh"},
                new Customer{ID=105,Name="Manvi",City="Palampur"},



            };
            //Anonymous Object.
            var data = new { OrderID = 1100, OrderDate = "12/01/2025", TotalAmount = 14000 };

           // var result = custList.Where(cust => cust.City == "Pune");
            var result1 = custList.FindAll(cust => cust.City == "Chandigarh");
            //var result = from cust in custList where cust.City == "Chandigarh" select cust;
             //var result = from cust in custList where cust.City == "Chandigarh"
             //             select new { cust.Name, cust.City };
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.ID}\t{item.Name}\t{item.City}");
            }
            }
        static void Main(string[] args)
        {
            // LinqToObjectDemo();
            LinqToObjecrOnCustomType();
        }
    }
}
