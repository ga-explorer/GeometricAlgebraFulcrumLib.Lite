using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Frames;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Curves.Samplers
{
    public interface IParametricCurveSampler3D :
        IGeometricElement,
        IReadOnlyList<ParametricCurveLocalFrame3D>
    {
        IParametricCurve3D Curve { get; }

        Float64Range1D ParameterRange { get; }
        
        bool IsPeriodic { get; }

        IEnumerable<double> GetParameterValues();

        IEnumerable<Float64Range1D> GetParameterSections();

        IEnumerable<Float64Vector3D> GetPoints();

        IEnumerable<Float64Vector3D> GetTangents();

        IEnumerable<ParametricCurveLocalFrame3D> GetFrames();
    }
}
