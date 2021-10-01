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
    /// <summary>
    /// Represents the types of each cell in the "types" array under <see cref="Cells"/> XML element.
    /// Refer to VTK User's Guide 11th Edition p.481 for definitons of each cell type.
    /// </summary>
    public enum CellType : byte
    {
#pragma warning disable SA1602 // Enumeration items should be documented
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
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
        QuadraticEdge = 21,
        QuadraticTriangle,
        QuadraticQuad,
        QuadraticTetra,
        QuadraticHexahedron,
        QuadraticWedge,
        QuadraticPyramid,
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}
