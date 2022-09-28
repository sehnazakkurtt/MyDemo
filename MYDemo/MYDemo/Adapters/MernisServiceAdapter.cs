﻿using MernisServiceReference;
using MYDemo.Abstract;
using MYDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MYDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);

        }
    }
}
