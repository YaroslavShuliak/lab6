using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal interface IMyDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        TValue this[TKey index] { get; set; }
        int Count { get; }
    }
}