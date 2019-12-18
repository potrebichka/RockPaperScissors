using System;
using System.Collections.Generic;
namespace RPS.Models 
{
    public class Game
    {
        public static string CheckWinner(string choice1, string choice2)
        {

            if (choice1 == choice2) {
                return "Draw";
            } else {
                Dictionary<string, string> playerDict = new Dictionary<string, string>() {};
                playerDict.Add(choice1, "Player1");
                playerDict.Add(choice2, "Player2");
                string[] choiceList = {choice1, choice2};
                Array.Sort(choiceList);

                if (choiceList[0] == "Rock" && choiceList[1] == "Scissors") 
                {
                    return playerDict[choiceList[0]];
                }
                else if (choiceList[0] == "Paper" && choiceList[1] == "Rock")
                {
                    return playerDict[choiceList[0]];
                }
                else if (choiceList[0] == "Paper" && choiceList[1] == "Scissors")
                {
                    return playerDict[choiceList[1]];
                }
            }
            return "";
        }
    } 
}