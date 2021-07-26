﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public class AnswerRepoEf : IAnswer
    {
        private readonly QuizTakerDbContext _dbcontext;
        public List<Answer> GetAllAnswer()
        {
            return _dbcontext.Answers
                .ToList();
        }

        public Answer GetById(int id)
        {
            return GetAllAnswer()
                .Where(a => a.AnswerId == id)
                .FirstOrDefault();
        }
    }
}