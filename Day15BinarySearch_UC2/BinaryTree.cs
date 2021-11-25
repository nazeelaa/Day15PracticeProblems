using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearch_UC2
{
    class BinaryTree
    {
        public Node root = null;

        public void Add(int i)
        {
            Node node = new Node();
            node.data = i;
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = node;
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(node.data + " : Data is added");
        }

        public void Inorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.LeftNode);
            Console.Write(root.data + " ");
            Inorder(root.RightNode);

        }
        public void Preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            Preorder(root.LeftNode);

            Preorder(root.RightNode);

        }
        public void Postorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Postorder(root.LeftNode);

            Postorder(root.RightNode);
            Console.Write(root.data + " ");
        }
    }
}
    
