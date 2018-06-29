using System;
using Microsoft.EntityFrameworkCore;

namespace QuiZapp.Models
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options)
            : base(options)
        {
        }

        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuizAnswer> QuizAnswer { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<UserAnswer> UserAnswer { get; set; }
        public DbSet<User> User { get; set; }
    }
}
