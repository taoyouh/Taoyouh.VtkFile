﻿// <copyright file="PointsTests.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taoyouh.VtkFile.Tests;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class PointsTests
    {
        [TestMethod]
        public void XmlTest()
        {
            var points = new Points();
            points.FillPoints(new double[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 });
            var element = XmlHelper.ToXElement(points);
            var dataArrayElement = element.Elements("DataArray").Single();
            Assert.AreEqual(3, int.Parse(dataArrayElement.Attribute("NumberOfComponents").Value));
        }
    }
}
