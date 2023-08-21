using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Quaternions
{
    /// <summary>
    /// A parametric 4D curve with continuous first derivative
    /// </summary>
    public interface IParametricQuaternion :
        IGeometricElement
    {
        Float64Range1D ParameterRange { get; }
        
        Float64Quaternion GetPoint(double parameterValue);

        Float64Quaternion GetDerivative1Point(double parameterValue);
    }
}