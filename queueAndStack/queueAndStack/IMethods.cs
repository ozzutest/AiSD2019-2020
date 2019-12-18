using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueAndStack
{
    interface IMethods
    {
        int Length { get; }

        int Pop();

        void Push(int value);
    }
}
