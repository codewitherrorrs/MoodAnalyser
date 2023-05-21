using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MoodAnalyse moodanalyse = new MoodAnalyse();
                string mood = moodanalyse.AnalyseMood("I am in Null mood");
                Console.WriteLine($"mood is : {mood}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception is : {ex.Message}");
            }
        }
    }
}
