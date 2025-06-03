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
            const string nullPlaceholder = "null"; 
            // Expected format 
            // my_value: left_child_value right_child_value
            return $"{this.Value}: {(this.LeftChild==null? nullPlaceholder:this.LeftChild.Value)} {(this.RightChild == null ? nullPlaceholder : this.RightChild.Value)}";
        }
    }
}
