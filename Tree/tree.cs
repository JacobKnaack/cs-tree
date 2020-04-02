using System;

namespace Tree
{
  class Node<T>
  {
    public Node<T> LeftNode { get; set; }
    public Node<T> RightNode { get; set; }
    public T Value { get; set; }

    public Node(T value)
    {
      Value = value;
    }
    public void display()
    {
      Console.WriteLine(Value);
    }
  }

  class BinaryTree<T>
  {
    public Node<T> Root { get; set; }
    public BinaryTree(T value)
    {
      Root = new Node<T>(value);
    }

    public Node<T> insert(Node<T> root, T value)
    {
      if (root == null)
      {
        Root = new Node<T>(value);
      }
      else if (Root.LeftNode == null)
      {
        root.LeftNode = insert(root.LeftNode, value);
      }
      else
      {
        root.RightNode = insert(root.RightNode, value);
      }
      Root = root;
      return Root;
    }

    // this is preOrder {root => left => right}
    public void traverse(Node<T> root)
    {
      if (root == null)
      {
        return;
      }
      root.display();
      traverse(root.LeftNode);
      traverse(root.RightNode);
    }

    // Post order traversal
    public void traversePost(Node<T> root)
    {
      if (root == null)
      {
        return;
      }
      traversePost(root.LeftNode);
      traversePost(root.RightNode);
      root.display();
    }

    // traversal using an iterable
    public void traverseIteratively(Node<T> root)
    {
      // Need to use a data structure here that will let me reference node already visited.
      Node<T> current = root;

      while (current != null)
      {
        // need to set current to a left or right side node, and store visited node.
      }
    }
  }
}