// <copyright file="DataArrayTests.cs" company="Huang, Zhaoquan">
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
using Taoyouh.VtkFile;
using Taoyouh.VtkFile.Tests;

namespace Taoyouh.VtkFile.Xml.Tests
{
    [TestClass]
    public class DataArrayTests
    {
        [TestMethod]
        public void XmlTest()
        {
            DataArray array = new DataArray();
            array.FillData(new long[]
            {
                1, 2, 3, 4, 5,
            });

            var element = XmlHelper.ToXElement(array);
            Assert.AreEqual("Int64", element.Attribute("type").Value);
        }
    }
}