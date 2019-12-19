using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeClass
{
    class Node
    {
        public Node parent;
        public Node left;
        public Node right;
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
    class Tree
    {
        public Node root;
        public int length;
        public int depth;
        public Tree(int value)
        {
            this.root = new Node(value);
            this.length = 1;
            this.depth = 0;
        }
        public Node FindParent(int number)
        {
            List<int> path = new List<int>();
            while (number > 0)
            {
                number = number / 2;
                path.Add(number);
            }
            path.Reverse();
            var parent = this.root;
            for (int i = 1; i < path.Count; i++)
            {
                // path = num % 2 == 1 ? parent.left : parent.right;
                if (path[i] % 2 == 1)
                    parent = parent.left;
                else
                    parent = parent.right;
            }
            return parent;
        }

        public void Push(int value)
        {
            var child = new Node(value);
            var parent = this.FindParent(this.length);
            child.parent = parent;
            if (this.length % 2 == 1)
                parent.left = child;
            else
                parent.right = child;

            this.length++;
            // this.depth 
            List<int> path = new List<int>();
            int i = this.length - 1;
            while (i > 0)
            {
                --i;
                i = i / 2;
                path.Add(i);
            }
            this.depth = path.Count();

        }
        public string ShowPre(Node x)
        {
            if (x == null)
                return "";

            string result = x.value.ToString();

            result += this.ShowPre(x.left);

            result += this.ShowPre(x.right);

            return result;
        }

        public string ShowIn(Node x)
        {
            if (x == null)
                return "";

            string result = string.Empty;

            result += this.ShowIn(x.left);

            result = x.value.ToString();

            result += this.ShowIn(x.right);

            return result;
        }

        public string ShowPost(Node x)
        {
            if (x == null)
                return  "";

            string result = string.Empty;

            result += this.ShowPost(x.left);

            result += this.ShowPost(x.right);

            result = x.value.ToString();

            return result;
        }

        public override string ToString() => this.ShowPre(this.root);

    }

}
