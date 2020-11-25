using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Component mylap = new Directory("Computer admin");
            Component disc = new Directory("disc C");
            Component imageFile = new File("img.jpeg", 12);
            Component textFile = new File("word.txt", 10);


            disc.Add(imageFile);
            disc.Add(textFile);
            mylap.Add(disc);
            mylap.Print();
            mylap.Space();

            Console.WriteLine();
            disc.Remove(imageFile);
            disc.Print();
            mylap.Space();
            Console.ReadKey();

            // here I could create another directory and another files but I prefer to use it in tests 

        }
    }
}
