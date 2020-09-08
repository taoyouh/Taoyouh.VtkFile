using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile
{
    public class UnstructuredGrid
    {
        [XmlArray(ElementName = "Piece")]
        public List<Piece> Pieces { get; set; }
    }
}
