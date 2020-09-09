// <copyright file="PointDataTests.cs" company="Huang, Zhaoquan">
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
    public class PointDataTests
    {
        [TestMethod]
        public void XmlTest()
        {
            var pointData = new PointCellData();
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