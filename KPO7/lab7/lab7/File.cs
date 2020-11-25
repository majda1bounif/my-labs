using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public  class File : Component
    {
        public override int Size { get; }

        public override void Space()
        {
        }
        public override void Print()
        {
            Console.WriteLine("--" + Name + " (" + Size + "МБ)");
        }
        public File(string name, int size) : base(name)
        {
            Size = size;
        }

    }
}
