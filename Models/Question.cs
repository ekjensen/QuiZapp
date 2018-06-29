using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionID { get; set; }
        public int QuizID { get; set; }
        public string QuestionText { get; set; }

        public virtual Quiz Quiz { get; set; }

        public ICollection<QuizAnswer> QuizAnswers { get; set; }
    }
}
