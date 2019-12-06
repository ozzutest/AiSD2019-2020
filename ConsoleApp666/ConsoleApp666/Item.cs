using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Item
    {
        public int value;
        
        public Item(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
