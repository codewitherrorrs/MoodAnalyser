using MoodAnalyser;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyse moodAnalyse = new MoodAnalyse();
        [Test]
        public void Return_Mood_Sad()
        {
            string result = moodAnalyse.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(result,"Sad");
        }

        [Test]
        public void Return_Mood_Happy()
        {
            string result = moodAnalyse.AnalyseMood("I am in Any Mood");
            Assert.AreEqual(result, "Happy");
        }

        [Test]
        public void Return_Mood_Sad_Constructor()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }

        [Test]
        public void Return_Mood_Happy_Constructor()
        {
            string result = moodAnalyse.AnalyseMood("I am in Any Mood");
            Assert.AreEqual(result, "Happy");
        }


    }
}