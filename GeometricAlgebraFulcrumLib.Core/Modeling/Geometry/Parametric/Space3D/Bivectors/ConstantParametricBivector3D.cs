﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.Parametric.Space3D.Curves;
using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Core.Algebra.Scalars.Float64;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Geometry.Parametric.Space3D.Bivectors;

public class ConstantParametricBivector3D :
    IParametricBivector3D
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ConstantParametricBivector3D Create(LinFloat64Bivector3D point)
    {
        return new ConstantParametricBivector3D(point);
    }


    public LinFloat64Bivector3D Bivector { get; }
    
    public Float64ScalarRange ParameterRange 
        => Float64ScalarRange.Infinite;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ConstantParametricBivector3D(LinFloat64Bivector3D point)
    {
        Bivector = point;

        Debug.Assert(IsValid());
    }
    

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValid()
    {
        return Bivector.IsValid();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public LinFloat64Bivector3D GetBivector(double parameterValue)
    {
        return Bivector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IParametricCurve3D GetNormalVectorCurve(LinFloat64Vector3D? zeroNormal = null)
    {
        return ConstantParametricCurve3D.Create(
            Bivector.NormalToDirection3D(zeroNormal)
        );
    }
}