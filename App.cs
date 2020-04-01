using Tree;

class Program
{
  public static void Main()
  {
    System.Console.WriteLine("Main program run");
    BinaryTree tree = new Tree.BinaryTree();
    tree.insert(tree.r, 1);
    tree.insert(tree.r, 10);
    tree.insert(tree.r, 5);
    tree.insert(tree.r, 6);
    tree.insert(tree.r, 7);
    tree.traverseIterativly(tree.r);
  }
}