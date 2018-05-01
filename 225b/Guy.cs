using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _225b
{
    public class Guy
    {
        public string Name { get; private set; }
        private Bet myBet;
        private int cash;
        private RadioButton myRadioButton;
        private Label myLabel;

        public Guy(string name, int cash, RadioButton myRadioButton, Label myLabel)
        {
            this.Name = name;
            this.cash = cash;
            this.myRadioButton = myRadioButton;
            this.myLabel = myLabel;
            myBet = new Bet(this);
        }               

        public void UpdateLabels()
        {
            myRadioButton.Text = Name + " ma " + cash + " zł";
            myLabel.Text = myBet.GetDescription();
        }            

        public bool PlaceBet(int amount, int dogToWin)
        {
            myBet.Amount = amount;
            myBet.Dog = dogToWin;
            if (amount < this.cash)
            {
                return true;
            }
            else
                return false;
        }

        public void Collect(int winner)
        {
            cash += myBet.PayOut(winner);
        }


    }
}
