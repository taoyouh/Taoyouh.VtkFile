// <copyright file="PointCellData.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// Represents the "PointData" or "CellData" XML element under the "Piece" element
    /// (see <see cref="UnstructuredGridPiece"/>).
    /// </summary>
    public class PointCellData
    {
        /// <summary>
        /// The name of the active scalars array, if any.
        /// </summary>
        [XmlAttribute]
        public string Scalars { get; set; }

        /// <summary>
        /// The name of the active vectors array, if any.
        /// </summary>
        [XmlAttribute]

        public string Vectors { get; set; }

        /// <summary>
        /// The name of the active normals array, if any.
        /// </summary>
        [XmlAttribute]
        public string Normals { get; set; }

        /// <summary>
        /// The name of the active tensors array, if any.
        /// </summary>
        [XmlAttribute]
        public string Tensors { get; set; }

        /// <summary>
        /// The name of the active texture coordinates array, if any.
        /// </summary>
        [XmlAttribute]
        public string TCoords { get; set; }

        [XmlElement("DataArray")]
        public List<DataArray> DataArrays { get; } = new List<DataArray>();
    }
}