﻿using GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Extended.Basis;

namespace GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Extended.Records;

public interface IXGaBasisPairRecord
{
    /// <summary>
    /// The First Basis Blade
    /// </summary>
    XGaBasisBlade BasisBlade1 { get; }

    /// <summary>
    /// The Second Basis Blade
    /// </summary>
    XGaBasisBlade BasisBlade2 { get; }
}