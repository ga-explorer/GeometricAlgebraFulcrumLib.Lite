using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

namespace GeometricAlgebraFulcrumLib.Lite.Geometry;

/// <summary>
/// Conformal Geometric Algebra for 2D Euclidean Space
/// </summary>
public sealed class CGa4D : 
    RGaConformalGeometrySpace
{
    public static CGa4D Instance { get; } = new CGa4D();

    
    public RGaFloat64Bivector I2 { get; }
        
    public RGaFloat64Bivector I2Inv { get; }
        
    public RGaFloat64Bivector I2Rev { get; }

    public RGaFloat64KVector I2Ei { get; }

    
    private CGa4D() : base(4)
    {
        I2 = ConformalProcessor.CreateTermBivector(2, 3);
        I2Inv = I2.Inverse();
        I2Rev = I2.Reverse();
        I2Ei = I2.Op(Ei);
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeVector(double x, double y)
    {
        return ConformalProcessor.CreateVector(0, 0, x, y);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeVector(Float64Vector2D mv)
    {
        return ConformalProcessor.CreateVector(0, 0, mv.X, mv.Y);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector EncodeBivector(double xyScalar)
    {
        return xyScalar * I2;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodePoint(double pointX, double pointY)
    {
        var point = Float64Vector2D.Create(pointX, pointY);
        
        return Eo +
               EncodeVector(point) +
               0.5d * point.NormSquared() * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodePoint(Float64Vector2D point)
    {
        return Eo +
               EncodeVector(point) +
               0.5d * point.NormSquared() * Ei;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeLineIpns(double distance, double normalX, double normalY)
    {
        return EncodeLineIpns(
            distance,
            Float64Vector2D.Create(normalX, normalY)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeLineIpns(double distance, Float64Vector2D normal)
    {
        var n = EncodeVector(normal / normal.Norm());

        return n + distance * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EncodeLineIpns(Float64Vector2D point, Float64Vector2D vector)
    {
        var p = EncodeVector(point);
        var v = EncodeVector(vector / vector.Norm());

        return (v.Gp(I2) - p.Op(v).Gp(I2Ei)).GetKVectorPart(4);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeCircleIpns(double radiusSquared, double centerX, double centerY)
    {
        var c = EncodePoint(centerX, centerY);

        return c - 0.5d * radiusSquared * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeCircleIpns(double radiusSquared, Float64Vector2D center)
    {
        var c = EncodePoint(center);

        return c - 0.5d * radiusSquared * Ei;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeRealCircleIpns(double radius, double centerX, double centerY)
    {
        var c = EncodePoint(centerX,centerY);

        return c - 0.5d * radius * radius * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeRealCircleIpns(double radius, Float64Vector2D center)
    {
        var c = EncodePoint(center);

        return c - 0.5d * radius * radius * Ei;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeImaginaryCircleIpns(double radius, double centerX, double centerY)
    {
        var c = EncodePoint(centerX, centerY);

        return c + 0.5d * radius * radius * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Vector EncodeImaginaryCircleIpns(double radius, Float64Vector2D center)
    {
        var c = EncodePoint(center);

        return c + 0.5d * radius * radius * Ei;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Bivector EncodePointPairOpns(Float64Vector2D point1, Float64Vector2D point2)
    {
        var p1 = EncodePoint(point1);
        var p2 = EncodePoint(point2);

        return p1.Op(p2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EncodeLineOpns(Float64Vector2D point1, Float64Vector2D point2)
    {
        var p1 = EncodePoint(point1);
        var p2 = EncodePoint(point2);

        return p1.Op(p2).Op(Ei);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64KVector EncodeCircleOpns(Float64Vector2D point1, Float64Vector2D point2, Float64Vector2D point3)
    {
        var p1 = EncodePoint(point1);
        var p2 = EncodePoint(point2);
        var p3 = EncodePoint(point3);

        return p1.Op(p2).Op(p3);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle)
    {
        var angleCos = Math.Cos(angle / 2);
        var angleSin = Math.Sin(angle / 2);

        return Processor
            .CreateComposer()
            .SetScalarTerm(angleCos)
            .SetBivectorTerm(2, 3, angleSin)
            .GetSimpleMultivector();
    }
        
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeTranslation(double vectorX, double vectorY)
    {
        return EncodeTranslation(
            Float64Vector2D.Create(vectorX, vectorY)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeTranslation(Float64Vector2D vector)
    {
        var a = EncodeVector(vector);

        return 1 + 0.5d * a.Gp(Ei);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RGaFloat64Multivector EncodeDilation(double scalingFactor)
    {
        return Math.Cosh(scalingFactor / 2) +
               Math.Sinh(scalingFactor / 2) * Eoi;
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Float64Vector2D DecodeVector(RGaFloat64Vector vector)
    {
        return Float64Vector2D.Create(
            vector[2], 
            vector[3]
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Float64Bivector2D DecodeBivector(RGaFloat64Bivector bivector)
    {
        return Float64Bivector2D.Create(bivector[2, 3]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Float64Vector2D DecodePoint(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];

        if (eoScalar.IsNearZero())
            throw new InvalidOperationException();
        
        return Float64Vector2D.Create(
            vector[2] / eoScalar, 
            vector[3] / eoScalar
        );
    }
    
    public Tuple<double, Float64Vector2D> DecodeCircleIpns(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];

        if (eoScalar.IsNearZero())
            throw new InvalidOperationException();

        var eiScalar = 0.5 * (vector[0] - vector[1]);

        var center = Float64Vector2D.Create(
            vector[2] / eoScalar, 
            vector[3] / eoScalar
        );

        var radiusSquared = 
            center.NormSquared() - 2 * eiScalar / eoScalar;

        return new Tuple<double, Float64Vector2D>(radiusSquared, center);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, Float64Vector2D> DecodeRealCircleIpns(RGaFloat64Vector vector)
    {
        var (radiusSquared, center) = 
            DecodeCircleIpns(vector);

        if (radiusSquared < 0)
            throw new InvalidOperationException();
        
        return new Tuple<double, Float64Vector2D>(
            radiusSquared.Sqrt(),
            center
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, Float64Vector2D> DecodeImaginaryCircleIpns(RGaFloat64Vector vector)
    {
        var (radiusSquared, center) = 
            DecodeCircleIpns(vector);

        if (radiusSquared > 0)
            throw new InvalidOperationException();
        
        return new Tuple<double, Float64Vector2D>(
            (-radiusSquared).Sqrt(),
            center
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, Float64Vector2D> DecodeLineIpns(RGaFloat64Vector vector)
    {
        var normal = DecodeVector(vector);
        var normalNorm = normal.Norm();
        var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;
        
        return new Tuple<double, Float64Vector2D>(
            distance,
            normal / normalNorm
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, Float64Vector2D> DecodeWeightedPoint(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];

        if (eoScalar.IsNearZero())
            throw new InvalidOperationException();
        
        var point = Float64Vector2D.Create(
            vector[2] / eoScalar, 
            vector[3] / eoScalar
        );

        return new Tuple<double, Float64Vector2D>(eoScalar, point);
    }
    
    public Tuple<double, double, Float64Vector2D> DecodeWeightedCircleIpns(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];

        if (eoScalar.IsNearZero())
            throw new InvalidOperationException();

        var eiScalar = 0.5 * (vector[0] - vector[1]);

        var center = Float64Vector2D.Create(
            vector[2] / eoScalar, 
            vector[3] / eoScalar
        );

        var radiusSquared = 
            center.NormSquared() - 2 * eiScalar / eoScalar;

        return new Tuple<double, double, Float64Vector2D>(
            eoScalar, 
            radiusSquared, 
            center
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, double, Float64Vector2D> DecodeWeightedRealCircleIpns(RGaFloat64Vector vector)
    {
        var (weight, radiusSquared, center) = 
            DecodeWeightedCircleIpns(vector);

        if (radiusSquared < 0)
            throw new InvalidOperationException();
        
        return new Tuple<double, double, Float64Vector2D>(
            weight,
            radiusSquared.Sqrt(),
            center
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, double, Float64Vector2D> DecodeWeightedImaginaryCircleIpns(RGaFloat64Vector vector)
    {
        var (weight, radiusSquared, center) = 
            DecodeWeightedCircleIpns(vector);

        if (radiusSquared > 0)
            throw new InvalidOperationException();
        
        return new Tuple<double, double, Float64Vector2D>(
            weight,
            (-radiusSquared).Sqrt(),
            center
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Tuple<double, double, Float64Vector2D> DecodeWeightedLineIpns(RGaFloat64Vector vector)
    {
        var normal = DecodeVector(vector);
        var normalNorm = normal.Norm();
        var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;
        
        return new Tuple<double, double, Float64Vector2D>(
            normalNorm,
            distance,
            normal / normalNorm
        );
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double GetDistance(RGaFloat64Vector cgaVector1, RGaFloat64Vector cgaVector2)
    {
        return -2 * cgaVector1.Sp(cgaVector2).Scalar();
    }
    
    public RGaFloat64Vector Normalize(RGaFloat64Vector vector)
    {
        var eoScalar = vector[0] + vector[1];
            
        // IPNS vector encoding a sphere or point
        if (!eoScalar.IsNearZero()) 
            return vector / eoScalar;

        // IPNS vector encoding a hyper-plane
        var nX = vector[2];
        var nY = vector[3];
        var nNorm = Math.Sqrt(nX * nX + nY * nY);

        if (nNorm.IsNearZero())
            throw new InvalidOperationException();

        var nNormInv = 1d / nNorm;
        var eiScalar = 0.5 * (vector[0] - vector[1]);

        return EncodeLineIpns(eiScalar, Float64Vector2D.Create(
            nX * nNormInv, 
            nY * nNormInv
        ));
    }
}