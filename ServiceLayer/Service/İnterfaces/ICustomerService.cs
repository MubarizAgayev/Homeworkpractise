using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.İnterfaces
{
    public interface ICustomerService
    {
        int GetCustomerCountByFiltered();
        Customer[] GetCustomersByFiltered(int startAge,int endAge);
        double GetCustomersAvarageByAges();
    }
}
