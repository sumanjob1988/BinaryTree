using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDS
{
    class Utility
    {
        #region Height of Binary Tree
        /// <summary>
        /// Finds the height of the binary tree.
        /// </summary>
        /// <param name="tree">The tree.</param>
        /// <returns>Height of Binary Tree.</returns>
        public int FindBinaryTreeHeight(BinaryTree tree)
        {
            return height(tree.root);
        }
        private int height(Node root)
        {
            if (root == null) return 0;
            int leftHeight = height(root.left) + 1;
            int rightHeight = height(root.right) + 1;
            if (leftHeight > rightHeight)
                return leftHeight;
            else
                return rightHeight;
        }
        #endregion

        #region PreOrder Traversal
        /// <summary>
        /// Pre Order traversal.
        /// </summary>
        /// <param name="tree">The tree.</param>
        public void PreOrderTraversal(BinaryTree tree)
        {
            preOrderTraversal(tree.root);
        }

        private void preOrderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + "\t");
            preOrderTraversal(root.left);
            preOrderTraversal(root.right);
        } 
        #endregion
    }
}
