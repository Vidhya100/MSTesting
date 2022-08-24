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
        [TestMethod]
        public void Found_Class_Or_MethodName_With_Default_Constructor()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("Moodanalyzer.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [TestMethod]
        public void Found_Class_Or_MethodName_With_Parameterizd_Constructor()
        {
            object expected = new MoodAnalyzer("Happy");
            object obj = MoodAnalyserFactory1.Refelection_Using_Parameterized_Constructor("Moodanalyzer.MoodAnalyzer", "MoodAnalyzer", "Happy");
            expected.Equals(obj);
        }
    }
}