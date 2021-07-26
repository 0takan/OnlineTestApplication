using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public class Quiz
    {
        public Quiz()
        {
            Questions = new List<Question>();
        }
        public int QuizId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string QuizName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string QuizImg { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }
        public List<Question> Questions { get; set; }

    }
}
