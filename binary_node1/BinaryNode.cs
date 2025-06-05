using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node1
{
    internal class BinaryNode<T>(T value)
    {
        public T Value { get; set; } = value;

        public BinaryNode<T> LeftChild { get; set; } = null;

        public BinaryNode<T> RightChild { get; set; } = null;

        public void AddLeft(T value)
        {
            this.LeftChild = new BinaryNode<T>(value);
        }
        public void AddRight(T value)
        {
            this.RightChild = new BinaryNode<T>(value);
        }

        public override string ToString()
        {
            return ToString("");
        }

        private string ToString(string spaces)
        {
            string result = string.Format("{0}{1}:\n", spaces, Value);

            // See if the node has any children.
            if ((LeftChild != null) || (RightChild != null))
            {
                // Add null or the child's value.
                if (LeftChild == null)
                    result += string.Format("{0}{1}null\n", spaces, "  ");
                else
                    result += LeftChild.ToString(spaces + "  ");

                // Add null or the child's value.
                if (RightChild == null)
                    result += string.Format("{0}{1}null\n", spaces, "  ");
                else
                    result += RightChild.ToString(spaces + "  ");
            }
            return result;
        }

    }
}
