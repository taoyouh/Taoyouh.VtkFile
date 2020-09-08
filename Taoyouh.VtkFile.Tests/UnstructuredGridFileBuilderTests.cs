using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoyouh.VtkFile;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile.Tests
{
    [TestClass]
    public class UnstructuredGridFileBuilderTests
    {
        [TestMethod]
        public void ToXmlTest()
        {
            var builder = new UnstructuredGridFileBuilder();
            var pieceBuilder = new UnstructuredGridPieceBuilder();
            pieceBuilder.Points.AddPoint(0, 0, 0);
            pieceBuilder.Points.AddPoint(1, 0, 0);
            pieceBuilder.Points.AddPoint(0, 1, 0);
            pieceBuilder.Points.AddPoint(0, 0, 1);
            pieceBuilder.Cells.AddCell(new[] { 0, 1, 2, 3 }, Xml.CellType.Tetra);

            builder.Pieces.Add(pieceBuilder);
            var vtkFile = builder.ToXml();

            var xmlSerializer = new XmlSerializer(typeof(VTKFile));
            using (var stream = File.Create("UnstructuredGridFileBuilderTests.vtu"))
            {
                xmlSerializer.Serialize(stream, vtkFile);
            }
        }
    }
}