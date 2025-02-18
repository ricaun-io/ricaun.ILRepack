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
#if NETFRAMEWORK
        [Test]
        public void TestReferenceName_AreEqual()
        {
            var name = typeof(Class).Assembly.GetName().Name;
            Console.WriteLine(References.System_Text_Json);
            Assert.AreEqual(name, References.System_Text_Json);
        }
#endif
        [Test]
        public void TestReferenceName_AreNotEqual()
        {
            var name = typeof(Class).Assembly.GetName().Name;
            Console.WriteLine(References.Newtonsoft_Json);
            Assert.AreNotEqual(name, References.Newtonsoft_Json);
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