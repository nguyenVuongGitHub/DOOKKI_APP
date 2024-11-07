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
        private static Roles role;
        public static Roles Role { get => role; private set => role = value; }
        private static string username;
        public static string Username { get => username; set => username = value; }
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
