using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class VTKFile
    {
        [XmlAttribute("type")]
        public VTKFileType Type { get; set; }

        [XmlElement]
        public UnstructuredGrid UnstructuredGrid { get; set; }

        public void SetUnstructuredGrid(UnstructuredGrid grid)
        {
            UnstructuredGrid = grid;
            Type = VTKFileType.UnstructuredGrid;
        }
    }
}
