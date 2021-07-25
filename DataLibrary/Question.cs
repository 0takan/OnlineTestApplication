using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary
{
   public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        [JsonIgnore]
        public Quiz Quiz { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
