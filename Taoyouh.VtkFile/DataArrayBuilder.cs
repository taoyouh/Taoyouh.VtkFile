// <copyright file="DataArrayBuilder.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    /// <summary>
    /// The builder to store data for building a <see cref="DataArray"/> XML element.
    /// </summary>
    /// <typeparam name="T">
    /// The type of data element. It must be a primitive number type listed in <see cref="DataArrayType"/>.
    /// </typeparam>
    public class DataArrayBuilder<T> : IDataArrayBuilder
        where T : IConvertible
    {
        private readonly List<T> data = new List<T>();
        private readonly DataArrayType type;

        /// <summary>
        /// Creates an instance of <see cref="DataArrayBuilder{T}"/>.
        /// </summary>
        /// <param name="name">
        /// The name of the data array.
        /// </param>
        /// <param name="numberOfComponents">
        /// The number of components per value (e.g., per point / per cell).
        /// </param>
        /// <exception cref="NotSupportedException">
        /// The type <typeparamref name="T"/> is not supported by DataArray XML element.
        /// </exception>
        public DataArrayBuilder(string name, uint numberOfComponents = 1)
        {
            this.Name = name;
            this.NumberOfComponents = numberOfComponents;
            if (default(T) is int)
            {
                type = DataArrayType.Int32;
            }
            else if (default(T) is uint)
            {
                type = DataArrayType.UInt32;
            }
            else if (default(T) is long)
            {
                type = DataArrayType.Int64;
            }
            else if (default(T) is ulong)
            {
                type = DataArrayType.UInt64;
            }
            else if (default(T) is float)
            {
                type = DataArrayType.Float32;
            }
            else if (default(T) is double)
            {
                type = DataArrayType.Float64;
            }
            else if (default(T) is byte)
            {
                type = DataArrayType.UInt8;
            }
            else if (default(T) is sbyte)
            {
                type = DataArrayType.Int8;
            }
            else if (default(T) is short)
            {
                type = DataArrayType.Int16;
            }
            else if (default(T) is ushort)
            {
                type = DataArrayType.UInt16;
            }
            else
            {
                throw new NotSupportedException("The given type T is not supported by DataArray.");
            }
        }

        /// <summary>
        /// Gets the name of the data array.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the number of components per data point.
        /// </summary>
        public uint NumberOfComponents { get; }

        /// <summary>
        /// Appends a scalar value to the data array.
        /// </summary>
        /// <param name="value">The value to be appended.</param>
        /// <exception cref="InvalidOperationException">
        /// <see cref="NumberOfComponents"/> was set to not 1. A vector is expected but a scalar is appended.
        /// </exception>
        public void AddScalarDatum(T value)
        {
            if (NumberOfComponents != 1)
            {
                throw new InvalidOperationException("To add scalar datum, numberOfComponents must be 1.");
            }

            data.Add(value);
        }

        /// <summary>
        /// Appends a vector value to the data array.
        /// </summary>
        /// <param name="value">The vector components to be appended.</param>
        /// <exception cref="InvalidOperationException">
        /// Length of <paramref name="value"/> does not equal to <see cref="NumberOfComponents"/>.
        /// </exception>
        public void AddVectorDatum(IEnumerable<T> value)
        {
            if (value.Count() != NumberOfComponents)
            {
                throw new InvalidOperationException("The number of components in each vector datum must match numberOfComponents.");
            }

            data.AddRange(value);
        }

        /// <summary>
        /// Builds the XML element for serializing.
        /// </summary>
        /// <returns>The <see cref="DataArray"/> instance that represents the XML element.</returns>
        public DataArray ToXml()
        {
            DataArray array = new DataArray();
            array.NumberOfComponents = NumberOfComponents;
            array.Name = Name;
            array.FillData(data, type);
            return array;
        }
    }
}
