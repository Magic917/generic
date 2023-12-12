using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    public class MyAnswer<T> where T : struct
    {
        private List<T> list;
        public MyAnswer() 
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }
        public T GetItem(int index)
        {

            if (index >= 0 && index < list.Count)
            {
                return list[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            };
        }
        public List<T> GetOrderList()
        {
            List<T> Orderedlist = new List<T>(list);
            Orderedlist.Sort();
            return Orderedlist;
        }
    }
}



