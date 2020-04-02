using Tree;

class App
{
  public static void Main()
  {
    System.Console.WriteLine("Running tree app");
    BinaryTree tree = new Tree.BinaryTree();
    tree.insert(tree.r, 2);
    tree.insert(tree.r, 3);
    tree.insert(tree.r, 1);
    tree.insert(tree.r, 4);
    tree.insert(tree.r, 5);
    tree.postOrder(tree.r);
    // should print pre order
    tree.traverseIteratively(tree.r);
  }
}