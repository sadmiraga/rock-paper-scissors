using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 0  = PAPIR 
// 1  = KAMEN 
// 2  = SKARJE 



namespace rock_paper_scissors
{
    class Game:HelperClass
    {
        //data
        public int Player1Score = 0;
        public int Player2Score = 0;

        public int Player1State { get; set; }
        public int Player2State { get; set; }

        public  int Player1HighScore { get; set; }
        public  int Player2HighScore { get; set; }

        //PRI WINNERU JE :
        // 0: DRAW
        // 1: PLAYER 1
        // 2: PLAYER 2
        public int winner = 2;

        public int Play()
        {
            //both players get pick values
            int prvi = GetState();
            Player1State = prvi;

            int drugi = GetState();
            Player2State = drugi;

            //provjerit ko je pobjedio


            //PAPIR 
            if(Player1State == 0)
            {
                //PAPIR
                if(Player2State == 1)
                {
                    //PLAYER 1 WINS
                    Player1Score++;

                    //NOVI HIGHSCORE
                    if(Player1Score > Player1HighScore)
                    {
                        Player1HighScore = Player1Score;
                    }


                    winner = 1;
                    return winner;

                } else if(Player2State == 0)
                {
                    //DRAW
                    winner = 0;
                    return winner;

                } else
                {
                    //PLAYER 2 WINS
                    Player2Score++;

                    //NEW HIGH SCORE
                    if(Player2Score> Player2HighScore)
                    {
                        Player2HighScore = Player2Score;
                    }

                    winner = 2;
                    return winner;
                }

            } else if(Player1State == 1)
            {
                //KAMEN
                if(Player2State == 2)
                {
                    //PLAYER 1 WINS
                    Player1Score++;
                    //NEW HIGH SCORE
                    if(Player1Score > Player1HighScore)
                    {
                        Player1HighScore = Player1Score;
                    }

                    winner = 1;
                    return winner;

                } else if (Player2State == 1)
                {
                    //DRAW
                    winner = 0;
                    return winner;

                } else 
                {
                    //PLAYER 2 WINS 
                    Player2Score++;
                    //NEW HIGH SCORE 
                    if(Player2Score> Player2HighScore)
                    {
                        Player2HighScore = Player2Score;
                    }

                    winner = 2;
                    return winner;
                }

            } else
            {
                //SKARJE
                if(Player2State == 0)
                {
                    //PLAYER 1 WINS
                    Player1Score++;
                    //NEW HIGH SCORE 
                    if(Player1Score > Player1HighScore)
                    {
                        Player1HighScore = Player1Score;
                    }


                    winner = 1;
                    return winner;

                } else if (Player2State == 2)
                {
                    //DRAW
                    winner = 0;
                    return winner;

                } else 
                {
                    //PLAYER 2 WINS
                    Player2Score++;
                    //NEW HIGH SCORE 
                    if(Player2Score> Player2HighScore)
                    {
                        Player2HighScore = Player2Score;
                    }

                    winner = 2;
                    return winner;
                }

            }

           
        }

    }
}
