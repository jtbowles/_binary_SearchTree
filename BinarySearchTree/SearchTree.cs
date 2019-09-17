using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class SearchTree
    {
        public Node startNode;
        public Node currentNode;

        public void Insert(Node node)
        {
            if(startNode == null)
            {
                startNode = node;
                return;
            }

            Node currentNode = startNode;

            while (currentNode != null)
            {
                if(node.data > currentNode.data)
                {
                    if(currentNode.rightChild != null)
                    {
                        currentNode = currentNode.rightChild;
                        //Insert(currentNode.rightChild);
                    }
                    else
                    {
                        currentNode.rightChild = node;
                        break;
                    }
                }
                else if (node.data < currentNode.data)
                {
                    if(currentNode.leftChild != null)
                    {
                        Insert(currentNode.leftChild);
                    }
                    else
                    {
                        currentNode.leftChild = node;
                        break;
                    }
                }
            }         
        }

        public void AddNode(int value)
        {
            Node node = new Node(value);
            Insert(node);
        }

        public void Search(int value)
        {

        }

        private void CompareTwoNodes(Node currentNode, Node node)
        {
            if(node.data > currentNode.data)
            {
                currentNode.rightChild = node;
            }
            else
            {
                currentNode.leftChild = node;
            }
        }

        private bool CompareNodeValues(int value, Node node)
        {
            bool greaterValue = false;

            if(value > node.data)
            {
                greaterValue = true;
            }
            else
            {
                greaterValue = false;
            }
            return greaterValue;
        }


    }
}
