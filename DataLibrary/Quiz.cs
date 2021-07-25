using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLibrary
{
    public class Quiz
    {
        public int QuizId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string QuizName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string QuizImg { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }
    }
}
