﻿using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Differential.Functions;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Curves;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;
using MathNet.Numerics;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Bivectors
{
    public class ComputedParametricBivector3D :
        IParametricBivector3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Func<double, Float64Bivector3D> getBivectorFunc)
        {
            return new ComputedParametricBivector3D(
                Float64ScalarRange.Infinite, 
                getBivectorFunc
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Float64ScalarRange parameterRange, Func<double, Float64Bivector3D> getBivectorFunc)
        {
            return new ComputedParametricBivector3D(
                parameterRange, 
                getBivectorFunc
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Func<double, Float64Bivector3D> getBivectorFunc, Func<double, Float64Bivector3D> getTangentFunc)
        {
            return new ComputedParametricBivector3D(
                Float64ScalarRange.Infinite, 
                getBivectorFunc, 
                getTangentFunc
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Float64ScalarRange parameterRange, Func<double, Float64Bivector3D> getBivectorFunc, Func<double, Float64Bivector3D> getTangentFunc)
        {
            return new ComputedParametricBivector3D(
                parameterRange, 
                getBivectorFunc, 
                getTangentFunc
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(DifferentialFunction xyFunc, DifferentialFunction xzFunc, DifferentialFunction yzFunc)
        {
            return Create(
                Float64ScalarRange.Infinite, 
                xyFunc, 
                xzFunc,
                yzFunc
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Float64ScalarRange parameterRange, DifferentialFunction xyFunc, DifferentialFunction xzFunc, DifferentialFunction yzFunc)
        {
            var xyDtFunc = xyFunc.GetDerivative1();
            var xzDtFunc = xzFunc.GetDerivative1();
            var yzDtFunc = yzFunc.GetDerivative1();
            
            return new ComputedParametricBivector3D(
                parameterRange, 
                t => 
                    Float64Bivector3D.Create(
                        xyFunc.GetValue(t), 
                        xzFunc.GetValue(t), 
                        yzFunc.GetValue(t)
                    ),
                t => 
                    Float64Bivector3D.Create(
                        xyDtFunc.GetValue(t), 
                        xzDtFunc.GetValue(t), 
                        yzDtFunc.GetValue(t)
                    )
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Func<double, double> xyFunc, Func<double, double> xzFunc, Func<double, double> yzFunc)
        {
            return Create(
                Float64ScalarRange.Infinite, 
                xyFunc, 
                xzFunc, 
                yzFunc
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ComputedParametricBivector3D Create(Float64ScalarRange parameterRange, Func<double, double> xyFunc, Func<double, double> xzFunc, Func<double, double> yzFunc)
        {
            return new ComputedParametricBivector3D(
                parameterRange, 
                t => 
                    Float64Bivector3D.Create(
                        xyFunc(t), 
                        xzFunc(t), 
                        yzFunc(t)
                    ),
                t => 
                    Float64Bivector3D.Create(
                        Differentiate.FirstDerivative(xyFunc, t),
                        Differentiate.FirstDerivative(xzFunc, t),
                        Differentiate.FirstDerivative(yzFunc, t)
                    )
                );
        }


        public Float64ScalarRange ParameterRange { get; }
        
        public Func<double, Float64Bivector3D> GetBivectorFunc { get; }

        public Func<double, Float64Bivector3D> GetTangentFunc { get; }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ComputedParametricBivector3D(Float64ScalarRange parameterRange, Func<double, Float64Bivector3D> getBivectorFunc)
        {
            ParameterRange = parameterRange;
            GetBivectorFunc = getBivectorFunc;
            GetTangentFunc = 
                t =>
                {
                    const double epsilon = 1e-7;

                    var p1 = getBivectorFunc(t - epsilon);
                    var p2 = getBivectorFunc(t + epsilon);

                    return (p2 - p1) / (2 * epsilon);
                };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ComputedParametricBivector3D(Float64ScalarRange parameterRange, Func<double, Float64Bivector3D> getBivectorFunc, Func<double, Float64Bivector3D> getTangentFunc)
        {
            ParameterRange = parameterRange;
            GetBivectorFunc = getBivectorFunc;
            GetTangentFunc = getTangentFunc;
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsValid()
        {
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Bivector3D GetBivector(double parameterValue)
        {
            return GetBivectorFunc(parameterValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Bivector3D GetDerivative1Bivector(double parameterValue)
        {
            return GetTangentFunc(parameterValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IParametricCurve3D GetDualVectorCurve()
        {
            return ComputedParametricCurve3D.Create(
                ParameterRange,
                t => GetBivector(t).Dual3D()
            );
        }
    }
}