// <copyright file="CellsTests.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoyouh.VtkFile.Tests;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class CellsTests
    {
        [TestMethod]
        public void XmlTest()
        {
            var cells = new Cells();
            cells.FillCells(
                new[] { 0, 1, 2, 3 },
                new[] { 4 },
                new byte[] { 10 });
            var element = XmlHelper.ToXElement(cells);
            element.Elements("DataArray").Single(d => d.Attribute("Name").Value == "connectivity");
            element.Elements("DataArray").Single(d => d.Attribute("Name").Value == "offsets");
            element.Elements("DataArray").Single(d => d.Attribute("Name").Value == "types");
        }
    }
}