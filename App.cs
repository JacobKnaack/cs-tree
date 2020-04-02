using Tree;

class App
{
  public static void Main()
  {
    System.Console.WriteLine("Main program run");
    BinaryTree<int> tree = new Tree.BinaryTree<int>(2);
    tree.insert(tree.Root, 3);
    tree.insert(tree.Root, 1);
    tree.insert(tree.Root, 4);
    tree.insert(tree.Root, 5);

    // tree.traverseIteratively(tree.r);
    tree.traversePost(tree.Root);
    // tree.traverse(tree.r);
  }
}