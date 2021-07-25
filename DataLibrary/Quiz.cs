using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLibrary
{
    public class Quizzes
    {
        public int CardsId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string QuizName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string img { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string descrition { get; set; }
    }
}
