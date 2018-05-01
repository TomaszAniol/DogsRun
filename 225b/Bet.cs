using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _225b
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        private Guy bettor;

        public Bet(Guy bettor)
        {
            this.bettor = bettor;
        }

        public string GetDescription()
        {
            if (Amount > 0)
            {
                return (bettor.Name + " stawia " + Amount + " zł na charta numer " + (Dog + 1));
            }
            else
                return (bettor.Name + " nie zawarł zakładu");
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
                return -Amount;
        }
    }
}
