using System;
using System.Collections.Generic;
using System.Text;

namespace ProgName
{
    public class NodeRealiz : ILinkedList
    {
        public Node startNode { get; set; }
        public Node endNode { get; set; }

        public int GetCount()
        {
            var nextN = startNode;
            int i = 1;
            while (nextN.NextNode != null)
            {
                i++;
                nextN = nextN.NextNode;
            }
            return i;
        }
        public void AddNode(int value)
        {
            var newNode = new Node { Value = value};
            if(startNode == null)
            {
                startNode = newNode;                
                return;
            }           
            
            if(startNode != null && endNode == null)
            {
                endNode = newNode;
                endNode.PrevNode = startNode;
                startNode.NextNode = endNode;
                return;
            }

            var tempNode = endNode;
            endNode = newNode;
            endNode.PrevNode = tempNode;
            tempNode.NextNode = endNode;            
        }
        public void AddNodeAfter(Node node, int value)
        {
            var searchNA = FindNode(value); // find specific item

            if (searchNA == endNode)
            {
                var tempN = endNode;
                endNode = node;
                tempN.NextNode = endNode;
                endNode.PrevNode = tempN;                
                return;
            }
            
            node.NextNode = searchNA.NextNode;
            node.PrevNode = searchNA;
            searchNA.NextNode.PrevNode = node;
            searchNA.NextNode = node;            
        }
        public void RemoveNode(int index)
        {
            var searchN = FindNode(index);
            if (searchN == null)
                return;

            RemoveNode(searchN);
        }
        public void RemoveNode(Node node)
        {
            if (node.PrevNode == null)
            {
                node.NextNode.PrevNode = null;
                startNode = node.NextNode;                
                node.NextNode = null;
                return;
            }
            if (node.NextNode == null)
            {
                endNode = node.PrevNode;
                node.PrevNode = null;
                endNode.NextNode = null;
                return;
            }
            var nextN = node.NextNode;
            var prevN = node.PrevNode;            
            node.NextNode = null;
            node.PrevNode = null;
            nextN.PrevNode = prevN;
            prevN.NextNode = nextN;
        }
        public Node FindNode(int searchValue)
        {
            var currentNode = startNode;
            while(currentNode!=null)
            {
                if (currentNode.Value == searchValue)
                    return currentNode;
                currentNode = currentNode.NextNode;               
            }
            return null;
        }        
    }
}
