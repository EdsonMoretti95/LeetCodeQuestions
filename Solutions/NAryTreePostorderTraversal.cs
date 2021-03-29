using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given the root of an n-ary tree, return the postorder traversal of its nodes' values.
    /// Nary-Tree input serialization is represented in their level order traversal.Each group of children is separated by the null value (See examples)
    /// 
    /// Example:
    /// Input: root = [1,null,3,2,4,null,5,6]
    /// Output: [5,6,3,2,4,1]
    /// 
    /// Tree Ilustration:
    ///                         1
    ///                         
    ///             3           2          4
    ///             
    ///         5       6        
    /// 
    /// 
    /// According to leetCode the recursive solution is Trivial so here we have the iterative one implemented.
    /// </summary>
    class NAryTreePostorderTraversal
    {
        public static void Solve()
        {
            var thirdLevel = new List<Node>();
            thirdLevel.Add(new Node(5));
            thirdLevel.Add(new Node(6));
            var secondLevel = new List<Node>();
            secondLevel.Add(new Node(3, thirdLevel));
            secondLevel.Add(new Node(2));
            secondLevel.Add(new Node(4));
            var treeRoot = new Node(1, secondLevel);

            
            foreach (var item in Postorder(treeRoot))
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// This method uses what we call Postorder Traversal. It uses a Stack and then for each node it pushes the children into the stack.
        /// We loop until the stack is empty popping out the elements and processing them (also their children)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> Postorder(Node root)
        {            
            var result = new List<int>();

            if (root == null) return null;

            var st = new Stack<Node>();            
            st.Push(root);

            while(st.Count > 0)
            {
                var nd = st.Pop();
                result.Insert(0, nd.val);

                if(nd.children != null)
                {
                    for (int i = 0; i < nd.children.Count; i++)
                    {
                        st.Push(nd.children[i]);
                    }
                }

            }

            return result;
        }
    }
}
