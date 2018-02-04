using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDS
{
    class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            //            1
            //           / \
            //          2   3
            //         / \
            //        4   5 
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            //Initialize Utility Class to access utility methods
            Utility utility = new Utility();

            //PreOrder Traversal
            Console.Write("PreOrderTraversal: \t");
            utility.PreOrderTraversal(tree);

            //Heigth of tree
            Console.WriteLine("\n\nHeight of Tree : {0}", utility.FindBinaryTreeHeight(tree));

            Console.ReadKey();
        }
    }
}
