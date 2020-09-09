// <copyright file="XmlHelper.cs" company="Huang, Zhaoquan">
// Copyright (c) Huang, Zhaoquan. All rights reserved.
// This file may be licensed to you as part of the project (see license file if exists),
// but the copyright info in this file should not be removed.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Tests
{
    internal static class XmlHelper
    {
        public static XElement ToXElement<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, obj);
                stream.Seek(0, SeekOrigin.Begin);
                return XElement.Load(stream);
            }
        }
    }
}
