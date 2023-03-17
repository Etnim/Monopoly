using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Player
    {
        String name;
        int money;
        List<Card> cards;

        public Player(String name, int money)
        {
            this.name = name;
            this.money = money;
        }
    }
}
