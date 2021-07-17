using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.BinaryTree
{
    public static class TraverseTree
    {
        public static List<int> PreOrderTraversal(TreeNode root)
        {
            TreeNode current = root;
            Stack<TreeNode> rightNodes = new Stack<TreeNode>();
            List<int> result = new List<int>();

            while (current != null)
            {
                result.Add(current.Val);

                if (current.Right != null)
                    rightNodes.Push(current.Right);

                if (current.Left != null)
                    current = current.Left;
                else if (rightNodes.Count > 0)
                    current = rightNodes.Pop();
                else
                    current = null;
            }
            return result;
        }

        public static List<int> PostOrderTraversalRecursive(TreeNode root)
        {
            var list = new List<int>();
            if (root != null)
            {
                list.AddRange(PostOrderTraversalRecursive(root.Left));
                list.AddRange(PostOrderTraversalRecursive(root.Right));
                list.Add(root.Val);
            }
            return list;
        }

        public static List<int> PostOrderTraversal(TreeNode root)
        {
            Stack<TreeNode> nodesStack = new Stack<TreeNode>();
            Stack<TreeNode> nodesStack2 = new Stack<TreeNode>();

            var list = new List<int>();
            
            if(root != null)
            {
                nodesStack.Push(root);
                
                while (nodesStack.Count > 0)
                {
                    var current = nodesStack.Pop();
                    nodesStack2.Push(current);

                    if (current.Left != null)
                        nodesStack.Push(current.Left);
                    if (current.Right != null)
                        nodesStack.Push(current.Right);
                }

                while(nodesStack2.Count > 0)
                {
                    list.Add(nodesStack2.Pop().Val);
                }
            }

            return list;
        }

        public static List<int> InOrderTraversalRecursive(TreeNode root )
        {
            var list = new List<int>();
            if (root != null)
            {
                list.AddRange(InOrderTraversalRecursive(root.Left));
                list.Add(root.Val);
                list.AddRange(InOrderTraversalRecursive(root.Right));
            }
            return list;
        }

        public static List<int> InOrderTraversal(TreeNode root)
        {
            Stack<TreeNode> nodesStack = new Stack<TreeNode>();
            var current = root;
            var list = new List<int>();
           
            while (current != null || nodesStack.Count > 0)
            {
                while (current != null)
                {
                    nodesStack.Push(current);
                    current = current.Left;
                }

                current = nodesStack.Pop();
                list.Add(current.Val);


                current = current.Right;
            }
            return list;
        }
    
        public static IList<int> LevelOrdertraversal(TreeNode root, int index = 0)
        {
            var result = new List<int>();
            
            if (root != null)
            {
                result.Add(root.Val);

                result.AddRange(LevelOrdertraversal(root.Left));
                result.AddRange(LevelOrdertraversal(root.Right));
            }
            return result;
        }

        public static bool IsBst(TreeNode node)
        {
            if (node == null)
                return true;

            if (node.Left != null && node.Left.Val > node.Val)
                return false;

            if (node.Right != null && node.Right.Val < node.Val)
                return false;

            if (!IsBst(node.Left) || !IsBst(node.Right))
                return false;

            return true;
        }


        private static int answer = 0;

        public static int MaxDepth(TreeNode root, int depth = 1)
        {
            if (root == null) 
                return answer;

            if (root.Left == null && root.Right == null)
            {
                answer = Math.Max(answer, depth);
            }
            
            Console.WriteLine(depth);
            MaxDepth(root.Left, depth + 1);
            MaxDepth(root.Right, depth + 1);
            
            return answer;
        }


        private static bool answerPathSum = false;
        
        public static bool HasPathSum(TreeNode root, int target = 1)
        {
            var a = "-123";

            if (a.Contains('-'))
            {
                var resulta = new string(a.Split('-')[1].ToCharArray().Reverse().ToArray());
                int number = 0;
                int.TryParse(('-' + resulta), out number);
            }
            else
            {
                var resulta = new string(a.ToCharArray().Reverse().ToArray());
                int number = 0;
                int.TryParse(resulta, out number);
            }



   
            
                
                if (root == null || target == 0)
                return answerPathSum;

            target += root.Val;

            var result = HasPathSum(root.Left, target);
            var resultB = HasPathSum(root.Right, target);

            return answerPathSum;
        }

    }
}
