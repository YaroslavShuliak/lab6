using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal interface IMylist<T>
    {
        public void Add(T value);
        public int Count { get; }
        public T this[int index]
        { get; set; }
    }
}
