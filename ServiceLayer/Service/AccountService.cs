using ServiceLayer.Helpers.Constants;
using ServiceLayer.Helpers.Enums;
using ServiceLayer.Service.İnterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class AccountService : İAccountService
    {
        

        public string Login(string email,string password,int roleId)
        {
            if (email == AccountDatas.Email && password == AccountDatas.Password)
            {
                if (CheckRole(roleId))
                {
                    return ResponseMessages.Success;
                }
                else
                {
                    return ResponseMessages.Unauthorized;
                }
            }
            return ResponseMessages.Failed;
        }
        private bool CheckRole(int roleId)
        {
            if(roleId == (int)Roles.SuperAdmin)
                return true;
                return false;
            
        }
    }
}
