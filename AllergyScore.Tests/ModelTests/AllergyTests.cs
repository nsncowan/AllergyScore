using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergyScore;

namespace AllergyScore.Models
{
  [TestClass]
  public class ScoreTests
  {
//     [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    [TestMethod]
    public void ScoreCard_CreateScoreCard_True()
    {
      Score test = new Score("1");
      Assert.AreEqual(1, test.UserInputScore);
    }
}
}

