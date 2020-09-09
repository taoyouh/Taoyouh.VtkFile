// <copyright file="UnstructuredGridPiece.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// A piece of unstructured grid.
    /// </summary>
    public class UnstructuredGridPiece
    {
        [XmlIgnore]
        public int? NumberOfPoints { get; set; }

        [XmlIgnore]
        public int? NumberOfCells { get; set; }

        [XmlElement]
        public PointData PointData { get; set; }

        [XmlElement]
        public PointData CellData { get; set; }

        [XmlElement]
        public Points Points { get; set; }

        [XmlElement]
        public Cells Cells { get; set; }

        [XmlAttribute("NumberOfPoints")]
        public string NumberOfPointsString
        {
            get => NumberOfPoints?.ToString(CultureInfo.InvariantCulture);
            set => NumberOfPoints = value == null ? null : (int?)int.Parse(value);
        }

        [XmlAttribute("NumberOfCells")]
        public string NumberOfCellsString
        {
            get => NumberOfCells?.ToString(CultureInfo.InvariantCulture);
            set => NumberOfCells = value == null ? null : (int?)int.Parse(value);
        }
    }
}
