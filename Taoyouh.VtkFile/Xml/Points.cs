// <copyright file="Points.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class Points
    {
        public DataArray DataArray { get; set; }

        public void FillPoints(IEnumerable<double> points)
        {
            var dataArray = new DataArray();
            dataArray.FillData(points);
            dataArray.NumberOfComponents = 3;

            DataArray = dataArray;
        }
    }
}