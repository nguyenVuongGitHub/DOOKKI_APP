using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOKKI_APP.Helpers
{
    public enum Roles
    {
        admin,
        employee,
        customer
    }
    internal class User
    {
        public static Roles Role { get; private set; }
        public static string Username { get; set ; }
        public static string Name { get; set; }
        public static void SetRoles(string role)
        {
            switch (role.ToLower())
            {
                case "admin":
                    Role = Roles.admin;
                    break;
                case "employee":
                    Role = Roles.employee;
                    break;
                case "customer":
                    Role = Roles.customer;
                    break;
                default:
                    throw new ArgumentException("Invalid role provided.");

            }
        }
    }
}
