using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueAndStack
{
    internal abstract class DataStructure
    {
        protected int[] data;

        public int Length => this.data.Length;

        public int this[int index]
        {
            get => this.data[index];
            set => this.data[index] = value;
        }

        protected DataStructure()
        {
            this.data = new int[0];
        }

        public void Push(int value)
        {
            this.data = this.Rewrite();
            this.data[this.data.Length - 1] = value;
        }

        private int[] Rewrite()
        {
            var array = new int[this.Length + 1];

            for (var i = 0; i < this.Length; i++)
                array[i] = this.data[i];

            return array;
        }
    }
}

