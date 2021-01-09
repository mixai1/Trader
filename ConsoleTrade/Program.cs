using System;
using Trader.Domain.IServices;
using Trader.Domain.Models;
using Trader.EntityFramework;
using Trader.EntityFramework.Services;

namespace ConsoleTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            // It testing Services and
            // DB testing
            IDataService<User> service = new GenericDataService<User>(new TraderDbContext());
           // service.Create(new User() { UserName = "Tom" }).Wait();
            service.Delete(3).Wait();
            service.Delete(2).Wait();

            var res =  service.GetAll();
            foreach (var item in res.Result)
            {
                Console.WriteLine("UserName: {0}", item.Id);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
