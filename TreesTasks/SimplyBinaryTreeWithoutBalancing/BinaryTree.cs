using System;
using System.Text;

namespace SimplyBinaryTreeWithoutBalancing
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> root;

        public static StringBuilder sb = new StringBuilder();

        public void PrintSorted()
        {
            PrintInorder(this.root);
            sb.Length -= 2;
            Console.WriteLine(sb.ToString());
            sb.Clear();
        }

        public void PrintPost()
        {
            PrintPostorder(this.root);
            sb.Length -= 2;
            Console.WriteLine(sb.ToString());
            sb.Clear();
        }

        public void PrintPre()
        {
            PrintPreorder(this.root);
            sb.Length -= 2;
            Console.WriteLine(sb.ToString());
            sb.Clear();
        }

        private void PrintInorder(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            // Inorder traversal
            PrintInorder(node.Left);
            sb.Append($"{node.Value}, ");
            PrintInorder(node.Right);
        }

        private void PrintPostorder(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            // Postorder traversal
            PrintPostorder(node.Left);
            PrintPostorder(node.Right);
            sb.Append($"{node.Value}, ");
        }

        private void PrintPreorder(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            // Preorder traversal
            sb.Append($"{node.Value}, ");
            PrintPreorder(node.Left);
            PrintPreorder(node.Right);
        }


        public void Add(T value)
        {
            if (root == null)
            {
                root = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddInternal(value, this.root);
            }
        }

        private void AddInternal(T value, BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
            }
            else
            {
                var comparison = node.Value.CompareTo(value);

                if (comparison < 0)
                {
                    if (node.Right == null)
                    {
                        node.Right = new BinaryTreeNode<T>(value);
                    }
                    else
                    {
                        AddInternal(value, node.Right);
                    }
                }
                else if (comparison > 0)
                {
                    if (node.Left == null)
                    {
                        node.Left = new BinaryTreeNode<T>(value);
                    }
                    else
                    {
                        AddInternal(value, node.Left);
                    }
                }
                else if (comparison == 0)
                {
                    throw new InvalidOperationException("This value already exist.");
                }
            }
        }
    }

    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }
    }
}
