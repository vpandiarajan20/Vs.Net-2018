using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SIMON1
{
    public partial class Form1 : Form
    {
        // GLOBAL VARIABLES 
        int score;
        int[] pattern; // 1=G, 2=R, 3=Y, 4=B

        // true if we are supposed to repeat a pattern.
        bool isPlaying = false;
        int currentIndex = 0; // where you are in the pattern.

        SoundPlayer playerG = new SoundPlayer(@"C:\Users\dh.vpandiarajan\Downloads\briefcase-01.wav");
        SoundPlayer playerR = new SoundPlayer(@"C:\Users\dh.vpandiarajan\Downloads\coin2.wav");
        SoundPlayer playerY = new SoundPlayer(@"C:\Users\dh.vpandiarajan\Downloads\boing_spring.wav");
        SoundPlayer playerB = new SoundPlayer(@"C:\Users\dh.vpandiarajan\Downloads\beep-05.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            UpdateScore(0);
            pattern = new int[100];
            Random rng = new Random();
            // For loop through all of pattern array.
            for (int i = 0; i < 100; i++)
                pattern[i] = rng.Next(1, 5);// 1-4
            PlayPattern(0);
            isPlaying = true;
        }// End bStart
        public void PlayPattern(int upToIndex)
        {
            for (int i = 0; i <= upToIndex; i++)
                PlayColor(pattern[i]);
        }
        // Animate a button Press.
        public void PlayColor(int color)
        {
            if (color == 1)
            {
                // Green
                bGreen.BackColor = Color.Black;
                bGreen.Update(); // Refresh
                playerG.Play(); // play the sound
                System.Threading.Thread.Sleep(700);//stall
                bGreen.BackColor = Color.Green;
                bGreen.Update();
            }
            if (color == 2)
            {
                // Red
                bRed.BackColor = Color.Black;
                bRed.Update(); // Refresh
                playerR.Play(); // play the sound
                System.Threading.Thread.Sleep(700);//stall
                bRed.BackColor = Color.Red;
                bRed.Update();
            }
            if (color == 3)
            {
                // Yellow
                bYellow.BackColor = Color.Black;
                bYellow.Update(); // Refresh
                playerY.Play(); // play the sound
                System.Threading.Thread.Sleep(700);//stall
                bYellow.BackColor = Color.Yellow;
                bYellow.Update();
            }
            if (color == 4)
            {
                // Blue
                bBlue.BackColor = Color.Black;
                bBlue.Update(); // Refresh
                playerB.Play(); // play the sound
                System.Threading.Thread.Sleep(700);//stall
                bBlue.BackColor = Color.Blue;
                bBlue.Update();
            }
        }
        // Associate sounds with numberws. 1 => green sound.
        public void PlaySound(int colorNumber)
        {
            if (colorNumber == 1)
                playerG.Play();
            if (colorNumber == 2)
                playerR.Play();
            if (colorNumber == 3)
                playerY.Play();
            if (colorNumber == 4)
                playerB.Play();
        }
        // CheckInput() checks to see what color the user 
        // entered, and match it with the pattern array.
        // Needs to be in the playing mode.
        public bool CheckInput(int userSelection, int index)
        {
            if (isPlaying == false)
                return false;
            // we may assume we're in playing mode.
            return (userSelection == pattern[index]);
        }
        public void ButtonPressed(int buttonNumber)
        {
            // This function should be called every time
            // you press a button.
            if (isPlaying == false)
            {
                // we're not playing, just pressing randomly
                PlaySound(buttonNumber);
                return; // ends function.
            }
            // We may assume we are in playing mode.
            if (CheckInput(buttonNumber, currentIndex))
            {
                // We made a match in the pattern!
                currentIndex++;
                if (currentIndex > score)
                {
                    //matched the whole pattern
                    UpdateScore(score + 1);
                    currentIndex = 0;
                    if (score > 99)
                    {
                        // end game at win.
                        UpdateScore(0);
                        lScore.Text = "Win";
                        isPlaying = false;
                    }
                    else
                        PlayPattern(score);
                }// If currentIndex > score
            }// If CheckInput() is true
            else
            {
                // CheckInput() is false.
                MessageBox.Show("You lose, press start to try again!");
                isPlaying = false;
                UpdateScore(0);
                currentIndex = 0;
            } // Ends the CheckInput() is false

        }// Ends the ButtonPressed()

        private void UpdateScore(int newScore)
        {
            score = newScore;
            lScore.Text = newScore.ToString();
        }
        private void bGreen_Click(object sender, EventArgs e)
        {
            // increase score by 1
            ButtonPressed(1);
        }

        private void bRed_Click(object sender, EventArgs e)
        {
            ButtonPressed(2);
        }

        private void bYellow_Click(object sender, EventArgs e)
        {
            ButtonPressed(3);
        }

        private void bBlue_Click(object sender, EventArgs e)
        {
            ButtonPressed(4);
        }

        private void bgreen_Click(object sender, EventArgs e)
        {

        }
    }
}

