using System;

namespace QuizDataLibrary
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
    }
}
