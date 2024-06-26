﻿using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Algebra.LinearAlgebra.Generic.Angles;
using GeometricAlgebraFulcrumLib.Algebra.Scalars.Generic;
using GeometricAlgebraFulcrumLib.Modeling.Geometry.Euclidean.Space3D.Objects;

namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.Euclidean.Space3D.Maps;

public sealed class E3DMapRotate<T> :
    E3DMap<T>
{
    public override IScalarProcessor<T> ScalarProcessor
        => Origin.ScalarProcessor;

    public LinAngle<T> Angle { get; }

    public E3DPoint<T> Origin { get; }

    public E3DVector<T> UnitDirection { get; }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal E3DMapRotate(LinAngle<T> angle, E3DPoint<T> point, E3DVector<T> direction)
    {
        Angle = angle;
        Origin = point;
        UnitDirection = direction.GetUnitVector();
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override E3DVector<T> Map(E3DVector<T> vector)
    {
        var angleCos = Angle.Cos();
        var angleSin = Angle.Sin();

        return angleCos * vector +
               (1 - angleCos) * UnitDirection.Dot(vector) * UnitDirection +
               angleSin * UnitDirection.Cross(vector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override E3DPoint<T> Map(E3DPoint<T> point)
    {
        return Origin + Map(point - Origin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override E3DMap<T> GetInverse()
    {
        return new E3DMapRotate<T>(Angle.NegativeAngle(), Origin, UnitDirection);
    }
}