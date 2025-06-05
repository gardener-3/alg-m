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

            Console.WriteLine(root); 
           

        }
    }
}
