// <copyright file="PointCellDataBuilder.cs" company="Huang, Zhaoquan">
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
    public class PointCellDataBuilder
    {
        public List<IDataArrayBuilder> DataArrays { get; } = new List<IDataArrayBuilder>();

        public IDataArrayBuilder Scalars { get; set; }

        public IDataArrayBuilder Vectors { get; set; }

        public IDataArrayBuilder Normals { get; set; }

        public IDataArrayBuilder Tensors { get; set; }

        public IDataArrayBuilder TCoords { get; set; }

        public PointCellData ToXml()
        {
            var pointData = new PointCellData()
            {
                Scalars = Scalars?.Name,
                Vectors = Vectors?.Name,
                Normals = Normals?.Name,
                Tensors = Tensors?.Name,
                TCoords = TCoords?.Name,
            };

            foreach (var item in DataArrays)
            {
                pointData.DataArrays.Add(item.ToXml());
            }

            return pointData;
        }
    }
}
