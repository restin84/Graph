using Graph;
using System;
using System.Collections.Generic;

namespace Search
{
  public class BreadthFirstSearch
  {
    public static int VisitedShortestPathBreadthFirstSearch(Node root, Node target)
    {
      int pathLength = 0;
      Queue<Node> queue = new Queue<Node>();
      HashSet<Node> visited = new HashSet<Node>();
      queue.Enqueue(root);

      while(queue.Count > 0)
      {
        int levelSize = queue.Count;
        //every node that is pathLength away from root will be processed
        for (int i = 0; i < levelSize; i++) 
        {
          Node currentNode = queue.Dequeue();
          visited.Add(currentNode);
          //if the current node is the target node then return the path length
          //otherwise add the children of the current node to the queue
          if (currentNode == target)
          {
            return pathLength;
          }
          foreach (Node n in currentNode.Children)
          {
            if (!visited.Contains(n))
            {
              queue.Enqueue(n); 
            }
          }
        }
        pathLength++;
      }
      return -1;
    }
  }
}
