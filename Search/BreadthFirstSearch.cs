using Graph;
using System;
using System.Collections.Generic;

namespace Search
{
  public class BreadthFirstSearch
  {
    public static int AcyclicShortestPathBreadthFirstSearch(Node root, Node target)
    {
      int pathLength = 0;
      Queue<Node> queue = new Queue<Node>();
      queue.Enqueue(root);

      while(queue.Count > 0)
      {
        pathLength++;
        int levelSize = queue.Count;
        for (int i = 0; i < levelSize; i++)
        {
          Node currentNode = queue.Dequeue();
          if (currentNode == target)
          {
            return pathLength;
          }
          foreach (Node n in currentNode.Children)
          {
            queue.Enqueue(n);
          }
        }
      }
      return -1;
    }
  }
}
