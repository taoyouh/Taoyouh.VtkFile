using System;
using System.Collections.Generic;
using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    public class PointDataBuilder
    {
        public List<IDataArrayBuilder> DataArrays { get; } = new List<IDataArrayBuilder>();

        public IDataArrayBuilder Scalars { get; set; }

        public IDataArrayBuilder Vectors { get; set; }

        public IDataArrayBuilder Normals { get; set; }

        public IDataArrayBuilder Tensors { get; set; }

        public IDataArrayBuilder TCoords { get; set; }

        public PointData ToXml()
        {
            var pointData = new PointData()
            {
                Scalars = Scalars?.Name,
                Vectors = Vectors?.Name,
                Normals = Normals?.Name,
                Tensors = Tensors?.Name,
                TCoords = TCoords?.Name,
            };

            foreach (var item in DataArrays)
            {
                pointData.DataArrays.Add(item.ToXml());
            }

            return pointData;
        }
    }
}
