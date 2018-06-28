using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class Questions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string QuestionText { get; set; }
        public int QuizID { get; set; }

        public virtual ICollection<QuizName> QuizNames { get; set; }
    }
}
