using MYDemo.Abstract;
using MYDemo.Adapters;
using MYDemo.Concrete;
using MYDemo.Entities;
using System;

namespace MYDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1994,1,1), FirstName = "Şehnaz", LastName = "Akkurt", NationalityId = "66766108404" });
            Console.ReadLine();
        }
    }
}
