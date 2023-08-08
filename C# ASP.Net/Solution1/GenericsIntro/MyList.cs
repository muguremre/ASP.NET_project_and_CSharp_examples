using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
       public void Add(T item)
        {
            T[] geciciDizi = items;

            items = new T[items.Length + 1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                items[i] = geciciDizi[i];


            }
            items[items.Length - 1] = item;

        }
    }
}
