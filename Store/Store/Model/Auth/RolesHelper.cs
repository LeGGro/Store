using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Auth
{
    public enum Roles
    {
        User = 101,
        Admin = 202,
        Guest = 303
    
    }
    internal class RolesHelper
    {
        public Roles role;
        
        
        public int SetRole(int code)
        {
            switch ((Roles)code)
            {
                case Roles.User:
                    role = Roles.User;
                    return 1;
                case Roles.Admin:
                    role = Roles.Admin;
                    return 1;
                case Roles.Guest:
                    role = Roles.Guest;
                    return 1;
                default:
                    return -1;

            }


        }
        public string GivePermits()
        {
            switch (role)
            {
                case Roles.User:
                    return "R.Read\nE.Exit";
                case Roles.Admin:
                    return "C.Create\nR.Read\nU.Update\nD.Delete\nE.Exit";
                case Roles.Guest:
                    return "E.Exit";
                default:
                    return "'-'";

            }
        
        }
    }
}
