using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public interface IQuestion
    {
        Question GetById(int id);
        List<Question> ListAllQuestions();

    }
}
