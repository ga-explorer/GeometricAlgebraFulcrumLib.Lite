﻿using GeometricAlgebraFulcrumLib.Core.Algebra.GeometricAlgebra.Records;

namespace GeometricAlgebraFulcrumLib.Core.Algebra.GeometricAlgebra.Restricted.Records;

public interface IRGaKvIndexPairScalarRecord<out T> :
    IRGaKvIndexPairRecord,
    IGaScalarRecord<T>
{
}