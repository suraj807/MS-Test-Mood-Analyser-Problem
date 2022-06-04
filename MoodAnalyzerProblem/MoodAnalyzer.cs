﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message) // creating a constructor with one string parameter
        {
            this.message = message; // Assigning value to local variable
        }
        public string AnalyzeMood() // Creating method to find mood based on message
        {
            try
            {
                if (message.ToLower().Contains("sad")) // If message contains sad word then return sad mood else return happy mood
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException ex)
            {
                return "HAPPY";
            }

        }
    }
}