using System.Collections.Generic;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile
{
    public class Cells
    {
        [XmlArray("DataArray")]
        public List<DataArray> DataArrays { get; } = new List<DataArray>();

        public void FillCells(CellsBuilder builder)
        {
            var connectivityArray = new DataArray();
            connectivityArray.Name = "connectivity";
            connectivityArray.FillData(builder.Connectivity);

            var offsetsArray = new DataArray();
            offsetsArray.Name = "offsets";
            offsetsArray.FillData(builder.Offsets);

            var typesArray = new DataArray();
            typesArray.Name = "types";
            typesArray.FillData(builder.Types);

            DataArrays.Clear();
            DataArrays.Add(connectivityArray);
            DataArrays.Add(offsetsArray);
            DataArrays.Add(typesArray);
        }
    }
}