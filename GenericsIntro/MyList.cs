using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
                
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //tempArray-geçici dizi
            items = new T[items.Length+1];  //eleman sayısını bir arttırmış oldum. üst satırda tempArray ile eski değerleri tuttum.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }


        public int Length
        {
            get { return items.Length; }
            
        }

        public T[] LItems
        {
            get { return items; }

        }
    }
}
