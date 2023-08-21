using GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.Visuals.Space3D.Images;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.Visuals.Space3D.Grids
{
    public sealed class GrVisualXzSquareGrid3D :
        GrVisualLineGridImage3D
    {
        public IFloat64Vector3D Origin { get; set; } 
            = Float64Vector3D.Create(-12, 0, -12);

        public double UnitSize { get; set; } 
            = 1;

        public int UnitCountX { get; set; } 
            = 24;

        public int UnitCountZ { get; set; } 
            = 24;

        public double SizeX 
            => UnitCountX * UnitSize;

        public double SizeZ 
            => UnitCountZ * UnitSize;

        public double Opacity { get; set; } 
            = 0.2;


        public GrVisualXzSquareGrid3D(string name) 
            : base(name)
        {
        }
    }
}