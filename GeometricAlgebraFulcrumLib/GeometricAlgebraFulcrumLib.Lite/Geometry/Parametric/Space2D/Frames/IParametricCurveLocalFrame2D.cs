using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Frames
{
    public interface IParametricCurveLocalFrame2D :
        IFloat64Vector2D
    {
        int Index { get; }

        Float64Vector2D Point { get; }

        Color Color { get; set; }

        double ParameterValue { get; }

        Float64Vector2D Tangent { get; }
        
        Float64Vector2D Normal { get; }
    }
}