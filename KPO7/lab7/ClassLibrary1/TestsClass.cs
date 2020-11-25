using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lab7;


namespace ClassLibrary1
{
    [TestFixture]
    public class TestsClass
    {
        [Test]
        public void LaptopSpace()
        {
            Component mylap = new Directory("computer admin");
            Component disk = new Directory("Disk C");
            Component fileTxt = new File("Text.txt", 10);
            Component fileJpeg = new File("img.jpeg", 12);
            disk.Add(fileTxt);
            disk.Add(fileJpeg);
            mylap.Add(disk);
            mylap.Space();
            var actual = mylap.Size;
            var expected = 22;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void DiskSpaceTest()
        {
            Component mylap = new Directory("computer admin");
            Component disk1 = new Directory("Disk C");
            Component disk2 = new Directory("Disk D");
            Component fileTxt = new File("Text.txt", 10);
            Component fileJpeg = new File("img.jpeg", 12);
            disk2.Add(fileJpeg);
            disk1.Add(fileTxt);
            mylap.Add(disk2);
            disk1.Space();
            var actual = disk1.Size;
            var expected = 10;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void RemoveFileTest()
        {
            Component disk = new Directory("Disk E");
            Component fileTxt = new File("Text.txt", 10);
            Component filePng = new File("Png.png", 7);
            Component fileDoc = new File("Doc.docx", 9);
            disk.Add(fileTxt);
            disk.Add(filePng);
            disk.Add(fileDoc);
            disk.Remove(filePng);
            disk.Remove(fileDoc);
            disk.Space();
            var actual = disk.Size;
            var expected = 10;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void AddDisksInPCTest()
        {
            Component mylap = new Directory("computer admin");
            Component disk1 = new Directory("Disk C");
            Component disk2 = new Directory("Disk D");
            Component fileTxt = new File("Text.txt", 10);
            Component filePng = new File("Png.png", 15);
            Component fileDoc = new File("Doc.docx", 9);
            disk1.Add(fileTxt);
            disk2.Add(filePng);
            disk1.Add(fileDoc);
            mylap.Add(disk1);
            mylap.Add(disk2);
            mylap.Space();
            var actual = mylap.Size;
            var expected = 34;
            Assert.AreEqual(actual, expected);
        }
    }
}
