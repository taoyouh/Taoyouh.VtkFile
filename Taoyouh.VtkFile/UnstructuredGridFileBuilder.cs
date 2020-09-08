using System;
using System.Collections.Generic;
using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    public class UnstructuredGridFileBuilder
    {
        public List<UnstructuredGridPieceBuilder> Pieces { get; } = new List<UnstructuredGridPieceBuilder>();

        public VTKFile ToXml()
        {
            var unstructuredGrid = new UnstructuredGrid();
            foreach (var pieceBuilder in Pieces)
            {
                unstructuredGrid.Pieces.Add(pieceBuilder.ToXml());
            }

            var vtkFile = new VTKFile();
            vtkFile.SetUnstructuredGrid(unstructuredGrid);
            return vtkFile;
        }
    }
}
