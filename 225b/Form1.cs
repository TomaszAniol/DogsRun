using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _225b
{
    public partial class Form1 : Form
    {

        Greyhound[] GreyhoundArray;
        Guy[] GuyArray;
        Random random;
        int RadioButoonIndex;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
            Initial();
        }

        public void Initial()
        {
            
            GreyhoundArray = new Greyhound[4];
            GreyhoundArray[0] = new Greyhound(raceTrack.Width, dog1, random);
            GreyhoundArray[1] = new Greyhound(raceTrack.Width, dog2, random);
            GreyhoundArray[2] = new Greyhound(raceTrack.Width, dog3, random);
            GreyhoundArray[3] = new Greyhound(raceTrack.Width, dog4, random);
            
            GuyArray = new Guy[3];
            GuyArray[0] = new Guy("Janek", 50, janekRadioButton, janekBetLabel);
            GuyArray[1] = new Guy("Bartek", 75, bartekRadioButton, bartekBetLabel);
            GuyArray[2] = new Guy("Arek", 45, arekRadioButton, arekBetLebel);

            for (int i = 0; i < GuyArray.Length; i++)
            {
                GuyArray[i].UpdateLabels();
            }
        }

        private void janekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[0].Name;
            RadioButoonIndex = 0;
        }

        private void bartekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[1].Name;
            RadioButoonIndex = 1;
        }

        private void arekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = GuyArray[2].Name;
            RadioButoonIndex = 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer2.Start();
            startButton.Enabled = false;
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            GuyArray[RadioButoonIndex].PlaceBet((int)betNumericUpDown.Value, (int)dogNumericUpDown.Value - 1);
            GuyArray[RadioButoonIndex].UpdateLabels();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer2.Stop();
                    PayOut(i);
                    
                }
            }
        }

        public void PayOut(int Winner)
        {
            for (int i = 0; i < GuyArray.Length; i++)
            {
                GuyArray[i].Collect(Winner);
                GuyArray[i].UpdateLabels();                              
            }

            MessageBox.Show("Wygrał pies: " + (Winner + 1));

            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                GreyhoundArray[i].TakeStartPosition();
            }

            startButton.Enabled = true;
        }
    }
}
