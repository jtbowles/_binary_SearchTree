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

        //public void Insert(Node node)
        //{
        //    if(startNode == null)
        //    {
        //        startNode = node;
        //        this.currentNode = startNode;
        //        return;
        //    }

        //    Node currentNode = startNode;
        //    Node nodeToAdd = node;

        //    while (currentNode != null)
        //    {
        //        if(nodeToAdd.data > currentNode.data)
        //        {
        //            if(currentNode.rightChild != null)
        //            {
        //                currentNode = currentNode.rightChild;
        //                //Insert(currentNode.rightChild);
        //            }
        //            else
        //            {
        //                currentNode.rightChild = node;
        //                break;
        //            }
        //        }
        //        else if (nodeToAdd.data < currentNode.data)
        //        {
        //            if(currentNode.leftChild == null)
        //            {
        //                currentNode.leftChild = nodeToAdd;
        //                break;
        //            }
        //            else
        //            {
        //                Insert(currentNode.leftChild);
        //            }
        //        }
        //    }         
        //}

        //public void AddNode(int value)
        //{
        //    Node node = new Node(value);
        //    Insert(node);
        //}

        //public void Search(int value)
        //{

        //}

        //private void CompareTwoNodes(Node currentNode, Node node)
        //{
        //    if(node.data > currentNode.data)
        //    {
        //        currentNode.rightChild = node;
        //    }
        //    else
        //    {
        //        currentNode.leftChild = node;
        //    }
        //}

        //private bool CompareNodeValues(int value, Node node)
        //{
        //    bool greaterValue = false;

        //    if(value > node.data)
        //    {
        //        greaterValue = true;
        //    }
        //    else
        //    {
        //        greaterValue = false;
        //    }
        //    return greaterValue;
        //}


    }
}
