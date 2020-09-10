// <copyright file="DataArray.FillData.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

// The following code is generated from template DataArray.FillData.tt
#pragma warning disable SA1412 // Store files as UTF-8 with byte order mark

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// The type-specific definitions of method "FillData".
    /// </summary>
    public partial class DataArray
    {
        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<byte> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.UInt8;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<sbyte> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.Int8;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<short> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.Int16;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<ushort> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.UInt16;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<int> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.Int32;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<uint> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.UInt32;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<long> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.Int64;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<ulong> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.UInt64;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<float> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.Float32;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Clears and fills the data array with given data.
        /// </summary>
        /// <param name="data">The collection of all components to be filled with.</param>
        public void FillData(IEnumerable<double> data)
        {
            if (Format == DataArrayFormat.Ascii)
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

                Content = contentString.ToString();
                Type = DataArrayType.Float64;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}