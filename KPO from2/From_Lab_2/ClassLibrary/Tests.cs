using System;
using NUnit.Framework;
using From_Lab_2;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ClassLibrary
{
    [TestFixture]
    public class Tests
    {
        [Test()]
        public void PeekTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(s.Peek(), 3);
        }
        [Test()]
        public void PushTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            string actual = "";
            string expected = "321";
            foreach (var x in s)
                actual += x.ToString();
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        public void PopTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(s.Pop(), 3);
        }
        [Test()]
        public void ClearTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Clear();
            int actual = s.Count();
            int expected = 0;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        public void PushElementTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Clear();
            int actual = s.Count();
            int expected = 0;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        public void PeekEmptyStackTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            Assert.Throws<InvalidOperationException>(() => { int actual = s.Peek(); });
        }
        [Test()]
        public void LIFOTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Pop());
            Assert.AreEqual(2, s.Pop());
            Assert.AreEqual(1, s.Pop());
            Assert.Throws<InvalidOperationException>(() => { int actual = s.Pop(); }); // impossible to pop an element bcs the stack is already empty
        }
        [Test()]
        public void CloneTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            implDataStru<int> s1 = (implDataStru<int>)s.Clone();
            s1.Push(4);
            Assert.AreNotEqual(s, s1);
        }
        [Test()]
        public void ContainsElementTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(s.Contains(3), true);
        }
        [Test()]
        public void DoesNotContainsElementTest()
        {
            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(s.Contains(7), false);
        }
        [Test()]
        public void SerializableToJsonTest()
        {

            implDataStru<int> s = new implDataStru<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            string actual = "";
            string expected = "321";
            foreach (var x in s)
                actual += JsonConvert.SerializeObject(x).ToString();

            Assert.AreEqual(actual, expected);

       

         }
      

    }
    }
 

       
  
