using System;
using System.Collections.Generic;

#nullable disable

namespace API.CQRS.Sample.Models
{
    public partial class UserAnswer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AnswerId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual User User { get; set; }
    }
}
