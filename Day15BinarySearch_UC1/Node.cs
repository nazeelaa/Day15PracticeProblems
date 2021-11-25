using System;
using System.Collections.Generic;
using System.Text;

namespace Day15BinarySearch_UC1
{
    class Node
    {
        public int data;
        public Node LeftNode;
        public Node RightNode;
        public Node()
        {
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}
