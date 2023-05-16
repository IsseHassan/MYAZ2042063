namespace DataStructures.Trees.BinaryTree
{
    public class BinarySearchTreeNode<T>
    {
        public BinarySearchTreeNode(T value)
        {
            Value = value;
        }

        public BinarySearchTreeNode()
        {

        }
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}