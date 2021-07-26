using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public class QuizRepoEf : IQuiz
    {
        protected readonly QuizTakerDbContext _dbContext;

        public QuizRepoEf(QuizTakerDbContext dbContext)
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
