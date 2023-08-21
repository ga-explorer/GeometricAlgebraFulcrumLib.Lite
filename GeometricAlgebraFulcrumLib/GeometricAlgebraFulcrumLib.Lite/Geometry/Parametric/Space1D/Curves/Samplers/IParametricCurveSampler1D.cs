using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space1D.Frames;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space1D.Curves.Samplers
{
    public interface IParametricCurveSampler1D :
        IGeometricElement,
        IReadOnlyList<ParametricCurveLocalFrame1D>
    {
        IParametricCurve1D Curve { get; }

        Float64Range1D ParameterRange { get; }
        
        bool IsPeriodic { get; }

        IEnumerable<double> GetParameterValues();

        IEnumerable<Float64Range1D> GetParameterSections();

        IEnumerable<double> GetPoints();

        IEnumerable<double> GetTangents();

        IEnumerable<ParametricCurveLocalFrame1D> GetFrames();
    }
}
