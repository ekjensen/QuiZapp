using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class Result
    {
        public int ResultID { get; set; }
        public int QuizID { get; set; }
        public string HighestValue { get; set; }

        public Quiz Quiz { get; set; }
    }
}
