using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllergyScore.Models
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ScoreCard_CreateScoreCard_True()
    {
      Score test = new Score("1");
      Assert.AreEqual(1, test.UserInputScore);
    }

    [TestMethod]
    public void AllergyLoop_IterateOverDictionary_allergenList()
    {
      Score test = new Score("1");
      Assert.AreEqual("eggs", test.AllergyLoop()[0]);
      Score test2 = new Score("7");
      Assert.AreEqual("eggs", test2.AllergyLoop()[2]);
      Assert.AreEqual("peanuts", test2.AllergyLoop()[1]);
      Assert.AreEqual("shellfish", test2.AllergyLoop()[0]);
    }
}
}

