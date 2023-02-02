using System.Collections.Generic;

namespace AllergyScore.Models
{
  public class Score
  {
    public Dictionary<string, int> ScoreCard = new Dictionary<string, int>()
    {
      {"cats",128},
      {"pollen",64},
      {"chocolate",32},
      {"tomatoes",16},
      {"strawberries",8},
      {"shellfish", 4},
      {"peanuts", 2},
      {"eggs", 1}
    };

    public int UserInputScore;
    public Score(string input)
    {
      string stringInput = input;
      int intInput = int.Parse(stringInput);
      UserInputScore = intInput;
    }

    public List<string> AllergyLoop()
    {
      int x = UserInputScore;
      List<string> allergenList = new List<string>{};
      foreach (var item in ScoreCard)
      {
        if (x >= item.Value)
        {
          allergenList.Add(item.Key);
          x -= item.Value;
        }
        else 
        {
        }
      }
      return allergenList;
    }
  }
}
