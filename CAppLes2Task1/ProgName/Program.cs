using System;

namespace ProgName
{
    class Program
    {
        static void Main(string[] args)
        {
            // adds items in list
            int[] a = {-50, -25, 1, 2, 4, 5, 8, 10 };
            NodeRealiz nodeList = new NodeRealiz();
            for (int i = 0; i < a.Length; i++)
            {                
                nodeList.AddNode(a[i]);
            }

            // number of items in the list
            Console.WriteLine($"Number of items in the list = {nodeList.GetCount()}");
            Console.WriteLine("");

            // search specified item
            int[] search = {-49, -25, 1, 2, 0, 5, 8, 11 };
            for (int i = 0; i < search.Length; i++)
            {
                var searchNode = nodeList.FindNode(search[i]);
                if ( searchNode == null)
                {
                    Console.WriteLine($"Element with value '{search[i]}' not found");
                    Console.WriteLine("-------------------------------------------");
                }
                else
                {                    
                    Console.WriteLine($"Found item is value - {search[i]}!");
                    Console.WriteLine($"Next item - {searchNode.NextNode.Value} and Previous item - {searchNode.PrevNode.Value}");
                    Console.WriteLine("-------------------------------------------");
                }
            }

            // remove item with Node
            int[] delN = {-50, 2, 5, 10 };
            for (int i = 0; i < delN.Length; i++)
            {
                var searchND = nodeList.FindNode(delN[i]);
                if (searchND != null)
                {
                    nodeList.RemoveNode(searchND);
                    Console.WriteLine($"Element with value '{delN[i]}' deleted");
                }
                else
                {
                    Console.WriteLine($"Found Node is value - {delN[i]}!");
                }
            }

            // number of items in the list
            Console.WriteLine($"Number of items in the list = {nodeList.GetCount()}");
            Console.WriteLine("");

            // adds a new list item after a specific item
            int[] afterAdd = {-25, 1, 4, 8 };
            int[] valueAdd = { -50, 2, 5, 10 };
            for (int i = 0; i < afterAdd.Length; i++)
            {                
                var newNA = new Node { Value = valueAdd[i] };
                nodeList.AddNodeAfter(newNA, afterAdd[i]);
                Console.WriteLine($"Adds new items value - {valueAdd[i]}!");
            }

            // number of items in the list            
            Console.WriteLine($"Number of items in the list = {nodeList.GetCount()}");
            Console.WriteLine("");

            // remove item with search Value
            int[] delNV = { -25, 2, 5, 10 };
            for (int i = 0; i < delNV.Length; i++)
            {
                nodeList.RemoveNode(delNV[i]);
                Console.WriteLine($"Element with value '{delN[i]}' deleted");
            }

            // number of items in the list            
            Console.WriteLine($"Number of items in the list = {nodeList.GetCount()}");
            Console.WriteLine("");

            Console.WriteLine("Finish!");
        }
    }
}
