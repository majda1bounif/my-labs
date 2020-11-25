using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Web.UI;
//using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace From_Lab_2
{
    public class Program
    {
       /* [Serializable]
        public class Player
        {
            public string Name;
            public int Score;

            public Player() { }
            public Player(string name, int score)
            {
                Name = name;
                Score = score;

            }*/
            class DataSerializer
            {
                public void BinarySerialize(object data, string file)
                {
                    FileStream fileStream;
                    BinaryFormatter bf = new BinaryFormatter();
                    if (File.Exists(file)) File.Delete(file);
                    fileStream = File.Create(file);
                    bf.Serialize(fileStream, data);
                    fileStream.Close();

                }
                public void BinaryDeSerialize(string file)
                {
                    object obj = null;
                    FileStream fileStream;
                    BinaryFormatter bf = new BinaryFormatter();
                    if (File.Exists(file))
                    {
                        fileStream = File.OpenRead(file);
                        obj = bf.Deserialize(fileStream);
                        fileStream.Close();
                    }



                }
            }

            static void Main(string[] args)
            {


                implDataStru<int> s = new implDataStru<int>();
                s.Push(3);
                s.Push(2);
                s.Push(6);
                implDataStru<int> s1 = (implDataStru<int>)s.Clone();

                s1.Push(4);
                foreach (int x in s) //1
                    Console.Write(x + " ");
                Console.WriteLine("\n");
                foreach (int x in s1)//2
                    Console.Write(x + " ");// by comparing 1 && 2 we realise that the list is cloned




               
            }

        }

    }






        
   

