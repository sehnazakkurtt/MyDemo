using MernisServiceReference;
using MYDemo.Abstract;
using MYDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
