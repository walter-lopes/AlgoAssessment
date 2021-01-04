using System;

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
      Array.Resize(ref this._items, this._items.Length +1);
      this._items.SetValue(value, this._items.GetUpperBound(0));
    }

    public T Peek()
    {
      return this._items.Length > 0 ? (T)this._items.GetValue(this._items.GetUpperBound(0)) : default(T);
    }

    public T Pop()
    {
      var item = (T)this._items.GetValue(this._items.GetUpperBound(0));

      Array.Resize(ref this._items, this._items.Length -1);

      return item;
    }
    public void Clear()
    {
      this._items = new T[0];
    }
  }
}