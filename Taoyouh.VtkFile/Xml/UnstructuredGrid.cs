using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class UnstructuredGrid
    {
        [XmlElement("Piece")]
        public List<UnstructuredGridPiece> Pieces { get; } = new List<UnstructuredGridPiece>();
    }
}
