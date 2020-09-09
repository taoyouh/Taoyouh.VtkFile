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
    public class UnstructuredGridFileBuilder
    {
        public List<UnstructuredGridPieceBuilder> Pieces { get; } = new List<UnstructuredGridPieceBuilder>();

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
