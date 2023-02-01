using System; 
using System.Collections.Generic;
using LINQ;


namespace AllergyScore.Models
{
public class Score
{
Dictionary<string, int> ScoreCard = new Dictionary<string, int>()
{
{"eggs", 1},
{"peanuts", 2},
{"shellfish", 4},
{"strawberries",8},
{"tomatoes",16},
{"chocolate",32},
{"pollen",64},
{"cats",128}
};

public int UserInputScore;
public Score(string input){
  string stringInput = input;
  int intInput = int.Parse(stringInput);
  UserInputScore = intInput;
}

// Starting: 90 
// 128 > 90 : go to the next index
// 64 < 90 : push pollen, subtract 64, go to the next index
// 32 > 26 : go to the next index
// 16 < 26: push tomatoes, subtract 16, go tot he next index
// 8 < 10 : go to the next index

public List<string> AllergenLoop()
{
  for (int i=0; )
}

}


  
}
