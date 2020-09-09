// <copyright file="VTKFile.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class VTKFile
    {
        [XmlAttribute("type")]
        public VTKFileType Type { get; set; }

        [XmlElement]
        public UnstructuredGrid UnstructuredGrid { get; set; }

        public void SetUnstructuredGrid(UnstructuredGrid grid)
        {
            UnstructuredGrid = grid;
            Type = VTKFileType.UnstructuredGrid;
        }
    }
}
