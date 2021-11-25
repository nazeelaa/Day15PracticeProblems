using System;

namespace Day15BinarySearch_UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program.");
            BinaryTree binarytree = new BinaryTree();

            binarytree.Add(56);
            binarytree.Add(30);
            binarytree.Add(70);
            binarytree.Add(22);
            binarytree.Add(40);
            binarytree.Add(60);
            binarytree.Add(95);
            binarytree.Add(11);
            binarytree.Add(65);
            binarytree.Add(3);
            binarytree.Add(16);
            binarytree.Add(63);
            binarytree.Add(67);

            Console.Write("\n Inorder result : ");
            binarytree.Inorder(binarytree.root);
            Console.WriteLine();

            Console.Write("\n Post-order result : ");
            binarytree.Postorder(binarytree.root);
            Console.WriteLine();

            Console.Write("\n Pre-order result : ");
            binarytree.Preorder(binarytree.root);
            Console.WriteLine();
        }
    }
}
