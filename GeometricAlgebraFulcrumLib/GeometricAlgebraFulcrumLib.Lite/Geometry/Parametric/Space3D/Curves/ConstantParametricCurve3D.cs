﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Borders;
using GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Frames;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Parametric.Space3D.Curves;

public class ConstantParametricCurve3D :
    IParametricCurve3D
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ConstantParametricCurve3D Create(IFloat64Vector3D point)
    {
        return new ConstantParametricCurve3D(
            point, 
            Float64Vector3D.UnitSymmetric
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ConstantParametricCurve3D Create(IFloat64Vector3D point, IFloat64Vector3D tangent)
    {
        return new ConstantParametricCurve3D(
            point, 
            tangent
        );
    }


    public Float64Vector3D Point { get; }
    
    public Float64Vector3D Tangent { get; }

    public Float64Range1D ParameterRange 
        => Float64Range1D.Infinite;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ConstantParametricCurve3D(IFloat64Vector3D point, IFloat64Vector3D tangent)
    {
        Point = point.ToVector3D();
        Tangent = tangent.ToVector3D();

        Debug.Assert(IsValid());
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValid()
    {
        return Point.IsValid() && 
               Tangent.IsValid();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Float64Vector3D GetPoint(double parameterValue)
    {
        return Point;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Float64Vector3D GetDerivative1Point(double parameterValue)
    {
        return Tangent;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ParametricCurveLocalFrame3D GetFrame(double parameterValue)
    {
        return ParametricCurveLocalFrame3D.Create(
            parameterValue,
            Point,
            Tangent
        );
    }
}