using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            Random r = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                numbers.Add(r.Next(-10, 10));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"| {numbers[i]} |");
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                tree.Add(numbers[i]);
            }

            Console.WriteLine();
            TakeAllNegativeNumbers(tree);
        }
        public static void TakeAllNegativeNumbers(Tree tree)
        {
            var treeStructure = tree.LevelOrderTraversal();
            foreach (TreeNode item in treeStructure)
            {
                if(item.Value<0)
                    Console.WriteLine($"{item.Rank} : {item.Value}");
            }
        }
    }
}

