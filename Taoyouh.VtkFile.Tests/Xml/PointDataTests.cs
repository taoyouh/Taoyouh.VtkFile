using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoyouh.VtkFile.Tests;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class PointDataTests
    {
        [TestMethod]
        public void XmlTest()
        {
            var pointData = new PointData();
            const string name = "Some random name 23490371";
            pointData.DataArrays.Add(new DataArray()
            {
                Name = name,
            });

            var element = XmlHelper.ToXElement(pointData);
            Assert.AreEqual(name, element.Element("DataArray").Attribute("Name").Value);
        }
    }
}