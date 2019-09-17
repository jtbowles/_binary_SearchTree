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

        public SearchTree()
        {
            startNode = null;
            currentNode = null;
        }

        public void Add(int data)
        {
            Node temporaryNode = new Node(data);

            if (startNode == null)
            {
                startNode = temporaryNode;
                this.currentNode = startNode;
                return;
            }

            if(data > currentNode.data)
            {
                if(currentNode.rightChild == null)
                {
                    currentNode.rightChild = temporaryNode;
                }
                else
                {
                    currentNode = currentNode.rightChild;
                    Add(data);
                }
            }
            else if(data <= currentNode.data)
            {
                if(currentNode.leftChild == null)
                {
                    currentNode.leftChild = temporaryNode;
                }
                else
                {
                    currentNode = currentNode.leftChild;
                    Add(data);
                }
            }
            currentNode = startNode;
        }

        public bool Search(int data)
        {
            if(data > currentNode.data)
            {
                if(currentNode.rightChild == null)
                {
                    return false;
                }
                else
                {
                    currentNode = currentNode.rightChild;
                    Search(data);
                }
                //search the right side
            }
            else if(data <= currentNode.data)
            {
                if(currentNode.leftChild == null)
                {
                    return false;
                }
                else
                {
                    currentNode = currentNode.leftChild;
                    Search(data);
                }
                //search the left side
            }
            else
            {
                return true;
            }
        }

    }
}
