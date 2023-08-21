using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Frames;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Curves
{
    public interface IParametricCurve2D :
        IGeometricElement
    {
        Float64Range1D ParameterRange { get; }

        Float64Vector2D GetPoint(double t);

        Float64Vector2D GetDerivative1Point(double parameterValue);

        ParametricCurveLocalFrame2D GetFrame(double parameterValue);
    }
}