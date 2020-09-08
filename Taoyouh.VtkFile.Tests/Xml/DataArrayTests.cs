using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoyouh.VtkFile;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class DataArrayTests
    {
        [TestMethod]
        public void DataArrayTest()
        {
            DataArray array = new DataArray();
            array.FillData(new long[]
            {
                1, 2, 3, 4, 5,
            });

            var serializer = new XmlSerializer(typeof(DataArray), string.Empty);
            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, array);
                stream.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(stream))
                {
                    var str = reader.ReadToEnd();
                }
            }
        }
    }
}