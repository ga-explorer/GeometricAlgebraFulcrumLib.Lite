﻿using GeometricAlgebraFulcrumLib.Utilities.Structures.IndexSets;
using GeometricAlgebraFulcrumLib.Core.Algebra.GeometricAlgebra.Extended.Float64.Multivectors;

namespace GeometricAlgebraFulcrumLib.Core.Algebra.GeometricAlgebra.Extended.Records;

public sealed record XGaIdBivectorRecord(IIndexSet Id, XGaFloat64Bivector Bivector) :
    IXGaIdBivectorRecord;
