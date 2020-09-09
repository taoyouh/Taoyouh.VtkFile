// <copyright file="DataArrayType.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// The values of "type" attribute in <see cref="DataArray"/> XML element.
    /// See VTK User's Guide 11th Edition p.501.
    /// </summary>
    public enum DataArrayType
    {
#pragma warning disable SA1602 // Enumeration items should be documented
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Int8,
        UInt8,
        Int16,
        UInt16,
        Int32,
        UInt32,
        Int64,
        UInt64,
        Float32,
        Float64,
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}
