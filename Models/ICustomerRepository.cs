﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlindLowVisionProject.Models
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int Id);
        IEnumerable<Customer> GetAllCustomers();
    }
}
