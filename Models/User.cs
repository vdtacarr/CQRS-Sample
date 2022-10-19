using System;
using System.Collections.Generic;

#nullable disable

namespace API.CQRS.Sample.Models
{
    public partial class User
    {
        public User()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime RegisteredAt { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
