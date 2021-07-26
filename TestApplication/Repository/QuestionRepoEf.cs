using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Areas.Identity.Data;
using TestApplication.Data;

namespace QuizDataLibrary
{
    public class QuestionRepoEf : IQuestion
    {
        protected readonly AuthDbContext _dbContext;
        public QuestionRepoEf(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Question GetById(int id)
        {
            return ListAllQuestions()
                .Where(a => a.QuestionId == id)
                .FirstOrDefault();
        }

        public List<Question> ListAllQuestions()
        {
            return _dbContext.Questions.ToList();
        }
    }
}
