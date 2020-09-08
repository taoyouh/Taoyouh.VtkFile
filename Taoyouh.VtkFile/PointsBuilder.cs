using System;
using System.Collections.Generic;
using System.Text;
using Taoyouh.VtkFile.Xml;

namespace Taoyouh.VtkFile
{
    public class PointsBuilder
    {
        // x1, y1, z1, x2, y2, z2, ...
        private readonly List<double> points = new List<double>();

        public int Count => points.Count / 3;

        public void AddPoint(double x, double y, double z)
        {
            points.Add(x);
            points.Add(y);
            points.Add(z);
        }

        public Points ToXml()
        {
            var pointsXml = new Points();
            pointsXml.FillPoints(points);
            return pointsXml;
        }
    }
}
