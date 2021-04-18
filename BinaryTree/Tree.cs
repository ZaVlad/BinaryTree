using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        public TreeNode Root { get; private set; }
        public int Count { get; private set; }

        public void Add(int data)
        {
            if (Root == null)
            {
                Root = new TreeNode(data);
                Root.Rank = 1;
                Count = 1;
                return;
            }
            Root.Add(data,Root.Rank);
            Count++;
        }
        public IEnumerable<TreeNode> LevelOrderTraversal()
        {
            if (Root == null)
                yield break;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                yield return node;

                if (node.LeftNode != null)
                    queue.Enqueue(node.LeftNode);
                if (node.RightNode != null)
                    queue.Enqueue(node.RightNode);
            }
        }
    }
}
