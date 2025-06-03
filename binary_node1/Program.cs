namespace binary_node1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new BinaryNode<string>("Root");

            // Level 1
            root.AddLeft("A");
            root.AddRight("B");

            // Level 2
            root.LeftChild.AddLeft("C");
            root.LeftChild.AddRight("D");

            root.RightChild.AddRight("E");

            // Level 3
            root.RightChild.RightChild.AddLeft("F");

            Console.WriteLine(root);                    // Root: A B
            Console.WriteLine(root.LeftChild);          // A: C D
            Console.WriteLine(root.RightChild);         // B: null E
            Console.WriteLine(root.LeftChild.LeftChild);// C: null null
            Console.WriteLine(root.LeftChild.RightChild);// D: null null
            Console.WriteLine(root.RightChild.RightChild);// E: F null
            Console.WriteLine(root.RightChild.RightChild.LeftChild);// F: null null

        }
    }
}
