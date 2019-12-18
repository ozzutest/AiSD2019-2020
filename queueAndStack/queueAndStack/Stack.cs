using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace queueAndStack
{
    class Stack : DataStructure, IMethods
    {
        public int Pop()
        {

            var data = new int[this.Length - 1];

            for (var i = 0; i< this.Length - 1; i++)
                data[i] = this.data[i];

            var result = this.data[this.Length - 1];

            this.data = data;

            return result;
        }

    }
}
