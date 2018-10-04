using System;

namespace SimplyBinaryTreeWithoutBalancing
{
    class TreeStartup
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();

            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(6);
            tree.Add(2);
            tree.Add(7);
            tree.Add(1);
            tree.Add(12);
            tree.Add(13);
            tree.Add(20);
            tree.Add(11);
            tree.Add(25);
            tree.Add(19);

            Console.Write("Print sorted (Inorder DFS traversal): ");
            tree.PrintSorted();

            Console.Write("Print Postorder DFS traversal: ");
            tree.PrintPost();

            Console.Write("Print Preorder DFS traversal: ");
            tree.PrintPre();
        }
    }
}
