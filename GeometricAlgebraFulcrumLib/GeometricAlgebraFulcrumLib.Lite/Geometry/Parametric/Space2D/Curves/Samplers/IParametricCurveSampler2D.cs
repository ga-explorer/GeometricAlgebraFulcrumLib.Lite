using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Frames;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Curves.Samplers
{
    public interface IParametricCurveSampler2D :
        IGeometricElement,
        IReadOnlyList<ParametricCurveLocalFrame2D>
    {
        IParametricCurve2D Curve { get; }

        Float64Range1D ParameterRange { get; }
        
        bool IsPeriodic { get; }

        IEnumerable<double> GetParameterValues();

        IEnumerable<Float64Range1D> GetParameterSections();

        IEnumerable<Float64Vector2D> GetPoints();

        IEnumerable<Float64Vector2D> GetTangents();

        IEnumerable<ParametricCurveLocalFrame2D> GetFrames();
    }
}
