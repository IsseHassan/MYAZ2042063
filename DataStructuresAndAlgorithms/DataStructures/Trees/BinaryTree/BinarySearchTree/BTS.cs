using DataStructures.Trees.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTree.BinarySearchTree
{
    public class BST<T> where T:IComparable
    {
        public BinarySearchTreeNode<T> Root { get; set; }
        public BST()
        {
            Root = null;
        }
        public BST(BinarySearchTreeNode<T> node)
        {
            Root = node;
        }

        public BST(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T value)
        {
            var newNode = new BinarySearchTreeNode<T>(value);

            if(Root  is null)
            {
                Root = newNode;
                return;
            }

            var current = Root;
            BinarySearchTreeNode<T> parent;
            while (true)
            {
                parent = current;

                //Left-side
                if (value.CompareTo(current.Value) < 0)
                {
                    if(current is null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }

                else
                {
                    current = current.Right;
                    if(current is null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }

    }
}
