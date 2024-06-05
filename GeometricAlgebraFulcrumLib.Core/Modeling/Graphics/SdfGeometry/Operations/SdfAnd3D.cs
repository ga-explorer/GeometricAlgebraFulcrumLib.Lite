﻿using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space3D;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.SdfGeometry.Operations;

/// <summary>
/// http://iquilezles.org/www/articles/distfunctions/distfunctions.htm
/// </summary>
public sealed class SdfAnd3D : SdfAggregation
{
    public override double GetScalarDistance(ILinFloat64Vector3D point)
    {
        return Surfaces.Max(s => s.GetScalarDistance(point));
    }
}