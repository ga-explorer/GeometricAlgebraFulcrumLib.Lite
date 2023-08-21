using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Frames;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Curves
{
    /// <summary>
    /// A parametric 3D curve with continuous first derivative
    /// </summary>
    public interface IParametricCurve3D :
        IGeometricElement
    {
        Float64Range1D ParameterRange { get; }
        
        Float64Vector3D GetPoint(double parameterValue);

        Float64Vector3D GetDerivative1Point(double parameterValue);

        ParametricCurveLocalFrame3D GetFrame(double parameterValue);
    }
}