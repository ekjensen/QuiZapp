using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class QuizName
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
