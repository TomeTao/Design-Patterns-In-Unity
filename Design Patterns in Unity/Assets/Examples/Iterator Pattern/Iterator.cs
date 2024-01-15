using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//µü´úÆ÷Ä£Ê½
namespace DesignPattern.Example.Pattern
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    public interface IAggregate<T>
    {
        IIterator<T> GetIterator();
    }

    public class ConcreteIterator<T> : IIterator<T>
    {
        private List<T> _items;
        private int _currentIndex = 0;

        public ConcreteIterator(List<T> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _currentIndex < _items.Count;
        }

        public T Next()
        {
            T item = _items[_currentIndex];
            _currentIndex++;
            return item;
        }
    }

    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            _items.Add(item);
        }

        public IIterator<T> GetIterator()
        {
            return new ConcreteIterator<T>(_items);
        }
    }
}
