// <copyright file="UnstructuredGridFileBuilder.cs" company="Huang, Zhaoquan">
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
    /// The builder to store data for building an <see cref="UnstructuredGrid"/> XML element.
    /// </summary>
    public class UnstructuredGridFileBuilder
    {
        /// <summary>
        /// The unrelated pieces of the grid.
        /// </summary>
        public List<UnstructuredGridPieceBuilder> Pieces { get; } = new List<UnstructuredGridPieceBuilder>();

        /// <summary>
        /// Builds the XML element for serializing.
        /// </summary>
        /// <returns>The <see cref="VTKFile"/> instance that represents the XML element.</returns>
        public VTKFile ToXml()
        {
            var unstructuredGrid = new UnstructuredGrid();
            foreach (var pieceBuilder in Pieces)
            {
                unstructuredGrid.Pieces.Add(pieceBuilder.ToXml());
            }

            var vtkFile = new VTKFile();
            vtkFile.SetUnstructuredGrid(unstructuredGrid);
            return vtkFile;
        }
    }
}
