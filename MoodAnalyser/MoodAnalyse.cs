using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        string message;

        public MoodAnalyse() 
        {

        }
        public MoodAnalyse(string message) 
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

        public string mood = "No Mood";
        public void CustomMood(string mood)
        {
            if (mood.Contains("Any"))
            {
                throw new CustomException("I am in Any Mood");
            }
            else
            {
                Console.WriteLine("Mood : "+mood); ;
            }
        }
    }
}
