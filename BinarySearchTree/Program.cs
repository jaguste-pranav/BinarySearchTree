using System;

namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.addToData(56);
            binaryTree.addToData(30);
            binaryTree.addToData(70);

            binaryTree.addToData(22);
            binaryTree.addToData(40);
            binaryTree.addToData(95);

            binaryTree.display(binaryTree.getRoot());
        }
    }
}