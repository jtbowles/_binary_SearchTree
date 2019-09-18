using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        public SearchTree binary;
        static void Main(string[] args)
        {
            SearchTree binary = new SearchTree();
            binary.Add(50);
            binary.Add(63);
            binary.Add(47);
            binary.Add(52);
            binary.Add(49);
            binary.Add(71);
            binary.Add(12);
            binary.Add(11);
            binary.Add(32);
            binary.Add(94);
            binary.Add(39);

            Console.WriteLine("   Would you like to add or search for a number in the tree?");
            Console.WriteLine("                 enter [add] or [search]");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "add":
                    DisplayAdd();
                    int numberToAdd = Convert.ToInt32(Console.ReadLine());
                    Add(numberToAdd, binary);
                    break;

                case "search":
                    DisplaySearch();
                    int numberToSearch = Convert.ToInt32(Console.ReadLine());
                    Search(numberToSearch, binary);
                    break;

                default:
                    break;
            }


        }

        public static void Add(int numToAdd, SearchTree tree)
        {
            tree.Add(numToAdd);
        }

        public static void Search(int numToSearch, SearchTree tree)
        {
            bool numFound = tree.Search(numToSearch);
            if (numFound)
            {
                Console.Clear();
                Console.WriteLine("  {0} was found!", numToSearch);
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("  {0} was not found :(", numToSearch);
                Console.ReadLine();
            }
        }

        public static void DisplayAdd()
        {
            Console.Clear();
            Console.WriteLine("   enter a number you wish to add");
        }

        public static void DisplaySearch()
        {
            Console.Clear();
            Console.WriteLine("   enter a number you wish to search for");
        }

    }
}
