// <copyright file="UnstructuredGridPieceBuilder.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    /// <summary>
    /// The builder to store data for building a "Piece" XML element
    /// (see <see cref="UnstructuredGridPiece"/>).
    /// </summary>
    public class UnstructuredGridPieceBuilder
    {
        /// <summary>
        /// Gets the point / node coordinates builder.
        /// </summary>
        public PointsBuilder Points { get; } = new PointsBuilder();

        /// <summary>
        /// Gets the cell / element builder.
        /// </summary>
        public CellsBuilder Cells { get; } = new CellsBuilder();

        /// <summary>
        /// Gets the point data builder (values defined at points / nodes).
        /// </summary>
        public PointCellDataBuilder PointData { get; } = new PointCellDataBuilder();

        /// <summary>
        /// Gets the cell data builder (values defined in cells).
        /// </summary>
        public PointCellDataBuilder CellData { get; } = new PointCellDataBuilder();

        /// <summary>
        /// Builds the XML element for serializing.
        /// </summary>
        /// <returns>The <see cref="UnstructuredGridPiece"/> instance that represents the XML element.</returns>
        public UnstructuredGridPiece ToXml()
        {
            var piece = new UnstructuredGridPiece();
            piece.Cells = Cells.ToXml();
            piece.Points = Points.ToXml();
            piece.PointData = PointData.ToXml();
            piece.CellData = CellData.ToXml();
            piece.NumberOfCells = Cells.Count;
            piece.NumberOfPoints = Points.Count;
            return piece;
        }
    }
}
