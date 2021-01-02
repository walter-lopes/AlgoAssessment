using Xunit;

namespace TGS.Challenge.Tests
{
  public class QueueTests
  {
    [Fact]
    public void Enqueue_add_new_items_to_the_beginning()
    {
      var queue = new Queue<int>();
      var expected = new int[] { 2, 1 };

      queue.Enqueue(1);
      queue.Enqueue(2);

      Assert.Equal(queue.Count, 2);
      Assert.Equal(1, queue.Dequeue());
      Assert.Equal(2, queue.Dequeue());
    }

    [Fact]
    public void Clear_removes_all_items()
    {
      var queue = new Queue<int>();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Clear();

      Assert.Equal(0, queue.Count);
    }

    [Fact]
    public void Dequeue_removes_items_from_the_end()
    {
      var queue = new Queue<int>();

      queue.Enqueue(1);
      queue.Enqueue(2);
      
      var item = queue.Dequeue();

      Assert.Equal(1, queue.Count);
      Assert.Equal(1, item);
    }

    [Fact]
    public void Peek_does_not_remove_the_item()
    {
      var queue = new Queue<int>();

      queue.Enqueue(1);
      queue.Enqueue(2);

      var item = queue.Peek();

      Assert.Equal(2, queue.Count);
      Assert.Equal(1, item);
    }
  }
}