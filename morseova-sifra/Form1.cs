using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace morseova_sifra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] abeceda = { "", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        string[] morseova = { "|", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..",
                                "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." };

        public Boolean blinkpause = false;
        public String morsecode = "";

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            int[] indexes = {};
            int index;
            String textt = "";
            textOriginal.Text = textOriginal.Text.ToLower().Replace(" ", "");
            textEncoded.Text = textEncoded.Text.ToLower().Replace(" ", "");

            for (int i = 0; i != textOriginal.TextLength; i++)
            {
                index = Array.IndexOf(abeceda, Convert.ToString(textOriginal.Text[i]));
                textt += Convert.ToString(morseova.ElementAt(index));
                textt += "|";
            }
            textEncoded.Text = textt;
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            int[] indexes = {};
            int index = 0;
            String textt = "";
            String textTODECODE = "";
            textOriginal.Text = textOriginal.Text.ToLower().Replace(" ", "");
            textEncoded.Text = textEncoded.Text.ToLower().Replace(" ", "");

            for (int i = 0; i != textEncoded.TextLength; i++)
            {
                if (Convert.ToString(textEncoded.Text[i]) == "|")
                {
                    index = Array.IndexOf(morseova, Convert.ToString(textTODECODE));
                    textt += Convert.ToString(abeceda.ElementAt(index));
                    textTODECODE = "";
                }
                else { textTODECODE += textEncoded.Text[i]; };

            }
            textOriginal.Text = textt;
        }

        private void buttonBlink_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Console.WriteLine("blikaj");
            morsecode = textEncoded.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
            
        {
            Console.WriteLine(morsecode);
            //blnk.BackColor = Color.Black;
            //timer1.Interval = 1000;


            if (blinkpause)
            {
                blnk.BackColor = Color.Black;
                timer1.Interval = 300;
                blinkpause = false;
            }
            else if (morsecode.Equals("")) timer1.Stop();
            else if (morsecode[0].Equals('.'))
            {
                blnk.BackColor = Color.Red;
                timer1.Interval = 200;
                morsecode = morsecode.Substring(1);
                blinkpause = true;
            }
            else if (morsecode[0].Equals('-'))
            {
                blnk.BackColor = Color.Red;
                timer1.Interval = 600;
                morsecode = morsecode.Substring(1);
                blinkpause = true;
            }
            else if (morsecode[0].Equals('|'))
            {
                blnk.BackColor = Color.Black;
                timer1.Interval = 800;
                morsecode = morsecode.Substring(1);
                blinkpause = true;
            }
        }
    }
}

