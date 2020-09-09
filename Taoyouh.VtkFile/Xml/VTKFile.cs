// <copyright file="VTKFile.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// Represents the root element of a VTK XML file.
    /// </summary>
    public class VTKFile
    {
        /// <summary>
        /// The type of the VTK file. The "type" XML attribute of the "VTKFile" element.
        /// </summary>
        [XmlAttribute("type")]
        public VTKFileType Type { get; set; }

        /// <summary>
        /// The data of the unstructured grid. The "UnstructuredGrid" XML element under the "VTKFile" element.
        /// </summary>
        [XmlElement]
        public UnstructuredGrid UnstructuredGrid { get; set; }

        /// <summary>
        /// Sets the content to the given "UnstructuredGrid" element and
        /// sets <see cref="Type"/> correspondingly.
        /// </summary>
        /// <param name="grid">The given unstructured grid.</param>
        public void SetUnstructuredGrid(UnstructuredGrid grid)
        {
            UnstructuredGrid = grid;
            Type = VTKFileType.UnstructuredGrid;
        }

        /// <summary>
        /// Saves to a VTK XML file (.vti/.vtp/.vtr/...).
        /// </summary>
        /// <param name="stream">The file stream.</param>
        public void Save(Stream stream)
        {
            var xmlSerializer = new XmlSerializer(typeof(VTKFile));
            xmlSerializer.Serialize(stream, this);
        }
    }
}
