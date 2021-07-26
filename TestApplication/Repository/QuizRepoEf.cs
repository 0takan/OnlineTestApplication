using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Areas.Identity.Data;
using TestApplication.Data;

namespace QuizDataLibrary
{
    public class QuizRepoEf : IQuiz
    {
        protected readonly AuthDbContext _dbContext;

        public QuizRepoEf(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Quiz GetById(int id)
        {
            return ListAllQuizzes()
               .Where(a => a.QuizId == id)
               .FirstOrDefault();
        }

        public List<Quiz> ListAllQuizzes()
        {
            return _dbContext.Quizzes.ToList();
        }
    }
}
