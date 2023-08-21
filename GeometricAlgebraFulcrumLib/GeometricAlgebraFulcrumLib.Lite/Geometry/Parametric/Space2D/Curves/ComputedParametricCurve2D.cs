using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Differential.Functions;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Frames;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;
using MathNet.Numerics;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space2D.Curves
{
    public class ComputedParametricCurve2D :
        IParametricCurve2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricCurve2D Create(Func<double, Float64Vector2D> getPointFunc)
        {
            return new ComputedParametricCurve2D(getPointFunc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricCurve2D Create(Func<double, Float64Vector2D> getPointFunc, Func<double, Float64Vector2D> getTangentFunc)
        {
            return new ComputedParametricCurve2D(getPointFunc, getTangentFunc);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricCurve2D Create(DifferentialFunction xFunc, DifferentialFunction yFunc)
        {
            var xDtFunc = xFunc.GetDerivative1();
            var yDtFunc = yFunc.GetDerivative1();
            
            return Create(t => Float64Vector2D.Create((Float64Scalar)xFunc.GetValue(t),
                    (Float64Scalar)yFunc.GetValue(t)),
                t => Float64Vector2D.Create((Float64Scalar)xDtFunc.GetValue(t),
                    (Float64Scalar)yDtFunc.GetValue(t)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricCurve2D Create(Func<double, double> xFunc, Func<double, double> yFunc)
        {
            return Create(t => Float64Vector2D.Create((Float64Scalar)xFunc(t),
                    (Float64Scalar)yFunc(t)),
                t => Float64Vector2D.Create((Float64Scalar)Differentiate.FirstDerivative(xFunc, t),
                    (Float64Scalar)Differentiate.FirstDerivative(yFunc, t)));
        }


        public Float64Range1D ParameterRange 
            => Float64Range1D.Infinite;
        
        public Func<double, Float64Vector2D> GetPointFunc { get; }

        public Func<double, Float64Vector2D>? GetTangentFunc { get; }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ComputedParametricCurve2D(Func<double, Float64Vector2D> getPointFunc)
        {
            GetPointFunc = getPointFunc;
            GetTangentFunc = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ComputedParametricCurve2D(Func<double, Float64Vector2D> getPointFunc, Func<double, Float64Vector2D> getTangentFunc)
        {
            GetPointFunc = getPointFunc;
            GetTangentFunc = getTangentFunc;
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsValid()
        {
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Vector2D GetPoint(double parameterValue)
        {
            return GetPointFunc(parameterValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Vector2D GetDerivative1Point(double parameterValue)
        {
            if (GetTangentFunc is not null)
                return GetTangentFunc(parameterValue);

            const double epsilon = 1e-7;

            var p1 = GetPointFunc(parameterValue - epsilon);
            var p2 = GetPointFunc(parameterValue + epsilon);

            return (p2 - p1) / (2 * epsilon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ParametricCurveLocalFrame2D GetFrame(double parameterValue)
        {
            return ParametricCurveLocalFrame2D.Create(
                parameterValue,
                GetPoint(parameterValue),
                GetDerivative1Point(parameterValue)
            );
        }
    }
}