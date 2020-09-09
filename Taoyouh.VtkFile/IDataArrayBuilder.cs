using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    public interface IDataArrayBuilder
    {
        string Name { get; }

        DataArray ToXml();
    }
}
