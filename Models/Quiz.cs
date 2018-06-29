using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }

        public ICollection<Result> Results { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
