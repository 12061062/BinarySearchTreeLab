using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BST_Example
{
    internal class BinaryTreeNode<T> where T : IComparable<T>
    {
        public T Data;
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;
        public BinaryTreeNode<T> Parent;

        public BinaryTreeNode(T Data)
        {
            this.Data = Data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
