namespace TGS.Challenge
{
  public class Stack<T>
  {
    private T[] _items;

    public int Count
    {
      get { return this._items.Length; }
    }

    public Stack()
    {
      this._items = new T[] {};
    }

    public void Push(T value)
    {
      var temp = new T[this._items.Length];

      this._items.CopyTo(temp, 0);
      this._items = new T[temp.Length +1];
      temp.CopyTo(this._items, 0);
      this._items.SetValue(value, this._items.GetUpperBound(0));
    }

    public T Peek()
    {
      return this._items.Length > 0 ? (T)this._items.GetValue(this._items.GetUpperBound(0)) : default(T);
    }

    public T Pop()
    {
      var item = (T)this._items.GetValue(this._items.GetUpperBound(0));
      var temp = new T[this._items.Length];

      this._items.CopyTo(temp, 0);
      this._items = new T[temp.Length -1];

      for (var i = 0; i < this._items.Length; i++)
      {
        this._items.SetValue(temp[i], i);
      }

      return item;
    }
    public void Clear()
    {
      this._items = new T[0];
    }
  }
}