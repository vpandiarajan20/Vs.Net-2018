using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // ADD THIS!!!

namespace S_i_m_o_n
{
    public partial class Form1 : Form
    {
        // GLOBAL VARIABLES 
        int score;
        int[] pattern; // 1=G, 2=R, 3=Y, 4=B

        // true if we are supposed to repeat a pattern.
        bool isPlaying = false;
        int currentIndex = 0; // where you are in the pattern.

        SoundPlayer playerG = new SoundPlayer(@"\\dvhs-fs\DH-Teacher\akim\Downloads\briefcase-01.wav");
        SoundPlayer playerR = new SoundPlayer(@"\\dvhs-fs\DH-Teacher\akim\Downloads\coin2.wav");
        SoundPlayer playerY = new SoundPlayer(@"\\dvhs-fs\DH-Teacher\akim\Downloads\boing_spring.wav");
        SoundPlayer playerB = new SoundPlayer(@"\\dvhs-fs\DH-Teacher\akim\Downloads\beep-05.wav");

        public Form1()
        {
            InitializeComponent();
        }

    }
}

