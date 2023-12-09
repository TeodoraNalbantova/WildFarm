using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Foods
{
    public abstract class Food
    {
        public int Quantity { get; set; }
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

    }
}
