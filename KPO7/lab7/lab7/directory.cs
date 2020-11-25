using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Directory : Component
    {
        private List<Component> components;
        private int size;
        public Directory(string name) : base(name)
        {
            components = new List<Component>();
        }
        public override int Size
        {
            get => size;
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
 

        public override void Space()
        {
            size = 0;
            foreach (var i in components)
            {
                i.Space();
                if (i is Directory || i is File)
                    size += i.Size;
            }
            Console.WriteLine(Name + " (" + size + "МБ)");
        }
        public override void Print()
        {
            Console.WriteLine(Name);
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }


}
