using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace From_Lab_2
{
   public class StackImplementation<T> : IStack<T>, IEnumerable, ISerializable
    {
        
        LinkedList<T> ll = new LinkedList<T>();
        public StackImplementation() { }
        public StackImplementation(LinkedList<T> ll)
        {
            this.ll = ll;
        }

        public void Push(T data)=> ll.AddFirst(data);

        public T Pop()
        {
            T value = ll.First.Value;
            ll.RemoveFirst();
            return value;
        }

        public T Peek()=> ll.First.Value;

        public void Clear()=> ll.Clear();

        public bool Contains(T data)
        {
            int counter = 0;
            foreach (T x in ll)
                if (x.Equals(data))
                    counter++;
            if (counter > 0)
                return true;
            else return false;
        }

        public int Count() => ll.Count; 

        public IEnumerator<T> GetEnumerator() => ll.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            T current = ll.First.Value;
            while (current != null)
            {
                yield return current;
                ll.RemoveFirst();
                current = ll.First.Value;
            }
           
        }

        public object Clone() => new LinkedList<T>(ll);//Cloning data

        public void GetObjectData(SerializationInfo info, StreamingContext context) => info.AddValue("props", ll, typeof(string)); // Serialization data 

        public StackImplementation(SerializationInfo info, StreamingContext context)//Constructor for deserialization
        {
            ll = (LinkedList<T>)info.GetValue("props", typeof(string));
        }
    }
}
