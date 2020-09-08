using System;
using System.Collections.Generic;
using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    /// <summary>
    /// Builder for building VTK cell data. Used in <see cref="Cells.FillCells(CellsBuilder)"/>.
    /// </summary>
    public class CellsBuilder
    {
        // For definitions of each arrays see VTKUsersGuide.pdf p.487
        private readonly List<int> connectivity = new List<int>();

        private readonly List<int> offsets = new List<int>();

        private readonly List<byte> types = new List<byte>();

        public int Count => types.Count;

        public void AddCell(IEnumerable<int> points, CellType type)
        {
            connectivity.AddRange(points);
            offsets.Add(connectivity.Count);
            types.Add((byte)type);
        }

        public Cells ToXml()
        {
            var cells = new Cells();
            cells.FillCells(connectivity, offsets, types);
            return cells;
        }
    }
}
