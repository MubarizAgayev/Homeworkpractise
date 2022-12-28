using ServiceLayer.Service;
using ServiceLayer.Service.İnterfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPractise.Controllers
{
    public class AccountController
    {
        public void Login()
        {
            Console.WriteLine("Add email :");
            string email = Console.ReadLine();
            Console.WriteLine("Add password :");
            string password = Console.ReadLine();

            int roleId = 1;

            İAccountService account=new AccountService();
            string result=account.Login(email, password, roleId);
            Console.WriteLine(result);
        }
    }
}
