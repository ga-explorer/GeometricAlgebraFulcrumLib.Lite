﻿namespace GeometricAlgebraFulcrumLib.Modeling.Geometry.Parametric.Float64.Space1D.Scalars;

public interface IFloat64ParametricArcLengthScalar :
    IFloat64ParametricFiniteScalar
{
    double GetLength();

    double ParameterToLength(double parameterValue);

    double LengthToParameter(double length);
}