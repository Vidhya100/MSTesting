using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moodanalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood()
        {
            //Arrange
            
            string meassage = "\0";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(meassage);
            string ExpectedOutput = "Happy";

            string result = moodAnalyzer.AnalyseMood();

            Assert.AreEqual(result, ExpectedOutput);

        }
    }
}