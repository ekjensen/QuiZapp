using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class QuizAnswer
    {
        public int QuizAnswerID { get; set; }
        public int QuestionID { get; set; }
        public string AnswerText { get; set; }
        public int AnswerValue { get; set; }

        public virtual Question Question { get; set; }

        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
