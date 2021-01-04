using TGS.Challenge.DataStructures;
using Xunit;

namespace TGS.Challenge.Tests.DataStructures
{
  public class StackTests
  {
    [Fact]
    public void Push_adds_items_to_the_end()
    {
      var stack = new Stack<int>();

      stack.Push(1);
      stack.Push(2);

      Assert.Equal(2, stack.Count);
      Assert.Equal(2, stack.Pop());
      Assert.Equal(1, stack.Pop());
    }

    [Fact]
    public void Pop_removes_the_item_at_the_end()
    {
      var stack = new Stack<int>();

      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Pop());
      Assert.Equal(2, stack.Count);
    }

    [Fact]
    public void Peek_returns_the_item_at_the_end_but_does_not_remove()
    {
      var stack = new Stack<int>();

      stack.Push(1);
      stack.Push(3);
      
      Assert.Equal(3, stack.Peek());
      Assert.Equal(2, stack.Count);
    }

    [Fact]
    public void Clear_removes_all_items()
    {
      var stack = new Stack<int>();

      stack.Push(1);
      stack.Push(2);
      stack.Clear();

      Assert.Equal(0, stack.Count);
    }
  }
}