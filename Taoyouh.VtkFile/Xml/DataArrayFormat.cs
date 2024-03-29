﻿// <copyright file="DataArrayFormat.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    /// <summary>
    /// The values of "format" attribute in <see cref="DataArray"/> XML element.
    /// </summary>
    public enum DataArrayFormat
    {
        // Refer to VTK user guide for definitions of each data array format.
#pragma warning disable SA1602 // Enumeration items should be documented
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        [XmlEnum("ascii")]
        Ascii,

        [XmlEnum("binary")]
        Binary,

        [XmlEnum("appended")]
        Appended,
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}