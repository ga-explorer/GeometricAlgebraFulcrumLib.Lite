﻿using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Restricted.Generic.Multivectors;
using GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Restricted.Generic.Processors;
using GeometricAlgebraFulcrumLib.Algebra.Scalars;
using GeometricAlgebraFulcrumLib.Core.Algebra;

namespace GeometricAlgebraFulcrumLib.Algebra.GeometricAlgebra.Restricted.Generic.Spaces.Conformal;

public abstract class RGaConformalBlade<T> :
    IAlgebraicElement
{
    public RGaConformalSpace<T> Space { get; }

    public IScalarProcessor<T> ScalarProcessor 
        => Space.ScalarProcessor;

    public RGaProcessor<T> Processor 
        => Space.ConformalProcessor;
    
    public RGaConformalProcessor<T> ConformalProcessor 
        => Space.ConformalProcessor;

    public abstract RGaKVector<T> Blade { get; }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaConformalBlade(RGaConformalSpace<T> space)
    {
        Space = space;
    }


    public abstract bool IsValid();
}