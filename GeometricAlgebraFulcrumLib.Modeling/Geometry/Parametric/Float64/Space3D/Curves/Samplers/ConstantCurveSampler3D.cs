﻿using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Algebra.Scalars.Float64;

namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space3D.Curves.Samplers;

public class ConstantCurveSampler3D :
    IParametricCurveSampler3D
{
    public ConstantParametricCurve3D ConstantCurve { get; private set; }

    public IParametricCurve3D Curve
        => ConstantCurve;

    public LinFloat64Vector3D Point
        => ConstantCurve.Point;

    public LinFloat64Vector3D Tangent
        => ConstantCurve.Tangent;

    public Float64ScalarRange ParameterRange { get; private set; }

    public bool IsPeriodic
        => true;

    public int Count
        => 2;

    public ParametricCurveLocalFrame3D this[int index]
    {
        get
        {
            var parameterValue =
                index % 2 == 0
                    ? ParameterRange.MinValue
                    : ParameterRange.MaxValue;

            return ConstantCurve.GetFrame(parameterValue);
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ConstantCurveSampler3D(ILinFloat64Vector3D point, Float64ScalarRange parameterRange)
    {
        ConstantCurve = ConstantParametricCurve3D.Create(point, LinFloat64Vector3D.E1);
        ParameterRange = parameterRange;

        Debug.Assert(IsValid());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ConstantCurveSampler3D(ILinFloat64Vector3D point, ILinFloat64Vector3D tangent, Float64ScalarRange parameterRange)
    {
        ConstantCurve = ConstantParametricCurve3D.Create(point, tangent);
        ParameterRange = parameterRange;

        Debug.Assert(IsValid());
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValid()
    {
        return ParameterRange.IsValid() &&
               ConstantCurve.IsValid();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ConstantCurveSampler3D SetCurve(ILinFloat64Vector3D point, Float64ScalarRange parameterRange)
    {
        ConstantCurve = ConstantParametricCurve3D.Create(point, LinFloat64Vector3D.E1);
        ParameterRange = parameterRange;

        Debug.Assert(IsValid());

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ConstantCurveSampler3D SetCurve(ILinFloat64Vector3D point, ILinFloat64Vector3D tangent, Float64ScalarRange parameterRange)
    {
        ConstantCurve = ConstantParametricCurve3D.Create(point, tangent);
        ParameterRange = parameterRange;

        Debug.Assert(IsValid());

        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<Float64Scalar> GetParameterValues()
    {
        yield return ParameterRange.MinValue;
        yield return ParameterRange.MaxValue;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<Float64ScalarRange> GetParameterSections()
    {
        yield return ParameterRange;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<LinFloat64Vector3D> GetPoints()
    {
        yield return Point;
        yield return Point;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<LinFloat64Vector3D> GetTangents()
    {
        yield return Tangent;
        yield return Tangent;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<ParametricCurveLocalFrame3D> GetFrames()
    {
        yield return ConstantCurve.GetFrame(ParameterRange.MinValue);
        yield return ConstantCurve.GetFrame(ParameterRange.MaxValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerator<ParametricCurveLocalFrame3D> GetEnumerator()
    {
        return GetFrames().GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}