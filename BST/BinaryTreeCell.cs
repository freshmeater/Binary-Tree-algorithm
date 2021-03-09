using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BST
{
    class BinaryTreeCell<T> : IEnumerable where T: IComparable, IComparable<T>
    {
        public BinaryTreeCell<T> SmallChild = null;
        public BinaryTreeCell<T> BigChild = null;
        public T Value;

        public BinaryTreeCell(T value)
        {
            Value = value;
        }

        public BinaryTreeCell<T> FindMinimum()
        {
            if (SmallChild == null)
                return this;
            return SmallChild.FindMinimum();
        }

        public BinaryTreeCell<T> TryFind(T value, BinaryTreeCell<T> slot)
        {
            if (slot == null)
                return null;
            else
                return slot.Find(value);
        }

        public BinaryTreeCell<T> Find(T value)
        {
            if (value.CompareTo(Value) == 0)
                return this;
            if (value.CompareTo(Value) >= 0)
                return TryFind(value, BigChild);
            else
                return TryFind(value, SmallChild);
        }

        public bool Contains(T value) => Find(value) != null;
        
        public void TryAdd(T value, ref BinaryTreeCell<T> slot)
        {
            if (slot == null)
                slot = new BinaryTreeCell<T>(value);
            else 
                slot.Add(value);
        }
        
        public void Add(T value)
        {
            if (value.CompareTo(Value) >= 0)
                TryAdd(value, ref BigChild);
            else
                TryAdd(value, ref SmallChild);
        }

        public IEnumerator GetEnumerator()
        {
            if (SmallChild != null)
                foreach (T value in SmallChild)
                    yield return value;
            yield return Value;
            if (BigChild != null)
                foreach (T value in BigChild)
                    yield return value;
        }
    }
}
