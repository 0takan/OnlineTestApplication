﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDataLibrary
{
    public interface IAnswer
    {
        Answer GetById(int id);
        List<Answer> GetAllAnswer();
    }
}
