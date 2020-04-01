using System;

namespace Tree
{
  public class Node
  {
    public Node LeftNode;
    public Node RightNode;
    public int value;

    public void display()
    {
      System.Console.WriteLine(this.value);
    }
  }

  class BinaryTree
  {
    public Node r = null;
    public Node insert(Node root, int v)
    {
      if (root == null)
      {
        root = new Node();
        root.value = v;
      }
      else if (v < root.value)
      {
        root.LeftNode = insert(root.LeftNode, v);
      }
      else
      {
        root.RightNode = insert(root.RightNode, v);
      }
      this.r = root;
      return this.r;
    }

    public void traverse(Node root)
    {
      if (root == null)
      {
        return;
      }
      root.display();
      traverse(root.RightNode);
      traverse(root.LeftNode);
    }
    public void traverseIterativly(Node root)
    {
      Node current = root;

      while (current != null)
      {
        current.display();
        if (current.RightNode != null)
        {
          current = current.RightNode;
        }
        else
        {
          current = current.LeftNode;
        }
      }
    }
  }

  class Program
  {
    public static void Main()
    {
      System.Console.WriteLine("Main program run");
      BinaryTree tree = new BinaryTree();
      tree.insert(tree.r, 1);
      tree.insert(tree.r, 10);
      tree.insert(tree.r, 5);
      tree.insert(tree.r, 6);
      tree.insert(tree.r, 7);
      tree.traverseIterativly(tree.r);
    }
  }
}