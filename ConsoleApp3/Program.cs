namespace BST_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            tree.Add("1 Captain Underpants");
            tree.Add("2 Ready Player One");
            tree.Add("3 Dune");
            tree.Add("4 The Silver Eyes");
            tree.Add("5 Moby Dick");

            Console.WriteLine(tree);

            tree.Add("6 Eldest");
            tree.Add("7 Eggplant");

            Console.ReadLine();

            var foundNode = tree.FindNode("5 Moby Dick");

            Console.WriteLine(foundNode == null ? "Not found" : "Found");

            Console.WriteLine(tree);
        }
    }
}