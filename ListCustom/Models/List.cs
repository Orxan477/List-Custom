using System;
using System.Collections.Generic;
using System.Text;
//using 

namespace ListCustom.Models
{
    public class MyList<T>
    {
        private T[] _list;

        public MyList()
        {
            _list = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index < _list.Length)
                {
                    return _list[index];
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index < _list.Length)
                {
                    _list[index] = value;
                    return;
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public int Length()
        {
            return _list.Length;
        }
        /// <summary>
        /// Add Element to List
        /// </summary>
        /// <param name="elm">Element</param>
        public void Add(T elm)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = elm;
        }
        /// <summary>
        /// Add Array to List
        /// </summary>
        /// <param name="collection">Array</param>
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Array.Resize(ref _list, _list.Length + 1);
                _list[_list.Length - 1] = item;
            }
        }
        /// <summary>
        /// Remove element to list
        /// </summary>
        /// <param name="remove">element</param>
        public void Remove(T remove)
        {
            int index = 0;
            for (int i = index; i < _list.Length - 1; i++)
            {
                _list[i] = _list[i + 1];
                if (index < _list.Length)
                {
                    index = i;
                }
            }
            for (int i = index; i < _list.Length; i++)
            {
                if (i + 1 < _list.Length)
                {
                    _list[i] = _list[i + 1];
                }

            }
            Array.Resize(ref _list, _list.Length - 1);
        }
        /// <summary>
        /// learn the index of the element
        /// </summary>
        /// <param name="item">element</param>
        /// <returns></returns>
        public virtual int IndexOf(T item)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < _list.Length; i++)
            {
                if (comparer.Equals(_list[i], item))
                {
                    return i;
                }
            }
            return -1;
            //throw new IndexOutsideBoundsExceptions("Index was outside the bounds of the array.");
        }
        /// <summary>
        /// Clear List
        /// </summary>
        public virtual void Clear()
        {
            _list = new T[0];
        }
        /// <summary>
        /// Reverse word
        /// </summary>
        /// <param name="item"></param>
        public void Reverse(T item)
        {
            StringBuilder result = new StringBuilder();

            //   string result=string.Empty;
            for (int i = _list.Length - 1; i >= 0; i--)
            {
                result.Append(_list[i]);
            }
            //return result.ToString();
        }
        /// <summary>
        /// Find
        /// </summary>
        /// <param name="func">element</param>
        /// <returns>one element</returns>
        public T Find(Predicate<T> func)
        {
            foreach (var search in _list)
            {
                if (func(search))
                {
                    return search;
                }
            }
            return default;

        }
        /// <summary>
        /// FindAll
        /// </summary>
        /// <param name="func">element</param>
        /// <returns>list</returns>
        public MyList<T> FindAll(Predicate<T> func)
        {
            MyList<T> FindAll = new MyList<T>();
            foreach (var search in _list)
            {
                if (func(search))
                {
                    FindAll.Add(search);
                    return FindAll;
                }
            }
            return default;
        }
    }
}
