using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class PointData
    {
        /// <summary>
        /// The name of the active scalars array, if any.
        /// </summary>
        [XmlAttribute]
        public string Scalars { get; set; }

        /// <summary>
        /// The name of the active vectors array, if any.
        /// </summary>
        [XmlAttribute]

        public string Vectors { get; set; }

        /// <summary>
        /// The name of the active normals array, if any.
        /// </summary>
        [XmlAttribute]
        public string Normals { get; set; }

        /// <summary>
        /// The name of the active tensors array, if any.
        /// </summary>
        [XmlAttribute]
        public string Tensors { get; set; }

        /// <summary>
        /// The name of the active texture coordinates array, if any.
        /// </summary>
        [XmlAttribute]
        public string TCoords { get; set; }

        [XmlElement("DataArray")]
        public List<DataArray> DataArrays { get; } = new List<DataArray>();
    }
}