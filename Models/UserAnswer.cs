using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class UserAnswer
    {
        public int UserAnswerID { get; set; }
        public int QuizAnswerID { get; set; }
        public int UserID { get; set; }

        public virtual QuizAnswer QuizAnswer { get; set; }
        public virtual User User { get; set; }
    }
}
