// <copyright file="UnstructuredGrid.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// Represents the "UnstructuredGrid" XML element under <see cref="VTKFile"/>.
    /// </summary>
    public class UnstructuredGrid
    {
        [XmlElement("Piece")]
        public List<UnstructuredGridPiece> Pieces { get; } = new List<UnstructuredGridPiece>();
    }
}
