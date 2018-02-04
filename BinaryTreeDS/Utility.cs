using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDS
{
    class Utility
    {
        public int findBinaryTreeHeight(BinaryTree tree)
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
    }
}
