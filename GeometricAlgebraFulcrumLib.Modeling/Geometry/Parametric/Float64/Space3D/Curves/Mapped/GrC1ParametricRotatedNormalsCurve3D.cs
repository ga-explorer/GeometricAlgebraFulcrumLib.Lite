﻿using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Float64.Angles;
using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Algebra.Scalars.Float64;

namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space3D.Curves.Mapped;

public class GrParametricRotatedNormalsCurve3D :
    IParametricCurve3D
{
    public IParametricCurve3D BaseCurve { get; }

    public Func<double, LinFloat64Angle> AngleFunction { get; }

    public Float64ScalarRange ParameterRange
        => BaseCurve.ParameterRange;


    public GrParametricRotatedNormalsCurve3D(IParametricCurve3D baseCurve, Func<double, LinFloat64Angle> angleFunction)
    {
        BaseCurve = baseCurve;
        AngleFunction = angleFunction;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValid()
    {
        return BaseCurve.IsValid();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LinFloat64Vector3D GetPoint(double parameterValue)
    {
        return BaseCurve.GetPoint(parameterValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LinFloat64Vector3D GetDerivative1Point(double parameterValue)
    {
        return BaseCurve.GetDerivative1Point(parameterValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ParametricCurveLocalFrame3D GetFrame(double parameterValue)
    {
        return BaseCurve
            .GetFrame(parameterValue)
            .RotateNormalsBy(
                AngleFunction(parameterValue)
            );
    }
}