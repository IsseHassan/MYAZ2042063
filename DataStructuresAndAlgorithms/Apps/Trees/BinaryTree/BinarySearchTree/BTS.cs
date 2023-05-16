using DataStructures.Trees.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTree.BinarySearchTree
{
    public class BTS<T> where T:IComparable
    {
        public BinarySearchTreeNode<T> Root { get; set; }
        public BTS()
        {
            Root = null;
        }
        public BTS(BinarySearchTreeNode<T> node)
        {
            Root = node;
        }

        public BTS(IEnumerable<T> collection) : this()
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
