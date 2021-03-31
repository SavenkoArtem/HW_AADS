using System;
using System.Collections.Generic;
using System.Text;

namespace ProgName
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    public interface ILinkedList
    {
        int GetCount(); // returns the number of items in the list
        void AddNode(int value); // adds a new list item
        void AddNodeAfter(Node node, int value); // adds a new list item after a specific item
        void RemoveNode(int index); // deletes an item by ordinal number
        void RemoveNode(Node node); // deletes the specified element 
        Node FindNode(int searchValue); // searches for an element by its value
    }
    
}
