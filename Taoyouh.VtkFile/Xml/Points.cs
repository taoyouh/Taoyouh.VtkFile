// <copyright file="Points.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// Represents the "Points" XML element under "Piece" element (see <see cref="UnstructuredGridPiece"/>).
    /// </summary>
    public class Points
    {
        /// <summary>
        /// The "DataArray" element that represents the components of point coordinates.
        /// </summary>
        public DataArray DataArray { get; set; }

        /// <summary>
        /// Fills the data array with point coordinates.
        /// </summary>
        /// <param name="points">All coordinate components ordered by point.</param>
        public void FillPoints(IEnumerable<double> points)
        {
            var dataArray = new DataArray();
            dataArray.FillData(points);
            dataArray.NumberOfComponents = 3;

            DataArray = dataArray;
        }
    }
}