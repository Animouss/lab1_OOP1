using lab1_3;

class Program
{
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(3);
        TreeNode node4 = new TreeNode(4);
        TreeNode node5 = new TreeNode(5);
        TreeNode node6 = new TreeNode(6);

        root.AddChild(node2);
        root.AddChild(node3);
        node2.AddChild(node4);
        node2.AddChild(node5);
        node3.AddChild(node6);

        root.PrintChildren();
    }
}
