using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _225b
{
    public class Greyhound
    {
        private readonly Point startingPosition;
        private int raceTrackLength;
        private PictureBox myPictureBox = null;
        private Random myRandom;

        public Greyhound(int raceTrackLength, PictureBox myPictureBox, Random random)
        {
            this.startingPosition = myPictureBox.Location;
            this.raceTrackLength = raceTrackLength;
            this.myPictureBox = myPictureBox;
            this.myRandom = random;
        }

        public bool Run()
        {            
            myPictureBox.Left += myRandom.Next(5, 15);
            
            if (myPictureBox.Left > raceTrackLength - myPictureBox.Width)
            {
                return true;
            }
            else
                return false;
        }

        public void TakeStartPosition()
        {
            myPictureBox.Location = startingPosition;
        }
    }
}
