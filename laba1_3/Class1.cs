using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    public class TreeNode
    {
        private List<TreeNode> children;
        private int value;

        public TreeNode(int value)
        {
            this.value = value;
            this.children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            children.Add(child);
        }

        public void PrintChildren()
        {
            Console.WriteLine($"Значение узла: {value}");

            foreach (var child in children)
            {
                Console.WriteLine($"Потомок: {child.value}");
                child.PrintChildren(); 
            }
        }
    }
}
