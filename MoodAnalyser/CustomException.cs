﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class CustomException : Exception
    {
        public CustomException(string Message) : base(Message) 
        {

        }
    }
}
