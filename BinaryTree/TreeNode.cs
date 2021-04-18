using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class TreeNode  
    {
        public int Value { get; private set; }
        public TreeNode  LeftNode{ get; private set; }
        public TreeNode  RightNode{ get;  private set; }
        public int Rank { get; set; }


        public TreeNode(int value)
        {
            Value = value;
        }
        public TreeNode()
        {

        }

        public void Add(int data, int rank)
        {
            var node = new TreeNode(data);
            node.Rank = rank;
            if (node.Value.CompareTo(Value) == -1)
            {
                if(LeftNode == null)
                {
                    node.Rank += 1;
                    LeftNode = node;
                }
                else
                {
                    LeftNode.Add(data,rank+1);
                }
            }
            else
            {
                if (RightNode == null)
                {
                    node.Rank += 1;
                    RightNode = node;
                }
                else
                {
                    RightNode.Add(data,rank+1);
                }
            }
        }

        public int CompareTo(object obj)
        {
                if(obj is TreeNode node)
                return Value.CompareTo(node.Value);
            else
            {
                throw new Exception("Wrong type");
            }
        }
        public override string ToString()
        {
            return Value.ToString();
        }


    }
}
