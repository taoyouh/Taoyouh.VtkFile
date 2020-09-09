﻿// <copyright file="Cells.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// Represents the "Cells" XML element under <see cref="UnstructuredGridPiece"/>.
    /// </summary>
    public class Cells
    {
        [XmlElement("DataArray")]
        public List<DataArray> DataArrays { get; } = new List<DataArray>();

        public void FillCells(IEnumerable<int> connectivity, IEnumerable<int> offsets, IEnumerable<byte> types)
        {
            var connectivityArray = new DataArray();
            connectivityArray.Name = "connectivity";
            connectivityArray.FillData(connectivity);

            var offsetsArray = new DataArray();
            offsetsArray.Name = "offsets";
            offsetsArray.FillData(offsets);

            var typesArray = new DataArray();
            typesArray.Name = "types";
            typesArray.FillData(types);

            DataArrays.Clear();
            DataArrays.Add(connectivityArray);
            DataArrays.Add(offsetsArray);
            DataArrays.Add(typesArray);
        }
    }
}