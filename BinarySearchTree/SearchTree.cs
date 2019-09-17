using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class SearchTree
    {
        public Node rootNode;
        

        public void Insert(int value)
        {
            Node node = new Node(value);

            if(rootNode == null)
            {
                rootNode = node;
                return;
            }
            else
            {
                Node temporaryNode = rootNode;
                bool valueIsGreater = CompareNodeValues(value);
                while (valueIsGreater)
                {
                    if(temporaryNode.rightChild != null)
                    {
                        temporaryNode = temporaryNode.rightChild;
                    }
                    temporaryNode.rightChild = node;
                }
                if(!valueIsGreater)
                {
                    if(temporaryNode.leftChild != null)
                    {
                        temporaryNode = temporaryNode.leftChild;
                    }
                    temporaryNode.leftChild = node;
                }
            }
        }

        public void Search(int value)
        {

        }

        private bool CompareNodeValues(int value)
        {
            bool greaterValue = false;

            if(value > rootNode.data)
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
