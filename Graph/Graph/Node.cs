using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Node
    {
        public int value;

        public Node(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}