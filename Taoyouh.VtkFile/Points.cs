using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile
{
    public class Points
    {
        public DataArray DataArray { get; set; }

        public void FillPoints(IEnumerable<double> points, uint componentsPerPoint)
        {
            var dataArray = new DataArray();
            dataArray.FillData(points);
            dataArray.NumberOfComponents = componentsPerPoint;

            DataArray = dataArray;
        }
    }
}