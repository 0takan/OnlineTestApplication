using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public class QuestionRepoEf : IQuestion
    {
        protected readonly QuizTakerDbContext _dbContext;
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
