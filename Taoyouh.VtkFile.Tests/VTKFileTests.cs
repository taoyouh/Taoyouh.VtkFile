using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taoyouh.VtkFile.Tests
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

            grid.Pieces = new List<Piece>();
            var piece = new Piece();
            grid.Pieces.Add(piece);

            piece.Points = new Points();
            piece.Points.FillPoints(
                new double[]
                {
                    0, 0, 0,
                    1, 0, 0,
                    0, 1, 0,
                    0, 0, 1,
                },
                3);

            var cellsBuilder = new CellsBuilder();
            cellsBuilder.AddCell(new int[] { 0, 1, 2, 3 }, CellType.Tetra);
            piece.Cells = new Cells();
            piece.Cells.FillCells(cellsBuilder);

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
