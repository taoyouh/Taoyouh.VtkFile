using System;
using System.Collections.Generic;
using System.Text;

namespace Taoyouh.VtkFile
{
    public enum CellType : byte
    {
        Vertex = 1,
        PolyVertex,
        Line,
        PolyLine,
        Triangle,
        TriangleStrip,
        Polygon,
        Pixel,
        Quad,
        Tetra,
        Voxel,
        Hexahedron,
        Wedge,
        Pyramid,
        PentagonalPrism,
        HexagonalPrism,
    }
}
