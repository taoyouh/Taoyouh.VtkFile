// <copyright file="CellType.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Taoyouh.VtkFile.Xml
{
    public enum CellType : byte
    {
        // Refer to VTK user guide for definitons of each cell type.
#pragma warning disable SA1602 // Enumeration items should be documented
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
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}
