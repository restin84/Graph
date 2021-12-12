using Graph;
using System;

namespace GraphConsole
{
  class Program
  {
    static void Main(string[] args) {
      Node zero = new Node(0);
      Node one = new Node(1);
      Node two = new Node(2);
      Node three = new Node(3);
      Node four = new Node(4);
      Node five = new Node(5);
      Node six = new Node(6);
      Node seven = new Node(7);
      Node eight = new Node(8);
      Node nine = new Node(9);
      zero.Children.Add(one);
      zero.Children.Add(six);
      zero.Children.Add(eight);
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


      Console.ReadLine();
    }
  }
}
