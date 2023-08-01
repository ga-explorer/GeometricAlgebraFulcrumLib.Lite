using System.Runtime.CompilerServices;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors;
using GeometricAlgebraFulcrumLib.Lite.GeometricAlgebra.Restricted.Float64.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra;
using GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space3D;
using GeometricAlgebraFulcrumLib.Lite.ScalarAlgebra;

// ReSharper disable CompareOfFloatsByEqualityOperator

// ReSharper disable CheckNamespace

namespace GeometricAlgebraFulcrumLib.Lite.Geometry
{
    /// <summary>
    /// Conformal Geometric Algebra for 3D Euclidean Space
    /// </summary>
    public sealed class CGa5D : 
        RGaConformalGeometrySpace
    {
        public static CGa5D Instance { get; } = new CGa5D();

        
        public RGaFloat64Vector E3 { get; }
        
        public RGaFloat64Bivector E13 { get; }

        public RGaFloat64Bivector E23 { get; }
        
        public RGaFloat64HigherKVector I3 { get; }
        
        public RGaFloat64HigherKVector I3Inv { get; }
        
        public RGaFloat64HigherKVector I3Rev { get; }

        public RGaFloat64KVector I3Ei { get; }

        
        private CGa5D() : base(5)
        {
            E3 = ConformalProcessor.CreateTermVector(4);
            
            E13 = ConformalProcessor.CreateTermBivector(2, 4);
            E23 = ConformalProcessor.CreateTermBivector(3, 4);

            I3 = ConformalProcessor.CreateHigherKVector(new []{ 2, 3, 4 });
            I3Inv = I3.Inverse();
            I3Rev = I3.Reverse();
            I3Ei = I3.Op(Ei);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeVector(double x, double y, double z)
        {
            return ConformalProcessor.CreateVector(0, 0, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeVector(Float64Vector3D mv)
        {
            return ConformalProcessor.CreateVector(0, 0, mv.X, mv.Y, mv.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector EncodeBivector(double xy, double xz, double yz)
        {
            return ConformalProcessor
                .CreateComposer()
                .SetBivectorTerm(2, 3, xy)
                .SetBivectorTerm(2, 4, xz)
                .SetBivectorTerm(3, 4, yz)
                .GetBivector();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector EncodeBivector(Float64Bivector3D bivector)
        {
            return ConformalProcessor
                .CreateComposer()
                .SetBivectorTerm(2, 3, bivector.Xy)
                .SetBivectorTerm(2, 4, bivector.Xz)
                .SetBivectorTerm(3, 4, bivector.Yz)
                .GetBivector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64HigherKVector EncodeTrivector(double xyzScalar)
        {
            return xyzScalar * I3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodePoint(double pointX, double pointY, double pointZ)
        {
            var point = Float64Vector3D.Create(pointX, pointY, pointZ);

            return Eo +
                   EncodeVector(point) +
                   0.5d * point.NormSquared() * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodePoint(Float64Vector3D point)
        {
            return Eo +
                   EncodeVector(point) +
                   0.5d * point.NormSquared() * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector EncodeLineIpns(Float64Vector3D point, Float64Vector3D vector)
        {
            var p = EncodeVector(point);
            var v = EncodeVector(vector / vector.Norm());

            return (v.Gp(I3) - p.Op(v).Gp(I3Ei)).GetKVectorPart(4);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodePlaneIpns(double distance, double normalX, double normalY, double normalZ)
        {
            var normal = Float64Vector3D.Create(normalX, normalY, normalZ);

            var n = EncodeVector(normal / normal.Norm());

            return n + distance * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodePlaneIpns(double distance, Float64Vector3D normal)
        {
            var n = EncodeVector(normal / normal.Norm());

            return n + distance * Ei;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeSphereIpns(double radiusSquared, double centerX, double centerY, double centerZ) 
        {
            var c = EncodePoint(centerX, centerY, centerZ);

            return c - 0.5d * radiusSquared * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeSphereIpns(double radiusSquared, Float64Vector3D center) 
        {
            var c = EncodePoint(center);

            return c - 0.5d * radiusSquared * Ei;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeRealSphereIpns(double radius, double centerX, double centerY, double centerZ)
        {
            var c = EncodePoint(centerX, centerY, centerZ);

            return c - 0.5d * radius * radius * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeRealSphereIpns(double radius, Float64Vector3D center)
        {
            var c = EncodePoint(center);

            return c - 0.5d * radius * radius * Ei;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeImaginarySphereIpns(double radius, double centerX, double centerY, double centerZ)
        {
            var c = EncodePoint(centerX, centerY, centerZ);

            return c + 0.5d * radius * radius * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Vector EncodeImaginarySphereIpns(double radius, Float64Vector3D center)
        {
            var c = EncodePoint(center);

            return c + 0.5d * radius * radius * Ei;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Bivector EncodePointPairOpns(Float64Vector3D point1, Float64Vector3D point2)
        {
            var p1 = EncodePoint(point1);
            var p2 = EncodePoint(point2);

            return p1.Op(p2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector EncodeLineOpns(Float64Vector3D point1, Float64Vector3D point2)
        {
            var p1 = EncodePoint(point1);
            var p2 = EncodePoint(point2);

            return p1.Op(p2).Op(Ei);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector EncodePlaneOpns(Float64Vector3D point1, Float64Vector3D point2, Float64Vector3D point3)
        {
            var p1 = EncodePoint(point1);
            var p2 = EncodePoint(point2);
            var p3 = EncodePoint(point3);

            return p1.Op(p2).Op(p3).Op(Ei);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector EncodeCircleOpns(Float64Vector3D point1, Float64Vector3D point2, Float64Vector3D point3)
        {
            var p1 = EncodePoint(point1);
            var p2 = EncodePoint(point2);
            var p3 = EncodePoint(point3);

            return p1.Op(p2).Op(p3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64KVector EncodeSphereOpns(Float64Vector3D point1, Float64Vector3D point2, Float64Vector3D point3, Float64Vector3D point4)
        {
            var p1 = EncodePoint(point1);
            var p2 = EncodePoint(point2);
            var p3 = EncodePoint(point3);
            var p4 = EncodePoint(point4);

            return p1.Op(p2).Op(p3).Op(p4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle, double bivectorXy, double bivectorXz, double bivectorYz)
        {
            var scalar = Math.Cos(angle / 2);
            var bivectorNorm = (bivectorXy * bivectorXy + bivectorXz * bivectorXz + bivectorYz * bivectorYz).Sqrt();
            var bivectorScalar = Math.Sin(angle / 2) / bivectorNorm;

            return Processor
                .CreateComposer()
                .SetScalarTerm(scalar)
                .SetBivectorTerm(2, 3, bivectorScalar * bivectorXy)
                .SetBivectorTerm(2, 4, bivectorScalar * bivectorXz)
                .SetBivectorTerm(3, 4, bivectorScalar * bivectorYz)
                .GetSimpleMultivector();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeRotation(Float64PlanarAngle angle, Float64Bivector3D bivector)
        {
            var scalar = Math.Cos(angle / 2);
            var bivectorScalar = Math.Sin(angle / 2) / bivector.Norm();

            return Processor
                .CreateComposer()
                .SetScalarTerm(scalar)
                .SetBivectorTerm(2, 3, bivectorScalar * bivector.Xy)
                .SetBivectorTerm(2, 4, bivectorScalar * bivector.Xz)
                .SetBivectorTerm(3, 4, bivectorScalar * bivector.Yz)
                .GetSimpleMultivector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeTranslation(double vectorX, double vectorY, double vectorZ)
        {
            return EncodeTranslation(
                Float64Vector3D.Create(vectorX, vectorY, vectorZ)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RGaFloat64Multivector EncodeTranslation(Float64Vector3D vector)
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
        public Float64Vector3D DecodeVector(RGaFloat64Vector vector)
        {
            return Float64Vector3D.Create(
                vector[2], 
                vector[3], 
                vector[4]
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Bivector3D DecodeBivector(RGaFloat64Bivector bivector)
        {
            return Float64Bivector3D.Create(
                bivector[2, 3], 
                bivector[2, 4], 
                bivector[3, 4]
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Trivector3D DecodeTrivector(RGaFloat64HigherKVector trivector)
        {
            return Float64Trivector3D.Create(
                trivector[2, 3, 4]
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float64Vector3D DecodePoint(RGaFloat64Vector vector)
        {
            var eoScalar = vector[0] + vector[1];

            if (eoScalar.IsNearZero())
                throw new InvalidOperationException();
        
            return Float64Vector3D.Create(
                vector[2] / eoScalar, 
                vector[3] / eoScalar, 
                vector[4] / eoScalar
            );
        }
        
        public Tuple<double, Float64Vector3D> DecodeSphereIpns(RGaFloat64Vector vector)
        {
            var eoScalar = vector[0] + vector[1];

            if (eoScalar.IsNearZero())
                throw new InvalidOperationException();

            var eiScalar = 0.5 * (vector[0] - vector[1]);

            var center = Float64Vector3D.Create(
                vector[2] / eoScalar, 
                vector[3] / eoScalar, 
                vector[4] / eoScalar
            );

            var radiusSquared = 
                center.NormSquared() - 2 * eiScalar / eoScalar;

            return new Tuple<double, Float64Vector3D>(radiusSquared, center);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, Float64Vector3D> DecodeRealSphereIpns(RGaFloat64Vector vector)
        {
            var (radiusSquared, center) = 
                DecodeSphereIpns(vector);

            if (radiusSquared < 0)
                throw new InvalidOperationException();
        
            return new Tuple<double, Float64Vector3D>(
                radiusSquared.Sqrt(),
                center
            );
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, Float64Vector3D> DecodeImaginarySphereIpns(RGaFloat64Vector vector)
        {
            var (radiusSquared, center) = 
                DecodeSphereIpns(vector);

            if (radiusSquared > 0)
                throw new InvalidOperationException();
        
            return new Tuple<double, Float64Vector3D>(
                (-radiusSquared).Sqrt(),
                center
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, Float64Vector3D> DecodePlaneIpns(RGaFloat64Vector vector)
        {
            var normal = DecodeVector(vector);
            var normalNorm = normal.Norm();
            var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;
            
            return new Tuple<double, Float64Vector3D>(
                distance,
                normal / normalNorm
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, Float64Vector3D> DecodeWeightedPoint(RGaFloat64Vector vector)
        {
            var eoScalar = vector[0] + vector[1];

            if (eoScalar.IsNearZero())
                throw new InvalidOperationException();
        
            var point = Float64Vector3D.Create(
                vector[2] / eoScalar, 
                vector[3] / eoScalar, 
                vector[4] / eoScalar
            );

            return new Tuple<double, Float64Vector3D>(eoScalar, point);
        }
        
        public Tuple<double, double, Float64Vector3D> DecodeWeightedSphereIpns(RGaFloat64Vector vector)
        {
            var eoScalar = vector[0] + vector[1];

            if (eoScalar.IsNearZero())
                throw new InvalidOperationException();

            var eiScalar = 0.5 * (vector[0] - vector[1]);

            var center = Float64Vector3D.Create(
                vector[2] / eoScalar, 
                vector[3] / eoScalar, 
                vector[4] / eoScalar
            );

            var radiusSquared = 
                center.NormSquared() - 2 * eiScalar / eoScalar;

            return new Tuple<double, double, Float64Vector3D>(
                eoScalar, 
                radiusSquared, 
                center
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, double, Float64Vector3D> DecodeWeightedRealSphereIpns(RGaFloat64Vector vector)
        {
            var (weight, radiusSquared, center) = 
                DecodeWeightedSphereIpns(vector);

            if (radiusSquared < 0)
                throw new InvalidOperationException();
        
            return new Tuple<double, double, Float64Vector3D>(
                weight,
                radiusSquared.Sqrt(),
                center
            );
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, double, Float64Vector3D> DecodeWeightedImaginarySphereIpns(RGaFloat64Vector vector)
        {
            var (weight, radiusSquared, center) = 
                DecodeWeightedSphereIpns(vector);

            if (radiusSquared > 0)
                throw new InvalidOperationException();
            
            return new Tuple<double, double, Float64Vector3D>(
                weight,
                (-radiusSquared).Sqrt(),
                center
            );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Tuple<double, double, Float64Vector3D> DecodeWeightedPlaneIpns(RGaFloat64Vector vector)
        {
            var normal = DecodeVector(vector);
            var normalNorm = normal.Norm();
            var distance = 0.5 * (vector[0] - vector[1]) / normalNorm;
            
            return new Tuple<double, double, Float64Vector3D>(
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
            var nZ = vector[4];
            var nNorm = Math.Sqrt(nX * nX + nY * nY + nZ * nZ);

            if (nNorm.IsNearZero())
                throw new InvalidOperationException();

            var nNormInv = 1d / nNorm;
            var eiScalar = 0.5 * (vector[0] - vector[1]);

            return EncodePlaneIpns(eiScalar, Float64Vector3D.Create(
                nX * nNormInv, 
                nY * nNormInv, 
                nZ * nNormInv
            ));
        }
    }
}
