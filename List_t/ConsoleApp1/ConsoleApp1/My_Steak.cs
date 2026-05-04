using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
//
internal class My_Steak<T> where T : class
{
    private List<T> _list= new List<T>();
    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        int lastIndex = _list.Count - 1;
        var item = _list[lastIndex];
        _list.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _list[_list.Count - 1];
    }
    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    public void Clear()
    {
        _list.Clear();
    }

    public int Count()
    {
        return _list.Count;
    }

    public override string ToString() => string.Join(", ", _list);
}
