using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Taoyouh.VtkFile.Xml
{
    public class DataArray
    {
        [XmlAttribute("type")]
        public DataArrayType Type { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlIgnore]
        public uint? NumberOfComponents { get; set; }

        [XmlAttribute("format")]
        public DataArrayFormat Format { get; set; }

        [XmlIgnore]
        public uint? Offset { get; set; }

        [XmlText]
        public string Content { get; set; }

        [XmlAttribute("NumberOfComponents")]
        public string NumberOfComponentsString
        {
            get => NumberOfComponents?.ToString(CultureInfo.InvariantCulture);
            set => NumberOfComponents = value == null ? null : (uint?)uint.Parse(value, CultureInfo.InvariantCulture);
        }

        [XmlAttribute("offset")]
        public string OffsetString
        {
            get => Offset?.ToString(CultureInfo.InvariantCulture);
            set => Offset = value == null ? null : (uint?)uint.Parse(value, CultureInfo.InvariantCulture);
        }

        public void FillData(IEnumerable<long> data)
            => FillData(data, DataArrayType.Int64);

        public void FillData(IEnumerable<int> data)
            => FillData(data, DataArrayType.Int32);

        public void FillData(IEnumerable<double> data)
            => FillData(data, DataArrayType.Float64);

        public void FillData(IEnumerable<float> data)
            => FillData(data, DataArrayType.Float32);

        public void FillData(IEnumerable<byte> data)
            => FillData(data, DataArrayType.UInt8);

        private void FillData<T>(IEnumerable<T> data, DataArrayType type)
            where T : IConvertible
        {
            StringBuilder contentString = new StringBuilder();
            foreach (var datum in data)
            {
                contentString.Append(datum.ToString(CultureInfo.InvariantCulture));
                contentString.Append(' ');
            }

            if (contentString.Length > 0)
            {
                contentString.Remove(contentString.Length - 1, 1);
            }

            Type = type;
            Content = contentString.ToString();
        }
    }
}
