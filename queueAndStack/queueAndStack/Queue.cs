using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueAndStack
{
    class Queue : DataStructure, IMethods
    {
        public int Pop()
        {

            var data = new int[this.Length - 1];

            for (var i = 0; i < this.Length - 1; i++)
                data[i] = this.data[i + 1];

            var result = this.data[0];

            this.data = data;

            return result;
        }
    }
}
