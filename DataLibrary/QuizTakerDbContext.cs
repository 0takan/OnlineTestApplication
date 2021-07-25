using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class QuizTakerDbContext : DbContext
    {
        public QuizTakerDbContext(DbContextOptions<QuizTakerDbContext> options)
        : base(options)
        {
        }

        public DbSet<Quiz> Quizzes { get; set; }
    }
}
