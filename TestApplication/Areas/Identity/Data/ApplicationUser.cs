using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
    }
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
    }
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
        public string ShortDescription { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }
        public List<Question> Questions { get; set; }

    }
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        [JsonIgnore]
        public Quiz Quiz { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
    }
    public class QuizTry2 {
        public int Id { get; set; }
        public string Question { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public string Correctans { get; set; }


    }

}
