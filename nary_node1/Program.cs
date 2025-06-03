namespace nary_node1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new NaryNode<string>("Root");
            root.AddChild("A");
            root.AddChild("B");
            root.AddChild("C");

            var aNode = root.Children[0];
            aNode.AddChild("D");
            aNode.AddChild("E");

            var cNode = root.Children[2];
            cNode.AddChild("F");

            var dNode = aNode.Children[0];
            dNode.AddChild("G");

            var fNode = cNode.Children[0];
            fNode.AddChild("H");
            fNode.AddChild("I");

            // Print the immediate children of root
            Console.WriteLine(root); // Root: A B C
            Console.WriteLine(aNode); // A: D E
            Console.WriteLine(root.Children[1]);
            Console.WriteLine(cNode); // C: F
            Console.WriteLine(dNode); // D: G
            Console.WriteLine(aNode.Children[1]);
            Console.WriteLine(fNode); // F: H I
            Console.WriteLine(dNode.Children[0]);
            Console.WriteLine(fNode.Children[0]);
            Console.WriteLine(fNode.Children[1]);
        }
    }
}
