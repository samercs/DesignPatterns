﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade mortgage = new Facade();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
