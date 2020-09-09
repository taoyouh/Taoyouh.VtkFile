// <copyright file="VTKFileTests.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoyouh.VtkFile.Tests;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class VTKFileTests
    {
        [TestMethod]
        public void XmlTest()
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

            piece.PointData = new PointCellData();
            piece.PointData.DataArrays.Add(new DataArray()
            {
                Name = "data array 1",
            });

            piece.CellData = new PointCellData();
            piece.CellData.DataArrays.Add(new DataArray()
            {
                Name = "data array 2",
            });

            var element = XmlHelper.ToXElement(vtkFile);
            var gridElement = element.Element("UnstructuredGrid");
            var pieceElement = gridElement.Element("Piece");
            Assert.IsNotNull(pieceElement.Element("Points").Element("DataArray"));
            Assert.IsNotNull(pieceElement.Element("Cells").Element("DataArray"));
            Assert.AreEqual(
                "data array 1",
                pieceElement.Element("PointData").Element("DataArray").Attribute("Name").Value);
            Assert.AreEqual(
                "data array 2",
                pieceElement.Element("CellData").Element("DataArray").Attribute("Name").Value);
        }
    }
}
