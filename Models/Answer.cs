using System;
using System.Collections.Generic;

#nullable disable

namespace API.CQRS.Sample.Models
{
    public partial class Answer
    {
        public Answer()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }

        public int Id { get; set; }
        public string TextField { get; set; }
        public int QuestionId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
