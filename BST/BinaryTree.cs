using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BST
{
    class BinaryTree <T> : IEnumerable where T: IComparable, IComparable<T>
    {
        private BinaryTreeCell<T> Root;
        
        public BinaryTree(IEnumerable<T> input)
        {
            foreach(T x in input)
            {
                Root.Add(x);
            }
        }

        public BinaryTree()
        {
            Root = null;
        }

        public void Add(T value)
        {
            if (Root == null)
                Root = new BinaryTreeCell<T>(value);
            else
                Root.Add(value);
        }

        public bool Contains(T value)
        {
            if (Root != null)
                return Root.Contains(value);
            else 
                return false;
        }

        public BinaryTreeCell<T> Find(T value)
        {
            if (Root != null)
                return Root.Find(value);
            else 
                return null;
        }

        public override string ToString()
        {
            List<T> a = new List<T>();
            foreach (T x in this)
                a.Add(x);
            return string.Join(",", a);
        }

        public BinaryTreeCell<T> FindMinimum() => Root.FindMinimum();

        public IEnumerator GetEnumerator()
        {
            if (Root is null)
                throw new Exception("Tree is empty.");
            return Root.GetEnumerator();
        }
    }
}