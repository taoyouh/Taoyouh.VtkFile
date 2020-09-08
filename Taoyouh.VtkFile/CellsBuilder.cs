using System;
using System.Collections.Generic;
using System.Text;

namespace Taoyouh.VtkFile
{
    /// <summary>
    /// Builder for building VTK cell data. Used in <see cref="Cells.FillCells(CellsBuilder)"/>.
    /// </summary>
    public class CellsBuilder
    {
        // For definitions of each arrays see VTKUsersGuide.pdf p.487
        internal List<int> Connectivity { get; } = new List<int>();

        internal List<int> Offsets { get; } = new List<int>();

        internal List<byte> Types { get; } = new List<byte>();

        public void AddCell(IEnumerable<int> points, CellType type)
        {
            Connectivity.AddRange(points);
            Offsets.Add(Connectivity.Count - 1);
            Types.Add((byte)type);
        }
    }
}
