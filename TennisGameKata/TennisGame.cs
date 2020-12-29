using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGameKata
{
    public class TennisGame
    {
        private string score;
        private string playerOne = "Love";
        private string playerTwo = "Love";

        public String Score()
        {
            if (playerOne == "win")
            {
                score = "Player One Wins";
            }
            else if (playerTwo == "win")
            {
                score = "Player Two Wins";
            }
            else
            {
                if (playerOne == "adv")
                {
                    if (playerTwo == "adv")
                    {
                        playerOne = "40";
                        playerTwo = "40";
                        score = "Deuce";
                    }
                    else
                    {
                        score = "Advantage Player One";
                    }
                }
                else if (playerTwo == "adv")
                {
                    if (playerOne == "adv")
                    {
                        playerOne = "40";
                        playerTwo = "40";
                        score = "Deuce";
                    }
                    else
                    {
                        score = "Advantage Player Two";
                    }
                }
                else if (playerOne == "40" && playerTwo == "40")
                {
                    score = "Deuce";
                }
                else if (playerOne == playerTwo)
                {
                    score = playerOne + " all";
                }
                else
                {
                    score = playerOne + " : " + playerTwo;
                }
            }

            return score;
        }

        public void PlayerOneWinsBall()
        {
            playerOne = PlayerWinsBall(playerOne);
        }

        public void PlayerTwoWinsBall()
        {
            playerTwo = PlayerWinsBall(playerTwo);
        }

        private string PlayerWinsBall(String Player)
        {
            if (Player == "Love")
            {
                Player = "15";
            }
            else if (Player == "15")
            {
                Player = "30";
            }
            else if (Player == "30")
            {
                Player = "40";
            }
            else if (Player == "40")
            {
                Player = "adv";
            }
            else if (Player == "adv")
            {
                Player = "win";
            }
            return Player;
        }
    }
}
