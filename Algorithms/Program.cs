using Algorithms.BinaryTree;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {

          
            var example = new TreeNode();
            example.Val = 5;
            example.Left = new TreeNode(4, new TreeNode(11, new TreeNode(7),new TreeNode(2)));
            example.Right = new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)));

            //var result = TraverseTree.HasPathSum(example, 22);

        }
    }
}
