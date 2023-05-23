
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
                Add(item);
            }
        }
        public void Add(T value)
        {
            if (value == null) 
            {
                throw new ArgumentNullException("value"); 
            }
            var newNode = new Node<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            var current = Root;
            Node<T> parent;
            while (true)
            {
                parent = current;
                // Sol-taraf
                if (value.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }
                // Sağ-taraf
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }

        public List<T> PreOrderRecursive(Node<T> node)
        {
            List<T> list = new List<T>();
            if (node == null)
            {
                return list;
            }
            list.Add(node.Value);
            list.AddRange(PreOrderRecursive(node.Left));
            list.AddRange(PreOrderRecursive(node.Right));
            return list;    
        }
   

        public List<T> PreOrderIterative(Node<T> node)
        {
            var list = new List<T>(); 
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node),"The node is empty");
               
            }
            Stack<Node<T>> stack = new Stack<Node<T>>(); 
            stack.Push(node); 
            while (stack.Count > 0) 
            {
                Node<T> current = stack.Pop(); 
                list.Add(current.Value); 
                if (current.Right != null) 
                {
                    stack.Push(current.Right); 
                }
                if (current.Left != null) 
                {
                    stack.Push(current.Left); 
                }
            }
            return list; 
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
