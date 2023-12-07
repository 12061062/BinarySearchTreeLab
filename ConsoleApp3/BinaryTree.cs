using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST_Example
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        BinaryTreeNode<T> root;

        public void Add(T data)
        {
            if (this.root == null)
            {
                this.root = new BinaryTreeNode<T>(data);
                return;
            }
            Add(this.root, data);
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += "PreOrder: " + PreOrderTraversal(this.root);
            result += "\n\n\n";
            result += "InOrder: " + InOrderTraversal(this.root);
            result += "\n\n\n";
            result += "PostOrder: " + PostOrderTraversal(this.root);
            return result;
        }

        public BinaryTreeNode<T>? FindNode(T data)
        {
            var currentNode = this.root;
            while (currentNode != null)
            {
                if (currentNode.Data.CompareTo(data) == 0)
                {
                    return currentNode;
                }
                else if (currentNode.Data.CompareTo(data) > 0)
                {
                    currentNode = currentNode.Left;
                }
                else if (currentNode.Data.CompareTo(data) < 0)
                {
                    currentNode = currentNode.Right;
                }
            }
            return null;
        }

        public string PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null) return String.Empty;

            string result = node.ToString() + ", ";
            result += PreOrderTraversal(node.Left);
            result += PreOrderTraversal(node.Right);

            return result;
        }

        public string InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null) return String.Empty;

            string result = InOrderTraversal(node.Left);
            result += node.ToString() + ", ";
            result += InOrderTraversal(node.Right);

            return result;
        }

        public string PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null) return String.Empty;

            string result = PostOrderTraversal(node.Left);
            result += PostOrderTraversal(node.Right);
            result += node.ToString() + ", ";

            return result;
        }

        private BinaryTreeNode<T> Add(BinaryTreeNode<T> root, T data)
        {
            if (root == null)
            {
                root = new BinaryTreeNode<T>(data);
            }
            else if (data.CompareTo(root.Data) < 0)
            {
                root.Left = Add(root.Left, data);
            }
            else if (data.CompareTo(root.Data) >= 0)
            {
                root.Right = Add(root.Right, data);
            }
            return root;
        }
    }
}
