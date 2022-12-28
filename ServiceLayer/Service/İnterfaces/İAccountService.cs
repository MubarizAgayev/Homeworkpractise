using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.İnterfaces
{
    public interface İAccountService
    {
       string Login(string email,string password,int roleId);
    }
}
