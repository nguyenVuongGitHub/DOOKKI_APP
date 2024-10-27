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
        cashier
    }
    internal class User
    {
        private static Roles role;
        public static Roles Role { get => role; private set => role = value; }
        public static void SetRoles(string role)
        {
            switch (role.ToLower())
            {
                case "admin":
                    Role = Roles.admin;
                    break;
                case "cashier":
                    Role = Roles.cashier;
                    break;
                default:
                    throw new ArgumentException("Invalid role provided.");

            }
        }
    }
}
