﻿using GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Restricted.Generic.Multivectors;

namespace GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Restricted.Generic.LinearMaps;

public interface IRGaUnilinearMap<T> : 
    IRGaElement<T>
{
    IRGaUnilinearMap<T> GetAdjoint();
    
    RGaMultivector<T> MapBasisBlade(ulong id);
    
    RGaMultivector<T> Map(RGaMultivector<T> multivector);
    
    IEnumerable<KeyValuePair<ulong, RGaMultivector<T>>> GetMappedBasisBlades(int vSpaceDimensions);
}