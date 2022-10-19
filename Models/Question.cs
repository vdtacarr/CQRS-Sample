using System;
using System.Collections.Generic;

#nullable disable

namespace API.CQRS.Sample.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
