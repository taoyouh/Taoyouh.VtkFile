# Taoyouh.VtkFile
A .NET Standard (2.0) library for writing VTK XML files. (Currently only unstructured grid is supported.)

## Usage
1. The library can be obtained from [Nuget](https://www.nuget.org/packages/Taoyouh.VtkFile/1.0.0-rc3).

2. Build your unstructured grid using class `Taoyouh.Vtkfile.UnstructuredFileBuilder`.

3. Call the `ToXml()` method of the builder class to get the XML object, and then use the `Save(Stream)` function to save a file. (Remember the extension is .vtu for unstrctured grid files.)

## Sample code

```C#
var builder = new UnstructuredGridFileBuilder();

// A VTK file can have multiple pieces of grids.
var pieceBuilder = new UnstructuredGridPieceBuilder();
builder.Pieces.Add(pieceBuilder);

// Add points to the piece of grid.
pieceBuilder.Points.AddPoint(0, 0, 0);
pieceBuilder.Points.AddPoint(1, 0, 0);
pieceBuilder.Points.AddPoint(0, 1, 0);
pieceBuilder.Points.AddPoint(0, 0, 1);
// Add cells to the piece of grid.
pieceBuilder.Cells.AddCell(new[] { 0, 1, 2, 3 }, Xml.CellType.Tetra);

// Point data are data defined at points.
var pointData = new DataArrayBuilderInt32("point data");
pointData.AddScalarDatum(0);
pointData.AddScalarDatum(1);
pointData.AddScalarDatum(2);
pointData.AddScalarDatum(3);
pieceBuilder.PointData.DataArrays.Add(pointData);

// Cell data are data defined in cells.
var cellData = new DataArrayBuilderInt32("cell data");
cellData.AddScalarDatum(111);
pieceBuilder.CellData.DataArrays.Add(cellData);

// Get the XML object.
var vtkFile = builder.ToXml();

// Serialize the object to a file.
using (var stream = File.Create("UnstructuredGridFileBuilderTests.vtu"))
{
    vtkFile.Save(stream);
}
```