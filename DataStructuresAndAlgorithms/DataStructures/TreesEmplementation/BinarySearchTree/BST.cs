
namespace TreesEmplementation
{
    public class BST<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        public BST()
        {
            Root = null;
        }

        public BST(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Insert(item);
            }
        }
        public void Insert(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            Node<T> current = Root;
            Node<T> parent;
            while (current != null)
            {
                parent = current;

                if (value.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                }
                else if (value.CompareTo(current.Value) > 0)
                {
                    current = current.Right;
                }
                else
                {
                    return;
                }
                if (value.CompareTo(parent.Value) < 0)
                {
                    parent.Left = newNode;
                }
                else
                {
                    parent.Right = newNode;
                }
            }

        }

        public void PreOrderRecursive(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.Value + " ");
            PreOrderRecursive(node.Left);
            PreOrderRecursive(node.Right);
        }

        public void PreOrderIterative(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                Node<T> current = stack.Pop();
                Console.Write(current.Value + " ");
                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }
                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }
        public int CountLeaves(Node<T> node)
        {
            // Base case: 
            if (node == null)
            {
                return 0;
            }
            if (node.Left == null && node.Right == null)
            {
                return 1;
            }
            return CountLeaves(node.Left) + CountLeaves(node.Right);
        }
    }
}
