﻿using ServiceLayer.Service;
using ServiceLayer.Service.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractise.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }

        public void GetCustomerCountByFiltered()
        {
            Console.WriteLine(_service.GetCustomerCountByFiltered());
        }
        public void GetCustomersAvarageByAges()
        {
            Console.WriteLine(_service.GetCustomersAvarageByAges());
        }
        public void GetCustomersByFiltered()
        {
            int startAge = 22;
            int endAge = 30;
            int shaiqAge=0;
            int pervinAge=0;

            var result = _service.GetCustomersByFiltered(startAge, endAge);
            foreach(var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id}{item.Name}{item.Surname}{item.Position}");
                    //if (item.Name == "Shaiq")
                    //{
                    //    shaiqAge= item.Age;
                    //}
                    //else if (item.Name == "Pervin")
                    //{
                    //    pervinAge= item.Age;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Emeliyyat duzgun deyil");
                    //}
                }
                
            }
            //Console.WriteLine(shaiqAge >= pervinAge);

        }
    }
}