using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public interface IQuiz
    {
        Quiz GetById(int id);
        List<Quiz> ListAllQuizzes();

    }
}
