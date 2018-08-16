using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinaryTree
    {
        TreeNode<int> root;
        public BinaryTree()
        {
            root = CreateTree();
        }
        public TreeNode<int> CreateTree()
        {
            int x;
            if(!int.TryParse(Console.ReadLine(),out x))
            {
                throw new Exception("Not An int");
            }
            
            if (x == -1)
            {
                return null;
            }
            TreeNode<int> newTreeNode = new TreeNode<int>(x);
            Console.WriteLine("Enter the left child of" + x);
            newTreeNode.SetLeft(CreateTree());
            Console.WriteLine("Enter the right child of" + x);
            newTreeNode.SetRight(CreateTree());
            return newTreeNode;
        }
        public void PrintInOrder()
        {
            this.PrintInOrder(root);
        }
        private void PrintInOrder(TreeNode<int> root)
        {
            if (root == null) return;
            PrintInOrder(root.GetLeft());
            Console.Write(root.GetData() + " ");
            PrintInOrder(root.GetRight());
        }
        public void PrintPreOrder()
        {
            this.PrintPreOrder(root);
        }
        private void PrintPreOrder(TreeNode<int> root)
        {
            if (root == null) return;
            Console.Write(root.GetData() + " ");
            PrintPreOrder(root.GetLeft());
            PrintPreOrder(root.GetRight());
        }
        public void PrintPostOrder()
        {
            this.PrintPostOrder(root);
        }
        private void PrintPostOrder(TreeNode<int> root)
        {
            if (root == null) return;
            PrintPostOrder(root.GetLeft());
            PrintPostOrder(root.GetRight());
            Console.Write(root.GetData() + " ");

        }
        public void PrintLevelOrder()
        {
            this.PrintLevelOrder(root);
        }
        private void PrintLevelOrder(TreeNode<int> root)
        {
            const TreeNode<int> MARKER = null;
            if (root == null)
            {
                return;
            }
            Queue<TreeNode<int>> displayQueue = new Queue<TreeNode<int>>();
            displayQueue.Enqueue(root);
            displayQueue.Enqueue(MARKER);

            while (displayQueue.Count != 0)
            {
                TreeNode<int> currentNode = displayQueue.Dequeue();
                if (currentNode == MARKER)
                {
                    Console.WriteLine();
                    if (displayQueue.Count != 0) displayQueue.Enqueue(MARKER);
                    continue;
                }
                Console.Write(currentNode.GetData() + " ");
                if (currentNode.GetLeft() != null)
                {
                    displayQueue.Enqueue(currentNode.GetLeft());
                }
                if (currentNode.GetRight() != null)
                {
                    displayQueue.Enqueue(currentNode.GetRight());
                }
            }

        }
    }
}
