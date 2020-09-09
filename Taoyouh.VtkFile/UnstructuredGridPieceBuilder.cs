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

        public PointDataBuilder PointData { get; } = new PointDataBuilder();

        public UnstructuredGridPiece ToXml()
        {
            var piece = new UnstructuredGridPiece();
            piece.Cells = Cells.ToXml();
            piece.Points = Points.ToXml();
            piece.PointData = PointData.ToXml();
            piece.NumberOfCells = Cells.Count;
            piece.NumberOfPoints = Points.Count;
            return piece;
        }
    }
}
