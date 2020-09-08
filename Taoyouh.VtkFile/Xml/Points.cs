using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class Points
    {
        public DataArray DataArray { get; set; }

        public void FillPoints(IEnumerable<double> points)
        {
            var dataArray = new DataArray();
            dataArray.FillData(points);
            dataArray.NumberOfComponents = 3;

            DataArray = dataArray;
        }
    }
}