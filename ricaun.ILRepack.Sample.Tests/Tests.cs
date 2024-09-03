using NUnit.Framework;
using System;

namespace ricaun.ILRepack.Sample.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var c = new Class();
            Console.WriteLine(c);
        }

        [Test]
        public void TestJson()
        {
            var c = new Class();
            Console.WriteLine(c.ToJson());
            Assert.AreEqual(c.ToString(), c.ToJson());
        }

        [Test]
        public void TestJsonName()
        {
            var name = typeof(Class).Assembly.GetName().Name;
            Console.WriteLine(JsonExtension.Name);
            Assert.AreEqual(name, JsonExtension.Name);
        }

        [Test]
        public void TestAssembly()
        {
            foreach (var item in AppDomain.CurrentDomain.GetAssemblies())
            {
                Console.WriteLine(item);
            }
        }
    }
}