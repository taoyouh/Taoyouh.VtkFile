using System.Xml.Serialization;

namespace Taoyouh.VtkFile
{
    public enum DataArrayFormat
    {
        [XmlEnum("ascii")]
        Ascii,

        [XmlEnum("binary")]
        Binary,

        [XmlEnum("appended")]
        Appended,
    }
}