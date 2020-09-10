// <copyright file="IDataArrayBuilder.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    /// <summary>
    /// The common interface of DataArrayBuilder's.
    /// The class can produce the data structure representing a "DataArray" element.
    /// </summary>
    public interface IDataArrayBuilder
    {
        /// <summary>
        /// The name of the data array.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Builds the XML element for serializing.
        /// </summary>
        /// <returns>The <see cref="DataArray"/> instance that represents the XML element.</returns>
        DataArray ToXml();
    }
}
