using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public enum DataArrayFormat
    {
        // Refer to VTK user guide for definitions of each data array format.
#pragma warning disable SA1602 // Enumeration items should be documented
        [XmlEnum("ascii")]
        Ascii,

        [XmlEnum("binary")]
        Binary,

        [XmlEnum("appended")]
        Appended,
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}