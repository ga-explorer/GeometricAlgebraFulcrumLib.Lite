﻿namespace GeometricAlgebraFulcrumLib.Core.Algebra.Polynomials.CurveBasis;

public interface IPolynomialBasisSet
{
    public int Degree { get; }

    double GetValue(int index, double parameterValue);

    double GetValue(int index, double parameterValue, double termScalar);

    double GetValue(double parameterValue, params double[] termScalarsList);

    IReadOnlyList<double> GetValues(double parameterValue);
}