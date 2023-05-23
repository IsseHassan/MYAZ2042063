using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees.BinaryTree
{
    public class BinaryTree<T> : IEnumerable where T : IComparable<T>
    {
        public Node<T> Root { get; set; }
        public int Count { get; set; }

        public BinaryTree()
        {
            Count = 0;
        }

        public BinaryTree(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
                Insert(item);
        }

        public T Insert(T value)
        {
            var newNode = new Node<T>(value);

            // Root ?
            if (Root == null)
            {
                Root = newNode;
                Count++;
                return value;
            }

            var list = new List<Node<T>>();
            var q = new Queue<Node<T>>();
            q.Enqueue(Root);
            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                list.Add(temp);
                if (temp.Left != null)
                    q.Enqueue(temp.Left);
                else
                {
                    temp.Left = newNode;
                    Count++;
                    return value;
                }
                if (temp.Right != null)
                    q.Enqueue(temp.Right);
                else
                {
                    temp.Right = newNode;
                    Count++;
                    return value;
                }
            }
            throw new Exception("The insertion operation failed.");
        }

        public static List<T> InOrderIterationTraverse(Node<T> root)
        {

            if (root == null)
                return null;

            var list = new List<T>();
            var stack = new Stack<Node<T>>();
            bool done = false;
            Node<T> currentNode = root;
            while (!done)
            {
                if (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stack.Pop();
                        list.Add(currentNode.Value);
                        currentNode = currentNode.Right;
                    }
                }
            }

            return list;
        }

        public static List<Node<T>> LevelOrderTraverse(Node<T> root)
        {
            var list = new List<Node<T>>();
            if (root != null)
            {
                var q = new Queue<Node<T>>();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    var temp = q.Dequeue();
                    list.Add(temp);
                    if (temp.Left != null) q.Enqueue(temp.Left);
                    if (temp.Right != null) q.Enqueue(temp.Right);
                }
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return LevelOrderTraverse(this.Root).GetEnumerator();
        }

        public T Delete(T value)
        {
            
            if (Root == null)
            {
                throw new Exception("The tree is empty.");
            }

            
            Node<T> node = Root;
            Node<T> parent = null;
            bool found = false;
            while (node != null && !found)
            {
                if (value.Equals(node.Value))
                {
                    found = true;
                }
                else
                {
                    parent = node;
                    if (value.CompareTo(node.Value) < 0)
                    {
                        node = node.Left;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }

            
            if (!found)
            {
                throw new Exception("The value is not in the tree.");
            }

          
            Node<T> last = Root;
            Node<T> lastParent = null;
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                lastParent = last;
                last = queue.Dequeue();
                if (last.Left != null)
                {
                    queue.Enqueue(last.Left);
                }
                if (last.Right != null)
                {
                    queue.Enqueue(last.Right);
                }
            }

           
            node.Value = last.Value;

          
            if (lastParent == null) 
            {
                Root = null;
            }
            else if (lastParent.Left == last) 
            {
                lastParent.Left = null;
            }
            else 
            {
                lastParent.Right = null;
            }

            
            Count--;
            return value;
        }

        public T Delete()
        {
            
            if (Root == null)
            {
                throw new Exception("The tree is empty.");
            }

            
            T value = Root.Value;
            Delete(value);

            
            return value;
        }

    }
}
