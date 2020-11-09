using System;
using System.Collections.Generic;
using System.Text;

namespace UAPA.FactConsultorio.Domain.Entities
{
    public class User: EntityBase
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserRole { get; set; }
        public bool Locked { get; set; }
    }

    public static class LoggedUser
    {
        public static int UserId { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Name = null;
            Role = "";
        }
    }
}