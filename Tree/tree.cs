using System;
using System.Collections.Generic;

namespace Tree
{
  public class Node
  {
    public Node LeftNode;
    public Node RightNode;
    public int value;

    public void display()
    {
      Console.WriteLine(this.value);
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

    public void preOrder(Node root)
    {
      if (root == null)
      {
        return;
      }
      root.display();
      preOrder(root.LeftNode);
      preOrder(root.RightNode);
    }

    public void postOrder(Node root)
    {
      if (root == null)
      {
        return;
      }
      postOrder(root.LeftNode);
      postOrder(root.RightNode);
      root.display();
    }

    public void inOrder(Node root)
    {
      if (root == null)
      {
        return;
      }
      inOrder(root.LeftNode);
      root.display();
      inOrder(root.RightNode);
    }

    public void traverseIteratively(Node root)
    {
      Stack<Node> traversal = new Stack<Node>();
      traversal.Push(root);

      while (traversal.Count != 0)
      {
        Node current = traversal.Pop();
        current.display();
        if (current.LeftNode != null)
        {
          traversal.Push(current.LeftNode);
        }

        if (current.RightNode != null)
        {
          traversal.Push(current.RightNode);
        }
      }
    }
  }
}