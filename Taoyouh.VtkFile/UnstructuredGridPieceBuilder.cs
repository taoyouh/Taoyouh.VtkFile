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
    public class UnstructuredGridPieceBuilder
    {
        public PointsBuilder Points { get; } = new PointsBuilder();

        public CellsBuilder Cells { get; } = new CellsBuilder();

        public PointCellDataBuilder PointData { get; } = new PointCellDataBuilder();

        public PointCellDataBuilder CellData { get; } = new PointCellDataBuilder();

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
