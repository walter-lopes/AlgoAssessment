using System;

namespace TGS.Challenge.DataStructures
{
  public class Queue<T>
  {
    private T[] _items;
    public int Count
    {
      get { return this._items.Length; }
    }

    public Queue()
    {
      this._items = new T[] {};
    }

    public void Enqueue(T item)
    {
      var temp = new T[this._items.Length];

      this._items.CopyTo(temp, 0);
      this._items = new T[temp.Length +1];
      this._items.SetValue(item, 0);
      temp.CopyTo(this._items, 1);
    }

    public T Peek()
    {
      return this._items.Length > 0 ? this._items[this._items.GetUpperBound(0)] : default(T);
    }

    public T Dequeue()
    {
      if (this._items.Length == 0){
        return default(T);
      }

      var result = (T)this._items.GetValue(this._items.GetUpperBound(0));

      Array.Resize(ref this._items, this._items.Length -1);

      return result;
    }

    public void Clear()
    {
      this._items = new T[0];
    }
  }
}
