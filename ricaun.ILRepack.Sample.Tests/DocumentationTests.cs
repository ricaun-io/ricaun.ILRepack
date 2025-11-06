using NUnit.Framework;

namespace ricaun.ILRepack.Sample.Tests
{
    public class DocumentationTests
    {
        private string GetXmlDocumentationPath()
        {
            var location = typeof(Documentation).Assembly.Location;
            var fileXml = System.IO.Path.ChangeExtension(location, ".xml");
            return fileXml;
        }

        /// <summary>
        /// This test checks if the XML documentation file exists when using `GenerateDocumentationFile`.
        /// </summary>
        [Test]
        public void XmlDocumentationFile_Exists()
        {
            var fileXml = GetXmlDocumentationPath();
            Assert.IsTrue(System.IO.File.Exists(fileXml), $"XML documentation file not found: {fileXml}");
        }

        /// <summary>
        /// This test checks if the `/xmldocs` join the `System.Text.Json.xml` with `ricaun.ILRepack.Sample.xml`.
        /// </summary>
        [Test]
        public void XmlDocumentationFile_ContainsDocumentation()
        {
            var fileXml = GetXmlDocumentationPath();
            var xmlContent = System.IO.File.ReadAllText(fileXml);
            var className = Documentation.System_Text_Json;
            Assert.IsTrue(xmlContent.Contains(className), $"XML documentation file does not contain expected {className} tags.");
        }
    }
}