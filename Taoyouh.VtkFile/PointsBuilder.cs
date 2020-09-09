// <copyright file="PointsBuilder.cs" company="Huang, Zhaoquan">
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
    /// The builder to store data for building a <see cref="Points"/> XML element.
    /// </summary>
    public class PointsBuilder
    {
        // x1, y1, z1, x2, y2, z2, ...
        private readonly List<double> points = new List<double>();

        /// <summary>
        /// The count of points.
        /// </summary>
        public int Count => points.Count / 3;

        /// <summary>
        /// Adds a point into the internal list.
        /// </summary>
        /// <param name="x">The x component of the point.</param>
        /// <param name="y">The y component of the point.</param>
        /// <param name="z">The z component of the point.</param>
        public void AddPoint(double x, double y, double z)
        {
            points.Add(x);
            points.Add(y);
            points.Add(z);
        }

        /// <summary>
        /// Builds the XML element for serializing.
        /// </summary>
        /// <returns>The <see cref="Points"/> instance that represents the XML element.</returns>
        public Points ToXml()
        {
            var pointsXml = new Points();
            pointsXml.FillPoints(points);
            return pointsXml;
        }
    }
}
