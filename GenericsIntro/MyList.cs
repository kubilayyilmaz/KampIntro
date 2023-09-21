using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempItems = items;
            
            items = new T[items.Length + 1];

            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }
    }
}
