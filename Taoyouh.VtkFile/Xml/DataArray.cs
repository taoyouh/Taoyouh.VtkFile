// <copyright file="DataArray.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// Represents a "DataArray" XML element.
    /// </summary>
    /// <remarks>
    /// See VTK User's Guide 11th Edition p.487 for details.
    /// The documents of the members are taken from the VTK User's Guide.
    /// </remarks>
    public class DataArray
    {
        /// <summary>
        /// Gets or sets the data type of a single component of the array.
        /// </summary>
        [XmlAttribute("type")]
        public DataArrayType Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the array.
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of components per value in the array.
        /// </summary>
        [XmlIgnore]
        public uint? NumberOfComponents { get; set; }

        /// <summary>
        /// Gets or sets the means by which the data values themselves are stored in the file.
        /// </summary>
        [XmlAttribute("format")]
        public DataArrayFormat Format { get; set; }

        /// <summary>
        /// If <see cref="Format"/> is <see cref="DataArrayFormat.Appended"/>, this specifies the
        /// offset from the beginning of the appended data section to the beginning of this
        /// array's data.
        /// </summary>
        [XmlIgnore]
        public uint? Offset { get; set; }

        /// <summary>
        /// The content of the data array as a string.
        /// </summary>
        [XmlText]
        public string Content { get; set; }

        /// <summary>
        /// The string of <see cref="NumberOfComponents"/> used for XML serialization.
        /// </summary>
        [XmlAttribute("NumberOfComponents")]
        public string NumberOfComponentsString
        {
            get => NumberOfComponents?.ToString(CultureInfo.InvariantCulture);
            set => NumberOfComponents = value == null ? null : (uint?)uint.Parse(value, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// The string of <see cref="Offset"/> used for XML serialization.
        /// </summary>
        [XmlAttribute("offset")]
        public string OffsetString
        {
            get => Offset?.ToString(CultureInfo.InvariantCulture);
            set => Offset = value == null ? null : (uint?)uint.Parse(value, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<long> data)
            => FillData(data, DataArrayType.Int64);

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<int> data)
            => FillData(data, DataArrayType.Int32);

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<double> data)
            => FillData(data, DataArrayType.Float64);

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<float> data)
            => FillData(data, DataArrayType.Float32);

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<byte> data)
            => FillData(data, DataArrayType.UInt8);

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <typeparam name="T">The type of a single component.</typeparam>
        /// <param name="data">The collection of all components to be filled with.</param>
        /// <param name="type">The VTK data type corresponding to <typeparamref name="T"/>.</param>
        public void FillData<T>(IEnumerable<T> data, DataArrayType type)
            where T : IConvertible
        {
            StringBuilder contentString = new StringBuilder();
            foreach (var datum in data)
            {
                contentString.Append(datum.ToString(CultureInfo.InvariantCulture));
                contentString.Append(' ');
            }

            if (contentString.Length > 0)
            {
                contentString.Remove(contentString.Length - 1, 1);
            }

            Type = type;
            Content = contentString.ToString();
        }
    }
}
