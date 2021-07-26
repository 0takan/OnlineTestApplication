using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public class QuizTakerDbContext : DbContext
    {
        public QuizTakerDbContext(DbContextOptions<QuizTakerDbContext> options)
        : base(options)
        {

        }
        internal DbSet<Answer> Answers { get; set; }
        internal DbSet<Question> Questions { get; set; }
        internal DbSet<Quiz> Quizzes { get; set; }
    }
}
