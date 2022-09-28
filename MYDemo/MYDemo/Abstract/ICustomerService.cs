using MYDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
