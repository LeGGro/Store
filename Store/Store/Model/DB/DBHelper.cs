using Store.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.DB
{
    internal class DBHelper
    {
        public string CreateNewInfo(Roles role)
        { 
            if (role == Roles.Admin) 
            { 
                return "New info created"; 
            }
            return "";
        }
        public string ReadInfo(Roles role)
        {
            if (role == Roles.Admin || role == Roles.User)
            {
                return "Some Info";
            }
            return "";
        }
        public string UpdateInfo(Roles role)
        {
            if (role == Roles.Admin)
            {
                return "Some Info Updated";
            }
            return "";
        }
        public string DeleteInfo(Roles role)
        {
            if (role == Roles.Admin)
            {
                return "Info Deleted";
            }
            return "";
        }
    }
}
