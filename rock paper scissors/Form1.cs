using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors
{
    public partial class Form1 : Form
    {
        //zapocet novu igru
        Game igra = new Game();

        //Images Sources 
        public string papir = "C:/Users/vela/Desktop/skola/Hrastnik/OOP/rock paper scissors/paper.jpg";
        public string skarje = "C:/Users/vela/Desktop/skola/Hrastnik/OOP/rock paper scissors/scissors.jpg";
        public string kamen = "C:/Users/vela/Desktop/skola/Hrastnik/OOP/rock paper scissors/rock.jpg";

        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            igra.Play();

            //making sure picture looks fine
            player1.SizeMode = PictureBoxSizeMode.StretchImage;
            player2.SizeMode = PictureBoxSizeMode.StretchImage;


            //PICTURE for Player 1
            if(igra.Player1State == 0)
            {
                player1.Image = Image.FromFile(papir);
            } else if(igra.Player1State == 1)
            {
                player1.Image = Image.FromFile(kamen);
            } else if (igra.Player1State == 2)
            {
                player1.Image = Image.FromFile(skarje);
            }

            //PICTURE for Player 2
            if (igra.Player2State == 0)
            {
                player2.Image = Image.FromFile(papir);
            }
            else if (igra.Player2State == 1)
            {
                player2.Image = Image.FromFile(kamen);
            }
            else if (igra.Player2State == 2)
            {
                player2.Image = Image.FromFile(skarje);
            }




            //vrijednosti u labelima
            //SCORE
            player1ScoreLabel.Text = igra.Player1Score.ToString();
                Player2ScoreLabel.Text = igra.Player2Score.ToString();

                //HIGH SCORE 
                player1HighScore.Text = igra.Player1HighScore.ToString();
                player2HighScore.Text = igra.Player2HighScore.ToString();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //change value
            igra.Player1Score = 0;
            igra.Player2Score = 0;

            //show value
            player1ScoreLabel.Text = igra.Player1Score.ToString();
            Player2ScoreLabel.Text = igra.Player2Score.ToString();
        }
    }
}
