using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLib.Models
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
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserRole UserRole { get; set; }

        [ForeignKey("Items")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
