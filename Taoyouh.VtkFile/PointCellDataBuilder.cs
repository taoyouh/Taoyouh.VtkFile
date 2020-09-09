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
    /// <summary>
    /// The builder to store data for building a <see cref="PointCellData"/> XML element.
    /// </summary>
    public class PointCellDataBuilder
    {
        /// <summary>
        /// The list of point data / cell data.
        /// </summary>
        public List<IDataArrayBuilder> DataArrays { get; } = new List<IDataArrayBuilder>();

        /// <summary>
        /// The active scalars array, if any.
        /// </summary>
        public IDataArrayBuilder Scalars { get; set; }

        /// <summary>
        /// The active vectors array, if any.
        /// </summary>
        public IDataArrayBuilder Vectors { get; set; }

        /// <summary>
        /// The active normals array, if any.
        /// </summary>
        public IDataArrayBuilder Normals { get; set; }

        /// <summary>
        /// The active tensors array, if any.
        /// </summary>
        public IDataArrayBuilder Tensors { get; set; }

        /// <summary>
        /// The active texture coordinates array, if any.
        /// </summary>
        public IDataArrayBuilder TCoords { get; set; }

        /// <summary>
        /// Builds the XML element for serializing.
        /// </summary>
        /// <returns>The <see cref="PointCellData"/> instance that represents the XML element.</returns>
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
