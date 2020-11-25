using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public abstract class Component
    {
        protected string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public virtual int Size { get; }
        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
        public virtual void Replace(Component component) { }
        public virtual void Space() { }
        public virtual void Print()
        {
            Console.WriteLine(Name + " (" + Size + "МБ)");
        }

    }
}

