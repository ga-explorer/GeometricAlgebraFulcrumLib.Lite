﻿using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Core.Algebra.LinearAlgebra.Float64.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Core.Algebra.Scalars.Float64;

namespace GeometricAlgebraFulcrumLib.Core.Modeling.Graphics.SdfGeometry.Primitives;

/// <summary>
/// http://iquilezles.org/www/articles/distfunctions/distfunctions.htm
/// </summary>
public sealed class SdfCylinderZ3D : ScalarDistanceFunction
{
    public LinFloat64Vector2D CenterXy { get; set; }
        = LinFloat64Vector2D.Create((Float64Scalar)0, 0);

    public double Radius { get; set; }


    public override double GetScalarDistance(ILinFloat64Vector3D point)
    {
        return (point.XyToLinVector2D() - CenterXy).VectorENorm() - Radius;
    }
}