using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibVer1.Models
{
    public enum UserStatus
    {
        LoggedIn,
        LoggedOff
    }

    public enum UserRole
    {
        Admin,
        Guest,
        Registered
    }
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserRole UserRole { get; set; }
    }
}
