using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Card
    {
        private String title { get; set; }
        private Player owner { get; set; }
        private int price { get; set; }
        private int taxes { get; set; }
        private bool isUpdated { get; set; }
        private List<Player> staying { get; set; }

        public Card( String title, int price, int taxes)
        {
            this.title = title;
            this.price = price;
            this.taxes = taxes;
            this.isUpdated = false;
        }

    }
}
