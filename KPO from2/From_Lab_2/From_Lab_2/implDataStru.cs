using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace From_Lab_2
{
    
    public class implDataStru<T> : IStack<T>, ICloneable, ISerializable
    {
        LinkedList<T> linkedlist = new LinkedList<T>();
        //public implDataStru(implDataStru<int> linkedlist) { }
        public implDataStru() { }
        public implDataStru(LinkedList<T> linkedlist)
        {
            this.linkedlist = linkedlist;
        }

        public void Push(T value)
        {
            linkedlist.AddFirst(value);
        }
        public T Pop()
        {
            if (linkedlist.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            T value = linkedlist.First.Value;
            linkedlist.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (linkedlist.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            return linkedlist.First.Value;
        }
        public void Clear()
        {
            linkedlist.Clear();
        }
        public int Count() => linkedlist.Count;
        public bool Contains(T data)
        {
            int counter = 0;
            foreach (T x in linkedlist)
                if (x.Equals(data))
                    counter++;
            if (counter > 0)
                return true;
            else return false;
        }
        public IEnumerator<T> GetEnumerator() => linkedlist.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            T Value = linkedlist.First.Value;
            while (Value != null)
            {
                yield return Value;
                linkedlist.RemoveFirst();
                Value = linkedlist.First.Value;
            }
        }
        public object Clone() => new implDataStru<T>(linkedlist);
        public void GetObjectData(SerializationInfo info, StreamingContext context) => info.AddValue("props", linkedlist, typeof(string)); //to save data

        public implDataStru(SerializationInfo info, StreamingContext context)//constructer to deserialize values
        {
            linkedlist = (LinkedList<T>)info.GetValue("props", typeof(string));
        }














    }


}

