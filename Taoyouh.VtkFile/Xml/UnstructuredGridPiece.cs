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
    /// Represents the "Piece" XML element under <see cref="UnstructuredGrid"/>.
    /// </summary>
    public class UnstructuredGridPiece
    {
        /// <summary>
        /// The total number of points in the piece of grid.
        /// </summary>
        [XmlIgnore]
        public int? NumberOfPoints { get; set; }

        /// <summary>
        /// The total number of cells in the piece of grid.
        /// </summary>
        [XmlIgnore]
        public int? NumberOfCells { get; set; }

        /// <summary>
        /// The point data (values defined on points) of the piece of grid.
        /// </summary>
        [XmlElement]
        public PointCellData PointData { get; set; }

        /// <summary>
        /// The cell data (values defined on cells) of the piece of grid.
        /// </summary>
        [XmlElement]
        public PointCellData CellData { get; set; }

        /// <summary>
        /// The point coordinates of the piece of grid.
        /// </summary>
        [XmlElement]
        public Points Points { get; set; }

        /// <summary>
        /// The cells of the piece of grid.
        /// </summary>
        [XmlElement]
        public Cells Cells { get; set; }

        /// <summary>
        /// The string of <see cref="NumberOfPoints"/> for XML serialization.
        /// </summary>
        [XmlAttribute("NumberOfPoints")]
        public string NumberOfPointsString
        {
            get => NumberOfPoints?.ToString(CultureInfo.InvariantCulture);
            set => NumberOfPoints = value == null ? null : (int?)int.Parse(value);
        }

        /// <summary>
        /// The string of <see cref="NumberOfCells"/> for XML serialization.
        /// </summary>
        [XmlAttribute("NumberOfCells")]
        public string NumberOfCellsString
        {
            get => NumberOfCells?.ToString(CultureInfo.InvariantCulture);
            set => NumberOfCells = value == null ? null : (int?)int.Parse(value);
        }
    }
}
