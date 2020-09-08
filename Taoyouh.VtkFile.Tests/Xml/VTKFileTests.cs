using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class VTKFileTests
    {
        [TestMethod]
        public void VTKFileTest()
        {
            var vtkFile = new VTKFile();

            var grid = new UnstructuredGrid();
            vtkFile.SetUnstructuredGrid(grid);

            var piece = new UnstructuredGridPiece();
            grid.Pieces.Add(piece);

            piece.Points = new Points();
            piece.Points.FillPoints(
                new double[]
                {
                    0, 0, 0,
                    1, 0, 0,
                    0, 1, 0,
                    0, 0, 1,
                });

            piece.Cells = new Cells();
            piece.Cells.FillCells(
                new int[] { 0, 1, 2, 3 },
                new int[] { 4 },
                new byte[] { (byte)CellType.Tetra });

            piece.NumberOfCells = 1;
            piece.NumberOfPoints = 4;

            var xmlSerializer = new XmlSerializer(typeof(VTKFile));
            using (var stream = File.Create("VTKFileTest.vtu"))
            {
                xmlSerializer.Serialize(stream, vtkFile);
            }
        }
    }
}
