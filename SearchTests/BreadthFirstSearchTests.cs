using Graph;
using System;
using Xunit;

namespace SearchTests
{
  public class BreadthFirstSearchTests
  {
    private Node zero;
    private Node one;
    private Node two;
    private Node three;
    private Node four;
    private Node five;
    private Node six;
    private Node seven;
    private Node eight;
    private Node nine;
    public BreadthFirstSearchTests()
    {
      InitializeNodes();
      
    }

    private void InitializeNodes()
    {
      zero = new Node(0);
      one = new Node(1);
      two = new Node(2);
      three = new Node(3);
      four = new Node(4);
      five = new Node(5);
      six = new Node(6);
      seven = new Node(7);
      eight = new Node(8);
      nine = new Node(9);
    }

    private void CreateCyclicGraph()
    {
      zero.Children.Add(one);
      zero.Children.Add(six);
      zero.Children.Add(eight);
      one.Children.Add(zero);
      one.Children.Add(four);
      one.Children.Add(six);
      one.Children.Add(nine);
      two.Children.Add(four);
      two.Children.Add(six);
      three.Children.Add(four);
      three.Children.Add(five);
      three.Children.Add(eight);
      four.Children.Add(one);
      four.Children.Add(two);
      four.Children.Add(three);
      four.Children.Add(five);
      four.Children.Add(nine);
      five.Children.Add(three);
      five.Children.Add(four);
      six.Children.Add(zero);
      six.Children.Add(one);
      six.Children.Add(two);
      seven.Children.Add(eight);
      seven.Children.Add(nine);
      eight.Children.Add(zero);
      eight.Children.Add(three);
      eight.Children.Add(seven);
      nine.Children.Add(one);
      nine.Children.Add(four);
      nine.Children.Add(seven);
    }

    private void CreateACyclicGraph()
    {
      one.Children.Add(four);
      one.Children.Add(two);
      two.Children.Add(one);
      two.Children.Add(three);
      two.Children.Add(six);
      four.Children.Add(one);
      five.Children.Add(one);
      five.Children.Add(seven);
      six.Children.Add(two);
      seven.Children.Add(five);
      seven.Children.Add(nine);
      eight.Children.Add(nine);
      nine.Children.Add(eight);
      nine.Children.Add(seven);
    }

    [Fact]
    public void Test1()
    {
      Assert.True(one != null);
    }
  }
}
