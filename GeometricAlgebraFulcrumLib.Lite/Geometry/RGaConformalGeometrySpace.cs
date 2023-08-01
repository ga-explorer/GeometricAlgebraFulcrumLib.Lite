using System.Collections.Immutable;
using DataStructuresLib.BitManipulation;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.LinearMaps.Outermorphisms;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Processors;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.LinearMaps.SpaceND;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.SpaceND;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry;

public abstract class RGaConformalGeometrySpace :
    RGaGeometrySpace
{
    public RGaFloat64ConformalProcessor ConformalProcessor 
        => RGaFloat64ConformalProcessor.Instance;

    public override RGaFloat64Processor Processor 
        => ConformalProcessor;

    public override IReadOnlyList<string> LaTeXVectorSubscripts { get; }

    public override IRGaFloat64Outermorphism LaTeXBasisMap { get; }

    public RGaFloat64Vector En { get; }
        
    public RGaFloat64Vector Ep { get; }
    
    public RGaFloat64Vector E1 { get; }
        
    public RGaFloat64Vector E2 { get; }

    public RGaFloat64Vector Eo { get; }

    public RGaFloat64Vector Ei { get; }

    public RGaFloat64Bivector Eoi { get; }
    
    public RGaFloat64Bivector E12 { get; }

    public RGaFloat64HigherKVector I { get; }

    public RGaFloat64HigherKVector Iinv { get; }

    public RGaFloat64HigherKVector Irev { get; }


    protected RGaConformalGeometrySpace(int vSpaceDimensions)
        : base(vSpaceDimensions)
    {
        if (vSpaceDimensions < 4)
            throw new ArgumentOutOfRangeException(nameof(vSpaceDimensions));

        LaTeXVectorSubscripts = GetCGaVectorSubscripts().ToImmutableArray();
        LaTeXBasisMap = GetCGaBasisMap();

        En = ConformalProcessor.CreateTermVector(0);
        Ep = ConformalProcessor.CreateTermVector(1);
        E1 = ConformalProcessor.CreateTermVector(2);
        E2 = ConformalProcessor.CreateTermVector(3);
            
        Eo = ConformalProcessor.CreateVector(0.5d, 0.5d);
        Ei = ConformalProcessor.CreateVector(1d, -1d);
        Eoi = Eo.Op(Ei);

        E12 = ConformalProcessor.CreateTermBivector(2, 3);

        I = ConformalProcessor.CreateHigherKVector(VSpaceDimensions.GetRange().ToImmutableArray());
        Iinv = I.Inverse();
        Irev = I.Reverse();
    }


    protected IEnumerable<string> GetCGaVectorSubscripts()
    {
        for (var i = 0; i < VSpaceDimensions - 2; i++)
            yield return (i + 1).ToString();

        yield return "o";
        yield return @"\infty";
    }

    protected RGaFloat64LinearMapOutermorphism GetCGaBasisMap()
    {
        // If linearly independent basis F = <f1, f2, f3> is related to
        // orthonormal basis E = <e1, e2, e3> via matrix M (F = M E), then
        // the scalars of a multivector expressed using E (Ae) are related
        // to the scalars of the same multivectors expressed using basis F
        // (Af) using the inverse transpose of M: Af = inv(transpose(M)) Ae
        // Thus if M is an orthogonal matrix (or as a special case, a permutation)
        // they are related using M itself: Af = M Ae.

        var vectorMapArray = new double[VSpaceDimensions, VSpaceDimensions];

        for (var i = 0; i < VSpaceDimensions - 2; i++)
            vectorMapArray[i, i + 2] = 1d;

        vectorMapArray[VSpaceDimensions - 2, 0] = 1d;
        vectorMapArray[VSpaceDimensions - 1, 0] = 0.5d;

        vectorMapArray[VSpaceDimensions - 2, 1] = 1d;
        vectorMapArray[VSpaceDimensions - 1, 1] = -0.5d;

        return vectorMapArray
            .ColumnsToLinVectors()
            .ToLinUnilinearMap()
            .ToOutermorphism(Processor);
    }

}