using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataStructuresLib.BitManipulation;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Basis;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.LinearMaps.Outermorphisms;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Processors;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.LinearMaps.SpaceND;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.SpaceND;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry.Conformal;

public abstract class RGaConformalSpace :
    RGaGeometrySpace
{
    public RGaFloat64ConformalProcessor ConformalProcessor
        => RGaFloat64ConformalProcessor.Instance;

    public override RGaFloat64Processor Processor
        => ConformalProcessor;

    public RGaFloat64MusicalAutomorphism MusicalIsomorphism
        => RGaFloat64MusicalAutomorphism.Instance;

    public override IReadOnlyList<string> LaTeXVectorSubscripts { get; }

    public override IRGaFloat64Outermorphism LaTeXBasisMap { get; }

    public override IRGaFloat64Outermorphism LaTeXBasisMapInverse { get; }
    
    public RGaFloat64Scalar OneScalar { get; }

    public RGaFloat64Vector ZeroVector { get; }

    public RGaFloat64Vector En { get; }

    public RGaFloat64Vector Ep { get; }

    public RGaFloat64Vector E1 { get; }

    public RGaFloat64Vector E2 { get; }

    public RGaFloat64Vector Eo { get; }

    public RGaFloat64Vector Ei { get; }

    public RGaFloat64Bivector Eoi { get; }

    public RGaFloat64Bivector E12 { get; }

    public RGaFloat64KVector Ie { get; }

    public RGaFloat64KVector IeInv { get; }

    public RGaFloat64KVector IeRev { get; }

    public RGaFloat64KVector EoIe { get; }

    public RGaFloat64KVector IeEi { get; }

    public RGaFloat64HigherKVector Ic { get; }

    public RGaFloat64HigherKVector IcInv { get; }

    public RGaFloat64HigherKVector IcRev { get; }


    protected RGaConformalSpace(int vSpaceDimensions)
        : base(vSpaceDimensions)
    {
        if (vSpaceDimensions < 4)
            throw new ArgumentOutOfRangeException(nameof(vSpaceDimensions));

        LaTeXVectorSubscripts = GetCGaVectorSubscripts().ToImmutableArray();
        LaTeXBasisMap = GetCGaBasisMap();
        LaTeXBasisMapInverse = GetCGaBasisMapInverse();
        
        OneScalar = ConformalProcessor.CreateOneScalar();
        ZeroVector = ConformalProcessor.CreateZeroVector();

        En = ConformalProcessor.CreateTermVector(0);
        Ep = ConformalProcessor.CreateTermVector(1);
        E1 = ConformalProcessor.CreateTermVector(2);
        E2 = ConformalProcessor.CreateTermVector(3);

        Eo = ConformalProcessor.CreateVector(0.5d, 0.5d);
        Ei = ConformalProcessor.CreateVector(1d, -1d);
        Eoi = Eo.Op(Ei);

        E12 = ConformalProcessor.CreateTermBivector(2, 3);

        Ie = ConformalProcessor.CreateTermHigherKVector((VSpaceDimensions - 2).GetRange(2).ToImmutableArray());
        IeInv = Ie.Inverse();
        IeRev = Ie.Reverse();

        EoIe = Eo.Op(Ie);
        IeEi = Ie.Op(Ei);

        Ic = ConformalProcessor.CreateTermHigherKVector(VSpaceDimensions.GetRange().ToImmutableArray());
        IcInv = Ic.Inverse();
        IcRev = Ic.Reverse();
    }


    protected IEnumerable<string> GetCGaVectorSubscripts()
    {
        yield return "o";

        for (var i = 0; i < VSpaceDimensions - 2; i++)
            yield return (i + 1).ToString();

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
            vectorMapArray[i + 1, i + 2] = 1d;

        vectorMapArray[0, 0] = 1d;
        vectorMapArray[0, 1] = 1d;

        vectorMapArray[VSpaceDimensions - 1, 0] = 0.5d;
        vectorMapArray[VSpaceDimensions - 1, 1] = -0.5d;

        return vectorMapArray
            .ColumnsToLinVectors()
            .ToLinUnilinearMap()
            .ToOutermorphism(Processor);
    }

    protected RGaFloat64LinearMapOutermorphism GetCGaBasisMapInverse()
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
            vectorMapArray[i + 2, i + 1] = 1d;

        vectorMapArray[0, 0] = 0.5d;
        vectorMapArray[1, 0] = 0.5d;

        vectorMapArray[0, VSpaceDimensions - 1] = 1d;
        vectorMapArray[1, VSpaceDimensions - 1] = -1d;

        return vectorMapArray
            .ColumnsToLinVectors()
            .ToLinUnilinearMap()
            .ToOutermorphism(Processor);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidEGaElement(RGaFloat64Multivector mv)
    {
        if (!IsValidElement(mv)) return false;

        // EGA elements only contain Euclidean basis vectors, but never E-, E+
        const ulong maskEnp = 3UL;

        return mv.IsZero ||
               mv.Ids.All(id => (id & maskEnp) == 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidPGaElement(RGaFloat64Multivector mv)
    {
        if (!IsValidElement(mv)) return false;

        // PGA (= CGAo) elements only contain Eo and Euclidean basis vectors, but never Ei
        var maskEi = 1UL << VSpaceDimensions - 1;

        return mv.IsZero ||
               LaTeXBasisMap.OmMap(mv).Ids.All(id => (id & maskEi) == 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidCGaInfElement(RGaFloat64Multivector mv)
    {
        if (!IsValidElement(mv)) return false;

        // CGAi elements only contain Ei and Euclidean basis vectors, but never Eo
        const ulong maskEo = 1UL;

        return mv.IsZero ||
               LaTeXBasisMap.OmMap(mv).Ids.All(id => (id & maskEo) == 0);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<RGaFloat64KVector> GetCGaBasisBlades()
    {
        return GaSpaceDimensions
            .GetRange()
            .OrderBy(id => id.Grade())
            .ThenBy(id => id)
            .Select(LaTeXBasisMapInverse.OmMapBasisBlade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<RGaFloat64KVector> GetPGaBasisBlades()
    {
        return (1UL << VSpaceDimensions - 1)
            .GetRange()
            .OrderBy(id => id.Grade())
            .ThenBy(id => id)
            .Select(LaTeXBasisMapInverse.OmMapBasisBlade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<RGaFloat64KVector> GetCGaInfBasisBlades()
    {
        return (1UL << VSpaceDimensions - 1)
            .GetRange(id => id << 1)
            .OrderBy(id => id.Grade())
            .ThenBy(id => id)
            .Select(LaTeXBasisMapInverse.OmMapBasisBlade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IEnumerable<RGaFloat64KVector> GetEGaBasisBlades()
    {
        return (1UL << VSpaceDimensions - 2)
            .GetRange()
            .OrderBy(id => id.Grade())
            .ThenBy(id => id)
            .Select(id =>
                ConformalProcessor.CreateTermKVector(id << 2)
            );
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaFloat64Vector RemoveEi(RGaFloat64Bivector mv)
    {
        var eiIdMask = (1UL << (VSpaceDimensions - 1)) - 1UL;

        return LaTeXBasisMapInverse.OmMap(
            LaTeXBasisMap
                .OmMap(mv)
                .MapBasisBlades(id => id & eiIdMask)
                .GetVectorPart()
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaFloat64KVector RemoveEi(RGaFloat64KVector mv)
    {
        var eiIdMask = (1UL << (VSpaceDimensions - 1)) - 1UL;

        return LaTeXBasisMapInverse.OmMap(
            LaTeXBasisMap
                .OmMap(mv)
                .MapBasisBlades(id => id & eiIdMask)
                .GetFirstKVectorPart()
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected RGaFloat64Multivector RemoveEi(RGaFloat64Multivector mv)
    {
        var eiIdMask = (1UL << (VSpaceDimensions - 1)) - 1UL;

        return LaTeXBasisMapInverse.OmMap(
            LaTeXBasisMap
                .OmMap(mv)
                .MapBasisBlades(id => id & eiIdMask)
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalDirection DefineDirection(double weight, RGaFloat64KVector direction)
    {
        return new RGaConformalDirection(
            this,
            weight,
            direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalDirection DefineDirectionFromVectors(double weight, params RGaFloat64Vector[] directionVectors)
    {
        return DefineDirection(
            weight, 
            directionVectors.Op()
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalDirection DefineDirectionFromVectors(double weight, IEnumerable<RGaFloat64Vector> directionVectors)
    {
        return DefineDirection(
            weight, 
            directionVectors.Op()
        );
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat DefineFlatPoint(double weight, RGaFloat64Vector position)
    {
        return new RGaConformalFlat(
            this,
            weight,
            position,
            OneScalar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat DefineFlat(double weight, RGaFloat64Vector position, RGaFloat64KVector direction)
    {
        return new RGaConformalFlat(
            this,
            weight,
            position,
            direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat DefineFlatFromVectors(double weight, RGaFloat64Vector position, IEnumerable<RGaFloat64Vector> directionVectors)
    {
        return new RGaConformalFlat(
            this,
            weight,
            position,
            directionVectors.Op()
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat DefineFlatFromVectors(double weight, RGaFloat64Vector position, params RGaFloat64Vector[] directionVectors)
    {
        return new RGaConformalFlat(
            this,
            weight,
            position,
            directionVectors.Op()
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat DefineFlatFromPoints(double weight, params RGaFloat64Vector[] positions)
    {
        var position = positions[0];
        var direction = 
            positions.Skip(1).Select(p => p - position).Op();

        return new RGaConformalFlat(
            this,
            weight,
            position,
            direction
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat DefineFlatFromPoints(double weight, IReadOnlyList<RGaFloat64Vector> positions)
    {
        var position = positions[0];
        var direction = 
            positions.Skip(1).Select(p => p - position).Op();

        return new RGaConformalFlat(
            this,
            weight,
            position,
            direction
        );
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent DefineTangentPoint(double weight, RGaFloat64Vector position)
    {
        return new RGaConformalTangent(
            this,
            weight,
            position,
            OneScalar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent DefineTangent(double weight, RGaFloat64Vector position, RGaFloat64KVector direction)
    {
        return new RGaConformalTangent(
            this,
            weight,
            position,
            direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent DefineTangentFromVectors(double weight, RGaFloat64Vector position, params RGaFloat64Vector[] directionVectors)
    {
        return new RGaConformalTangent(
            this,
            weight,
            position,
            directionVectors.Op()
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent DefineTangentFromVectors(double weight, RGaFloat64Vector position, IEnumerable<RGaFloat64Vector> directionVectors)
    {
        return new RGaConformalTangent(
            this,
            weight,
            position,
            directionVectors.Op()
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound DefineRound(double weight, double radiusSquared, RGaFloat64Vector position, RGaFloat64KVector direction)
    {
        return new RGaConformalRound(
            this,
            weight,
            radiusSquared,
            position,
            direction
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound DefineRoundFromVectors(double weight, double radiusSquared, RGaFloat64Vector position, params RGaFloat64Vector[] directionVectors)
    {
        return new RGaConformalRound(
            this,
            weight,
            radiusSquared,
            position,
            directionVectors.Op()
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound DefineRoundFromPoints(double weight, params RGaFloat64Vector[] egaPoints)
    {
        return OpnsDecodeRound(
            weight * egaPoints.Select(IpnsEncodePoint).Op()
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound DefineRoundFromPoints(double weight, IEnumerable<RGaFloat64Vector> egaPoints)
    {
        return OpnsDecodeRound(
            weight * egaPoints.Select(IpnsEncodePoint).Op()
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsEncodePoint(RGaFloat64Vector egaPoint)
    {
        Debug.Assert(IsValidEGaElement(egaPoint));

        return Eo +
               egaPoint +
               0.5d * egaPoint.NormSquared() * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsEncodeSphere(double radiusSquared, RGaFloat64Vector egaCenter)
    {
        var c = IpnsEncodePoint(egaCenter);

        return c - 0.5d * radiusSquared * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsEncodeRealSphere(double radius, RGaFloat64Vector egaCenter)
    {
        var c = IpnsEncodePoint(egaCenter);

        return c - 0.5d * radius * radius * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsEncodeImaginarySphere(double radius, RGaFloat64Vector egaCenter)
    {
        var c = IpnsEncodePoint(egaCenter);

        return c + 0.5d * radius * radius * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector IpnsEncodeDirection(RGaFloat64KVector egaBlade)
    {
        return -EGaDual(egaBlade).Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector IpnsEncodeLine(RGaFloat64Vector egaPoint, RGaFloat64Vector egaVector)
    {
        Debug.Assert(
            IsValidEGaElement(egaPoint) &&
            IsValidEGaElement(egaVector)
        );

        var egaUnitVector = egaVector.DivideByNorm();

        return (egaUnitVector.Lcp(Ie) - egaPoint.Op(egaUnitVector).Lcp(IeEi)).GetKVectorPart(Ie.Grade - 1);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsEncodeHyperPlane(double distance, RGaFloat64Vector normal)
    {
        Debug.Assert(IsValidEGaElement(normal));

        var nNorm = normal.Norm();

        if (nNorm.IsNearZero())
            throw new InvalidOperationException();

        return normal.Divide(nNorm) + distance * Ei;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeDirection(RGaFloat64KVector egaBlade)
    {
        return egaBlade.Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector OpnsEncodeFlatPoint(RGaFloat64Vector egaPoint)
    {
        return IpnsEncodePoint(egaPoint).Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeLineFromPoints(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);

        return p1.Op(p2).Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeFlat(RGaFloat64Vector egaPoint, RGaFloat64KVector egaBlade)
    {
        return IpnsEncodePoint(egaPoint).Op(egaBlade).Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector OpnsEncodeFlatFromPoints(RGaFloat64Vector egaPoint)
    {
        var p1 = IpnsEncodePoint(egaPoint);

        return p1.Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeFlatFromPoints(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);

        return p1.Op(p2).Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeFlatFromPoints(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2, RGaFloat64Vector egaPoint3)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);
        var p3 = IpnsEncodePoint(egaPoint3);

        return p1.Op(p2).Op(p3).Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeFlatFromPoints(params RGaFloat64Vector[] egaPointArray)
    {
        return egaPointArray.Select(IpnsEncodePoint).Op().Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeFlatFromPoints(IEnumerable<RGaFloat64Vector> egaPointList)
    {
        return egaPointList.Select(IpnsEncodePoint).Op().Op(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector OpnsEncodePointPair(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);

        return p1.Op(p2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeCircle(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2, RGaFloat64Vector egaPoint3)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);
        var p3 = IpnsEncodePoint(egaPoint3);

        return p1.Op(p2).Op(p3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeRound(RGaFloat64Vector egaPoint)
    {
        return IpnsEncodePoint(egaPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeRound(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);

        return p1.Op(p2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeRound(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2, RGaFloat64Vector egaPoint3)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);
        var p3 = IpnsEncodePoint(egaPoint3);

        return p1.Op(p2).Op(p3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeRound(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2, RGaFloat64Vector egaPoint3, RGaFloat64Vector egaPoint4)
    {
        var p1 = IpnsEncodePoint(egaPoint1);
        var p2 = IpnsEncodePoint(egaPoint2);
        var p3 = IpnsEncodePoint(egaPoint3);
        var p4 = IpnsEncodePoint(egaPoint4);

        return p1.Op(p2).Op(p3).Op(p4);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeRound(params RGaFloat64Vector[] egaPointArray)
    {
        return egaPointArray.Select(IpnsEncodePoint).Op();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsEncodeRound(IEnumerable<RGaFloat64Vector> egaPointList)
    {
        return egaPointList.Select(IpnsEncodePoint).Op();
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle, RGaFloat64Bivector bivector)
    {
        return Math.Cos(angle / 2) +
               Math.Sin(angle / 2) / bivector.Norm() * bivector;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeTranslation(RGaFloat64Vector egaVector)
    {
        Debug.Assert(IsValidEGaElement(egaVector));

        return 1 + 0.5d * Ei.Op(egaVector);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeDilation(double scalingFactor)
    {
        return Math.Cosh(scalingFactor / 2) +
               Math.Sinh(scalingFactor / 2) * Eoi;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaEncodePoint(RGaFloat64Vector egaPoint)
    {
        Debug.Assert(IsValidEGaElement(egaPoint));

        return PGaUnDual(Eo + egaPoint);
        //return (Ie + EGaDual(egaPoint).Op(Eo)).GetKVectorPart(Ie.Grade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaEncodeLineFromPoints(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2)
    {
        Debug.Assert(
            IsValidEGaElement(egaPoint1) &&
            IsValidEGaElement(egaPoint2)
        );

        var p1 = Eo + egaPoint1; //PGaEncodePoint(egaPoint1);
        var p2 = Eo + egaPoint2; //PGaEncodePoint(egaPoint2);

        return PGaUnDual(
            p1.Op(p2)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaEncodePlaneFromPoints(RGaFloat64Vector egaPoint1, RGaFloat64Vector egaPoint2, RGaFloat64Vector egaPoint3)
    {
        Debug.Assert(
            IsValidEGaElement(egaPoint1) &&
            IsValidEGaElement(egaPoint2) &&
            IsValidEGaElement(egaPoint3)
        );

        var p1 = Eo + egaPoint1; //PGaEncodePoint(egaPoint1);
        var p2 = Eo + egaPoint2; //PGaEncodePoint(egaPoint2);
        var p3 = Eo + egaPoint3; //PGaEncodePoint(egaPoint3);

        return PGaUnDual(
            p1.Op(p2).Op(p3)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaEncodeFlatFromPoints(params RGaFloat64Vector[] egaPointArray)
    {
        Debug.Assert(
            egaPointArray.All(IsValidEGaElement)
        );

        return PGaUnDual(
            egaPointArray.Select(egaPoint => Eo + egaPoint).Op()
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaEncodeFlatFromPoints(IEnumerable<RGaFloat64Vector> egaPointArray)
    {
        Debug.Assert(
            egaPointArray.All(IsValidEGaElement)
        );

        return PGaUnDual(
            egaPointArray.Select(egaPoint => Eo + egaPoint).Op()
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector PGaEncodeTranslation(RGaFloat64Vector egaVector)
    {
        Debug.Assert(IsValidEGaElement(egaVector));

        return 1 - 0.5d * Eo.Op(egaVector);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector HGaEncodePoint(RGaFloat64Vector egaPoint)
    {
        Debug.Assert(IsValidEGaElement(egaPoint));

        return Eo + egaPoint;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat PGaDecodeFlat(RGaFloat64KVector pgaFlat)
    {
        return IpnsDecodeFlat(
            PGaToIpns(pgaFlat)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat PGaDecodeFlat(RGaFloat64KVector pgaFlat, RGaFloat64Vector egaProbePoint)
    {
        return IpnsDecodeFlat(
            PGaToIpns(pgaFlat),
            egaProbePoint
        );
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalDirection OpnsDecodeDirection(RGaFloat64KVector opnsDirection)
    {
        return OpnsDecodeDirection(
            opnsDirection,
            ZeroVector
        );
    }

    public RGaConformalDirection OpnsDecodeDirection(RGaFloat64KVector opnsDirection, RGaFloat64Vector egaProbePoint)
    {
        var directionOpEi = opnsDirection;

        var weight =
            IpnsEncodePoint(egaProbePoint)
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        return new RGaConformalDirection(
            this,
            weight,
            RemoveEi(directionOpEi)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat OpnsDecodeFlat(RGaFloat64KVector opnsFlat)
    {
        return OpnsDecodeFlat(
            opnsFlat,
            ZeroVector
        );
    }

    public RGaConformalFlat OpnsDecodeFlat(RGaFloat64KVector opnsFlat, RGaFloat64Vector egaProbePoint)
    {
        var ipnsProbePoint = 
            IpnsEncodePoint(egaProbePoint);

        var position =
            IpnsSphereToEGaCenter(
                ipnsProbePoint
                    .Lcp(opnsFlat)
                    .Gp(opnsFlat.Inverse())
                    .GetVectorPart()
            );

        var directionOpEi =
            -Ei.Lcp(opnsFlat);

        var weight =
            ipnsProbePoint
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        var flat = new RGaConformalFlat(
            this,
            weight,
            position,
            RemoveEi(directionOpEi)
        );

        Debug.Assert(flat.EncodeIpnsPosition().Op(opnsFlat).IsNearZero());
        
        return flat;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent OpnsDecodeTangent(RGaFloat64KVector opnsTangent)
    {
        return OpnsDecodeTangent(
            opnsTangent,
            ZeroVector
        );
    }

    public RGaConformalTangent OpnsDecodeTangent(RGaFloat64KVector opnsTangent, RGaFloat64Vector egaProbePoint)
    {
        var eiX = -Ei.Lcp(opnsTangent);
        
        var position =
            IpnsSphereToEGaCenter(
                opnsTangent
                    .Gp(eiX.Inverse())
                    .GetVectorPart()
            );

        var directionOpEi =
            eiX.Op(Ei);

        var weight =
            IpnsEncodePoint(egaProbePoint)
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        return new RGaConformalTangent(
            this,
            weight,
            position,
            RemoveEi(directionOpEi)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound OpnsDecodeRound(RGaFloat64KVector opnsRound)
    {
        return OpnsDecodeRound(
            opnsRound,
            ZeroVector
        );
    }

    public RGaConformalRound OpnsDecodeRound(RGaFloat64KVector opnsRound, RGaFloat64Vector egaProbePoint)
    {
        var eiX = Ei.Lcp(opnsRound);
        var eiX2 = eiX.SpSquared().ScalarValue();

        var radiusSquared =
            (opnsRound.Sp(opnsRound.GradeInvolution()) / eiX2).ScalarValue();

        var position = IpnsSphereToEGaCenter(
            -0.5 / eiX2 * opnsRound.Gp(Ei).Gp(opnsRound).GetVectorPart()
        );

        var directionOpEi =
            -eiX.Op(Ei);

        var weight =
            IpnsEncodePoint(egaProbePoint)
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();
        
        var round = new RGaConformalRound(
            this,
            weight,
            radiusSquared,
            position,
            RemoveEi(directionOpEi)
        );
        
        //Debug.Assert(round.NearContainsEGaPoint(position));

        return round;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector GetEGaVectorPart(RGaFloat64Vector vector)
    {
        return vector.GetVectorPart(i => i >= 2);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsSphereToEGaCenter(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];

        //return eoScalar.IsNearZero()
        //    ? throw new InvalidOperationException()
        //    : Eoi.Lcp(Eoi.Op(vector / eoScalar)).GetVectorPart();

        return eoScalar.IsNearZero()
            ? throw new InvalidOperationException()
            : vector.GetVectorPart(i => i >= 2) / eoScalar;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalDirection IpnsDecodeDirection(RGaFloat64KVector ipnsDirection)
    {
        return IpnsDecodeDirection(
            ipnsDirection,
            ZeroVector
        );
    }

    public RGaConformalDirection IpnsDecodeDirection(RGaFloat64KVector ipnsDirection, RGaFloat64Vector egaProbePoint)
    {
        var directionOpEi =
            CGaUnDual(ipnsDirection);

        var weight =
            IpnsEncodePoint(egaProbePoint)
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        return new RGaConformalDirection(
            this,
            weight,
            RemoveEi(directionOpEi)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat IpnsDecodeHyperPlane(RGaFloat64Vector ipnsFlat)
    {
        return IpnsDecodeHyperPlane(ipnsFlat, ZeroVector);
    }

    public RGaConformalFlat IpnsDecodeHyperPlane(RGaFloat64Vector ipnsFlat, RGaFloat64Vector egaProbePoint)
    {
        var eoScalar = ipnsFlat[0] + ipnsFlat[1];

        // This is a point\hypersphere, not a hyperplane
        if (!eoScalar.IsNearZero())
            throw new InvalidOperationException();

        var normal = GetEGaVectorPart(ipnsFlat);
        var weight = normal.Norm();

        // Plane has zero normal
        if (weight.IsNearZero())
            throw new InvalidOperationException();
        
        var ipnsProbePoint = 
            IpnsEncodePoint(egaProbePoint);

        var position =
            IpnsSphereToEGaCenter(
                ipnsProbePoint
                    .Op(ipnsFlat)
                    .Gp(ipnsFlat.Inverse())
                    .GetVectorPart()
            );
        
        var flat = new RGaConformalFlat(
            this,
            weight,
            position,
            EGaUnDual(normal)
        );
        
        Debug.Assert(flat.EncodeIpnsPosition().Lcp(ipnsFlat).IsNearZero());

        return flat;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalFlat IpnsDecodeFlat(RGaFloat64KVector ipnsFlat)
    {
        return IpnsDecodeFlat(
            ipnsFlat,
            ZeroVector
        );
    }

    public RGaConformalFlat IpnsDecodeFlat(RGaFloat64KVector ipnsFlat, RGaFloat64Vector egaProbePoint)
    {
        var ipnsProbePoint = 
            IpnsEncodePoint(egaProbePoint);

        var position =
            IpnsSphereToEGaCenter(
                ipnsProbePoint
                    .Op(ipnsFlat)
                    .Gp(ipnsFlat.Inverse())
                    .GetVectorPart()
            );

        var directionOpEi =
            -Ei.Lcp(CGaUnDual(ipnsFlat));

        var weight =
            ipnsProbePoint
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        var flat = new RGaConformalFlat(
            this,
            weight,
            position,
            RemoveEi(directionOpEi)
        );
        
        Debug.Assert(flat.EncodeIpnsPosition().Lcp(ipnsFlat).IsNearZero());

        return flat;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalTangent IpnsDecodeTangent(RGaFloat64KVector ipnsTangent)
    {
        return IpnsDecodeTangent(
            ipnsTangent,
            ZeroVector
        );
    }

    public RGaConformalTangent IpnsDecodeTangent(RGaFloat64KVector ipnsTangent, RGaFloat64Vector egaProbePoint)
    {
        var position =
            IpnsSphereToEGaCenter(
                ipnsTangent
                    .Gp(-Ei.Lcp(ipnsTangent).Inverse())
                    .GetVectorPart()
            );

        var directionOpEi =
            -Ei.Lcp(CGaUnDual(ipnsTangent)).Op(Ei);

        var weight =
            IpnsEncodePoint(egaProbePoint)
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        return new RGaConformalTangent(
            this,
            weight,
            position,
            RemoveEi(directionOpEi)
        );
    }
    
    public RGaConformalRound IpnsDecodeHyperSphere(RGaFloat64Vector ipnsRound)
    {
        var weight = 
            ipnsRound[0] + ipnsRound[1];

        if (weight.IsNearZero())
            throw new InvalidOperationException();
        
        var position = 
            ipnsRound.GetVectorPart(index => index >= 2);

        var eiScalar = 
            0.5 * (ipnsRound[0] - ipnsRound[1]);

        var radiusSquared =
            position.NormSquared() - 2 * eiScalar / weight;

        var round = new RGaConformalRound(
            this,
            weight,
            radiusSquared,
            position,
            Ie
        );
        
        //Debug.Assert(position.Lcp(ipnsRound).IsNearZero());

        return round;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaConformalRound IpnsDecodeRound(RGaFloat64KVector ipnsRound)
    {
        return IpnsDecodeRound(
            ipnsRound,
            ZeroVector
        );
    }

    public RGaConformalRound IpnsDecodeRound(RGaFloat64KVector ipnsRound, RGaFloat64Vector egaProbePoint)
    {
        var eiX = Ei.Lcp(ipnsRound);
        var eiX2 = eiX.SpSquared().ScalarValue();

        var radiusSquared =
            -(ipnsRound.Sp(ipnsRound.GradeInvolution()) / eiX2).ScalarValue();

        var position =
            IpnsSphereToEGaCenter(
                -0.5 / eiX2 * ipnsRound.Gp(Ei).Gp(ipnsRound).GetVectorPart()
            );

        var directionOpEi =
            -Ei.Lcp(CGaUnDual(ipnsRound)).Op(Ei);

        var weight =
            IpnsEncodePoint(egaProbePoint)
                .Lcp(directionOpEi)
                .SpSquared()
                .ScalarValue()
                .SqrtOfAbs();

        var round = new RGaConformalRound(
            this,
            weight,
            radiusSquared,
            position,
            RemoveEi(directionOpEi)
        );
        
        //Debug.Assert(position.Lcp(ipnsRound).IsNearZero());

        return round;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaToOpns(RGaFloat64KVector mv)
    {
        return IpnsToOpns(PGaToIpns(mv));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector PGaToOpns(RGaFloat64Multivector mv)
    {
        return IpnsToOpns(PGaToIpns(mv));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsToPGa(RGaFloat64KVector mv)
    {
        return IpnsToPGa(OpnsToIpns(mv));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector OpnsToPGa(RGaFloat64Multivector mv)
    {
        return IpnsToPGa(OpnsToIpns(mv));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar PGaToIpns(RGaFloat64Scalar mv)
    {
        return mv;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector PGaToIpns(RGaFloat64Vector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector PGaToIpns(RGaFloat64Bivector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector PGaToIpns(RGaFloat64HigherKVector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaToIpns(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector PGaToIpns(RGaFloat64Multivector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar IpnsToPGa(RGaFloat64Scalar mv)
    {
        return mv;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector IpnsToPGa(RGaFloat64Vector mv)
    {
        Debug.Assert(IsValidCGaInfElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector IpnsToPGa(RGaFloat64Bivector mv)
    {
        Debug.Assert(IsValidCGaInfElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector IpnsToPGa(RGaFloat64HigherKVector mv)
    {
        Debug.Assert(IsValidCGaInfElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector IpnsToPGa(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidCGaInfElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector IpnsToPGa(RGaFloat64Multivector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(mv);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector OpnsToIpns(RGaFloat64KVector mv)
    {
        return mv.Lcp(IcInv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector OpnsToIpns(RGaFloat64Multivector mv)
    {
        return mv.Lcp(IcInv);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector IpnsToOpns(RGaFloat64KVector mv)
    {
        return mv.Lcp(Ic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector IpnsToOpns(RGaFloat64Multivector mv)
    {
        return mv.Lcp(Ic);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector CGaUnDual(RGaFloat64KVector mv)
    {
        return mv.Lcp(Ic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector CGaUnDual(RGaFloat64Multivector mv)
    {
        return mv.Lcp(Ic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector CGaDual(RGaFloat64KVector mv)
    {
        return mv.Lcp(IcInv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector CGaDual(RGaFloat64Multivector mv)
    {
        return mv.Lcp(IcInv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaUnDual(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(
            mv.Op(Ei).Lcp(IcInv)
        //TODO: Should this be mv.Op(Ei).Lcp(Ic) ?
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector PGaUnDual(RGaFloat64Multivector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(
            mv.Op(Ei).Lcp(IcInv)
        //TODO: Should this be mv.Op(Ei).Lcp(Ic) ?
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaDual(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(
            mv.Op(Ei).Lcp(IcInv)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector PGaDual(RGaFloat64Multivector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return MusicalIsomorphism.OmMap(
            mv.Op(Ei).Lcp(IcInv)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EGaUnDual(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidEGaElement(mv));

        return mv.Lcp(Ie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EGaUnDual(RGaFloat64Multivector mv)
    {
        Debug.Assert(IsValidEGaElement(mv));

        return mv.Lcp(Ie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EGaDual(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidEGaElement(mv));

        return mv.Lcp(IeInv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EGaDual(RGaFloat64Multivector mv)
    {
        Debug.Assert(IsValidEGaElement(mv));

        return mv.Lcp(IeInv);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double PGaNormSquared(RGaFloat64KVector mv)
    {
        Debug.Assert(IsValidPGaElement(mv));

        return mv.Sp(mv.CliffordConjugate()).ScalarValue();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double PGaNorm(RGaFloat64KVector mv)
    {
        return PGaNormSquared(mv).SqrtOfAbs();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector PGaNormalize(RGaFloat64KVector mv)
    {
        return mv / PGaNorm(mv);
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double IpnsGetDistance(RGaFloat64Vector cgaVector1, RGaFloat64Vector cgaVector2)
    {
        return -2 * cgaVector1.Sp(cgaVector2).Scalar();
    }

    public RGaFloat64Vector IpnsNormalize(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];

        // IPNS vector encoding a sphere or point
        if (!eoScalar.IsNearZero())
            return vector / eoScalar;

        // IPNS vector encoding a hyper-plane
        var normal = vector.GetVectorPart(index => index >= 2);
        var normalNorm = normal.Norm();

        if (normalNorm.IsNearZero())
            throw new InvalidOperationException();

        var normalNormInv = 1d / normalNorm;
        var distance = 0.5 * (vector[0] - vector[1]) * normalNormInv;

        return normal.Times(normalNormInv) + distance * Ei;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar Translate(RGaFloat64Scalar mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        return mv;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector Translate(RGaFloat64Vector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eit = 0.5d * Ei.Op(egaTranslationVector);

        return (1 + eit).Gp(mv).Gp(1 - eit).GetVectorPart();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector Translate(RGaFloat64Bivector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eit = 0.5d * Ei.Op(egaTranslationVector);

        return (1 + eit).Gp(mv).Gp(1 - eit).GetBivectorPart();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector Translate(RGaFloat64HigherKVector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eit = 0.5d * Ei.Op(egaTranslationVector);

        return (1 + eit).Gp(mv).Gp(1 - eit).GetHigherKVectorPart(mv.Grade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector Translate(RGaFloat64KVector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eit = 0.5d * Ei.Op(egaTranslationVector);

        return (1 + eit).Gp(mv).Gp(1 - eit).GetKVectorPart(mv.Grade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector Translate(RGaFloat64Multivector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eit = 0.5d * Ei.Op(egaTranslationVector);

        return (1 + eit).Gp(mv).Gp(1 - eit);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector TranslatePGa(RGaFloat64KVector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eot = 0.5d * Eo.Op(egaTranslationVector);

        return (1 - eot).Gp(mv).Gp(1 + eot).GetKVectorPart(mv.Grade);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector TranslatePGa(RGaFloat64Multivector mv, RGaFloat64Vector egaTranslationVector)
    {
        Debug.Assert(IsValidEGaElement(egaTranslationVector));

        var eot = 0.5d * Eo.Op(egaTranslationVector);

        return (1 - eot).Gp(mv).Gp(1 + eot);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector IntersectCGaPGa(RGaFloat64KVector blade1, RGaFloat64KVector blade2)
    {
        return blade1.Op(PGaToIpns(blade2));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector IntersectPGaCGa(RGaFloat64KVector blade1, RGaFloat64KVector blade2)
    {
        return PGaToIpns(blade1).Op(blade2);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ProjectCGaOnPGa(RGaFloat64Scalar blade, RGaFloat64KVector subspace)
    {
        return Project(
            blade,
            PGaToIpns(subspace)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ProjectCGaOnPGa(RGaFloat64Vector blade, RGaFloat64KVector subspace)
    {
        return Project(
            blade,
            PGaToIpns(subspace)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ProjectCGaOnPGa(RGaFloat64Bivector blade, RGaFloat64KVector subspace)
    {
        return Project(
            blade,
            PGaToIpns(subspace)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ProjectCGaOnPGa(RGaFloat64HigherKVector blade, RGaFloat64KVector subspace)
    {
        return Project(
            blade,
            PGaToIpns(subspace)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ProjectCGaOnPGa(RGaFloat64KVector blade, RGaFloat64KVector subspace)
    {
        return Project(
            blade,
            PGaToIpns(subspace)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ProjectCGaOnPGa(RGaFloat64Multivector blade, RGaFloat64KVector subspace)
    {
        return Project(
            blade,
            PGaToIpns(subspace)
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Scalar ProjectPGaOnCGa(RGaFloat64Scalar blade, RGaFloat64KVector subspace)
    {
        return Project(
            PGaToIpns(blade),
            subspace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector ProjectPGaOnCGa(RGaFloat64Vector blade, RGaFloat64KVector subspace)
    {
        return Project(
            PGaToIpns(blade),
            subspace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector ProjectPGaOnCGa(RGaFloat64Bivector blade, RGaFloat64KVector subspace)
    {
        return Project(
            PGaToIpns(blade),
            subspace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64HigherKVector ProjectPGaOnCGa(RGaFloat64HigherKVector blade, RGaFloat64KVector subspace)
    {
        return Project(
            PGaToIpns(blade),
            subspace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector ProjectPGaOnCGa(RGaFloat64KVector blade, RGaFloat64KVector subspace)
    {
        return Project(
            PGaToIpns(blade),
            subspace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector ProjectPGaOnCGa(RGaFloat64Multivector blade, RGaFloat64KVector subspace)
    {
        return Project(
            PGaToIpns(blade),
            subspace
        );
    }

}