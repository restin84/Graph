using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
  public class Node
  {
    public int Id { get; set; }
    public List<Node> Children { get; set; } = new List<Node>();

    public Node(int id) {
      Id = id;
    }
  }
}
