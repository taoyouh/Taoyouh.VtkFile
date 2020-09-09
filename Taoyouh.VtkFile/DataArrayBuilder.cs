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
    public class DataArrayBuilder<T> : IDataArrayBuilder
        where T : IConvertible
    {
        private readonly List<T> data = new List<T>();
        private readonly uint numberOfComponents;
        private readonly DataArrayType type;

        public DataArrayBuilder(string name, uint numberOfComponents = 1)
        {
            this.Name = name;
            this.numberOfComponents = numberOfComponents;
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

        public string Name { get; }

        public void AddScalarDatum(T value)
        {
            if (numberOfComponents != 1)
            {
                throw new InvalidOperationException("To add scalar datum, numberOfComponents must be 1.");
            }

            data.Add(value);
        }

        public void AddVectorDatum(IEnumerable<T> value)
        {
            if (value.Count() != numberOfComponents)
            {
                throw new InvalidOperationException("The number of components in each vector datum must match numberOfComponents.");
            }

            data.AddRange(value);
        }

        public DataArray ToXml()
        {
            DataArray array = new DataArray();
            array.NumberOfComponents = numberOfComponents;
            array.Name = Name;
            array.FillData(data, type);
            return array;
        }
    }
}
