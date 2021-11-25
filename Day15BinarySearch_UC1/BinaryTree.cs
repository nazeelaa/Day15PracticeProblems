using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearch_UC1
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
                root = node;//if root is null assign newNode to root
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
                            parent.LeftNode = node;  //go left
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = node;  //go right
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(node.data + " : Data is added");
        }

        public void TraverseInorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TraverseInorder(root.LeftNode);
            Console.Write(root.data + " ");
            TraverseInorder(root.RightNode);

        }
        public void TraversePreorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            TraversePreorder(root.LeftNode);

            TraversePreorder(root.RightNode);

        }
        public void TraversePostorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TraversePostorder(root.LeftNode);

            TraversePostorder(root.RightNode);
            Console.Write(root.data + " ");
        }
    }
}
