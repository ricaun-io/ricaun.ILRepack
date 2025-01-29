using NUnit.Framework;

namespace ricaun.ILRepack.Sample.Tests
{
    public class ReferenceTests
    {
        [Test]
        public void Test()
        {
            _ = typeof(Newtonsoft.Json.JsonConverter);
            _ = typeof(System.Text.Json.JsonSerializer);
        }
    }
}