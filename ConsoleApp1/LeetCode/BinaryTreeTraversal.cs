using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class BinaryTreeTraversal
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public void Test()
        {
            /*
             * Given the root of a binary tree, return the inorder traversal of its nodes' values.
             */

            // Create a binary tree
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            // Perform inorder traversal iteratively
            IList<int> resultIterative = InorderTraversalIterative(root);

            // Perform inorder traversal recursively
            IList<int> resultRecursive = InorderTraversalRecursive(root);

            // Print the results
            Console.WriteLine("Inorder Traversal (Iterative): " + string.Join(", ", resultIterative));
            Console.WriteLine("Inorder Traversal (Recursive): " + string.Join(", ", resultRecursive));
        }

        public IList<int> InorderTraversalIterative(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }

            return result;
        }

        public IList<int> InorderTraversalRecursive(TreeNode root)
        {
            List<int> result = new List<int>();
            InorderTraversalHelper(root, result);
            return result;
        }

        private void InorderTraversalHelper(TreeNode node, List<int> result)
        {
            if (node == null)
                return;

            InorderTraversalHelper(node.left, result);
            result.Add(node.val);
            InorderTraversalHelper(node.right, result);
        }

        public void InoderTraverse(TreeNode node, List<int> result)
        {
            if (node == null)
                return;

            InoderTraverse(node.left, result);
            result.Add(node.val);
            InoderTraverse(node.right, result);

        }
    }
}
