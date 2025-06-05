using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node1
{
    internal class NaryNode<T>(T value)
    {
        public T Value { get; set; } = value;

        public List<NaryNode<T>> Children { get; set; } = new List<NaryNode<T>>();

        public void AddChild(T value) {        
            Children.Add(new NaryNode<T>(value));
        }

        public override string ToString()
        {
            // my_value: child1_value child2_value child3_value
            
            var sb = new StringBuilder();
            sb.Append($"{Value}: ");
            foreach (var child in Children)
            {
                sb.Append($" {child.Value} ");
            }
            return sb.ToString();
        }

        private string ToString(string spaces)
        {           
            string result = string.Format("{0}{1}:\n", spaces, Value);
          
            foreach (NaryNode<T> child in Children)
                result += child.ToString(spaces + "  ");
            return result;
        }
    }
}
