using System;
using System.Collections.Generic;
using System.Text;

namespace Taoyouh.VtkFile
{
    /// <summary>
    /// Possible values of "type" in DataArray.
    /// See VTKUsersGuide.pdf p.501.
    /// </summary>
    public enum DataArrayType
    {
        Int8,
        UInt8,
        Int16,
        UInt16,
        Int32,
        UInt32,
        Int64,
        UInt64,
        Float32,
        Float64
    }
}
