using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuiZapp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
